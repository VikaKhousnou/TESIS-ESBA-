Public Class FrmTicket
    Dim subTotal, propina, pagar As Double


    Private Sub BtnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPagar.Click

        subTotal = TxtImporte.Text
        propina = TxtPropina.Text

        If propina >= 0 Then
            pagar = subTotal + ("$" & propina)
            TxtPagar.Text = "$" & pagar
            MsgBox("Gracias por su compra" & vbNewLine & "el valor de su pedido es" & vbNewLine & "$" & pagar, , "Retire su pedido")
        Else
            MsgBox("La propina no puede ser negativa", MsgBoxStyle.Critical, "Cuidado")
        End If

        
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class