<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.firstNm = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.SurNm = New System.Windows.Forms.TextBox()
        Me.fembtn = New System.Windows.Forms.RadioButton()
        Me.malebtn = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.ComboBox()
        Me.DateOB = New System.Windows.Forms.DateTimePicker()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'exitbtn
        '
        Me.exitbtn.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.Location = New System.Drawing.Point(327, 401)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(112, 32)
        Me.exitbtn.TabIndex = 0
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.Location = New System.Drawing.Point(391, 363)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(112, 32)
        Me.savebtn.TabIndex = 1
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(170, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CREATE TIMESHEET ACCOUNT"
        '
        'firstNm
        '
        Me.firstNm.BackColor = System.Drawing.SystemColors.Info
        Me.firstNm.Location = New System.Drawing.Point(274, 90)
        Me.firstNm.Name = "firstNm"
        Me.firstNm.Size = New System.Drawing.Size(229, 20)
        Me.firstNm.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.Info
        Me.txtUser.Location = New System.Drawing.Point(274, 174)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(229, 20)
        Me.txtUser.TabIndex = 5
        '
        'SurNm
        '
        Me.SurNm.BackColor = System.Drawing.SystemColors.Info
        Me.SurNm.Location = New System.Drawing.Point(274, 128)
        Me.SurNm.Name = "SurNm"
        Me.SurNm.Size = New System.Drawing.Size(229, 20)
        Me.SurNm.TabIndex = 7
        '
        'fembtn
        '
        Me.fembtn.AutoSize = True
        Me.fembtn.Location = New System.Drawing.Point(315, 299)
        Me.fembtn.Name = "fembtn"
        Me.fembtn.Size = New System.Drawing.Size(59, 17)
        Me.fembtn.TabIndex = 8
        Me.fembtn.TabStop = True
        Me.fembtn.Text = "Female"
        Me.fembtn.UseVisualStyleBackColor = True
        '
        'malebtn
        '
        Me.malebtn.AutoSize = True
        Me.malebtn.Location = New System.Drawing.Point(391, 299)
        Me.malebtn.Name = "malebtn"
        Me.malebtn.Size = New System.Drawing.Size(48, 17)
        Me.malebtn.TabIndex = 9
        Me.malebtn.TabStop = True
        Me.malebtn.Text = "Male"
        Me.malebtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(154, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Username"
        '
        'Dept
        '
        Me.Dept.BackColor = System.Drawing.SystemColors.Info
        Me.Dept.FormattingEnabled = True
        Me.Dept.Items.AddRange(New Object() {"Accounts", "Information Technology", "Administrative duties", "Management systems"})
        Me.Dept.Location = New System.Drawing.Point(274, 322)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(229, 21)
        Me.Dept.TabIndex = 15
        '
        'DateOB
        '
        Me.DateOB.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DateOB.Location = New System.Drawing.Point(274, 263)
        Me.DateOB.Name = "DateOB"
        Me.DateOB.Size = New System.Drawing.Size(229, 20)
        Me.DateOB.TabIndex = 16
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.Info
        Me.txtPass.Location = New System.Drawing.Point(274, 215)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(229, 20)
        Me.txtPass.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 22)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Password"
        '
        'cancelbtn
        '
        Me.cancelbtn.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.Location = New System.Drawing.Point(274, 363)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(112, 32)
        Me.cancelbtn.TabIndex = 19
        Me.cancelbtn.Text = "Clear"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(798, 445)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.DateOB)
        Me.Controls.Add(Me.Dept)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.malebtn)
        Me.Controls.Add(Me.fembtn)
        Me.Controls.Add(Me.SurNm)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.firstNm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Name = "Form2"
        Me.Text = "Sign-Up "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents firstNm As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents SurNm As TextBox
    Friend WithEvents fembtn As RadioButton
    Friend WithEvents malebtn As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Dept As ComboBox
    Friend WithEvents DateOB As DateTimePicker
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cancelbtn As Button
End Class
