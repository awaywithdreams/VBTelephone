'Danielle Allan'
'Project 3 2016'
'Professor Wagner'
'Description: A program that allows a user to use phone directories, adding and deleteing them
'then creating contacts, to add, modify and delete them, including a splash screen & an about box'
'Comments: I have redone this project 5 times now, and i want to pull my hair out'

Public Class Form1
    Dim mydirectories As String() = IO.File.ReadAllLines("MyDirectory.txt")
    Dim directory As String



    Structure Contact
        'Builds a structure to call in later parts'
        Dim Name As String
        Dim Phone As String
    End Structure

    Private Sub menuclose_Click(sender As Object, e As EventArgs) Handles menuclose.Click
        'In the menu strip allows user to close the program'
        Me.Close()
    End Sub

    Private Sub menuabout_Click(sender As Object, e As EventArgs) Handles menuabout.Click
        'A control in the menu that opens the about box containing information on the project'
        AboutBox1.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstdir.Items.AddRange(mydirectories)
        'Puts the phone directories in the list box'
    End Sub

    Private Sub lstdir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstdir.SelectedIndexChanged
        'list box of the telephone directoies'
        directory = lstdir.SelectedItem
        'Allows user to click on a directory

    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim displaytext, title, space As String
        Dim myValue As String
        displaytext = "Please fill out name of telephone directory"
        title = "Telephone Directory"
        space = ""
        myValue = InputBox(displaytext, title, space)

        If myValue Is "" Or IO.File.Exists(myValue & ".txt") Then
            MessageBox.Show("Information is Invalid")


        Else
            Dim sw As IO.StreamWriter = IO.File.CreateText(myValue & ".txt")
            sw.Close()

            Dim sw1 As IO.StreamWriter = IO.File.AppendText("MyDirectory.txt")
            sw1.WriteLine(myValue & ".txt")
            sw1.Close()

            MessageBox.Show("New Directory has been Created")
            lstdir.Items.Add(myValue)
        End If
    End Sub

    Sub dispDir()
        Dim dir As IO.StreamReader = IO.File.OpenText("MyDirectory.txt")
        lstdir.Items.Clear()
        Do Until dir.EndOfStream
            lstdir.Items.Add(dir.ReadLine)
        Loop
        dir.Close()
    End Sub
    Dim info() As Contact

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        displayall()
    End Sub
    Sub displayall()
        If directory = "" Then
            MessageBox.Show("No information avalible")
        Else
            ParseData()

            Dim query = From Contact In info
                        Order By Contact.Name Ascending
                        Select Contact.Name, Contact.Phone

            dgvcontacts.DataSource = query.ToList
            dgvcontacts.CurrentCell = Nothing
            dgvcontacts.Columns("Name").HeaderText = "Name"
            dgvcontacts.Columns("Phone").HeaderText = "Phone Number"
        End If
    End Sub
    Sub ParseData()

        Dim line As String
        Dim data(1) As String
        Dim type() As String = IO.File.ReadAllLines(directory)
        Dim n = type.Count - 1
        ReDim info(n)
        For i As Integer = 0 To n
            line = type(i)
            data = line.Split(","c)
            info(i).Name = data(0)
            info(i).Phone = data(1)
        Next
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        If directory = "" Then
            MessageBox.Show("Please Pick a Directory")
        Else
            Dim madamX As String = InputBox("Please Select Contact you wish to remove", "Delete Contact").ToUpper
            If madamX = "" Then

                Return
            Else
                If IsInFile(madamX.ToUpper) = False Then
                    MessageBox.Show("Name is not in Directory", "Error")
                Else

                    Dim srX As IO.StreamReader = IO.File.OpenText(directory)
                    Dim swX As IO.StreamWriter = IO.File.CreateText("temp.txt")

                    Dim line3 As String

                    Do Until srX.EndOfStream

                        line3 = srX.ReadLine()

                        If ParseLine(line3) <> madamX.ToUpper Then
                            swX.WriteLine(line3)

                        End If
                    Loop
                    srX.Close()
                    swX.Close()

                    IO.File.Delete(directory)
                    IO.File.Move("temp.txt", directory)


                End If
            End If
        End If
        displayall()
    End Sub
    Public Function IsInFile(person As String) As Boolean
        Dim sr5 As IO.StreamReader = IO.File.OpenText(directory)
        Dim first As String
        Do Until sr5.EndOfStream

            first = ParseLine(sr5.ReadLine.ToUpper)

            If first = person Then

                sr5.Close()

                Return True
            End If
        Loop
        sr5.Close()
        Return False
    End Function

    Function ParseLine(line As String) As String
        Dim name() As String = line.Split(","c)
        Dim first As String = name(0)
        Return first.ToUpper
    End Function

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Form2.Show()
        Dim Name1, Phone1 As String
        Name1 = Form2.txtnum.Text
        Phone1 = Form2.txtname.Text

        If Name1 <> "" Then
            If IsInFile(Name1) Then

                MessageBox.Show("Name Already Exsists In Directory, Please Add a Last Inital")
            Else


                Dim sw2 As IO.StreamWriter = IO.File.AppendText(directory)
                sw2.WriteLine(Name1 & ", " & Phone1)
                sw2.Close()
                Form2.txtname.Text = ""
                Form2.txtnum.Text = ""

            End If
        Else
            MessageBox.Show("Please Fill Out All Information")
        End If

    End Sub

    Private Sub btndeldir_Click(sender As Object, e As EventArgs) Handles btndeldir.Click
        Dim response = MsgBox("Delete  " & lstdir.SelectedItem & " ? ", MsgBoxStyle.YesNo, "Directory Delete")
        If response = MsgBoxResult.No Then
            Return
        End If
        Dim person As String = lstdir.Text
        If person = "" Then
            MessageBox.Show("Cannot Delete a Blank Entry, Please Select a Directory To Delete")
        Else

            Dim SR As IO.StreamReader = IO.File.OpenText("MyDirectory.txt")
            Dim sw As IO.StreamWriter = IO.File.CreateText("Temp.txt")
            Dim individual As String
            Do Until SR.EndOfStream
                individual = SR.ReadLine
                If individual <> person Then
                    sw.WriteLine(individual)
                End If
            Loop
            SR.Close()
            sw.Close()
            IO.File.Delete("MyDirectory.txt")
            IO.File.Move("Temp.txt", "MyDirectory.txt")
            IO.File.Delete(person)
            MessageBox.Show(person & " Deleted", "Directory Deleted")
            dispDir()
            lstdir.SelectedIndex = 0


        End If

    End Sub

    Private Sub menudeletedir_Click(sender As Object, e As EventArgs) Handles menudeletedir.Click
        Dim person As String = lstdir.Text
        If person = "" Then
            MessageBox.Show("Cannot Delete a Blank Entry, Please Select a Directory to Delete")
        Else

            Dim SR As IO.StreamReader = IO.File.OpenText("MyDirectory.txt")
            Dim sw As IO.StreamWriter = IO.File.CreateText("Temp.txt")
            Dim individual As String
            Do Until SR.EndOfStream
                individual = SR.ReadLine
                If individual <> person Then
                    sw.WriteLine(individual)
                End If
            Loop
            SR.Close()
            sw.Close()
            IO.File.Delete("MyDirectory.txt")
            IO.File.Move("Temp.txt", "MyDirectory.txt")
            IO.File.Delete(person)
            MessageBox.Show(person & " Deleted", "Directory Deleted")
            dispDir()
            lstdir.SelectedIndex = 0


        End If

    End Sub

    Private Sub menucreate_Click(sender As Object, e As EventArgs) Handles menucreate.Click
        Dim displaytext, title, space As String
        Dim myValue As String
        displaytext = "Please fill out name of telephone directory"
        title = "Telephone Directory"
        space = ""
        myValue = InputBox(displaytext, title, space)

        If myValue Is "" Or IO.File.Exists(myValue & ".txt") Then
            MessageBox.Show("Information Is Invalid")


        Else
            Dim sw As IO.StreamWriter = IO.File.CreateText(myValue & ".txt")
            sw.Close()

            Dim sw1 As IO.StreamWriter = IO.File.AppendText("MyDirectory.txt")
            sw1.WriteLine(myValue & ".txt")
            sw1.Close()

            MessageBox.Show("New Directory has been Created")
            lstdir.Items.Add(myValue)
        End If
    End Sub

    Private Sub menudisplay_Click(sender As Object, e As EventArgs) Handles menudisplay.Click
        displayall()
    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        Form2.Show()
        If directory = "" Then
            MessageBox.Show("Please Pick a Directory")
        Else
            Dim madamX As String = InputBox("Please Select Contact you wish to remove", "Delete Contact").ToUpper
            If madamX = "" Then

                Return
            Else
                If IsInFile(madamX.ToUpper) = False Then
                    MessageBox.Show("Name Is Not in Directory", "Error")
                Else

                    Dim srX As IO.StreamReader = IO.File.OpenText(directory)
                    Dim swX As IO.StreamWriter = IO.File.CreateText("temp.txt")

                    Dim line3 As String

                    Do Until srX.EndOfStream

                        line3 = srX.ReadLine()

                        If ParseLine(line3) <> madamX.ToUpper Then
                            swX.WriteLine(line3)

                        End If
                    Loop
                    srX.Close()
                    swX.Close()
                End If
            End If
        End If
    End Sub
End Class
