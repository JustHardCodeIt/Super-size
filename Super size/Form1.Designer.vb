<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurgers))
        Me.lsvBurgers = New System.Windows.Forms.ListView()
        Me.cboBurgers = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRep = New System.Windows.Forms.Button()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvBurgers
        '
        Me.lsvBurgers.Location = New System.Drawing.Point(12, 12)
        Me.lsvBurgers.Name = "lsvBurgers"
        Me.lsvBurgers.Size = New System.Drawing.Size(347, 148)
        Me.lsvBurgers.TabIndex = 0
        Me.lsvBurgers.UseCompatibleStateImageBehavior = False
        Me.lsvBurgers.View = System.Windows.Forms.View.Details
        '
        'cboBurgers
        '
        Me.cboBurgers.FormattingEnabled = True
        Me.cboBurgers.Items.AddRange(New Object() {"3.50 Cheese burger", "5.68 Double Decker", "7.89 Bacon Cheese Burger", "5.67 Vegie Burger", "8.93 Big Double Burger", "9.99 Tripple Decker", "1.17 Small Drink", "1.89 Medium Drink", "1.99 Large Drink", "2.45 Small fries", "2.56 Large Fries"})
        Me.cboBurgers.Location = New System.Drawing.Point(12, 166)
        Me.cboBurgers.Name = "cboBurgers"
        Me.cboBurgers.Size = New System.Drawing.Size(347, 21)
        Me.cboBurgers.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRep
        '
        Me.btnRep.Location = New System.Drawing.Point(12, 193)
        Me.btnRep.Name = "btnRep"
        Me.btnRep.Size = New System.Drawing.Size(89, 35)
        Me.btnRep.TabIndex = 3
        Me.btnRep.Text = "Generate Reciept"
        Me.btnRep.UseVisualStyleBackColor = True
        '
        'btnCustom
        '
        Me.btnCustom.Location = New System.Drawing.Point(295, 214)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(75, 23)
        Me.btnCustom.TabIndex = 4
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(371, 237)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.btnRep)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboBurgers)
        Me.Controls.Add(Me.lsvBurgers)
        Me.Name = "frmBurgers"
        Me.Text = "Order form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvBurgers As System.Windows.Forms.ListView
    Friend WithEvents cboBurgers As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRep As Button
    Friend WithEvents btnCustom As Button
End Class
