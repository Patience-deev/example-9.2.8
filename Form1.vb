Imports System.ComponentModel.Design.Serialization

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim originalphase As String
        Dim embeddedphrase As String
        Dim TxtExtract

        n = 1
        originalphase = " visual basic 2022 "
        embeddedphrase = "basic"

        TxtExtract = MsgBox(InStr(1, “Visual Basic”, “Basic”))
    End Sub
End Class



