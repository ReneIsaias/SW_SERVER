<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENSAJE
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
        Me.TextBoxMENSAJE = New System.Windows.Forms.TextBox()
        Me.RichTextBoxRECIBIDO = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxMENSAJE
        '
        Me.TextBoxMENSAJE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMENSAJE.BackColor = System.Drawing.Color.Navy
        Me.TextBoxMENSAJE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMENSAJE.ForeColor = System.Drawing.Color.White
        Me.TextBoxMENSAJE.Location = New System.Drawing.Point(12, 440)
        Me.TextBoxMENSAJE.Multiline = True
        Me.TextBoxMENSAJE.Name = "TextBoxMENSAJE"
        Me.TextBoxMENSAJE.Size = New System.Drawing.Size(320, 75)
        Me.TextBoxMENSAJE.TabIndex = 1
        Me.TextBoxMENSAJE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBoxRECIBIDO
        '
        Me.RichTextBoxRECIBIDO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRECIBIDO.BackColor = System.Drawing.Color.Navy
        Me.RichTextBoxRECIBIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRECIBIDO.ForeColor = System.Drawing.Color.White
        Me.RichTextBoxRECIBIDO.Location = New System.Drawing.Point(12, 35)
        Me.RichTextBoxRECIBIDO.Name = "RichTextBoxRECIBIDO"
        Me.RichTextBoxRECIBIDO.ReadOnly = True
        Me.RichTextBoxRECIBIDO.Size = New System.Drawing.Size(320, 380)
        Me.RichTextBoxRECIBIDO.TabIndex = 17
        Me.RichTextBoxRECIBIDO.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "MENSAJE SERVIDOR-CLIENTE"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 420)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Mensaje :"
        '
        'MENSAJE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(345, 522)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxMENSAJE)
        Me.Controls.Add(Me.RichTextBoxRECIBIDO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MENSAJE"
        Me.Text = "MENSAJE SERVIDOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxMENSAJE As TextBox
    Friend WithEvents RichTextBoxRECIBIDO As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
