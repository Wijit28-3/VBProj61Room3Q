<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLap3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.labInput = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.White
        Me.txtInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInput.Location = New System.Drawing.Point(311, 87)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ShortcutsEnabled = False
        Me.txtInput.Size = New System.Drawing.Size(390, 78)
        Me.txtInput.TabIndex = 0
        '
        'labInput
        '
        Me.labInput.AutoSize = True
        Me.labInput.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labInput.Location = New System.Drawing.Point(137, 110)
        Me.labInput.Name = "labInput"
        Me.labInput.Size = New System.Drawing.Size(144, 37)
        Me.labInput.TabIndex = 2
        Me.labInput.Text = " กำหนดค่าตัวเลข"
        '
        'txtSize
        '
        Me.txtSize.AutoSize = True
        Me.txtSize.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.Location = New System.Drawing.Point(462, 205)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(87, 29)
        Me.txtSize.TabIndex = 2
        Me.txtSize.Text = " ขนาดฟอนด์"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(125, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 176)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFSky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFSky.Location = New System.Drawing.Point(259, 103)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(54, 37)
        Me.lblFSky.TabIndex = 22
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFWhite.Location = New System.Drawing.Point(199, 103)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(54, 37)
        Me.lblFWhite.TabIndex = 21
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFBlack.Location = New System.Drawing.Point(259, 46)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(54, 37)
        Me.lblFBlack.TabIndex = 23
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFBrown.Location = New System.Drawing.Point(139, 103)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(54, 37)
        Me.lblFBrown.TabIndex = 25
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFViolet.Location = New System.Drawing.Point(199, 46)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(54, 37)
        Me.lblFViolet.TabIndex = 24
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFYellow.Location = New System.Drawing.Point(79, 103)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(54, 37)
        Me.lblFYellow.TabIndex = 17
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Lime
        Me.lblFGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFGreen.Location = New System.Drawing.Point(139, 46)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(54, 37)
        Me.lblFGreen.TabIndex = 16
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFOrange.Location = New System.Drawing.Point(19, 103)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(54, 37)
        Me.lblFOrange.TabIndex = 18
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFBlue.Location = New System.Drawing.Point(79, 46)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(54, 37)
        Me.lblFBlue.TabIndex = 20
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFRed.Location = New System.Drawing.Point(19, 46)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(54, 37)
        Me.lblFRed.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBWhite)
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(483, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 174)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BigColor"
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBSky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBSky.Location = New System.Drawing.Point(260, 101)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(54, 37)
        Me.lblBSky.TabIndex = 12
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBWhite.Location = New System.Drawing.Point(200, 101)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(54, 37)
        Me.lblBWhite.TabIndex = 11
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBBlack.Location = New System.Drawing.Point(260, 44)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(54, 37)
        Me.lblBBlack.TabIndex = 13
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBBrown.Location = New System.Drawing.Point(140, 101)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(54, 37)
        Me.lblBBrown.TabIndex = 15
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBViolet.Location = New System.Drawing.Point(200, 44)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(54, 37)
        Me.lblBViolet.TabIndex = 14
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBYellow.Location = New System.Drawing.Point(80, 101)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(54, 37)
        Me.lblBYellow.TabIndex = 7
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.Lime
        Me.lblBGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBGreen.Location = New System.Drawing.Point(140, 44)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(54, 37)
        Me.lblBGreen.TabIndex = 6
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBOrange.Location = New System.Drawing.Point(20, 101)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(54, 37)
        Me.lblBOrange.TabIndex = 8
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBBlue.Location = New System.Drawing.Point(80, 44)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(54, 37)
        Me.lblBBlue.TabIndex = 10
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBRed.Location = New System.Drawing.Point(20, 44)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(54, 37)
        Me.lblBRed.TabIndex = 9
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(651, 89)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(49, 32)
        Me.btnUp.TabIndex = 8
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(651, 129)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(49, 35)
        Me.btnDown.TabIndex = 9
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14", "16", "18", "20"})
        Me.cboSize.Location = New System.Drawing.Point(554, 210)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(182, 21)
        Me.cboSize.TabIndex = 10
        '
        'frmLap3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 636)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.labInput)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLap3"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents labInput As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFSky As System.Windows.Forms.Label
    Friend WithEvents lblFWhite As System.Windows.Forms.Label
    Friend WithEvents lblFBlack As System.Windows.Forms.Label
    Friend WithEvents lblFBrown As System.Windows.Forms.Label
    Friend WithEvents lblFViolet As System.Windows.Forms.Label
    Friend WithEvents lblFYellow As System.Windows.Forms.Label
    Friend WithEvents lblFGreen As System.Windows.Forms.Label
    Friend WithEvents lblFOrange As System.Windows.Forms.Label
    Friend WithEvents lblFBlue As System.Windows.Forms.Label
    Friend WithEvents lblFRed As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBSky As System.Windows.Forms.Label
    Friend WithEvents lblBWhite As System.Windows.Forms.Label
    Friend WithEvents lblBBlack As System.Windows.Forms.Label
    Friend WithEvents lblBBrown As System.Windows.Forms.Label
    Friend WithEvents lblBViolet As System.Windows.Forms.Label
    Friend WithEvents lblBYellow As System.Windows.Forms.Label
    Friend WithEvents lblBGreen As System.Windows.Forms.Label
    Friend WithEvents lblBOrange As System.Windows.Forms.Label
    Friend WithEvents lblBBlue As System.Windows.Forms.Label
    Friend WithEvents lblBRed As System.Windows.Forms.Label
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
End Class
