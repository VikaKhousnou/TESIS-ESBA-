<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTicket
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTicket))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.BtnPagar = New System.Windows.Forms.Button
        Me.TxtPagar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Total = New System.Windows.Forms.Label
        Me.TxtPropina = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.BtnVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ticket"
        '
        'TxtImporte
        '
        Me.TxtImporte.Enabled = False
        Me.TxtImporte.Location = New System.Drawing.Point(97, 94)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(100, 20)
        Me.TxtImporte.TabIndex = 1
        '
        'BtnPagar
        '
        Me.BtnPagar.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnPagar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.Location = New System.Drawing.Point(97, 186)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(100, 50)
        Me.BtnPagar.TabIndex = 2
        Me.BtnPagar.Text = "Pagar"
        Me.BtnPagar.UseVisualStyleBackColor = False
        '
        'TxtPagar
        '
        Me.TxtPagar.Location = New System.Drawing.Point(97, 160)
        Me.TxtPagar.Name = "TxtPagar"
        Me.TxtPagar.Size = New System.Drawing.Size(100, 20)
        Me.TxtPagar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SubTotal"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(57, 165)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(33, 15)
        Me.Total.TabIndex = 3
        Me.Total.Text = "Total"
        '
        'TxtPropina
        '
        Me.TxtPropina.Location = New System.Drawing.Point(97, 117)
        Me.TxtPropina.Name = "TxtPropina"
        Me.TxtPropina.Size = New System.Drawing.Size(100, 20)
        Me.TxtPropina.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Propina"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Coral
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(212, 344)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 25)
        Me.btnSalir.TabIndex = 41
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnVolver.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(122, 344)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 25)
        Me.BtnVolver.TabIndex = 41
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FrmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(312, 401)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPagar)
        Me.Controls.Add(Me.TxtPagar)
        Me.Controls.Add(Me.TxtPropina)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTicket"
        Me.Text = "Ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents BtnPagar As System.Windows.Forms.Button
    Friend WithEvents TxtPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents TxtPropina As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
End Class
