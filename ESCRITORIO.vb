Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Public Class ESCRITORIO

    Dim YO As TcpListener
    Dim REMOTO As TcpClient
    Dim RECIBE As Thread
    Dim NS As NetworkStream
    Private Sub ESCRITORIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        timerDBGetDatas.Start()
        iniciarServicio()
    End Sub
    Public Sub iniciarServicio()
        Try
            CheckForIllegalCrossThreadCalls = False
            YO = New TcpListener(IPAddress.Any, Form1.PortEscritorio)
            YO.Start()
            RECIBE = New Thread(AddressOf RECIBIR)
            RECIBE.Start()
            btnConectar.Visible = False
            LabelCONEXION.Text = "ESCUCHANDO..."
        Catch ex As Exception
            MsgBox("Error al iniciar el servicio : " & ex.Message)
        End Try
    End Sub
    Public Sub RECIBIR()
        Dim BF As New BinaryFormatter
        Try
            While True
                REMOTO = YO.AcceptTcpClient()
                NS = REMOTO.GetStream
                LabelCONEXION.Text = "CONECTADO"
                While REMOTO.Connected = True
                    pictureRemoto.Image = BF.Deserialize(NS)
                End While
            End While
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            LabelCONEXION.Text = "DESCONECTADO"
        End Try
    End Sub

    Private Sub detenerServicio(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ejecutar("UPDATE control SET estadoUsuario = 0 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & lblname.Text & "'")
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
        Try
            NS.Dispose()
        Catch ex As Exception
        End Try
        Try
            YO.Stop()
            RECIBE.Abort()
        Catch ex As Exception
        End Try
        ' Form1.Show()
    End Sub

    Private Sub timerDBGetDatas_Tick(sender As Object, e As EventArgs) Handles timerDBGetDatas.Tick
        Try
            'Obtiene nombre usuario
            ejecutar("SELECT nombreUsuario FROM control WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' LIMIT 1")
            If leerRene.Read() Then
                lblname.Text = leerRene(0).ToString()
                lblTitle.Text = "CLIENTE => " & Form1.txtIpCliente.Text
            End If
            leerRene.Close()
            'Mantiene activo al cliente
            ejecutar("UPDATE control SET estadoUsuario = 1 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & lblname.Text & "'")
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error al obtener los datos")
        End Try
    End Sub

    Private Sub clienteBloquear(sender As Object, e As EventArgs) Handles cmbBloquear.SelectedIndexChanged
        Try
            ejecutar("UPDATE control SET bloquear = " & cmbBloquear.SelectedIndex & " WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & lblname.Text & "'")
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
    End Sub

    Private Sub clienteApagar(sender As Object, e As EventArgs) Handles cmbApagar.SelectedIndexChanged
        Try
            ejecutar("UPDATE control SET apagar = " & cmbApagar.SelectedIndex & " WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & lblname.Text & "'")
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        Try
            ejecutar("UPDATE control SET mensaje = 1 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & lblname.Text & "'")
            leerRene.Close()
            MENSAJE.Show()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        Try
            ejecutar("UPDATE control SET transferir = 1 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & lblname.Text & "'")
            leerRene.Close()
            TRANSFERIR.Show()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        'iniciarServicio()
    End Sub

    Private Sub btnWebcam_Click(sender As Object, e As EventArgs) Handles btnWebcam.Click
        Try
            ejecutar("UPDATE control SET webcam = 1 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & lblname.Text & "'")
            leerRene.Close()
            WEBCAM.Show()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
    End Sub
End Class