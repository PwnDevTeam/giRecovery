'//============================================================================
'// Name         :  giRecovery_
'// Author       :  Fallensn0w
'// Version      :  (Check Main.vb)
'// Copyright    :  http://github.com/Fallensn0w/giRecovery
'// Description  :  The most awesome GUI for iRecovery EVER
'//============================================================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zForm))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.BackColor = System.Drawing.SystemColors.Control
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Red
        Me.button2.Location = New System.Drawing.Point(608, 309)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(76, 29)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Reset USB"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.BackColor = System.Drawing.SystemColors.Control
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(507, 309)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(95, 29)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Send"
        Me.button1.UseVisualStyleBackColor = False
        '
        'textBox2
        '
        Me.textBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox2.BackColor = System.Drawing.Color.White
        Me.textBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.textBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(9, 10)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ReadOnly = True
        Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox2.Size = New System.Drawing.Size(675, 295)
        Me.textBox2.TabIndex = 999999
        Me.textBox2.Text = "Welcome to giRecovery for the Windows Platform!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(281, 347)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(84, 19)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Command"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(369, 347)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 19)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "File Upload"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(463, 347)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(108, 19)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.Text = "Exploit Payload"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(577, 347)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(108, 19)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.Text = "Multi-line Script"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(134, 345)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(149, 18)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "By: Fallensn0w"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 340)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 25)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Check for updates"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.textBox1.FormattingEnabled = True
        Me.textBox1.Location = New System.Drawing.Point(9, 309)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(492, 26)
        Me.textBox1.TabIndex = 1
        '
        'zForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 369)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "zForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "giRecovery -- Version: 0.0 -- By: Fallensn0w"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents button2 As System.Windows.Forms.Button
    Public WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents textBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents textBox1 As System.Windows.Forms.ComboBox

End Class
