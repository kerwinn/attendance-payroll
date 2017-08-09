Imports MySql.Data.MySqlClient
Imports MySql.Data


Public Class AdminLogin

    Dim count As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            con.Close()
            cmd.Connection = con
            con.Open()
            Dim username, password As String
            username = TextBox1.Text
            password = TextBox2.Text
            cmd.CommandText = "Select * from adminlogin_tb where username = '" & username & "' and password = '" & password & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Dim name = dr.GetString("username")
                    MessageBox.Show("Hello, " & name)

                    main.Show()
                    Me.Hide()
                    main.Text = name
            Else
                MessageBox.Show("Invalid User!")

            End If
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

    End Sub

    Private Sub AdminLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(Me.TextBox1, "Type Your Username Here")
        toolTip1.SetToolTip(Me.TextBox2, "Type Your Password Here")
        toolTip1.SetToolTip(Me.Button1, "Log In")
    End Sub

   
End Class
