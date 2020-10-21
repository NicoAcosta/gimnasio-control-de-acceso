Imports System.IO.Ports

Public Class indexForm

    ' El id del tag (llavero) leido por rfid
    Dim TagRead As String

    ' Por serial com recibe un mensaje de Arduino cuando el sensor detecta que pasa alguien por la entrada
    ' ReceiveSensor seria "darle bola cuando pasa alquien"
    ' On = com abierto
    ' Off = com cerrado
    Dim ReceiveSensor As Boolean

    ' Cuando carga la pantalla index...
    Private Sub indexForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        nameForm.Activate()

        ReceiveSensor = True

        ' Si esta abierto el serial com, cerrarlo
        If SSerial.IsOpen Then
            SSerial.Close()
        End If

        ' Configurar serial com
        Try
            With SSerial
                .PortName = "COM3"
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .ReceivedBytesThreshold = 1
                .RtsEnable = True

            End With

            'Abrir serial com
            SSerial.Open()

            '  Esperar a que se llene el buffe
            System.Threading.Thread.Sleep(50)

        Catch ex As Exception
            Console.Write(ex)
        End Try

    End Sub


    ' Cuando se presiona Enter virtualmente luego de leer el tag rfid...
    Private Sub TagID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TagID.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            ' Mostrar nameForm
            nameForm.Activate()

            ' Dejar de darle bola al sensor (para que no suene la alarma) mientras se muestra la info del tag leido 
            ReceiveSensor = False

            TagRead = TagID.Text

            ' Borrar del textfield el tag del rfid leido
            TagID.Clear()

            e.Handled = True

            ' resultForm.Show()
            nameForm.Show()

            ' Copiar el tag en el campo de busqueda de nameForm, seleccionar el botón de busqueda y simular doble click
            nameForm.TagToolStripTextBox.Text = TagRead
            nameForm.ByTagToolStripButton.Select()
            nameForm.ByTagToolStripButton.PerformClick()
            nameForm.ByTagToolStripButton.PerformClick()

            ' 
            nameForm.MatchearData()

            ''System.Threading.Thread.Sleep(100)

            ' Si está h
            If nameForm.MostrandoData = True Then

                ' Esperar 2 segundos (haciendo sleep 2000 no funcionaba - con el for funcionó)
                For i As Integer = 0 To 200
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                Next


                nameForm.Hide()
                Me.Show()

                nameForm.MostrandoData = False


            End If

            ReceiveSensor = True

        End If


    End Sub

    ' Si alguien pasa y esta 
    Private Sub SSerial_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SSerial.DataReceived

        If RecibirSensor = True Then
            My.Computer.Audio.Play("C:\OD\OneDrive\Oxigeno\Resources\AlSensor.wav", AudioPlayMode.Background)
        End If

    End Sub

End Class
