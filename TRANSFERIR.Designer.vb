<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRANSFERIR
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
        Me.LabelNOMBRE = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonENVIAR = New System.Windows.Forms.Button()
        Me.TextBoxARCHIVO = New System.Windows.Forms.TextBox()
        Me.ButtonELEGIR = New System.Windows.Forms.Button()
        Me.LabelESTADO = New System.Windows.Forms.Label()
        Me.ButtonRUTA = New System.Windows.Forms.Button()
        Me.TextBoxRUTA = New System.Windows.Forms.TextBox()
        Me.LabelTRANSMISION = New System.Windows.Forms.Label()
        Me.TextBoxPUERTO = New System.Windows.Forms.TextBox()
        Me.ButtonCONECTAR = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'LabelNOMBRE
        '
        Me.LabelNOMBRE.AutoSize = True
        Me.LabelNOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNOMBRE.ForeColor = System.Drawing.Color.White
        Me.LabelNOMBRE.Location = New System.Drawing.Point(186, 73)
        Me.LabelNOMBRE.Name = "LabelNOMBRE"
        Me.LabelNOMBRE.Size = New System.Drawing.Size(85, 20)
        Me.LabelNOMBRE.TabIndex = 27
        Me.LabelNOMBRE.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ENVIAR ARCHIVOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "RECIBIR ARCHIVOS"
        '
        'ButtonENVIAR
        '
        Me.ButtonENVIAR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonENVIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonENVIAR.ForeColor = System.Drawing.Color.White
        Me.ButtonENVIAR.Location = New System.Drawing.Point(331, 235)
        Me.ButtonENVIAR.Name = "ButtonENVIAR"
        Me.ButtonENVIAR.Size = New System.Drawing.Size(140, 53)
        Me.ButtonENVIAR.TabIndex = 24
        Me.ButtonENVIAR.Text = "ENVIAR"
        Me.ButtonENVIAR.UseVisualStyleBackColor = False
        '
        'TextBoxARCHIVO
        '
        Me.TextBoxARCHIVO.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxARCHIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxARCHIVO.ForeColor = System.Drawing.Color.Black
        Me.TextBoxARCHIVO.Location = New System.Drawing.Point(26, 178)
        Me.TextBoxARCHIVO.Multiline = True
        Me.TextBoxARCHIVO.Name = "TextBoxARCHIVO"
        Me.TextBoxARCHIVO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxARCHIVO.Size = New System.Drawing.Size(485, 33)
        Me.TextBoxARCHIVO.TabIndex = 23
        '
        'ButtonELEGIR
        '
        Me.ButtonELEGIR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonELEGIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonELEGIR.ForeColor = System.Drawing.Color.White
        Me.ButtonELEGIR.Location = New System.Drawing.Point(35, 235)
        Me.ButtonELEGIR.Name = "ButtonELEGIR"
        Me.ButtonELEGIR.Size = New System.Drawing.Size(140, 53)
        Me.ButtonELEGIR.TabIndex = 22
        Me.ButtonELEGIR.Text = "ELEGIR"
        Me.ButtonELEGIR.UseVisualStyleBackColor = False
        '
        'LabelESTADO
        '
        Me.LabelESTADO.AutoSize = True
        Me.LabelESTADO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelESTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelESTADO.ForeColor = System.Drawing.Color.White
        Me.LabelESTADO.Location = New System.Drawing.Point(31, 73)
        Me.LabelESTADO.Name = "LabelESTADO"
        Me.LabelESTADO.Size = New System.Drawing.Size(81, 20)
        Me.LabelESTADO.TabIndex = 21
        Me.LabelESTADO.Text = "ESTADO"
        '
        'ButtonRUTA
        '
        Me.ButtonRUTA.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonRUTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRUTA.ForeColor = System.Drawing.Color.White
        Me.ButtonRUTA.Location = New System.Drawing.Point(531, 33)
        Me.ButtonRUTA.Name = "ButtonRUTA"
        Me.ButtonRUTA.Size = New System.Drawing.Size(75, 37)
        Me.ButtonRUTA.TabIndex = 20
        Me.ButtonRUTA.Text = "RUTA"
        Me.ButtonRUTA.UseVisualStyleBackColor = False
        '
        'TextBoxRUTA
        '
        Me.TextBoxRUTA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxRUTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRUTA.ForeColor = System.Drawing.Color.Black
        Me.TextBoxRUTA.Location = New System.Drawing.Point(27, 33)
        Me.TextBoxRUTA.Multiline = True
        Me.TextBoxRUTA.Name = "TextBoxRUTA"
        Me.TextBoxRUTA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRUTA.Size = New System.Drawing.Size(484, 37)
        Me.TextBoxRUTA.TabIndex = 19
        '
        'LabelTRANSMISION
        '
        Me.LabelTRANSMISION.AutoSize = True
        Me.LabelTRANSMISION.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelTRANSMISION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTRANSMISION.ForeColor = System.Drawing.Color.White
        Me.LabelTRANSMISION.Location = New System.Drawing.Point(28, 124)
        Me.LabelTRANSMISION.Name = "LabelTRANSMISION"
        Me.LabelTRANSMISION.Size = New System.Drawing.Size(131, 20)
        Me.LabelTRANSMISION.TabIndex = 18
        Me.LabelTRANSMISION.Text = "TRANSMISION"
        '
        'TextBoxPUERTO
        '
        Me.TextBoxPUERTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxPUERTO.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxPUERTO.Location = New System.Drawing.Point(27, 99)
        Me.TextBoxPUERTO.Name = "TextBoxPUERTO"
        Me.TextBoxPUERTO.Size = New System.Drawing.Size(147, 20)
        Me.TextBoxPUERTO.TabIndex = 17
        Me.TextBoxPUERTO.Text = "55555"
        Me.TextBoxPUERTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxPUERTO.Visible = False
        '
        'ButtonCONECTAR
        '
        Me.ButtonCONECTAR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonCONECTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCONECTAR.ForeColor = System.Drawing.Color.White
        Me.ButtonCONECTAR.Location = New System.Drawing.Point(331, 99)
        Me.ButtonCONECTAR.Name = "ButtonCONECTAR"
        Me.ButtonCONECTAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCONECTAR.TabIndex = 16
        Me.ButtonCONECTAR.Text = "CONECTAR"
        Me.ButtonCONECTAR.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TRANSFERIR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 341)
        Me.Controls.Add(Me.LabelNOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonENVIAR)
        Me.Controls.Add(Me.TextBoxARCHIVO)
        Me.Controls.Add(Me.ButtonELEGIR)
        Me.Controls.Add(Me.LabelESTADO)
        Me.Controls.Add(Me.ButtonRUTA)
        Me.Controls.Add(Me.TextBoxRUTA)
        Me.Controls.Add(Me.LabelTRANSMISION)
        Me.Controls.Add(Me.TextBoxPUERTO)
        Me.Controls.Add(Me.ButtonCONECTAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TRANSFERIR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSFERIR SERVIDOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNOMBRE As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonENVIAR As Button
    Friend WithEvents TextBoxARCHIVO As TextBox
    Friend WithEvents ButtonELEGIR As Button
    Friend WithEvents LabelESTADO As Label
    Friend WithEvents ButtonRUTA As Button
    Friend WithEvents TextBoxRUTA As TextBox
    Friend WithEvents LabelTRANSMISION As Label
    Friend WithEvents TextBoxPUERTO As TextBox
    Friend WithEvents ButtonCONECTAR As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
