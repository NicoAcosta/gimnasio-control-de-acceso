Public Class nameForm


    Public MostrandoData As Boolean

    ' Cargar/conectar datos Access
    Private Sub SnarkyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SnarkyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PuppyDataSet)
    End Sub

    ' Al cargar nameForm... llenar datos
    Private Sub nameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuppyDataSet.Snarky' Puede moverla o quitarla según sea necesario.
        Me.SnarkyTableAdapter.Fill(Me.PuppyDataSet.Snarky)
    End Sub

    ' Cuando se hace virtualmente el doble click... 
    Private Sub ByTagToolStripButton_Click(sender As Object, e As EventArgs) Handles ByTagToolStripButton.Click
        ' Ubicar la info en la base de datos por el tag
        Try
            Me.SnarkyTableAdapter.ByTag(Me.PuppyDataSet.Snarky, TagToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Check de acuerdo al estado del socio (al dia, por vencer, vencido, pase libre/staff) cambia el color, muestra/oculta datos
    Public Sub MatchearData()
        
        Select Case EstTextBox.Text

            ' Al dia - azul
            Case "1"

                NomApTextBox.ForeColor = Color.FromArgb(31, 104, 160)
                VenLabel.ForeColor = Color.FromArgb(31, 104, 160)
                EstadoTextBox.ForeColor = Color.FromArgb(1, 31, 104, 160)
                EstadoTextBox.Visible = True
                VencimientoDateTimePicker.Visible = True
                MostrandoData = True

            ' Por vencer - naranja
            Case "1"

                NomApTextBox.ForeColor = Color.Orange
                VenLabel.ForeColor = Color.Orange
                EstadoTextBox.ForeColor = Color.Orange
                EstadoTextBox.Visible = True
                VencimientoDateTimePicker.Visible = True
                MostrandoData = True

            ' Vencido - rojo
            Case "3"

                NomApTextBox.ForeColor = Color.Red
                VenLabel.ForeColor = Color.Red
                EstadoTextBox.ForeColor = Color.Red
                EstadoTextBox.Visible = True
                VencimientoDateTimePicker.Visible = True
                My.Computer.Audio.Play("C:\OD\OneDrive\Oxigeno\Resources\AlVencido.wav", AudioPlayMode.Background)
                MostrandoData = True

            ' Pase libre/staff - azul, ocultar fecha
            Case "4"

                NomApTextBox.ForeColor = Color.FromArgb(31, 104, 160)
                VenLabel.ForeColor = Color.White
                EstadoTextBox.ForeColor = Color.White
                EstadoTextBox.Visible = False

                VencimientoDateTimePicker.Visible = False
                MostrandoData = True


            Case Else

                ' si no se encuentra en la base de datos, sonar alarma, oculart NameForm
                My.Computer.Audio.Play("C:\OD\OneDrive\Oxigeno\Resources\AlVencido.wav", AudioPlayMode.Background)
                Me.Hide()
                indexForm.Show()

        End Select



    End Sub

End Class