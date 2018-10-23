Imports System.Data.OleDb


Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim myConnect As New System.Data.OleDb.OleDbConnection
        myConnect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prissy\Documents\Visual Studio 2015\Projects\app1\app1\mydb.accdb"

        myConnect.Open()
        Dim str As String
        str = "Insert into tb1([FirstName],[Surname],[DOB],[Department],[Username],[Password]) Values (
               ?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnect)
        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(firstNm.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(SurNm.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DOB", CType(DateOB.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Department", CType(Dept.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Username", CType(txtUser.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPass.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnect.Close()
            firstNm.Text = ""
            SurNm.Text = ""
            txtUser.Text = ""
            txtPass.Text = ""
            DateOB.Text = ""
            fembtn.Text = ""
            malebtn.Text = ""
            Dept.Text = ""
            Form1.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles cancelbtn.Click
        firstNm.Text = ""
        SurNm.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        DateOB.Text = ""
        fembtn.Text = ""
        malebtn.Text = ""
        Dept.Text = ""
    End Sub
End Class