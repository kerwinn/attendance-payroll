Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class AttMonitor

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub AttMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = DateTime.Now.ToString("MM-dd-yyyy")

        con.Close()
        cmd.Connection = con
        con.Open()
        Dim dt As New DataTable
        cmd.CommandText = "select attendance_tb.empID, attendance_tb.name, attendance_tb.date, attendance_tb.time, attendance_tb.type from attendance_tb where date = '" & Label3.Text & "'"
        dr = cmd.ExecuteReader
        dt.Load(dr)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        main.Show()
        Me.Hide()
    End Sub
End Class