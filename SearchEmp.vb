Public Class SearchEmp

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textempnum.TextChanged
        Textlname.Enabled = True
        Textfname.Enabled = True
        Textmname.Enabled = True
        Textgender.Enabled = True
        Textreligion.Enabled = True
        Textstatus.Enabled = True
        Textage.Enabled = True
        Textmonth.Enabled = True
        Textday.Enabled = True
        textyear.Enabled = True
        Texthnumber.Enabled = True
        Textstreet.Enabled = True
        Textcity.Enabled = True
        Texttelnum.Enabled = True
        Textcpnum.Enabled = True
        Textemail.Enabled = True

        con.Close()
        cmd.Connection = con
        con.Open()

        query = "select * from employee_tb where empID = '" & Textempnum.Text & "'"
        cmd.CommandText = query
        dr = cmd.ExecuteReader


        If dr.HasRows Then
            dr.Read()
            Textlname.Text = dr.GetString("lastname")
            Textfname.Text = dr.GetString("firstname")
            Textmname.Text = dr.GetString("middlename")
            Textgender.Text = dr.GetString("gender")
            Textreligion.Text = dr.GetString("religion")
            Textstatus.Text = dr.GetString("status")
            Textage.Text = dr.GetString("age")
            Textmonth.Text = dr.GetString("month")
            Textday.Text = dr.GetString("day")
            textyear.Text = dr.GetString("year")
            Texthnumber.Text = dr.GetString("house_num")
            Textstreet.Text = dr.GetString("barangay")
            Textcity.Text = dr.GetString("city")
            Texttelnum.Text = dr.GetString("telephone")
            Textcpnum.Text = dr.GetString("mobile")
            Textemail.Text = dr.GetString("email")

            If dr.GetString("image") = "" Then
                PictureBox1.Image = Nothing
            Else
                PictureBox1.Image = Image.FromFile("C:\Users\Whin\Documents\Visual Studio 2010\Projects\WindowsApplication1\WindowsApplication1\Pictures\" + dr.GetString("image"), True)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        If Textempnum.Text = "" Then
            Textlname.Enabled = False
            Textfname.Enabled = False
            Textmname.Enabled = False
            Textgender.Enabled = False
            Textreligion.Enabled = False
            Textstatus.Enabled = False
            Textage.Enabled = False
            Textmonth.Enabled = False
            Textday.Enabled = False
            textyear.Enabled = False
            Texthnumber.Enabled = False
            Textstreet.Enabled = False
            Textcity.Enabled = False
            Texttelnum.Enabled = False
            Textcpnum.Enabled = False
            Textemail.Enabled = False
            Textlname.Text = ""
            Textfname.Text = ""
            Textmname.Text = ""
            Textgender.Text = ""
            Textreligion.Text = ""
            Textstatus.Text = ""
            Textage.Text = ""
            Textmonth.Text = ""
            Textday.Text = ""
            textyear.Text = ""
            Texthnumber.Text = ""
            Textstreet.Text = ""
            Textcity.Text = ""
            Texttelnum.Text = ""
            Textcpnum.Text = ""
            Textemail.Text = ""
            PictureBox1.Image = Nothing
        End If
        con.Close()
    End Sub

    Private Sub SearchEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Textlname.Enabled = False
        Textfname.Enabled = False
        Textmname.Enabled = False
        Textgender.Enabled = False
        Textreligion.Enabled = False
        Textstatus.Enabled = False
        Textage.Enabled = False
        Textmonth.Enabled = False
        Textday.Enabled = False
        textyear.Enabled = False
        Texthnumber.Enabled = False
        Textstreet.Enabled = False
        Textcity.Enabled = False
        Texttelnum.Enabled = False
        Textcpnum.Enabled = False
        Textemail.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        query = "Update employee_tb set lastname = '" & Textlname.Text & "', firstname = '" & Textfname.Text & "', middlename = '" & Textmname.Text & "', gender = '" & Textgender.Text & "', religion =  '" & Textreligion.Text & "', age =  '" & Textage.Text & "', month =  '" & Textmonth.Text & "', day = '" & Textday.Text & "', year = '" & textyear.Text & "', house_num = '" & Texthnumber.Text & "', barangay =  '" & Textstreet.Text & "', city = '" & Textcity.Text & "', telephone = '" & Texttelnum.Text & "', mobile = '" & Textcpnum.Text & "', email = '" & Textemail.Text & "', status = '" & Textstatus.Text & "' where empID =  '" & Textempnum.Text & "' "
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MessageBox.Show("Update Successfull")

        Textlname.Enabled = False
        Textfname.Enabled = False
        Textmname.Enabled = False
        Textgender.Enabled = False
        Textreligion.Enabled = False
        Textstatus.Enabled = False
        Textage.Enabled = False
        Textmonth.Enabled = False
        Textday.Enabled = False
        textyear.Enabled = False
        Texthnumber.Enabled = False
        Textstreet.Enabled = False
        Textcity.Enabled = False
        Texttelnum.Enabled = False
        Textcpnum.Enabled = False
        Textemail.Enabled = False
        Textempnum.Text = ""
        Textlname.Text = ""
        Textfname.Text = ""
        Textmname.Text = ""
        Textgender.Text = ""
        Textreligion.Text = ""
        Textstatus.Text = ""
        Textage.Text = ""
        Textmonth.Text = ""
        Textday.Text = ""
        textyear.Text = ""
        Texthnumber.Text = ""
        Textstreet.Text = ""
        Textcity.Text = ""
        Texttelnum.Text = ""
        Textcpnum.Text = ""
        Textemail.Text = ""
        PictureBox1.Image = Nothing

    End Sub

    

    Private Sub Textcpnum_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textcpnum.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
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

    Private Sub Texthnumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Texthnumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textday_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textday.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textyear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textyear.KeyPress
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

    Private Sub Textempnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textempnum.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedInt As String = "0123456789"
            If Not allowedInt.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    
    Private Sub Textlname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textlname.KeyPress
        
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textlname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textlname.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Textfname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textfname.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textmname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textmname.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textgender_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textgender.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textmonth_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textmonth.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textstreet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textstreet.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textcity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textcity.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub Textreligion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textreligion.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textstatus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textstatus.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class