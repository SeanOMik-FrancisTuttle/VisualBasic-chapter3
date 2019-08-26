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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.picCrown = New System.Windows.Forms.PictureBox()
        Me.picEarbud = New System.Windows.Forms.PictureBox()
        Me.btnCrown = New System.Windows.Forms.Button()
        Me.btnEarbud = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEarbud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.DarkGray
        Me.lblHeader.Location = New System.Drawing.Point(123, 4)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(205, 39)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "VR Forward"
        '
        'picCrown
        '
        Me.picCrown.Image = Global.VirtualRealityHeadset.My.Resources.Resources.crown
        Me.picCrown.Location = New System.Drawing.Point(12, 54)
        Me.picCrown.Name = "picCrown"
        Me.picCrown.Size = New System.Drawing.Size(200, 200)
        Me.picCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCrown.TabIndex = 1
        Me.picCrown.TabStop = False
        Me.picCrown.Visible = False
        '
        'picEarbud
        '
        Me.picEarbud.Image = Global.VirtualRealityHeadset.My.Resources.Resources.earbud
        Me.picEarbud.Location = New System.Drawing.Point(238, 54)
        Me.picEarbud.Name = "picEarbud"
        Me.picEarbud.Size = New System.Drawing.Size(200, 200)
        Me.picEarbud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEarbud.TabIndex = 2
        Me.picEarbud.TabStop = False
        Me.picEarbud.Visible = False
        '
        'btnCrown
        '
        Me.btnCrown.Location = New System.Drawing.Point(62, 269)
        Me.btnCrown.Name = "btnCrown"
        Me.btnCrown.Size = New System.Drawing.Size(100, 25)
        Me.btnCrown.TabIndex = 3
        Me.btnCrown.Text = "VR Crown"
        Me.btnCrown.UseVisualStyleBackColor = True
        '
        'btnEarbud
        '
        Me.btnEarbud.Location = New System.Drawing.Point(288, 269)
        Me.btnEarbud.Name = "btnEarbud"
        Me.btnEarbud.Size = New System.Drawing.Size(100, 25)
        Me.btnEarbud.TabIndex = 4
        Me.btnEarbud.Text = "VR Earbud"
        Me.btnEarbud.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(175, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 25)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 343)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEarbud)
        Me.Controls.Add(Me.btnCrown)
        Me.Controls.Add(Me.picEarbud)
        Me.Controls.Add(Me.picCrown)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "VR Forward"
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEarbud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents picCrown As PictureBox
    Friend WithEvents picEarbud As PictureBox
    Friend WithEvents btnCrown As Button
    Friend WithEvents btnEarbud As Button
    Friend WithEvents btnExit As Button
End Class
