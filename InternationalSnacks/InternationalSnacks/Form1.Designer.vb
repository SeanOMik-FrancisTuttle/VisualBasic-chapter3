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
        Me.picBurrito = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBurrito = New System.Windows.Forms.Button()
        Me.btnFalafel = New System.Windows.Forms.Button()
        Me.picFalafel = New System.Windows.Forms.PictureBox()
        Me.btnGreekYogurt = New System.Windows.Forms.Button()
        Me.picGreekYogurt = New System.Windows.Forms.PictureBox()
        Me.btnSpringRolls = New System.Windows.Forms.Button()
        Me.picSpringRolls = New System.Windows.Forms.PictureBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        CType(Me.picBurrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFalafel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreekYogurt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpringRolls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBurrito
        '
        Me.picBurrito.Image = Global.InternationalSnacks.My.Resources.Resources.beanBurrito
        Me.picBurrito.Location = New System.Drawing.Point(12, 58)
        Me.picBurrito.Name = "picBurrito"
        Me.picBurrito.Size = New System.Drawing.Size(125, 125)
        Me.picBurrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBurrito.TabIndex = 0
        Me.picBurrito.TabStop = False
        Me.picBurrito.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Click on your desired snack!"
        '
        'btnBurrito
        '
        Me.btnBurrito.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnBurrito.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBurrito.Location = New System.Drawing.Point(37, 190)
        Me.btnBurrito.Name = "btnBurrito"
        Me.btnBurrito.Size = New System.Drawing.Size(75, 23)
        Me.btnBurrito.TabIndex = 5
        Me.btnBurrito.Text = "Bean burrito"
        Me.btnBurrito.UseVisualStyleBackColor = False
        '
        'btnFalafel
        '
        Me.btnFalafel.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnFalafel.Location = New System.Drawing.Point(168, 190)
        Me.btnFalafel.Name = "btnFalafel"
        Me.btnFalafel.Size = New System.Drawing.Size(75, 23)
        Me.btnFalafel.TabIndex = 7
        Me.btnFalafel.Text = "Falafel"
        Me.btnFalafel.UseVisualStyleBackColor = False
        '
        'picFalafel
        '
        Me.picFalafel.Image = Global.InternationalSnacks.My.Resources.Resources.magical_green_falafels_thumb_300x300
        Me.picFalafel.Location = New System.Drawing.Point(143, 58)
        Me.picFalafel.Name = "picFalafel"
        Me.picFalafel.Size = New System.Drawing.Size(125, 125)
        Me.picFalafel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFalafel.TabIndex = 6
        Me.picFalafel.TabStop = False
        Me.picFalafel.Visible = False
        '
        'btnGreekYogurt
        '
        Me.btnGreekYogurt.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnGreekYogurt.Location = New System.Drawing.Point(286, 190)
        Me.btnGreekYogurt.Name = "btnGreekYogurt"
        Me.btnGreekYogurt.Size = New System.Drawing.Size(100, 23)
        Me.btnGreekYogurt.TabIndex = 9
        Me.btnGreekYogurt.Text = "Greek Yogurt"
        Me.btnGreekYogurt.UseVisualStyleBackColor = False
        '
        'picGreekYogurt
        '
        Me.picGreekYogurt.Image = Global.InternationalSnacks.My.Resources.Resources.Greek_Yogurt_8
        Me.picGreekYogurt.Location = New System.Drawing.Point(274, 58)
        Me.picGreekYogurt.Name = "picGreekYogurt"
        Me.picGreekYogurt.Size = New System.Drawing.Size(125, 125)
        Me.picGreekYogurt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGreekYogurt.TabIndex = 8
        Me.picGreekYogurt.TabStop = False
        Me.picGreekYogurt.Visible = False
        '
        'btnSpringRolls
        '
        Me.btnSpringRolls.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnSpringRolls.Location = New System.Drawing.Point(430, 190)
        Me.btnSpringRolls.Name = "btnSpringRolls"
        Me.btnSpringRolls.Size = New System.Drawing.Size(75, 23)
        Me.btnSpringRolls.TabIndex = 11
        Me.btnSpringRolls.Text = "Spring Rolls"
        Me.btnSpringRolls.UseVisualStyleBackColor = False
        '
        'picSpringRolls
        '
        Me.picSpringRolls.Image = Global.InternationalSnacks.My.Resources.Resources.spring_rolls
        Me.picSpringRolls.Location = New System.Drawing.Point(405, 58)
        Me.picSpringRolls.Name = "picSpringRolls"
        Me.picSpringRolls.Size = New System.Drawing.Size(125, 125)
        Me.picSpringRolls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSpringRolls.TabIndex = 10
        Me.picSpringRolls.TabStop = False
        Me.picSpringRolls.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(233, 295)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 12
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(225, 271)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(91, 13)
        Me.lblConfirm.TabIndex = 13
        Me.lblConfirm.Text = "Option Confirmed!"
        Me.lblConfirm.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 328)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnSpringRolls)
        Me.Controls.Add(Me.picSpringRolls)
        Me.Controls.Add(Me.btnGreekYogurt)
        Me.Controls.Add(Me.picGreekYogurt)
        Me.Controls.Add(Me.btnFalafel)
        Me.Controls.Add(Me.picFalafel)
        Me.Controls.Add(Me.btnBurrito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBurrito)
        Me.Name = "Form1"
        Me.Text = "Healthy Snack Selection"
        CType(Me.picBurrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFalafel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreekYogurt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpringRolls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBurrito As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBurrito As Button
    Friend WithEvents btnFalafel As Button
    Friend WithEvents picFalafel As PictureBox
    Friend WithEvents btnGreekYogurt As Button
    Friend WithEvents picGreekYogurt As PictureBox
    Friend WithEvents btnSpringRolls As Button
    Friend WithEvents picSpringRolls As PictureBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblConfirm As Label
End Class
