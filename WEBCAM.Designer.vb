<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WEBCAM
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonA = New System.Windows.Forms.RadioButton()
        Me.RadioButtonB = New System.Windows.Forms.RadioButton()
        Me.PictureBoxVISOR = New System.Windows.Forms.PictureBox()
        Me.ButtonINICIAR = New System.Windows.Forms.Button()
        Me.PictureBoxREMOTO = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ButtonCONECTAR = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxVISOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxREMOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RadioButtonA)
        Me.GroupBox1.Controls.Add(Me.RadioButtonB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(646, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 87)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CALIDAD"
        '
        'RadioButtonA
        '
        Me.RadioButtonA.AutoSize = True
        Me.RadioButtonA.Location = New System.Drawing.Point(7, 43)
        Me.RadioButtonA.Name = "RadioButtonA"
        Me.RadioButtonA.Size = New System.Drawing.Size(71, 24)
        Me.RadioButtonA.TabIndex = 1
        Me.RadioButtonA.Text = "ALTA"
        Me.RadioButtonA.UseVisualStyleBackColor = True
        '
        'RadioButtonB
        '
        Me.RadioButtonB.AutoSize = True
        Me.RadioButtonB.Checked = True
        Me.RadioButtonB.Location = New System.Drawing.Point(8, 19)
        Me.RadioButtonB.Name = "RadioButtonB"
        Me.RadioButtonB.Size = New System.Drawing.Size(72, 24)
        Me.RadioButtonB.TabIndex = 0
        Me.RadioButtonB.TabStop = True
        Me.RadioButtonB.Text = "BAJA"
        Me.RadioButtonB.UseVisualStyleBackColor = True
        '
        'PictureBoxVISOR
        '
        Me.PictureBoxVISOR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxVISOR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBoxVISOR.Location = New System.Drawing.Point(646, 12)
        Me.PictureBoxVISOR.Name = "PictureBoxVISOR"
        Me.PictureBoxVISOR.Size = New System.Drawing.Size(204, 150)
        Me.PictureBoxVISOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVISOR.TabIndex = 22
        Me.PictureBoxVISOR.TabStop = False
        '
        'ButtonINICIAR
        '
        Me.ButtonINICIAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonINICIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonINICIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonINICIAR.ForeColor = System.Drawing.Color.Black
        Me.ButtonINICIAR.Location = New System.Drawing.Point(646, 193)
        Me.ButtonINICIAR.Name = "ButtonINICIAR"
        Me.ButtonINICIAR.Size = New System.Drawing.Size(204, 52)
        Me.ButtonINICIAR.TabIndex = 24
        Me.ButtonINICIAR.Text = "INICIAR CAMARA"
        Me.ButtonINICIAR.UseVisualStyleBackColor = False
        '
        'PictureBoxREMOTO
        '
        Me.PictureBoxREMOTO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxREMOTO.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBoxREMOTO.Location = New System.Drawing.Point(12, 26)
        Me.PictureBoxREMOTO.Name = "PictureBoxREMOTO"
        Me.PictureBoxREMOTO.Size = New System.Drawing.Size(605, 452)
        Me.PictureBoxREMOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxREMOTO.TabIndex = 23
        Me.PictureBoxREMOTO.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(654, 449)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "IMG/SEG."
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown1.Location = New System.Drawing.Point(751, 443)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(99, 26)
        Me.NumericUpDown1.TabIndex = 28
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ButtonCONECTAR
        '
        Me.ButtonCONECTAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCONECTAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCONECTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCONECTAR.ForeColor = System.Drawing.Color.Black
        Me.ButtonCONECTAR.Location = New System.Drawing.Point(646, 360)
        Me.ButtonCONECTAR.Name = "ButtonCONECTAR"
        Me.ButtonCONECTAR.Size = New System.Drawing.Size(204, 46)
        Me.ButtonCONECTAR.TabIndex = 25
        Me.ButtonCONECTAR.Text = "CONECTAR"
        Me.ButtonCONECTAR.UseVisualStyleBackColor = False
        Me.ButtonCONECTAR.Visible = False
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(730, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "YO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(282, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(248, 20)
        Me.lblTitle.TabIndex = 31
        Me.lblTitle.Text = "C L I E N T E => 192.168.1.73"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WEBCAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 490)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBoxVISOR)
        Me.Controls.Add(Me.ButtonINICIAR)
        Me.Controls.Add(Me.PictureBoxREMOTO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ButtonCONECTAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WEBCAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WEBCAM SERVER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxVISOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxREMOTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonA As RadioButton
    Friend WithEvents RadioButtonB As RadioButton
    Friend WithEvents PictureBoxVISOR As PictureBox
    Friend WithEvents ButtonINICIAR As Button
    Friend WithEvents PictureBoxREMOTO As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ButtonCONECTAR As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
End Class
