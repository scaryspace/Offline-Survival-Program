Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ListBox_Items.Click
        Dim Selection As String = ListBox_Items.SelectedItem
        Title.Text = Selection

        If Selection = "Dictionary" Then
            TextBox_Description.Text = "A set of definitions for the English Language."
            PictureBox.Image = WIP.My.Resources.icons8_dictionary_64
        End If

        If Selection = "Atlas" Then
            TextBox_Description.Text = "A map of the Earth."
            PictureBox.Image = WIP.My.Resources.icons8_globe_earth_64
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_About.Click
        MsgBox("This program was created to help people in areas where there is no internet. It contains potentially life-saving resources.", MsgBoxStyle.OkOnly, "About")
    End Sub

    Private Sub Button_Launch_Click(sender As Object, e As EventArgs) Handles Button_Launch.Click
        Dim Selection As String = ListBox_Items.SelectedItem

        If Selection = "Dictionary" Then
            Process.Start("F:\WIP\data\dictionary\WordWeb\wwnotray.exe")
        End If

        If Selection = "Atlas" Then
            Process.Start("F:\WIP\data\atlas\MarblePortable.exe")
        End If
    End Sub
End Class