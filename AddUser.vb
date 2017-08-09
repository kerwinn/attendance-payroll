Public Class AddUser

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim gen, status As String
        Dim pass = "1234"

        con.Close()
        cmd.Connection = con
        con.Open()
        If RadioButton1.Checked Then
            gen = "male"
        ElseIf RadioButton2.Checked Then
            gen = "female"
        End If

        If RadioButton3.Checked Then
            status = "single"
        ElseIf RadioButton4.Checked Then
            status = "married"
        ElseIf RadioButton5.Checked Then
            status = TextStatus.Text
        End If

        cmd.CommandText = "Select * from employee_tb where empId = '" & Textempnum.Text & "' "
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            MessageBox.Show("Duplicate of Employee Number")

        Else
            con.Close()
            con.Open()
            cmd2.Connection = con
            Dim extension = System.IO.Path.GetExtension(TextBoximage.Text)
            Dim img = Textfname.Text & "" & extension


            query = "insert into employee_tb(empID, lastname, firstname, middlename, gender, religion, age, month, day, year, house_num, barangay, city, telephone, mobile, email, status, image, password) values('" & Textempnum.Text & "', '" & Textlname.Text & "', '" & Textfname.Text & "', '" & Textmname.Text & "', '" & gen & "', '" & Textreligion.Text & "', '" & Textage.Text & "', '" & Combomonth.Text & "', '" & Textdate.Text & "', '" & Textyear.Text & "', '" & Texthnumber.Text & "', '" & Textstreet.Text & "', '" & Textcity.Text & "', '" & Texttelnum.Text & "', '" & Textcpnum.Text & "', '" & Textemail.Text & "', '" & status & "', '" & img & "', md5('" & pass & "')) "
            cmd2.CommandText = query
            cmd2.ExecuteNonQuery()


            MessageBox.Show("Employee added")
            con.Close()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBoximage.Text = ""
        Textage.Text = ""
        Textcity.Text = ""
        Textcpnum.Text = ""
        Textdate.Text = ""
        Textemail.Text = ""
        Textfname.Text = ""
        Texthnumber.Text = ""
        Textlname.Text = ""
        Textmname.Text = ""
        TextStatus.Text = ""
        Textstreet.Text = ""
        Texttelnum.Text = ""
        Textyear.Text = ""
        Textreligion.Text = ""
        Combomonth.Text = ""
        Textempnum.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Textempnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textempnum.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textage_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textage.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textdate.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textyear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textyear.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Texthnumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Texthnumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

   

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using im As New OpenFileDialog
            im.Multiselect = False
            im.Filter = "Image Files(*.jpg, *.jpeg, *.gif, *.bmp) |*.jpg; *.jpeg; *.gif; *.bmp"

            If im.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBoximage.Text = im.FileName
            End If
        End Using
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Textempnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textempnum.TextChanged

    End Sub

    Private Sub Texttelnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Texttelnum.TextChanged

    End Sub

    Private Sub Texttelnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Texttelnum.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Textcpnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textcpnum.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub
End Class