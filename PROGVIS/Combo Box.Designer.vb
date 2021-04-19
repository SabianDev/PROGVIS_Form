<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LstInfo = New System.Windows.Forms.ListBox()
        Me.Cmb_Drive = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstInfo
        '
        Me.LstInfo.AccessibleName = "LstInfo"
        Me.LstInfo.FormattingEnabled = True
        Me.LstInfo.ItemHeight = 15
        Me.LstInfo.Location = New System.Drawing.Point(59, 95)
        Me.LstInfo.Name = "LstInfo"
        Me.LstInfo.Size = New System.Drawing.Size(183, 94)
        Me.LstInfo.TabIndex = 0
        '
        'Cmb_Drive
        '
        Me.Cmb_Drive.FormattingEnabled = True
        Me.Cmb_Drive.Location = New System.Drawing.Point(59, 66)
        Me.Cmb_Drive.Name = "Cmb_Drive"
        Me.Cmb_Drive.Size = New System.Drawing.Size(183, 23)
        Me.Cmb_Drive.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sabian's Disk Properties"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 225)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Drive)
        Me.Controls.Add(Me.LstInfo)
        Me.Name = "Form1"
        Me.Text = "Disk Properties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstInfo As ListBox
    Friend WithEvents Cmb_Drive As ComboBox
    Friend WithEvents Label1 As Label
End Class
