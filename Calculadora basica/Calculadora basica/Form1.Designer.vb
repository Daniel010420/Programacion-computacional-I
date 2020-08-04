<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optPotencia = New System.Windows.Forms.RadioButton()
        Me.optResiduo = New System.Windows.Forms.RadioButton()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(95, 102)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(202, 305)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(305, 103)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 2
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Checked = True
        Me.optSuma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optSuma.Location = New System.Drawing.Point(225, 103)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(31, 17)
        Me.optSuma.TabIndex = 3
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optResta.Location = New System.Drawing.Point(225, 126)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(28, 17)
        Me.optResta.TabIndex = 4
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optMultiplicar.Location = New System.Drawing.Point(224, 149)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicar.TabIndex = 5
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Num 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Num 2 "
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optDividir.Location = New System.Drawing.Point(224, 173)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(30, 17)
        Me.optDividir.TabIndex = 8
        Me.optDividir.Text = "/"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optPorcentaje.Location = New System.Drawing.Point(224, 197)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(79, 17)
        Me.optPorcentaje.TabIndex = 9
        Me.optPorcentaje.Text = "Porcentaje "
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optPotencia
        '
        Me.optPotencia.AutoSize = True
        Me.optPotencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optPotencia.Location = New System.Drawing.Point(224, 221)
        Me.optPotencia.Name = "optPotencia"
        Me.optPotencia.Size = New System.Drawing.Size(31, 17)
        Me.optPotencia.TabIndex = 10
        Me.optPotencia.Text = "^"
        Me.optPotencia.UseVisualStyleBackColor = True
        '
        'optResiduo
        '
        Me.optResiduo.AutoSize = True
        Me.optResiduo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optResiduo.Location = New System.Drawing.Point(224, 242)
        Me.optResiduo.Name = "optResiduo"
        Me.optResiduo.Size = New System.Drawing.Size(64, 17)
        Me.optResiduo.TabIndex = 11
        Me.optResiduo.Tag = ""
        Me.optResiduo.Text = "Residuo"
        Me.optResiduo.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(50, 215)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(411, 107)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuesta.TabIndex = 13
        Me.lblrespuesta.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 381)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.optResiduo)
        Me.Controls.Add(Me.optPotencia)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtnum1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optPotencia As RadioButton
    Friend WithEvents optResiduo As RadioButton
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblrespuesta As Label
End Class
