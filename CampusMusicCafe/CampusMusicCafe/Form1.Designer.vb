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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblView = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgCafe = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.imgCafe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(46, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(433, 29)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Campus Music Cafe Open Mic Night"
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Location = New System.Drawing.Point(198, 130)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(129, 13)
        Me.lblView.TabIndex = 2
        Me.lblView.Text = "Choose what info to view:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "All college students are welcome!"
        '
        'imgCafe
        '
        Me.imgCafe.BackColor = System.Drawing.Color.Transparent
        Me.imgCafe.Image = Global.CampusMusicCafe.My.Resources.Resources.BusyDuidoughCafe
        Me.imgCafe.InitialImage = Nothing
        Me.imgCafe.Location = New System.Drawing.Point(2, 0)
        Me.imgCafe.Name = "imgCafe"
        Me.imgCafe.Size = New System.Drawing.Size(521, 455)
        Me.imgCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCafe.TabIndex = 5
        Me.imgCafe.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "View date, start location, and details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInfo.Location = New System.Drawing.Point(191, 187)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(142, 71)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(217, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 31)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 455)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.imgCafe)
        Me.Name = "Form1"
        Me.Text = "Campus Music Cafe"
        CType(Me.imgCafe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblView As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgCafe As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnExit As Button
End Class
