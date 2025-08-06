Public Class FrmOrden
    Public a, total As Double
    Private Sub btnTomarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTomarOrden.Click
        ListBox1.Items.Clear()

        If CheckBox1.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(0))
        End If

        If CheckBox2.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(1))
        End If

        If CheckBox3.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(2))
        End If

        If CheckBox4.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(3))
        End If

        If CheckBox5.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(4))
        End If

        If CheckBox6.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(5))
        End If

        If CheckBox7.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(6))
        End If

        If CheckBox8.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(7))
        End If

        If CheckBox9.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(8))
        End If
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        TextTotal.Clear()

        If CheckBox1.Checked = True Then
            a = 100
            total = total + a
        End If

        If CheckBox2.Checked = True Then
            a = 150
            total = total + a
        End If

        If CheckBox3.Checked = True Then
            a = 50
            total = total + a
        End If

        If CheckBox4.Checked = True Then
            a = 100
            total = total + a
        End If

        If CheckBox5.Checked = True Then
            a = 50
            total = total + a
        End If

        If CheckBox6.Checked = True Then
            a = 100
            total = total + a
        End If

        If CheckBox7.Checked = True Then
            a = 50
            total = total + a
        End If

        If CheckBox8.Checked = True Then
            a = 100
            total = total + a
        End If

        If CheckBox9.Checked = True Then
            a = 150
            total = total + a
        End If
        TextTotal.Clear()
        TextTotal.Text = "$" & total
        FrmTicket.Show()
        FrmTicket.TxtImporte.Text = Me.TextTotal.Text
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        total = 0
        TextTotal.Clear()
        ListBox1.Items.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
    End Sub
    Private Sub BtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInicio.Click
        Me.Close()
    End Sub
End Class