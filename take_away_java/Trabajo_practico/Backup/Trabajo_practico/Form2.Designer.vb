<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrden))
        Me.TextTotal = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ListMenu = New System.Windows.Forms.ListBox
        Me.btnTomarOrden = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnTotal = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.BtnInicio = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextTotal
        '
        Me.TextTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotal.Location = New System.Drawing.Point(197, 514)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(100, 30)
        Me.TextTotal.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label2.Location = New System.Drawing.Point(739, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 33)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "MENU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 33)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "SU ORDEN"
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(527, 297)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox9.TabIndex = 50
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(527, 268)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 49
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(527, 239)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox7.TabIndex = 48
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(527, 209)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 47
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(527, 179)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 46
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(527, 150)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 45
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(527, 121)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 44
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(527, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 43
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(527, 59)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 42
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ListMenu
        '
        Me.ListMenu.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListMenu.FormattingEnabled = True
        Me.ListMenu.ItemHeight = 29
        Me.ListMenu.Items.AddRange(New Object() {"Hamburguesa simple" & Global.Microsoft.VisualBasic.ChrW(9) & "$100", "Hamburguesa doble" & Global.Microsoft.VisualBasic.ChrW(9) & "$150", "Papas fritas pequeñas" & Global.Microsoft.VisualBasic.ChrW(9) & "$50", "Papas fritas grandes" & Global.Microsoft.VisualBasic.ChrW(9) & "$100", "Gaseosa pequeña" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$50", "Gaseosa grande" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$100", "Agua mediana" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$50", "Helado pequeño" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$100", "Helado grande" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$150"})
        Me.ListMenu.Location = New System.Drawing.Point(548, 50)
        Me.ListMenu.Name = "ListMenu"
        Me.ListMenu.Size = New System.Drawing.Size(490, 410)
        Me.ListMenu.TabIndex = 41
        '
        'btnTomarOrden
        '
        Me.btnTomarOrden.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTomarOrden.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTomarOrden.Location = New System.Drawing.Point(724, 513)
        Me.btnTomarOrden.Name = "btnTomarOrden"
        Me.btnTomarOrden.Size = New System.Drawing.Size(150, 50)
        Me.btnTomarOrden.TabIndex = 39
        Me.btnTomarOrden.Text = "Tomar Orden"
        Me.btnTomarOrden.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(548, 513)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 50)
        Me.btnLimpiar.TabIndex = 38
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Aqua
        Me.btnTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(13, 513)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(100, 40)
        Me.btnTotal.TabIndex = 37
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(284, 420)
        Me.ListBox1.TabIndex = 36
        '
        'BtnInicio
        '
        Me.BtnInicio.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnInicio.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.Location = New System.Drawing.Point(938, 514)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(100, 50)
        Me.BtnInicio.TabIndex = 38
        Me.BtnInicio.Text = "Inicio"
        Me.BtnInicio.UseVisualStyleBackColor = False
        '
        'FrmOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1093, 611)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ListMenu)
        Me.Controls.Add(Me.btnTomarOrden)
        Me.Controls.Add(Me.BtnInicio)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOrden"
        Me.Text = "Orden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ListMenu As System.Windows.Forms.ListBox
    Friend WithEvents btnTomarOrden As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BtnInicio As System.Windows.Forms.Button
End Class
