<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBurger
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
        Me.grpBurger = New System.Windows.Forms.GroupBox()
        Me.radCheeseBurger = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radSmallFries = New System.Windows.Forms.RadioButton()
        Me.radLargeFries = New System.Windows.Forms.RadioButton()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTommato = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.nudPatties = New System.Windows.Forms.NumericUpDown()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkSuperSIze = New System.Windows.Forms.CheckBox()
        Me.grpBurger.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudPatties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBurger
        '
        Me.grpBurger.Controls.Add(Me.RadioButton2)
        Me.grpBurger.Controls.Add(Me.radCheeseBurger)
        Me.grpBurger.Location = New System.Drawing.Point(13, 13)
        Me.grpBurger.Name = "grpBurger"
        Me.grpBurger.Size = New System.Drawing.Size(112, 71)
        Me.grpBurger.TabIndex = 0
        Me.grpBurger.TabStop = False
        Me.grpBurger.Text = "Burger"
        '
        'radCheeseBurger
        '
        Me.radCheeseBurger.AutoSize = True
        Me.radCheeseBurger.Location = New System.Drawing.Point(7, 20)
        Me.radCheeseBurger.Name = "radCheeseBurger"
        Me.radCheeseBurger.Size = New System.Drawing.Size(95, 17)
        Me.radCheeseBurger.TabIndex = 0
        Me.radCheeseBurger.TabStop = True
        Me.radCheeseBurger.Text = "Cheese Burger"
        Me.radCheeseBurger.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Hamburger"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkBacon)
        Me.GroupBox1.Controls.Add(Me.chkOnions)
        Me.GroupBox1.Controls.Add(Me.chkTommato)
        Me.GroupBox1.Controls.Add(Me.chkLettuce)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Toppings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radLargeFries)
        Me.GroupBox2.Controls.Add(Me.radSmallFries)
        Me.GroupBox2.Location = New System.Drawing.Point(132, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(140, 71)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fries"
        '
        'radSmallFries
        '
        Me.radSmallFries.AutoSize = True
        Me.radSmallFries.Location = New System.Drawing.Point(7, 20)
        Me.radSmallFries.Name = "radSmallFries"
        Me.radSmallFries.Size = New System.Drawing.Size(75, 17)
        Me.radSmallFries.TabIndex = 0
        Me.radSmallFries.TabStop = True
        Me.radSmallFries.Text = "Small Fries"
        Me.radSmallFries.UseVisualStyleBackColor = True
        '
        'radLargeFries
        '
        Me.radLargeFries.AutoSize = True
        Me.radLargeFries.Location = New System.Drawing.Point(7, 43)
        Me.radLargeFries.Name = "radLargeFries"
        Me.radLargeFries.Size = New System.Drawing.Size(77, 17)
        Me.radLargeFries.TabIndex = 1
        Me.radLargeFries.TabStop = True
        Me.radLargeFries.Text = "Large Fries"
        Me.radLargeFries.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(7, 19)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 0
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTommato
        '
        Me.chkTommato.AutoSize = True
        Me.chkTommato.Location = New System.Drawing.Point(7, 44)
        Me.chkTommato.Name = "chkTommato"
        Me.chkTommato.Size = New System.Drawing.Size(70, 17)
        Me.chkTommato.TabIndex = 1
        Me.chkTommato.Text = "Tommato"
        Me.chkTommato.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(94, 19)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(84, 17)
        Me.chkOnions.TabIndex = 2
        Me.chkOnions.Text = "Onion Rings"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(94, 44)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(57, 17)
        Me.chkBacon.TabIndex = 3
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox7)
        Me.GroupBox3.Controls.Add(Me.CheckBox6)
        Me.GroupBox3.Controls.Add(Me.CheckBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 91)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sauce"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(8, 19)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox5.TabIndex = 0
        Me.CheckBox5.Text = "Mayo"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(8, 42)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox6.TabIndex = 1
        Me.CheckBox6.Text = "Ketchup"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(8, 65)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox7.TabIndex = 2
        Me.CheckBox7.Text = "BBQ"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'nudPatties
        '
        Me.nudPatties.Location = New System.Drawing.Point(172, 167)
        Me.nudPatties.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPatties.Name = "nudPatties"
        Me.nudPatties.Size = New System.Drawing.Size(100, 20)
        Me.nudPatties.TabIndex = 4
        Me.nudPatties.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(172, 190)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Patties"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkSuperSIze
        '
        Me.chkSuperSIze.AutoSize = True
        Me.chkSuperSIze.Location = New System.Drawing.Point(172, 216)
        Me.chkSuperSIze.Name = "chkSuperSIze"
        Me.chkSuperSIze.Size = New System.Drawing.Size(77, 17)
        Me.chkSuperSIze.TabIndex = 9
        Me.chkSuperSIze.Text = "Super Size"
        Me.chkSuperSIze.UseVisualStyleBackColor = True
        '
        'CreateBurger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.chkSuperSIze)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.nudPatties)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBurger)
        Me.Name = "CreateBurger"
        Me.Text = "CreateBurger"
        Me.grpBurger.ResumeLayout(False)
        Me.grpBurger.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudPatties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBurger As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents radCheeseBurger As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkOnions As CheckBox
    Friend WithEvents chkTommato As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radLargeFries As RadioButton
    Friend WithEvents radSmallFries As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents nudPatties As NumericUpDown
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkSuperSIze As CheckBox
End Class
