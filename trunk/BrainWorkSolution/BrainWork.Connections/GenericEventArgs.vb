<Serializable()> _
Public Class GenericEventArgs
    Inherits EventArgs
    Public Value As Object

    Public Sub New(ByVal value As Object)
        Me.Value = value
    End Sub

End Class
