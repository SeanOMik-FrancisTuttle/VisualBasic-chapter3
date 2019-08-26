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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        Me.picMocha = New System.Windows.Forms.PictureBox()
        Me.btnPumpkin = New System.Windows.Forms.Button()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHeading.Location = New System.Drawing.Point(167, 10)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Latte Selection"
        '
        'picPumpkin
        '
        Me.picPumpkin.Image = Global.LatteSelection.My.Resources.Resources.pumpkin
        Me.picPumpkin.Location = New System.Drawing.Point(12, 48)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(200, 200)
        Me.picPumpkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPumpkin.TabIndex = 1
        Me.picPumpkin.TabStop = False
        Me.picPumpkin.Visible = False
        '
        'picMocha
        '
        Me.picMocha.Image = Global.LatteSelection.My.Resources.Resources.mocha
        Me.picMocha.Location = New System.Drawing.Point(291, 48)
        Me.picMocha.Name = "picMocha"
        Me.picMocha.Size = New System.Drawing.Size(200, 200)
        Me.picMocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMocha.TabIndex = 2
        Me.picMocha.TabStop = False
        Me.picMocha.Visible = False
        '
        'btnPumpkin
        '
        Me.btnPumpkin.BackColor = System.Drawing.Color.Bisque
        Me.btnPumpkin.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnPumpkin.Location = New System.Drawing.Point(62, 271)
        Me.btnPumpkin.Name = "btnPumpkin"
        Me.btnPumpkin.Size = New System.Drawing.Size(100, 25)
        Me.btnPumpkin.TabIndex = 3
        Me.btnPumpkin.Text = "Pumpkin Spice"
        Me.btnPumpkin.UseVisualStyleBackColor = False
        '
        'btnMocha
        '
        Me.btnMocha.BackColor = System.Drawing.Color.Bisque
        Me.btnMocha.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnMocha.Location = New System.Drawing.Point(337, 271)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(100, 25)
        Me.btnMocha.TabIndex = 4
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Bisque
        Me.btnSelect.Enabled = False
        Me.btnSelect.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnSelect.Location = New System.Drawing.Point(201, 271)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(100, 25)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select Latte"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblChoose
        '
        Me.lblChoose.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblChoose.Location = New System.Drawing.Point(129, 323)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(244, 11)
        Me.lblChoose.TabIndex = 0
        Me.lblChoose.Text = "Choose a latte flavor and then click ""Select Latte"" button"
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblEnjoy.Location = New System.Drawing.Point(189, 346)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(124, 13)
        Me.lblEnjoy.TabIndex = 6
        Me.lblEnjoy.Text = "Enjoy your latte selection"
        Me.lblEnjoy.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Bisque
        Me.btnExit.Enabled = False
        Me.btnExit.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnExit.Location = New System.Drawing.Point(213, 369)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 404)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.btnPumpkin)
        Me.Controls.Add(Me.picMocha)
        Me.Controls.Add(Me.picPumpkin)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Latte Selection"
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblChoose As Label
    Friend WithEvents lblEnjoy As Label
    Friend WithEvents btnExit As Button
End Class
