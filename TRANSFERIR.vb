Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Text
Public Class TRANSFERIR

    Dim YO As TcpListener
    Dim REMOTO As TcpClient
    Dim RECIBE As Thread
    Dim NS As NetworkStream
    Private Sub TRANSFERIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()

        'CARGA SI LA HAY LA RUTA CON LA QUE SE CONECTO POR ULTIMA VEZ
        Try
            TextBoxRUTA.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\RUTA.txt")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonRUTA_Click(sender As Object, e As EventArgs) Handles ButtonRUTA.Click
        'DONDE GUARDARA LOS ARCHIVOS QUE RECIBA
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxRUTA.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub ButtonCONECTAR_Click(sender As Object, e As EventArgs) Handles ButtonCONECTAR.Click
        'INICIA LA CONEXION Y EL THREAD DE ESCUCHA (RECIBIR)
        If TextBoxRUTA.Text <> "" Then
            Try
                CheckForIllegalCrossThreadCalls = False 'EVITA PROBLEMAS AL UTILIZAR CONTROLES (TEXTBOX, LABELS, PICTUREBOX, ETC) DURANTE EL THREAD
                YO = New TcpListener(IPAddress.Any, TextBoxPUERTO.Text)
                YO.Start()
                RECIBE = New Thread(AddressOf RECIBIR)
                RECIBE.Start()
                TextBoxRUTA.ReadOnly = True
                ButtonRUTA.Visible = False
                ButtonCONECTAR.Visible = False
                LabelTRANSMISION.Text = "ESCUCHANDO"
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\RUTA.txt", TextBoxRUTA.Text, False)
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("FALTA RUTA DONDE GUARDAR LOS ARCHIVOS")
        End If
    End Sub
    Public Sub RECIBIR()
        'THREAD DE ESCUCHA, RECEPCION DE ARCHIVOS
        Dim BF As New BinaryFormatter
        Try
            While True
                REMOTO = YO.AcceptTcpClient()
                NS = REMOTO.GetStream
                While REMOTO.Connected = True
                    LabelTRANSMISION.Text = "REMOTO CONECTADO"
                    If LabelESTADO.Text = "ESTADO" Or LabelESTADO.Text = "GUARDADO OK" Then
                        BF = New BinaryFormatter
                        LabelESTADO.Text = Encoding.UTF7.GetString(BF.Deserialize(NS))
                        LabelNOMBRE.Text = LabelESTADO.Text
                    Else
                        LabelESTADO.Text = "DESCARGANDO..."
                        BF = New BinaryFormatter
                        Dim RECIBIDO As Byte() = BF.Deserialize(NS)
                        File.WriteAllBytes(TextBoxRUTA.Text & LabelNOMBRE.Text, RECIBIDO)
                        LabelESTADO.Text = "GUARDADO OK"
                    End If
                End While
            End While
        Catch ex As Exception
            ' MsgBox("REMOTO DESCONECTADO ME CIERRO")
            Me.Close()
        End Try
    End Sub

    Private Sub ButtonELEGIR_Click(sender As Object, e As EventArgs) Handles ButtonELEGIR.Click
        'ELIGE EL ARCHIVO Y CREA UN ARRAY DE BYTES
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxARCHIVO.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonENVIAR_Click(sender As Object, e As EventArgs) Handles ButtonENVIAR.Click
        Dim BF As New BinaryFormatter
        Try
            'ENVIA EL NOMBRE ARCHIVO
            Dim NOMBRE As String = TextBoxARCHIVO.Text
            NOMBRE = NOMBRE.Remove(0, NOMBRE.LastIndexOf("\") + 1)
            Dim ARCHIVO As Byte() = Nothing
            ARCHIVO = Encoding.UTF7.GetBytes(NOMBRE)
            NS = REMOTO.GetStream
            BF.Serialize(NS, ARCHIVO)
            Threading.Thread.Sleep(1000) 'PARA SEPARAR EL ENVIO DEL NOMBRE DEL ENVIO DEL ARCHIVO
            'ENVIA EL ARCHIVO
            Dim MEMORIA As Byte() = File.ReadAllBytes(TextBoxARCHIVO.Text)
            NS = REMOTO.GetStream
            BF.Serialize(NS, MEMORIA)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TRANSFERIR_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ejecutar("UPDATE control SET transferir = 0 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & ESCRITORIO.lblname.Text & "'")
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
        'CIERRA EL NETWORKSTREAM, EL TCPLISTENER Y EL THREAD
        Try
            NS.Close()
        Catch ex As Exception
        End Try
        Try
            YO.Stop()
            RECIBE.Abort()
        Catch ex As Exception
        End Try
    End Sub
End Class