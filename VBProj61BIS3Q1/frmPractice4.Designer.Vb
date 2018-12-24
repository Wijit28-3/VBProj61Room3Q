<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice4
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
        Me.LabalTopic1 = New System.Windows.Forms.Label()
        Me.LabalTopic2 = New System.Windows.Forms.Label()
        Me.LabalTopic3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblProId = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProTotal = New System.Windows.Forms.Label()
        Me.radProCash = New System.Windows.Forms.RadioButton()
        Me.radProCredit = New System.Windows.Forms.RadioButton()
        Me.lblProNet = New System.Windows.Forms.Label()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabalTopic1
        '
        Me.LabalTopic1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabalTopic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabalTopic1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabalTopic1.Location = New System.Drawing.Point(65, 67)
        Me.LabalTopic1.Name = "LabalTopic1"
        Me.LabalTopic1.Size = New System.Drawing.Size(100, 29)
        Me.LabalTopic1.TabIndex = 0
        Me.LabalTopic1.Text = "รหัสสินค้า"
        Me.LabalTopic1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabalTopic2
        '
        Me.LabalTopic2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabalTopic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabalTopic2.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabalTopic2.Location = New System.Drawing.Point(65, 116)
        Me.LabalTopic2.Name = "LabalTopic2"
        Me.LabalTopic2.Size = New System.Drawing.Size(100, 29)
        Me.LabalTopic2.TabIndex = 0
        Me.LabalTopic2.Text = "ชื่อสินค้า"
        Me.LabalTopic2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabalTopic3
        '
        Me.LabalTopic3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabalTopic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabalTopic3.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabalTopic3.Location = New System.Drawing.Point(65, 163)
        Me.LabalTopic3.Name = "LabalTopic3"
        Me.LabalTopic3.Size = New System.Drawing.Size(100, 29)
        Me.LabalTopic3.TabIndex = 0
        Me.LabalTopic3.Text = "ราคาต่อหน่วย"
        Me.LabalTopic3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "จำนวณ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เป็นเงิน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "การชำระเงิน"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ยอดชำระ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProId
        '
        Me.lblProId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProId.Location = New System.Drawing.Point(203, 72)
        Me.lblProId.Name = "lblProId"
        Me.lblProId.Size = New System.Drawing.Size(228, 23)
        Me.lblProId.TabIndex = 1
        Me.lblProId.Text = " "
        '
        'lblProName
        '
        Me.lblProName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProName.Location = New System.Drawing.Point(203, 124)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(228, 23)
        Me.lblProName.TabIndex = 1
        Me.lblProName.Text = " "
        '
        'lblProPrice
        '
        Me.lblProPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProPrice.Location = New System.Drawing.Point(203, 169)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(228, 23)
        Me.lblProPrice.TabIndex = 1
        Me.lblProPrice.Text = " "
        '
        'lblProTotal
        '
        Me.lblProTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProTotal.Location = New System.Drawing.Point(203, 257)
        Me.lblProTotal.Name = "lblProTotal"
        Me.lblProTotal.Size = New System.Drawing.Size(228, 23)
        Me.lblProTotal.TabIndex = 1
        Me.lblProTotal.Text = " "
        '
        'radProCash
        '
        Me.radProCash.AutoSize = True
        Me.radProCash.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radProCash.Location = New System.Drawing.Point(203, 305)
        Me.radProCash.Name = "radProCash"
        Me.radProCash.Size = New System.Drawing.Size(69, 33)
        Me.radProCash.TabIndex = 2
        Me.radProCash.TabStop = True
        Me.radProCash.Text = "เงินสด"
        Me.radProCash.UseVisualStyleBackColor = True
        '
        'radProCredit
        '
        Me.radProCredit.AutoSize = True
        Me.radProCredit.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radProCredit.Location = New System.Drawing.Point(340, 305)
        Me.radProCredit.Name = "radProCredit"
        Me.radProCredit.Size = New System.Drawing.Size(73, 33)
        Me.radProCredit.TabIndex = 2
        Me.radProCredit.TabStop = True
        Me.radProCredit.Text = "เงินเชื่อ"
        Me.radProCredit.UseVisualStyleBackColor = True
        '
        'lblProNet
        '
        Me.lblProNet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProNet.Location = New System.Drawing.Point(203, 347)
        Me.lblProNet.Name = "lblProNet"
        Me.lblProNet.Size = New System.Drawing.Size(228, 57)
        Me.lblProNet.TabIndex = 1
        Me.lblProNet.Text = " "
        '
        'txtProAmount
        '
        Me.txtProAmount.Location = New System.Drawing.Point(203, 213)
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(227, 20)
        Me.txtProAmount.TabIndex = 3
        '
        'frmPractice4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 583)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.radProCredit)
        Me.Controls.Add(Me.radProCash)
        Me.Controls.Add(Me.lblProNet)
        Me.Controls.Add(Me.lblProTotal)
        Me.Controls.Add(Me.lblProPrice)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblProId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabalTopic3)
        Me.Controls.Add(Me.LabalTopic2)
        Me.Controls.Add(Me.LabalTopic1)
        Me.Name = "frmPractice4"
        Me.Text = "frmPractice4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabalTopic1 As System.Windows.Forms.Label
    Friend WithEvents LabalTopic2 As System.Windows.Forms.Label
    Friend WithEvents LabalTopic3 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProId As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents lblProPrice As System.Windows.Forms.Label
    Friend WithEvents lblProTotal As System.Windows.Forms.Label
    Friend WithEvents radProCash As System.Windows.Forms.RadioButton
    Friend WithEvents radProCredit As System.Windows.Forms.RadioButton
    Friend WithEvents lblProNet As System.Windows.Forms.Label
    Friend WithEvents txtProAmount As System.Windows.Forms.TextBox
End Class
