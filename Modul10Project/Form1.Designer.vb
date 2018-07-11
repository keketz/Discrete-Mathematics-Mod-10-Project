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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumberInput = New System.Windows.Forms.TextBox()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.txtTeacherInput = New System.Windows.Forms.TextBox()
        Me.txtQuarterInput = New System.Windows.Forms.TextBox()
        Me.txtSubjectInput = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnSortByNumber = New System.Windows.Forms.Button()
        Me.btnSortByName = New System.Windows.Forms.Button()
        Me.btnSortByTeacher = New System.Windows.Forms.Button()
        Me.btnSortByQuarter = New System.Windows.Forms.Button()
        Me.btnSortBySubject = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(484, 261)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Class Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Teachers Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quarter:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Subject:"
        '
        'txtNumberInput
        '
        Me.txtNumberInput.Location = New System.Drawing.Point(102, 320)
        Me.txtNumberInput.MaxLength = 100
        Me.txtNumberInput.Name = "txtNumberInput"
        Me.txtNumberInput.Size = New System.Drawing.Size(238, 20)
        Me.txtNumberInput.TabIndex = 6
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(93, 350)
        Me.txtNameInput.MaxLength = 100
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(247, 20)
        Me.txtNameInput.TabIndex = 7
        '
        'txtTeacherInput
        '
        Me.txtTeacherInput.Location = New System.Drawing.Point(113, 380)
        Me.txtTeacherInput.MaxLength = 100
        Me.txtTeacherInput.Name = "txtTeacherInput"
        Me.txtTeacherInput.Size = New System.Drawing.Size(227, 20)
        Me.txtTeacherInput.TabIndex = 8
        '
        'txtQuarterInput
        '
        Me.txtQuarterInput.Location = New System.Drawing.Point(72, 410)
        Me.txtQuarterInput.MaxLength = 100
        Me.txtQuarterInput.Name = "txtQuarterInput"
        Me.txtQuarterInput.Size = New System.Drawing.Size(268, 20)
        Me.txtQuarterInput.TabIndex = 9
        '
        'txtSubjectInput
        '
        Me.txtSubjectInput.Location = New System.Drawing.Point(73, 440)
        Me.txtSubjectInput.MaxLength = 100
        Me.txtSubjectInput.Name = "txtSubjectInput"
        Me.txtSubjectInput.Size = New System.Drawing.Size(267, 20)
        Me.txtSubjectInput.TabIndex = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(373, 438)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(107, 23)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit New Class"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnSortByNumber
        '
        Me.btnSortByNumber.Location = New System.Drawing.Point(70, 280)
        Me.btnSortByNumber.Name = "btnSortByNumber"
        Me.btnSortByNumber.Size = New System.Drawing.Size(92, 23)
        Me.btnSortByNumber.TabIndex = 12
        Me.btnSortByNumber.Text = "Class Number"
        Me.btnSortByNumber.UseVisualStyleBackColor = True
        '
        'btnSortByName
        '
        Me.btnSortByName.Location = New System.Drawing.Point(168, 280)
        Me.btnSortByName.Name = "btnSortByName"
        Me.btnSortByName.Size = New System.Drawing.Size(78, 23)
        Me.btnSortByName.TabIndex = 13
        Me.btnSortByName.Text = "Class Name"
        Me.btnSortByName.UseVisualStyleBackColor = True
        '
        'btnSortByTeacher
        '
        Me.btnSortByTeacher.Location = New System.Drawing.Point(252, 280)
        Me.btnSortByTeacher.Name = "btnSortByTeacher"
        Me.btnSortByTeacher.Size = New System.Drawing.Size(100, 23)
        Me.btnSortByTeacher.TabIndex = 14
        Me.btnSortByTeacher.Text = "Teachers Name"
        Me.btnSortByTeacher.UseVisualStyleBackColor = True
        '
        'btnSortByQuarter
        '
        Me.btnSortByQuarter.Location = New System.Drawing.Point(358, 280)
        Me.btnSortByQuarter.Name = "btnSortByQuarter"
        Me.btnSortByQuarter.Size = New System.Drawing.Size(57, 23)
        Me.btnSortByQuarter.TabIndex = 15
        Me.btnSortByQuarter.Text = "Quarter"
        Me.btnSortByQuarter.UseVisualStyleBackColor = True
        '
        'btnSortBySubject
        '
        Me.btnSortBySubject.Location = New System.Drawing.Point(421, 280)
        Me.btnSortBySubject.Name = "btnSortBySubject"
        Me.btnSortBySubject.Size = New System.Drawing.Size(59, 23)
        Me.btnSortBySubject.TabIndex = 16
        Me.btnSortBySubject.Text = "Subject"
        Me.btnSortBySubject.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Sort By:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(509, 472)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSortBySubject)
        Me.Controls.Add(Me.btnSortByQuarter)
        Me.Controls.Add(Me.btnSortByTeacher)
        Me.Controls.Add(Me.btnSortByName)
        Me.Controls.Add(Me.btnSortByNumber)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtSubjectInput)
        Me.Controls.Add(Me.txtQuarterInput)
        Me.Controls.Add(Me.txtTeacherInput)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.txtNumberInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(525, 510)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(525, 510)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumberInput As TextBox
    Friend WithEvents txtNameInput As TextBox
    Friend WithEvents txtTeacherInput As TextBox
    Friend WithEvents txtQuarterInput As TextBox
    Friend WithEvents txtSubjectInput As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnSortByNumber As Button
    Friend WithEvents btnSortByName As Button
    Friend WithEvents btnSortByTeacher As Button
    Friend WithEvents btnSortByQuarter As Button
    Friend WithEvents btnSortBySubject As Button
    Friend WithEvents Label6 As Label
End Class
