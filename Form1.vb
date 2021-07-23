Imports MessagingToolkit.QRCode.Codec
'Imports MessagingToolkit.QRCode.Codec.Data
'Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "QR Code Reader Generator"
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        'Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        ''Generator.BackColor = Color.White
        'Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        'Generator.IncludeLabel = True
        'Generator.CustomLabel = txtText.Text
        'Try
        '    pbQrCodeImg.Image = New Bitmap(Generator.Encode(BarcodeFormat.QRCode, txtText.Text, Nothing))
        'Catch ex As Exception
        '    pbQrCodeImg.Image = Nothing
        'End Try
    End Sub

    Private Sub setQrCode()
        pbQrCodeImg.SizeMode = PictureBoxSizeMode.StretchImage
        Dim i_barcode As String = txtText.Text
        Dim encoder As QRCodeEncoder = New QRCodeEncoder
        Dim qrcode As Bitmap = encoder.Encode(i_barcode)
        pbQrCodeImg.Image = qrcode
    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        lblBarcode.Text = txtText.Text
        setQrCode()
    End Sub
End Class
