<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLap2
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
        Me.txtsalaryVG = New System.Windows.Forms.TextBox()
        Me.txtsalaryFG = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labtotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.labcomtotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vistra Gluta"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(515, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 48)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Frista Glota"
        '
        'txtsalaryVG
        '
        Me.txtsalaryVG.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsalaryVG.Location = New System.Drawing.Point(189, 115)
        Me.txtsalaryVG.Name = "txtsalaryVG"
        Me.txtsalaryVG.Size = New System.Drawing.Size(219, 20)
        Me.txtsalaryVG.TabIndex = 0
        '
        'txtsalaryFG
        '
        Me.txtsalaryFG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsalaryFG.Location = New System.Drawing.Point(480, 115)
        Me.txtsalaryFG.Name = "txtsalaryFG"
        Me.txtsalaryFG.Size = New System.Drawing.Size(221, 20)
        Me.txtsalaryFG.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(189, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ยอดขายสินค้า"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ผลรวมยอดขาย"
        '
        'labtotal
        '
        Me.labtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labtotal.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labtotal.Location = New System.Drawing.Point(183, 170)
        Me.labtotal.Name = "labtotal"
        Me.labtotal.Size = New System.Drawing.Size(225, 37)
        Me.labtotal.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ค่าคอมมิชชันรวม"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(480, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Close "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'labcomtotal
        '
        Me.labcomtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labcomtotal.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labcomtotal.Location = New System.Drawing.Point(183, 250)
        Me.labcomtotal.Name = "labcomtotal"
        Me.labcomtotal.Size = New System.Drawing.Size(225, 37)
        Me.labcomtotal.TabIndex = 0
        '
        'lap2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 554)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsalaryFG)
        Me.Controls.Add(Me.txtsalaryVG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labcomtotal)
        Me.Controls.Add(Me.labtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "lap2"
        Me.Text = "lap2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsalaryVG As System.Windows.Forms.TextBox
    Friend WithEvents txtsalaryFG As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labtotal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents labcomtotal As System.Windows.Forms.Label
End Class
