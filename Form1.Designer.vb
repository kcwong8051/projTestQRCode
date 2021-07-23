<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.pbQrCodeImg = New System.Windows.Forms.PictureBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        CType(Me.pbQrCodeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PMingLiU", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text:"
        '
        'txtText
        '
        Me.txtText.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtText.Font = New System.Drawing.Font("PMingLiU", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtText.Location = New System.Drawing.Point(55, 427)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(177, 30)
        Me.txtText.TabIndex = 1
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGenerate.Font = New System.Drawing.Font("PMingLiU", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(335, 425)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(92, 32)
        Me.cmdGenerate.TabIndex = 3
        Me.cmdGenerate.Text = "QR Code"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'pbQrCodeImg
        '
        Me.pbQrCodeImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbQrCodeImg.Location = New System.Drawing.Point(92, 43)
        Me.pbQrCodeImg.Name = "pbQrCodeImg"
        Me.pbQrCodeImg.Size = New System.Drawing.Size(250, 250)
        Me.pbQrCodeImg.TabIndex = 4
        Me.pbQrCodeImg.TabStop = False
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Font = New System.Drawing.Font("PMingLiU", 14.0!)
        Me.lblBarcode.Location = New System.Drawing.Point(168, 306)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(99, 19)
        Me.lblBarcode.TabIndex = 5
        Me.lblBarcode.Text = "0123456789"
        Me.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 461)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.pbQrCodeImg)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbQrCodeImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents cmdGenerate As Button
    Friend WithEvents pbQrCodeImg As PictureBox
    Friend WithEvents lblBarcode As Label
End Class
