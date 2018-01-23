Public Class Form2
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtnum.Clear()
        txtname.Clear()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim Name1, Phone1 As String
        Name1 = txtname.Text
        Phone1 = txtnum.Text

        If Name1 <> "" Then
            If IsinFile(Name1) Then

                MessageBox.Show("Name Already Exsists in Directory, Please Add a Last Inital")
            Else


                Dim sw2 As IO.StreamWriter = IO.File.AppendText(directory)
                sw2.WriteLine(Name1 & "," & Phone1)
                sw2.Close()
                txtname.Text = ""
                txtnum.Text = ""

            End If
        Else
            MessageBox.Show("Please Fill Out All Information")
        End If
    End Sub
End Class