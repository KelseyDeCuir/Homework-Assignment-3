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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubheading = New System.Windows.Forms.Label()
        Me.lblPleasePay = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radPinwheel = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radSausCheese = New System.Windows.Forms.RadioButton()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.panFood = New System.Windows.Forms.Panel()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.panPay = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panFood.SuspendLayout()
        Me.panPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Homework_Assignment_3.My.Resources.Resources.platter
        Me.PictureBox1.Location = New System.Drawing.Point(338, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(97, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(131, 30)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Catering"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubheading
        '
        Me.lblSubheading.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheading.Location = New System.Drawing.Point(110, 39)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(97, 15)
        Me.lblSubheading.TabIndex = 2
        Me.lblSubheading.Text = "Star Market"
        '
        'lblPleasePay
        '
        Me.lblPleasePay.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasePay.Location = New System.Drawing.Point(59, 402)
        Me.lblPleasePay.Name = "lblPleasePay"
        Me.lblPleasePay.Size = New System.Drawing.Size(112, 26)
        Me.lblPleasePay.TabIndex = 5
        Me.lblPleasePay.Text = "Please Pay:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(177, 402)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(438, 39)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total displayed here"
        '
        'lblPoints
        '
        Me.lblPoints.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPoints.Location = New System.Drawing.Point(397, 248)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(106, 20)
        Me.lblPoints.TabIndex = 7
        Me.lblPoints.Text = "Loyalty Points"
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPoints.Location = New System.Drawing.Point(548, 248)
        Me.txtPoints.Multiline = True
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(42, 28)
        Me.txtPoints.TabIndex = 8
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Wheat
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(371, 333)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 26)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Wheat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(513, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 26)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.radCheese.Location = New System.Drawing.Point(11, 15)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(194, 21)
        Me.radCheese.TabIndex = 0
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "Gourmet Cheese $49.99"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radPinwheel
        '
        Me.radPinwheel.AutoSize = True
        Me.radPinwheel.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.radPinwheel.Location = New System.Drawing.Point(11, 42)
        Me.radPinwheel.Name = "radPinwheel"
        Me.radPinwheel.Size = New System.Drawing.Size(194, 21)
        Me.radPinwheel.TabIndex = 1
        Me.radPinwheel.TabStop = True
        Me.radPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheel.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.radVeggie.Location = New System.Drawing.Point(11, 69)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(130, 21)
        Me.radVeggie.TabIndex = 2
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radSausCheese
        '
        Me.radSausCheese.AutoSize = True
        Me.radSausCheese.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.radSausCheese.Location = New System.Drawing.Point(11, 96)
        Me.radSausCheese.Name = "radSausCheese"
        Me.radSausCheese.Size = New System.Drawing.Size(226, 21)
        Me.radSausCheese.TabIndex = 3
        Me.radSausCheese.TabStop = True
        Me.radSausCheese.Text = "Sausage and Cheese $49.99"
        Me.radSausCheese.UseVisualStyleBackColor = True
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.radFruit.Location = New System.Drawing.Point(11, 123)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(122, 21)
        Me.radFruit.TabIndex = 4
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'panFood
        '
        Me.panFood.BackColor = System.Drawing.Color.White
        Me.panFood.Controls.Add(Me.radFruit)
        Me.panFood.Controls.Add(Me.radCheese)
        Me.panFood.Controls.Add(Me.radSausCheese)
        Me.panFood.Controls.Add(Me.radPinwheel)
        Me.panFood.Controls.Add(Me.radVeggie)
        Me.panFood.Location = New System.Drawing.Point(30, 78)
        Me.panFood.Name = "panFood"
        Me.panFood.Size = New System.Drawing.Size(273, 161)
        Me.panFood.TabIndex = 11
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.radPrePay.Location = New System.Drawing.Point(12, 14)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(82, 21)
        Me.radPrePay.TabIndex = 0
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.radPickup.Location = New System.Drawing.Point(12, 41)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(146, 21)
        Me.radPickup.TabIndex = 1
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pay upon Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'panPay
        '
        Me.panPay.BackColor = System.Drawing.Color.White
        Me.panPay.Controls.Add(Me.radPickup)
        Me.panPay.Controls.Add(Me.radPrePay)
        Me.panPay.Location = New System.Drawing.Point(77, 257)
        Me.panPay.Name = "panPay"
        Me.panPay.Size = New System.Drawing.Size(158, 71)
        Me.panPay.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(674, 450)
        Me.Controls.Add(Me.panPay)
        Me.Controls.Add(Me.panFood)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPleasePay)
        Me.Controls.Add(Me.lblSubheading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panFood.ResumeLayout(False)
        Me.panFood.PerformLayout()
        Me.panPay.ResumeLayout(False)
        Me.panPay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubheading As Label
    Friend WithEvents lblPleasePay As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radSausCheese As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radPinwheel As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents panFood As Panel
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents panPay As Panel
End Class
