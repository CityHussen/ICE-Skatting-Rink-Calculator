<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windowIceSkatingRink1
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
        Me.btnFindVolume = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.PicIceSkatingRink = New System.Windows.Forms.PictureBox()
        Me.lblDepth = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.lblTotalVolume = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtDepth = New System.Windows.Forms.TextBox()
        CType(Me.PicIceSkatingRink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(286, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(262, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Ice Skating Rink"
        '
        'btnFindVolume
        '
        Me.btnFindVolume.BackColor = System.Drawing.Color.Peru
        Me.btnFindVolume.Location = New System.Drawing.Point(71, 234)
        Me.btnFindVolume.Name = "btnFindVolume"
        Me.btnFindVolume.Size = New System.Drawing.Size(113, 38)
        Me.btnFindVolume.TabIndex = 1
        Me.btnFindVolume.Text = "Find Volume"
        Me.btnFindVolume.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Peru
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(290, 234)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 38)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Peru
        Me.btnExit.Location = New System.Drawing.Point(509, 234)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Modern No. 20", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(12, 46)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(735, 24)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "This program diaplays the volume of Ice skating Rink.Most rink has depth of 2 ft." &
    ""
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(98, 79)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(267, 30)
        Me.lblLength.TabIndex = 5
        Me.lblLength.Text = "Enter the length in feets"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.Location = New System.Drawing.Point(98, 112)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(258, 30)
        Me.lblWidth.TabIndex = 6
        Me.lblWidth.Text = "Enter the width in feets"
        '
        'PicIceSkatingRink
        '
        Me.PicIceSkatingRink.Image = Global.iceskatingrink1.My.Resources.Resources.IceSkating2
        Me.PicIceSkatingRink.Location = New System.Drawing.Point(12, 291)
        Me.PicIceSkatingRink.Name = "PicIceSkatingRink"
        Me.PicIceSkatingRink.Size = New System.Drawing.Size(783, 248)
        Me.PicIceSkatingRink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicIceSkatingRink.TabIndex = 7
        Me.PicIceSkatingRink.TabStop = False
        '
        'lblDepth
        '
        Me.lblDepth.AutoSize = True
        Me.lblDepth.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepth.Location = New System.Drawing.Point(98, 150)
        Me.lblDepth.Name = "lblDepth"
        Me.lblDepth.Size = New System.Drawing.Size(261, 30)
        Me.lblDepth.TabIndex = 8
        Me.lblDepth.Text = "Enter the depth in feets"
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(98, 190)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(221, 30)
        Me.lblVolume.TabIndex = 9
        Me.lblVolume.Text = "The total volume is:"
        '
        'lblTotalVolume
        '
        Me.lblTotalVolume.AutoSize = True
        Me.lblTotalVolume.Location = New System.Drawing.Point(371, 189)
        Me.lblTotalVolume.Name = "lblTotalVolume"
        Me.lblTotalVolume.Size = New System.Drawing.Size(92, 20)
        Me.lblTotalVolume.TabIndex = 10
        Me.lblTotalVolume.Text = "_____   ft^3"
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(371, 84)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 26)
        Me.txtLength.TabIndex = 11
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(371, 119)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 26)
        Me.txtWidth.TabIndex = 12
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDepth
        '
        Me.txtDepth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepth.Location = New System.Drawing.Point(371, 154)
        Me.txtDepth.Name = "txtDepth"
        Me.txtDepth.Size = New System.Drawing.Size(100, 26)
        Me.txtDepth.TabIndex = 13
        Me.txtDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'windowIceSkatingRink1
        '
        Me.AcceptButton = Me.btnFindVolume
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 551)
        Me.Controls.Add(Me.txtDepth)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblTotalVolume)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblDepth)
        Me.Controls.Add(Me.PicIceSkatingRink)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFindVolume)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "windowIceSkatingRink1"
        Me.Text = "IceSkatingRink1"
        CType(Me.PicIceSkatingRink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnFindVolume As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents PicIceSkatingRink As PictureBox
    Friend WithEvents lblDepth As Label
    Friend WithEvents lblVolume As Label
    Friend WithEvents lblTotalVolume As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtDepth As TextBox
End Class
