Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form1

    Public PortDesktop As String = 21114
    Public PortEscritorio As String = 21111
    Public PortMensaje As String = 21112
    Public PortWebcam As String = 21113

    'MAS SERVICIOS
    Dim YO As TcpListener
    Dim REMOTO As TcpClient
    Dim RECIBE As Thread
    Dim NS As NetworkStream

    'mas servicios
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal text As String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        getIpconfig()
    End Sub

    Private Sub insertaUsuario(sender As Object, e As KeyEventArgs) Handles txtMensaje.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (txtUsuario.Text <> "" And txtIp.Text <> "" And txtMensaje.Text <> "") Then
                    ejecutar("INSERT control VALUES(DEFAULT,'" & txtUsuario.Text & "','" & txtIp.Text & "','" & lblAdmin.Text & "','" & txtMensaje.Text & "',0,0,0,0,0,0);")
                    lblNotificacion.Text = "Mensaje Enviado Correctamente"
                    Panel1.Visible = True
                    leerRene.Close()
                    txtUsuario.Enabled = False
                    txtIp.Enabled = False
                    txtMensaje.Text = ""
                    timerChatGeneral.Start()
                Else
                    MessageBox.Show("Oye debes de llenar los campos requeridos")
                    lblNotificacion.Text = "Oye debes de llenar los campos requeridos"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error en la conexion o la consulta" & ex.Message())
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerChatGeneral.Tick
        Try
            llenaLista(listChatGlobal, "SELECT CONCAT(UPPER(nombreUsuario),' => ',mensajeUsuario)AS MENSAJE FROM control;")
            lblNotificacion.Text = ""
        Catch ex As Exception
            MsgBox("No se pudo leer los mensajes del chat global " & ex.Message())
        End Try
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        iniciarServicio()
    End Sub

    Private Sub irCliente(sender As Object, e As EventArgs) Handles pictureCliente.DoubleClick
        ' detenerServicio()
        Try
            If txtIpCliente.Text <> Nothing Then
                ESCRITORIO.Show()
            Else
                MsgBox("Ingrese la IP del cliente")
            End If
        Catch ex As Exception
            MessageBox.Show("Conexion tiene " & ex.Message())
        End Try
    End Sub


    '''SERVICIO DE CLIENTES'''

    Public Sub iniciarServicio()
        Try
            CheckForIllegalCrossThreadCalls = False
            YO = New TcpListener(IPAddress.Any, PortDesktop)
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
                    pictureCliente.Image = BF.Deserialize(NS)
                End While
            End While
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            LabelCONEXION.Text = "DESCONECTADO"
        End Try
    End Sub
    Private Sub detenerServicio()
        Try
            NS.Dispose()
        Catch ex As Exception
        End Try
        Try
            YO.Stop()
            RECIBE.Abort()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtIp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtIp.MouseDoubleClick
        Dim x As Integer
        For x = 1 To 10
        Next
        Dim tercero As Integer
        Dim cortado As Integer
        Dim segundo As String
        Dim cuarto As String
        Dim quinto As Integer
        Dim sexto As String
        Dim puerta As String = "192.168.1.254"
        cortado = InStr(TextBox8.Text, "Adaptador de LAN inal mbrica Wi-Fi:")
        segundo = Mid(TextBox8.Text, cortado)
        tercero = InStr(segundo, "IPv4. . . . . . . . . . . . . . : ")
        cuarto = Mid(segundo, tercero + 34)
        quinto = InStr(cuarto, "M scara de subred")
        sexto = Mid(cuarto, 1, 15)
        sexto = sexto.Replace(" ", "")
        txtIp.Text = sexto
    End Sub
    Public Sub getIpconfig()
        Dim comando As String
        comando = "ipconfig"
        If comando.Contains(" ") Then
            psi = New ProcessStartInfo(comando.Split(" ")(0), comando.Split(" ")(1))
        Else
            psi = New ProcessStartInfo(comando$)
        End If
        Dim systemencoding As System.Text.Encoding
        System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)
        With psi
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True
            .StandardOutputEncoding = systemencoding
            .StandardErrorEncoding = systemencoding
        End With
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}
        AddHandler cmd.ErrorDataReceived, AddressOf este
        AddHandler cmd.OutputDataReceived, AddressOf este
        cmd.Start()
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()
        For z As Integer = 1 To 100
            z += 1
        Next
    End Sub
    Private Sub este(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf esteNo), e.Data)
    End Sub
    Private Sub esteNo(ByVal text As String)
        TextBox8.AppendText(text & Environment.NewLine)
        TextBox8.ScrollToCaret()
    End Sub
End Class