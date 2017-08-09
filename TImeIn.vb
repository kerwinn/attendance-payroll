Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class TImeIn
    Dim count = 0
    Private Sub TImeIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label11.Text = TimeOfDay.ToString("h:mm:ss tt")
        Label13.Text = DateTime.Now.ToString("MM-dd-yyyy")


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        con.Close()
        cmd.Connection = con
        con.Open()
        Dim id, name As String

        id = TextBox1.Text

        cmd.CommandText = "select * from employee_tb where empID = '" & id & "'"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            name = dr.GetString("lastname") & ", " & dr.GetString("firstname") & " " & dr.GetString("middlename")
            Label3.Text = name
            PictureBox2.Image = Image.FromFile("C:\Users\Whin\Documents\Visual Studio 2010\Projects\WindowsApplication1\WindowsApplication1\Pictures\" + dr.GetString("image"), True)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Please Enter Your Employee Number")
        Else
            confirmation.Show()
        End If

        'cmd.Connection = con
        'Dim ID, dt, tm As String
        'Dim type As String

        'ID = TextBox1.Text
        'dt = Label13.Text
        'tm = Label11.Text



        'If ID = "" Then
        'MessageBox.Show("Please Enter Your Employee Number")

        'Else
        'cmd.CommandText = "select * from attendance_tb where empID = " & ID & " and date = '" & dt & "'"
        'da.SelectCommand = New MySqlCommand("select * from attendance_tb where empID = " & ID & " and date = '" & dt & "'")
        'da.SelectCommand.Connection = con
        'da.Fill(ds)
        'count = ds.Tables(0).Rows.Count
        'dr = cmd.ExecuteReader
        'con.Close()
        'con.Open()
        'If count > 1 Then
        ' MessageBox.Show("Already Signed Out!")
        '
        'Else
        'If count = 1 Then
        'Type = "Time Out"
        'Else
        'Type = "Time In"
        'End If

        'con.Close()
        'con.Open()
        'query = "Insert Into attendance_tb(empID, name, date, time, type) Values ('" & ID & "', '" & Label3.Text & "', '" & dt & "', '" & tm & "', '" & Type & "') "
        'cmd.CommandText = query
        'da.SelectCommand = cmd
        'cmd.ExecuteNonQuery()
        'Timer2.Enabled = True

        'End If

        'End If
        'con.Close()

        'con.Close()



    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        ProgressBar1.Value += 10
        If ProgressBar1.Value >= ProgressBar1.Maximum Then

            Timer2.Enabled = False
            MessageBox.Show("Record Added")
            TextBox1.Text = ""
            Label3.Text = ""
            PictureBox2.Image = Nothing

            ProgressBar1.Value = 0
        End If


    End Sub

   

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Your Employee Number First")
        Else
            changepass.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class