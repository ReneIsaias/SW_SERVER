Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Public Class MENSAJE

    Dim YO2 As TcpListener
    Dim REMOTO2 As TcpClient
    Dim RECIBE2 As Thread
    Dim NS2 As NetworkStream
    Private Sub MENSAJE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        Try
            CheckForIllegalCrossThreadCalls = False
            YO2 = New TcpListener(IPAddress.Any, Form1.PortMensaje)
            YO2.Start()
            RECIBE2 = New Thread(AddressOf RECIBIR2)
            RECIBE2.Start()
            RichTextBoxRECIBIDO.SelectionColor = Color.Red
            RichTextBoxRECIBIDO.AppendText("CONECTADO" & vbCrLf)
            RichTextBoxRECIBIDO.ScrollToCaret()
            TextBoxMENSAJE.Focus()
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Size.Width, 200)
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub
    Public Sub RECIBIR2()
        Dim BF2 As New BinaryFormatter
        Try
            While True
                REMOTO2 = YO2.AcceptTcpClient()
                NS2 = REMOTO2.GetStream
                While REMOTO2.Connected = True
                    Dim MENSAJE As String = System.Text.Encoding.UTF7.GetString(BF2.Deserialize(NS2))
                    RichTextBoxRECIBIDO.SelectionColor = Color.White
                    RichTextBoxRECIBIDO.AppendText("Cliente : " & MENSAJE & vbCrLf)
                    RichTextBoxRECIBIDO.ScrollToCaret()
                End While
            End While
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TextBoxMENSAJE_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxMENSAJE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim ENVIO As Byte() = System.Text.Encoding.UTF7.GetBytes(TextBoxMENSAJE.Text)
                NS2 = REMOTO2.GetStream()
                Dim BF2 As New BinaryFormatter
                BF2.Serialize(NS2, ENVIO)
                RichTextBoxRECIBIDO.SelectionColor = Color.Black
                RichTextBoxRECIBIDO.AppendText("Yo : " & TextBoxMENSAJE.Text & vbCrLf)
                RichTextBoxRECIBIDO.ScrollToCaret()
                TextBoxMENSAJE.Clear()
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            TextBoxMENSAJE.Clear()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            '  MsgBox("Cliente Desconectado")
        End Try
    End Sub
    Private Sub MENSAJE_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ejecutar("UPDATE control SET mensaje = 0 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & ESCRITORIO.lblname.Text & "'")
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
        Try
            YO2.Stop()
            RECIBE2.Abort()
        Catch ex As Exception
        End Try
    End Sub
End Class