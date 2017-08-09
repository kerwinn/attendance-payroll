Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Time
    Dim count = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Timer2.Enabled = True

        'If ProgressBar1.Value = ProgressBar1.Maximum Then
        If TextBox1.Text = "" Then
            MessageBox.Show("Please Enter Your Employee Number")
            'ProgressBar1.Value = 0
            'Timer2.Enabled = False
        Else
            confirmation.Show()
            'ProgressBar1.Value = 0
            'Timer2.Enabled = False
        End If
        'End If

    End Sub

    Private Sub Time_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Your Employee Number First")
        Else
            changepass.Show()
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

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'ProgressBar1.Value += 40
        'If ProgressBar1.Value = ProgressBar1.Maximum Then
        'Timer2.Enabled = False
        'End If
    End Sub
End Class