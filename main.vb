Public Class main

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()

        toolTip1.SetToolTip(Me.ButtonAdd, "Add")
        toolTip1.SetToolTip(Me.ButtonEdit, "Edit")
        toolTip1.SetToolTip(Me.ButtonAttendance, "Attendance")
        toolTip1.SetToolTip(Me.ButtonReports, "Reports")


    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        AddUser.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        SearchEmp.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAttendance.Click
        AttMonitor.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonReports_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReports.Click
        cr.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pay2.Show()
        Me.Hide()

    End Sub
End Class