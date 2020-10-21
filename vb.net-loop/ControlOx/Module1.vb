Imports System.Diagnostics
Imports System.ComponentModel


Module Module1

    Sub Main()

        Dim p As New System.Diagnostics.Process()


        While 1 = 1

            p = Process.Start("C:\OD\OneDrive\Oxigeno\App\Oxigeno App.exe")

            For index As Integer = 1 To 60

                Threading.Thread.Sleep(60000)

            Next

            p.Kill()

        End While



    End Sub

End Module

