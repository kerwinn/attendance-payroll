Imports MySql.Data.MySqlClient
Public Class confirmation
    Dim type As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim id, dt, tm As String
        id = TImeIn.TextBox1.Text
        dt = TImeIn.Label13.Text
        tm = TImeIn.Label11.Text
        con.Open()
        cmd.Connection = con

        If id = "" Then
            MessageBox.Show("Please Enter Your Employee Number")

        Else
            cmd.CommandText = "select * from attendance_tb where empID = " & id & " and date = '" & dt & "'"
            da.SelectCommand = New MySqlCommand("select * from attendance_tb where empID = " & id & " and date = '" & dt & "'")
            da.SelectCommand.Connection = con
            da.Fill(ds)
            count = ds.Tables(0).Rows.Count
            dr = cmd.ExecuteReader
            con.Close()
            con.Open()
            If count > 1 Then
                MessageBox.Show("Already Signed Out!")

            Else
                If count = 1 Then
                    type = "Time Out"
                Else
                    type = "Time In"
                End If

                con.Close()
                con.Open()
                query = "Insert Into attendance_tb(empID, name, date, time, type) Values ('" & id & "', '" & TImeIn.Label3.Text & "', '" & dt & "', '" & tm & "', '" & type & "') "
                cmd.CommandText = query
                da.SelectCommand = cmd
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Added")

            End If

        End If
        TextBox1.Text = ""
        TImeIn.PictureBox2.Image = Nothing
        TImeIn.TextBox1.Text = ""
        TImeIn.Label3.Text = ""
        Me.Hide()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class