Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label3.Visible = True
    End Sub

    Private Sub Stormtrooper_Click(sender As Object, e As EventArgs) Handles Stormtrooper.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label4.Visible = True
    End Sub

    Private Sub Batman_Click(sender As Object, e As EventArgs) Handles Batman.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        Label5.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        Label6.Visible = True
    End Sub
End Class
