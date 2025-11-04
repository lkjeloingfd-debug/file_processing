Imports System.IO

Public Class Form1
    Dim filepath As String = "sample.txt"
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Using writer As New StreamWriter(filepath, True) 'true means append mode
                'writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("palitan bago.")
                writer.WriteLine(" ")
            End Using

            MessageBox.Show("Data written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) 'MesageBox.Show(content, tittle, buttonn, icon)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click

        Using reader As New StreamReader(filepath)
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show(content, "File Content", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonReadPerLine.Click
        ListBox.Items.Clear()
        Using reader As New StreamReader(filepath)
            Dim line As String = reader.ReadLine()

            While line IsNot Nothing
                ListBox.Items.Add(line)
                line = reader.ReadLine()

            End While


        End Using
    End Sub
End Class
