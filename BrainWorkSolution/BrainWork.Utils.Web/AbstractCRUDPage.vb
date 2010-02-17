Imports System.Web.UI.HtmlControls

Public MustInherit Class AbstractCRUDPage
    Inherits AbstractPage
    Public Enum EnumABMLMode
        Lista
        Alta
        Baja
        Modificacion
        Reporte
    End Enum

    Private _MainEntity As Object
    Private _MainBL As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic

    Public MustOverride ReadOnly Property ControlsCointainerID() As String

    Public Overridable Function GetBrainworkEntity() As BrainWork.Entities.AbstractEntityBase
        Return TryCast(_MainEntity, BrainWork.Entities.AbstractEntityBase)
    End Function
    Public Overridable Function GetBrainWorkBussinesLogic() As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
        Return _MainBL
    End Function



    Public Property MainEntity() As Object
        Set(ByVal value As Object)
            If Not value.GetType.BaseType.FullName = "BrainWork.Entities.AbstractEntityBase" Then
                Throw New Exception("la clase base debe ser del tipo AbstractEntityBase")
            End If
            _MainEntity = value
        End Set
        Get
            Return _MainEntity
        End Get

    End Property

    Public WriteOnly Property MainBL() As Object
        Set(ByVal value As Object)
            If Not value.GetType.BaseType.FullName = "BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic" Then
                Throw New Exception("la clase base debe ser del tipo AbstractBussinesLogic")
            End If
            _MainBL = value
        End Set
    End Property



    Public Property Mode() As EnumABMLMode
        Get
            If ViewState("_Mode") Is Nothing Then
                ViewState("_Mode") = EnumABMLMode.Lista
            End If

            Return CType(ViewState("_Mode"), EnumABMLMode)
        End Get
        Set(ByVal value As EnumABMLMode)
            ViewState("_Mode") = value
        End Set
    End Property

    Protected MustOverride Function GetCurrentForm() As HtmlForm


    Protected Overridable Sub FillEntityFromControls()
        FillEntityFromControls(Me._MainEntity, Me.GetCurrentForm)
    End Sub

    Public MustOverride ReadOnly Property MyGrid() As BrainWork.Utils.Web.WebControls.Data.GridView


    Public Overridable Sub LoadSearchValuesInGrid(ByVal ent As Object)
        MyGrid.DataSource = Nothing
        MyGrid.DataBind()
        '_MainEntity = Activator.CreateInstance(_MainEntity.GetType)
        FillEntityFromControls()

        Dim blObject As Object
        blObject = Activator.CreateInstance(_MainBL.GetType, Me.CurrentUser)
        ' New GEOS.BussinesLogic.BlSales_Currency(Me.CurrentUser)
        Dim bl As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
        bl = CType(blObject, BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic)
        bl.EntityObject = ent 'Me._MainEntity

        MyGrid.SetDataSourceBussines(bl)
        MyGrid.DataBind()

    End Sub

    Public Overridable Sub LoadSearchValuesInGrid()
        LoadSearchValuesInGrid(_MainEntity)
    End Sub

    Protected Overridable Sub AddCurrentValues()
        Try
            _MainEntity = Activator.CreateInstance(_MainEntity.GetType)
            FillEntityFromControls()

            Dim blObject As Object
            blObject = Activator.CreateInstance(_MainBL.GetType, Me.CurrentUser)
            ' New GEOS.BussinesLogic.BlSales_Currency(Me.CurrentUser)
            Dim bl As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
            bl = CType(blObject, BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic)
            bl.EntityObject = Me._MainEntity
            bl.Add()
            SucessAction("Se ha agregado el nuevo elemento, con el ID: " & bl.Entity.GetCurrentPrimaryKeyValue)
        Catch ex As Exception
            ExceptionMessage(ex)
        End Try

    End Sub


    Protected Sub FillEntityFromControls(ByRef Ent As Object, Optional ByVal pForm As HtmlForm = Nothing)
        If pForm Is Nothing Then
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is HtmlForm Then
                    pForm = ctrl
                End If
            Next
        End If

        For Each ctrl As System.Web.UI.Control In pForm.FindControl(Me.ControlsCointainerID).Controls
            If Not ctrl Is Nothing Then

                If TypeOf ctrl Is BrainWork.Utils.Web.WebControls.CustomTextBox Then
                    Dim ctrlNew As BrainWork.Utils.Web.WebControls.CustomTextBox
                    ctrlNew = CType(ctrl, BrainWork.Utils.Web.WebControls.CustomTextBox)
                    For Each EntityPropertyInfo As System.Reflection.PropertyInfo In Ent.GetType.GetProperties
                        For Each ControlPropertyInfo As System.Reflection.PropertyInfo In ctrlNew.GetType.GetProperties()
                            If ControlPropertyInfo.CanRead AndAlso ControlPropertyInfo.CanWrite Then

                                If ControlPropertyInfo.Name.ToLower = "propertyname" Then
                                    Dim objValue As Object = ControlPropertyInfo.GetValue(ctrl, Nothing)
                                    If Not objValue Is Nothing AndAlso objValue.ToString.ToLower = EntityPropertyInfo.Name.ToLower Then
                                        Dim NewValue As Object = IIf(String.IsNullOrEmpty(ctrlNew.Text), Nothing, CObj(ctrlNew.Text))
                                        If Not NewValue Is Nothing Then
                                            Select Case True
                                                Case ctrlNew.TypeName.ToLower = "date" OrElse ctrlNew.TypeName.ToLower = "datetime"
                                                    If IsDate(NewValue) Then
                                                        EntityPropertyInfo.SetValue(Ent, CDate(NewValue), Nothing)
                                                    Else
                                                        Throw New ApplicationException("Tipo de dato no valido:" & ctrlNew.PropertyName)
                                                    End If

                                                Case ctrlNew.TypeName.ToLower = "integer" OrElse _
                                                     ctrlNew.TypeName.ToLower = "int32" OrElse _
                                                     ctrlNew.TypeName.ToLower = "int16" OrElse _
                                                     ctrlNew.TypeName.ToLower = "int64" OrElse _
                                                     ctrlNew.TypeName.ToLower = "double" OrElse _
                                                     ctrlNew.TypeName.ToLower = "float"

                                                    If IsNumeric(NewValue) Then
                                                        EntityPropertyInfo.SetValue(Ent, Val(NewValue), Nothing)
                                                    Else
                                                        Throw New ApplicationException("Tipo de dato no valido" & ctrlNew.PropertyName)
                                                    End If

                                                Case Else
                                                    EntityPropertyInfo.SetValue(Ent, NewValue, Nothing)

                                            End Select

                                        End If
                                       
                                    End If
                                    Exit For
                                End If
                            End If
                        Next
                    Next
                End If
            End If

        Next
    End Sub

End Class
