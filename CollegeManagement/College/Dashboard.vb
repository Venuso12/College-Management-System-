Imports System.Data.SqlClient

Public Class Dashboard
    Dim Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\venu\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub CountStud()
        Dim StNum As Integer
        Con.Open()
        Dim sql = "Select COUNT(*) from StudentTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        StNum = cmd.ExecuteScalar
        Label3.Text = StNum
        Con.Close()
    End Sub
    Private Sub CountTech()
        Dim TNum As Integer
        Con.Open()
        Dim sql = "Select COUNT(*) from TeacherTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        TNum = cmd.ExecuteScalar
        Tenum.Text = TNum
        Con.Close()
    End Sub
    Private Sub CountDep()
        Dim DNum As Integer
        Con.Open()
        Dim sql = "Select COUNT(*) from DepartmentTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        DNum = cmd.ExecuteScalar
        Depnum.Text = DNum
        Con.Close()
    End Sub

    Private Sub SumFees()
        Dim FNum As Integer
        Con.Open()
        Dim sql = "Select Sum(Amount) from paymentTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        FNum = cmd.ExecuteScalar
        Dim Am As String
        Am = Convert.ToString(FNum)
        FeeNum.Text = "Rs " + Am
        Con.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountTech()
        CountStud()
        CountDep()
        SumFees()
    End Sub

    Private Function StdLbl() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

   

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Obj = New Department()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj = New Student()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim Obj = New Teacher()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Fees()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class