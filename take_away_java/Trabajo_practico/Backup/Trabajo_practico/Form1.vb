Public Class FrmInicio
    Dim nombre, apellido As String
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        nombre = TxtNombre.Text
        apellido = TxtApellido.Text

        If nombre = "Carina" And apellido = "Quiroga" Then
            FrmOrden.Show()
            MsgBox("Ingrese un pedido por persona", , "Tp final")
            Me.Hide()
        ElseIf nombre = "Carina" And apellido = "" Then
            MsgBox("Ingrese el apellido", MsgBoxStyle.Critical)
        ElseIf nombre = "" And apellido = "Quiroga" Then
            MsgBox("Ingrese el nombre", MsgBoxStyle.Critical)
        ElseIf nombre = "carina" And apellido = "quiroga" Then
            MsgBox("Ingrese el nombre y el apellido en mayúscula", MsgBoxStyle.Critical)
        Else
            MsgBox("Ingrese el nombre y el apellido correcto", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
