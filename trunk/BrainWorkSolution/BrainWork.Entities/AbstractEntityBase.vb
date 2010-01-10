Option Explicit On
Option Strict On

Imports System.Reflection
Public Class AbstractEntityBase


    Public Function GetFieldProperties(ByVal PropertyName As String) As EntityFieldExtendsAttribute
        Dim t As Type = Me.GetType()
        Return GetPropertyAttributes(t, PropertyName)(0)
    End Function

    Public ReadOnly Property ExtendedClassAttributes() As EntityClassExtendsAttribute
        Get
            Return CType(Me.GetType().GetCustomAttributes(True)(0), EntityClassExtendsAttribute)
        End Get
    End Property



    Protected Function GetCustomAttributeValue(ByVal t As Type, ByVal PropertyType As Type, ByVal attributeName As String) As Object
        Dim attArray As BrainWork.Entities.EntityFieldExtendsAttribute()


        attArray = GetPropertyAttributes(t, PropertyType.Name)


        If Not attArray Is Nothing AndAlso attArray.Length > 0 Then

            For Each att As BrainWork.Entities.EntityFieldExtendsAttribute In attArray

                Dim pi() As Reflection.PropertyInfo = att.GetType.GetProperties()

                For Each p As PropertyInfo In pi
                    If p.Name.ToLower = attributeName.ToLower Then
                        Return p.GetValue(att, Nothing)
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function

    Protected Function GetCustomAttributeValue(ByVal t As Type, ByVal PropertyName As String, ByVal attributeName As String) As Object
        Dim attArray As BrainWork.Entities.EntityFieldExtendsAttribute()

        attArray = GetPropertyAttributes(t, PropertyName)


        If Not attArray Is Nothing AndAlso attArray.Length > 0 Then

            For Each att As BrainWork.Entities.EntityFieldExtendsAttribute In attArray

                Dim pi() As Reflection.PropertyInfo = att.GetType.GetProperties()

                For Each p As PropertyInfo In pi
                    If p.Name.ToLower = attributeName.ToLower Then
                        Return p.GetValue(att, Nothing)
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function

    


    Protected Function GetPropertyAttributes(ByVal t As Type, ByVal MemberName As String) As BrainWork.Entities.EntityFieldExtendsAttribute()

        Dim att() As BrainWork.Entities.EntityFieldExtendsAttribute


        Dim MyMemberInfo As MemberInfo() = t.GetMember(MemberName) 't.GetProperties()

        If MyMemberInfo Is Nothing OrElse MyMemberInfo.Length = 0 Then
            'verifico mayuscula y minuscula
            MemberName = FindPropertyByExample(t, MemberName)
            If MemberName Is Nothing Then
                Return Nothing
            End If
            MyMemberInfo = t.GetMember(MemberName)
        End If
        att = CType(Attribute.GetCustomAttributes(MyMemberInfo(0), GetType(BrainWork.Entities.EntityFieldExtendsAttribute)), EntityFieldExtendsAttribute())

        If att Is Nothing OrElse att.Length = 0 Then
            Return Nothing
        End If

        Return att

    End Function

    Protected Function FindPropertyByExample(ByVal t As Type, ByVal PropertyName As String) As String
        Dim pi As PropertyInfo() = t.GetProperties()
        PropertyName = PropertyName.ToLower

        For Each p As PropertyInfo In t.GetProperties
            If p.Name.ToLower = PropertyName Then
                Return p.Name
            End If
        Next

        Return Nothing
    End Function

End Class
