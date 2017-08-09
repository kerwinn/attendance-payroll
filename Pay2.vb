Imports System.Globalization

Public Class Pay2

    Dim startTime, endTime As String
    Dim grossPay As Decimal = 0
    Dim sss, pagibig, philhealth As Decimal
    Dim csss, cpagibig, cphilhealth, netPay, totalDeduct As Decimal
    Dim daysR As Integer = 0

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        con.Close()
        cmd.Connection = con
        con.Open()
        Dim id, name As String
        Dim provider As CultureInfo = CultureInfo.InvariantCulture

        id = TextBox1.Text

        cmd.CommandText = "select * from employee_tb where empID = '" & id & "'"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            name = dr.GetString("lastname") & ", " & dr.GetString("firstname") & " " & dr.GetString("middlename")
            Label2.Text = name
            PictureBox1.Image = Image.FromFile("C:\Users\Whin\Documents\Visual Studio 2010\Projects\WindowsApplication1\WindowsApplication1\Pictures\" + dr.GetString("image"), True)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            con.Close()
            If startTime < endTime Then
                con.Open()
                Dim exDate As DateTime
                Dim endDate As DateTime
                exDate = DateTime.ParseExact(startTime, "MM-dd-yyyy", provider)
                endDate = DateTime.ParseExact(endTime, "MM-dd-yyyy", provider)
                cmd2.CommandText = "select * from sallary_tb where empID=" & id
                cmd2.Connection = con
                da.SelectCommand = cmd2
                da.Fill(ds)

                Dim count As Integer = 0
                Dim countDate As Integer = 0
                Dim t As Boolean = False
                Dim steps As Integer = 0
                While t = False
                    If exDate.AddDays(countDate - 1).ToString("MM-dd-yyyy") < endDate Then
                        If ds.Tables(0).Rows.Count > count Then
                            If ds.Tables(0).Rows(count)("date").ToString() = exDate.AddDays(countDate).ToString("MM-dd-yyyy") Then
                                Console.WriteLine(exDate.AddDays(countDate).ToString("MM-dd-yyyy"))
                                grossPay += ds.Tables(0).Rows(count)("rate")
                                daysR += 1
                                count = 0
                                countDate += 1
                            End If
                        Else
                            count = 0
                            countDate += 1
                        End If
                        count += 1
                    Else
                        t = True
                    End If
                End While

            End If

            csss = sss * daysR
            cphilhealth = philhealth * daysR
            cpagibig = pagibig * daysR
            totalDeduct = csss + cphilhealth + cpagibig
            netPay = grossPay - totalDeduct

            Label15.Text &= " " & daysR
            Labeltotal.Text = totalDeduct
            Labelgross.Text = grossPay
            Labelsss.Text = csss
            Labelphilhealth.Text = cphilhealth
            Labelhart.Text = cpagibig
            Labelnet.Text = netPay

        End If

        con.Close()
    End Sub

    Private Sub Pay2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim day, month As String
        day = Now.ToString("dd")
        month = Now.ToString("MM")

        endTime = Now.ToString("MM-dd-yyyy")
        Label7.Text = endTime

        Select Case month
            Case 2
                If day = "15" Then
                    startTime = month & "-01-" & Now.ToString("yyyy")
                    Label6.Text = startTime
                ElseIf day = "28" Then
                    startTime = month & "-16-" & Now.ToString("yyyy")
                End If
            Case Else
                If day = "15" Then
                    startTime = month & "-01-" & Now.ToString("yyyy")
                ElseIf day = "30" Then
                    startTime = month & "-16-" & Now.ToString("yyyy")
                End If
        End Select


        sss = 14.53
        pagibig = 3.33
        philhealth = 9.13

        Label6.Text = startTime

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        main.Show()
        Me.Show()
    End Sub
End Class