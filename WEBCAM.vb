Imports System.Runtime.InteropServices
Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Public Class WEBCAM

    Dim YO As TcpListener
    Dim REMOTO As TcpClient
    Dim RECIBE As Thread
    Dim NS As NetworkStream
    Dim IMAGEN As Image
    Dim CALIDAD As String

    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    Public iDevice As Integer = 0
    Public hHwnd As Integer

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean

    Public Sub OpenPreviewWindow()
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PictureBoxVISOR.Handle.ToInt32, 0)
        Dim CONTADOR As Integer = 0
        For I = 1 To 10
            Dim CONECTADO As Integer = SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
            If CONECTADO = 1 Then
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictureBoxVISOR.Width, PictureBoxVISOR.Height, SWP_NOMOVE Or SWP_NOZORDER)
                ButtonINICIAR.Visible = False
                Exit For
            End If
            CONTADOR = I
        Next
        If CONTADOR = 10 Then
            DestroyWindow(hHwnd)
            MsgBox("NO PUEDO CONECTAR LA CAMARA")
        End If
    End Sub

    Private Sub WEBCAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarme()
        'iniciamos el servicio
        Try
            OpenPreviewWindow()
            iniciaServios()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'validamos la calidad
        If RadioButtonB.Checked Then
            CALIDAD = "BAJA"
        ElseIf RadioButtonA.Checked Then
            CALIDAD = "ALTA"
        End If
    End Sub
    Private Sub ButtonINICIAR_Click(sender As Object, e As EventArgs) Handles ButtonINICIAR.Click
        Try
            OpenPreviewWindow()
            ButtonCONECTAR.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadioButtonB_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonB.CheckedChanged
        If RadioButtonB.Checked Then
            CALIDAD = "BAJA"
            Timer1.Stop()
        ElseIf RadioButtonA.Checked Then
            CALIDAD = "ALTA"
            Timer1.Start()
        End If
    End Sub

    Private Sub RadioButtonA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonA.CheckedChanged
        If RadioButtonB.Checked Then
            CALIDAD = "BAJA"
            Timer1.Stop()
        ElseIf RadioButtonA.Checked Then
            CALIDAD = "ALTA"
            Timer1.Start()
        End If
    End Sub

    Private Sub ButtonCONECTAR_Click(sender As Object, e As EventArgs) Handles ButtonCONECTAR.Click

    End Sub
    Public Sub iniciaServios()
        Try
            CheckForIllegalCrossThreadCalls = False
            YO = New TcpListener(IPAddress.Any, Form1.PortWebcam)
            YO.Start()
            RECIBE = New Thread(AddressOf RECIBIR)
            RECIBE.Start()
            If CALIDAD = "ALTA" Then
                Timer1.Interval = CInt(1000 / NumericUpDown1.Value)
                Timer1.Start()
            End If
            ButtonCONECTAR.Visible = False
            ButtonINICIAR.Visible = False
        Catch ex As Exception
            ' MsgBox("NO PUEDO CONECTAR")
        End Try
    End Sub
    Public Sub RECIBIR()
        Dim BF As New BinaryFormatter
        Try
            While True
                REMOTO = YO.AcceptTcpClient()
                NS = REMOTO.GetStream
                While REMOTO.Connected = True
                    Try
                        PictureBoxREMOTO.Image = BF.Deserialize(NS)

                    Catch ex As Exception
                        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                        MsgBox("RECEPTOR RECIBIR")
                    End Try
                    Try
                        If CALIDAD = "BAJA" Then
                            IMAGEN = New Bitmap(PictureBoxVISOR.Width, PictureBoxVISOR.Height)
                            Dim DIBUJO As Graphics = Graphics.FromImage(IMAGEN)
                            DIBUJO.CopyFromScreen(Me.Location.X + PictureBoxVISOR.Location.X + 8,
                                                  Me.Location.Y + PictureBoxVISOR.Location.Y + 30, 0, 0, PictureBoxVISOR.Size)
                        End If
                        NS = REMOTO.GetStream
                        BF.Serialize(NS, IMAGEN)
                    Catch ex As Exception
                        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                        MsgBox("RECEPTOR ENVIAR")
                    End Try
                End While
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If CALIDAD = "ALTA" Then
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
                Dim DATOS = Clipboard.GetDataObject
                IMAGEN = CType(DATOS.GetData(GetType(Bitmap)), Image)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub WEBCAM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ejecutar("UPDATE control SET webcam = 0 WHERE ipUsuario = '" & Form1.txtIpCliente.Text & "' AND nombreUsuario = '" & ESCRITORIO.lblname.Text & "'")
            leerRene.Close()
        Catch ex As Exception
            MsgBox("Error en la consulta de : " & ex.Message())
        End Try
        Try
            YO.Stop()
            RECIBE.Abort()
        Catch ex As Exception
        End Try
    End Sub
End Class