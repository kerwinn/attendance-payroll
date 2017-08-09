Public Class changepass

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim accs As String
        accs = TImeIn.TextBox1.Text


      

        If TextBoxnewpass.Text <> Textboxconfirm.Text Then
            Label1.Visible = True
        Else
            con.Open()
            cmd2.Connection = con
            query = "update employee_tb set password = '" & Textboxconfirm.Text & "' where empID = '" & accs & "' "
            cmd2.CommandText = query
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Password Changed")
            con.Close()
        End If


    End Sub

    Private Sub Textboxoldpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textboxoldpass.TextChanged

    End Sub

    Private Sub TextBoxnewpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxnewpass.TextChanged

    End Sub

    Private Sub Textboxconfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textboxconfirm.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class