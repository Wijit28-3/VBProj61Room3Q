<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLap1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labname = New System.Windows.Forms.Label()
        Me.labsalary = New System.Windows.Forms.Label()
        Me.labtotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ-สกุล"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 45)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เงินเดือน"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtname.Location = New System.Drawing.Point(312, 56)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(343, 20)
        Me.txtname.TabIndex = 0
        '
        'txtsalary
        '
        Me.txtsalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtsalary.Location = New System.Drawing.Point(312, 137)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(343, 20)
        Me.txtsalary.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(402, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 45)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ชื่อ-สกุล"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เงินเดือน"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 45)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เงินเดือนต่อปี"
        '
        'labname
        '
        Me.labname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.labname.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labname.Location = New System.Drawing.Point(330, 280)
        Me.labname.Name = "labname"
        Me.labname.Size = New System.Drawing.Size(325, 45)
        Me.labname.TabIndex = 0
        '
        'labsalary
        '
        Me.labsalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.labsalary.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labsalary.Location = New System.Drawing.Point(330, 355)
        Me.labsalary.Name = "labsalary"
        Me.labsalary.Size = New System.Drawing.Size(325, 45)
        Me.labsalary.TabIndex = 0
        '
        'labtotal
        '
        Me.labtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labtotal.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labtotal.Location = New System.Drawing.Point(330, 439)
        Me.labtotal.Name = "labtotal"
        Me.labtotal.Size = New System.Drawing.Size(325, 45)
        Me.labtotal.TabIndex = 0
        '
        'Lap1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 559)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labtotal)
        Me.Controls.Add(Me.labsalary)
        Me.Controls.Add(Me.labname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Lap1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labname As System.Windows.Forms.Label
    Friend WithEvents labsalary As System.Windows.Forms.Label
    Friend WithEvents labtotal As System.Windows.Forms.Label

End Class
