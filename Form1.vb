Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim start As String
        Dim endtime As String
        'Dim result As String
        'Dim th As String

        con.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("select * from attendance_tb where type = 'time in' and empID = 122351", con)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            start = dr.GetString("time")
        End If
        con.Close()

        con.Open()
        Dim cmd1 As MySqlCommand = New MySqlCommand("select * from attendance_tb where type = 'time out' and empID = 122351", con)
        dr2 = cmd1.ExecuteReader

        If dr2.HasRows Then
            dr2.Read()
            endtime = dr2.GetString("time")
        End If
        con.Close()


        'Dim diff As TimeSpan = DateTime.Parse(endtime) - DateTime.Parse(start)

        'Dim total = diff.TotalSeconds

        'result = total / 60
        'Label1.Text = result

        'th = result / 60
        'Label2.Text = th
        'con.Close()


    End Sub
End Class