Imports System.IO
Public Class Form1
    Private Sub ComboBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cmb_Drive.Items.AddRange(IO.DriveInfo.GetDrives)
    End Sub
    Private Sub Cmb_Drive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Drive.SelectedIndexChanged
        LstInfo.Items.Clear()
        LstInfo.Items.Add("Nama Drive: " & Dir("" & Cmb_Drive.Text & "", FileAttribute.Volume) & "")
        LstInfo.Items.Add("System: " & Dir("" & Cmb_Drive.Text & "", FileAttribute.System) & "")

        Dim drv As New DriveInfo(Cmb_Drive.Text)
        Dim kapasitas = CStr(drv.TotalSize / 1000000000) & " GB"
        Dim sisa = CStr(drv.TotalFreeSpace / 1000000000) & " GB"
        Dim terpakai = CStr(Val(kapasitas) - Val(sisa)) & " GB"

        LstInfo.Items.Add("Kapasitas: " & kapasitas)
        LstInfo.Items.Add("Terpakai: " & terpakai)
        LstInfo.Items.Add("Sisa: " & sisa)
    End Sub
End Class