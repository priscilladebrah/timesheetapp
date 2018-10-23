Imports System.Data.OleDb

Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUser.Text = ""
        txtPass.Text = ""
        txtUser.Focus()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer1.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If txtPass.Text = " " Or txtUser.Text = " " Then
            MessageBox.Show("Please fill the required field", "Authentication Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prissy\Documents\Visual Studio 2015\Projects\app1\app1\mydb.accdb"
            Try

                Dim sql As String = "SELECT * FROM tb1 WHERE Username='" & txtUser.Text & "'
                                AND Password ='" & txtPass.Text & "' "

                Dim sqlcom As New System.Data.OleDb.OleDbCommand(Sql)

                    'open db'
                    sqlcom.Connection = conn
                conn.Open()
                Dim sqlread As System.Data.OleDb.OleDbDataReader = sqlcom.ExecuteReader()


                If sqlread.Read() Then
                    Dim mainform As New Form3
                    mainform .Show()

                    Me.Hide()




                Else
                    MessageBox.Show("Username and Password do not match", "Authentication failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUser.Text = ""
                    txtPass.Text = ""


                    'focus on txtuser
                    txtUser.Focus()

                End If

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database...System Error Message: " & ex.Message,
                                  "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Form2.ShowDialog()
        Me.Close()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dd-MM-yyyy   ")
        Label5.Text = Date.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
