Imports System.Data.OleDb



Public Class Form3

    Private Sub Label6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New Form1
        Label1.Text = form.txtUser.Text


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged



    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged


    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim frm As New Form1
        Form1.Show()
        Me.Close()
        Form1.txtUser.Text = ""
        Form1.txtPass.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles save.Click


        'to insert values into database
        Dim mycnt As New System.Data.OleDb.OleDbConnection
        mycnt.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prissy\Documents\Visual Studio 2015\Projects\app1\app1\mydb.accdb"
        mycnt.Open()

        Dim st As String
        st = "Insert into tb1([Date_],[TaskName],[StartTime],[EndTime],[Description],[Totalhours]) Values (
               ?,?,?,?,?,?) "
        Dim cmd As OleDbCommand = New OleDbCommand(st, mycnt)
        cmd.Parameters.Add(New OleDbParameter("Date_", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Task_name", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Start_time", CType(TextBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("End_time", CType(TextBox9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Totalhours", CType(TextBox1.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            mycnt.Close()
            MessageBox.Show("Tasks Updated!")
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'mon.Clear()
        'tues.Clear()
        'wed.Clear()
        'thurs.Clear()
        'fri.Clear()
        'TextBox6.Clear()
        'TextBox7.Clear()
        'TextBox8.Clear()
        'TextBox9.Clear()



    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        'Form5.Show()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        LoginForm1.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection


        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prissy\Documents\Visual Studio 2015\Projects\app1\app1\mydb.accdb"
        Try
            con.Open()
            Dim cd As String

            cd = "select Date_,TaskName,StartTime,EndTime,Description,TotalHours from tb1 where Username='" & Form1.txtUser.Text & "'"
            Dim adap As New OleDbDataAdapter(cd, con)
            Dim dt As New DataTable
            adap.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class