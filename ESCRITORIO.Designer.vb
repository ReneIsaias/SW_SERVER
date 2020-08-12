<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESCRITORIO
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.LabelCONEXION = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.pictureRemoto = New System.Windows.Forms.PictureBox()
        Me.timerDBGetDatas = New System.Windows.Forms.Timer(Me.components)
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblBloquear = New System.Windows.Forms.Label()
        Me.cmbBloquear = New System.Windows.Forms.ComboBox()
        Me.cmbApagar = New System.Windows.Forms.ComboBox()
        Me.labApagar = New System.Windows.Forms.Label()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.btnWebcam = New System.Windows.Forms.Button()
        CType(Me.pictureRemoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(680, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "CONECTAR"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(185, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(198, 33)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "CLIENTE => "
        '
        'btnMensaje
        '
        Me.btnMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensaje.ForeColor = System.Drawing.Color.White
        Me.btnMensaje.Location = New System.Drawing.Point(660, 141)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(135, 40)
        Me.btnMensaje.TabIndex = 36
        Me.btnMensaje.Text = "MENSAJE"
        Me.btnMensaje.UseVisualStyleBackColor = False
        '
        'LabelCONEXION
        '
        Me.LabelCONEXION.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCONEXION.AutoSize = True
        Me.LabelCONEXION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCONEXION.ForeColor = System.Drawing.Color.White
        Me.LabelCONEXION.Location = New System.Drawing.Point(662, 97)
        Me.LabelCONEXION.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCONEXION.Name = "LabelCONEXION"
        Me.LabelCONEXION.Size = New System.Drawing.Size(133, 16)
        Me.LabelCONEXION.TabIndex = 35
        Me.LabelCONEXION.Text = "DESCONECTADO"
        '
        'btnConectar
        '
        Me.btnConectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.ForeColor = System.Drawing.Color.White
        Me.btnConectar.Location = New System.Drawing.Point(660, 53)
        Me.btnConectar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(135, 40)
        Me.btnConectar.TabIndex = 34
        Me.btnConectar.Text = "CONECTAR"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'pictureRemoto
        '
        Me.pictureRemoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureRemoto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pictureRemoto.Location = New System.Drawing.Point(13, 53)
        Me.pictureRemoto.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureRemoto.Name = "pictureRemoto"
        Me.pictureRemoto.Size = New System.Drawing.Size(629, 470)
        Me.pictureRemoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureRemoto.TabIndex = 33
        Me.pictureRemoto.TabStop = False
        '
        'timerDBGetDatas
        '
        Me.timerDBGetDatas.Interval = 4000
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Black
        Me.lblname.Location = New System.Drawing.Point(10, 9)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(85, 31)
        Me.lblname.TabIndex = 39
        Me.lblname.Text = "name"
        '
        'lblBloquear
        '
        Me.lblBloquear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBloquear.AutoSize = True
        Me.lblBloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloquear.Location = New System.Drawing.Point(661, 384)
        Me.lblBloquear.Name = "lblBloquear"
        Me.lblBloquear.Size = New System.Drawing.Size(81, 20)
        Me.lblBloquear.TabIndex = 40
        Me.lblBloquear.Text = "Bloquear"
        '
        'cmbBloquear
        '
        Me.cmbBloquear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBloquear.BackColor = System.Drawing.Color.Teal
        Me.cmbBloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBloquear.ForeColor = System.Drawing.Color.White
        Me.cmbBloquear.FormattingEnabled = True
        Me.cmbBloquear.Items.AddRange(New Object() {"DESBLOQUEAR", "BLOQUEAR"})
        Me.cmbBloquear.Location = New System.Drawing.Point(649, 407)
        Me.cmbBloquear.Name = "cmbBloquear"
        Me.cmbBloquear.Size = New System.Drawing.Size(146, 28)
        Me.cmbBloquear.TabIndex = 41
        '
        'cmbApagar
        '
        Me.cmbApagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbApagar.BackColor = System.Drawing.Color.Olive
        Me.cmbApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbApagar.ForeColor = System.Drawing.Color.White
        Me.cmbApagar.FormattingEnabled = True
        Me.cmbApagar.Items.AddRange(New Object() {"REINICIAR", "APAGAR"})
        Me.cmbApagar.Location = New System.Drawing.Point(649, 475)
        Me.cmbApagar.Name = "cmbApagar"
        Me.cmbApagar.Size = New System.Drawing.Size(146, 28)
        Me.cmbApagar.TabIndex = 43
        '
        'labApagar
        '
        Me.labApagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labApagar.AutoSize = True
        Me.labApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labApagar.Location = New System.Drawing.Point(661, 452)
        Me.labApagar.Name = "labApagar"
        Me.labApagar.Size = New System.Drawing.Size(67, 20)
        Me.labApagar.TabIndex = 42
        Me.labApagar.Text = "Apagar"
        '
        'btnTransferir
        '
        Me.btnTransferir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransferir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTransferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferir.ForeColor = System.Drawing.Color.White
        Me.btnTransferir.Location = New System.Drawing.Point(660, 217)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(135, 40)
        Me.btnTransferir.TabIndex = 46
        Me.btnTransferir.Text = "TRANSFERIR"
        Me.btnTransferir.UseVisualStyleBackColor = False
        '
        'btnWebcam
        '
        Me.btnWebcam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWebcam.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWebcam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWebcam.ForeColor = System.Drawing.Color.White
        Me.btnWebcam.Location = New System.Drawing.Point(660, 290)
        Me.btnWebcam.Name = "btnWebcam"
        Me.btnWebcam.Size = New System.Drawing.Size(135, 40)
        Me.btnWebcam.TabIndex = 47
        Me.btnWebcam.Text = "WEBCAM"
        Me.btnWebcam.UseVisualStyleBackColor = False
        '
        'ESCRITORIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(803, 536)
        Me.Controls.Add(Me.btnWebcam)
        Me.Controls.Add(Me.btnTransferir)
        Me.Controls.Add(Me.cmbApagar)
        Me.Controls.Add(Me.labApagar)
        Me.Controls.Add(Me.cmbBloquear)
        Me.Controls.Add(Me.lblBloquear)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnMensaje)
        Me.Controls.Add(Me.LabelCONEXION)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.pictureRemoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ESCRITORIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESCRITORIO SERVIDOR"
        CType(Me.pictureRemoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMensaje As Button
    Friend WithEvents LabelCONEXION As Label
    Friend WithEvents btnConectar As Button
    Friend WithEvents pictureRemoto As PictureBox
    Friend WithEvents timerDBGetDatas As Timer
    Friend WithEvents lblname As Label
    Friend WithEvents lblBloquear As Label
    Friend WithEvents cmbBloquear As ComboBox
    Friend WithEvents cmbApagar As ComboBox
    Friend WithEvents labApagar As Label
    Friend WithEvents btnTransferir As Button
    Friend WithEvents btnWebcam As Button
End Class
