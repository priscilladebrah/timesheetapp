
Imports System.Data.OleDb
Public Class Form5

    Dim con As New OleDbConnection
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prissy\Documents\Visual Studio 2015\Projects\app1\app1\mydb.accdb"
        Dim adap As New OleDbDataAdapter("select * from tb1", con)
        Dim dt As New DataTable
        adap.Fill(dt)

        DataGridView1.DataSource = dt


        'Dim dt As New DataTable
        'Dim ds As New DataSet
        'ds.Tables.Add(dt)

        'Dim da As New OleDbDataAdapter("INSERT into tab1 Date_,Description, TaskName,StartTime,EndTime,TotalHours  from tb1", con)
        'da.Fill(dt)

        'Dim myrow As DataRow
        'For Each myrow In dt.Rows
        '    ListView1.Items.Add(myrow.Item(1))
        '    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myrow.Item(1))


        'Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class