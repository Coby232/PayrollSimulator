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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WorkerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumPiecesTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AmountEarnedTextBox = New System.Windows.Forms.TextBox()
        Me.PiecesTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WorkerNameTextBox
        '
        Me.WorkerNameTextBox.Location = New System.Drawing.Point(229, 283)
        Me.WorkerNameTextBox.MaxLength = 20
        Me.WorkerNameTextBox.Name = "WorkerNameTextBox"
        Me.WorkerNameTextBox.Size = New System.Drawing.Size(234, 22)
        Me.WorkerNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Casual Worker Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Pieces completed:"
        '
        'NumPiecesTextBox
        '
        Me.NumPiecesTextBox.Location = New System.Drawing.Point(229, 327)
        Me.NumPiecesTextBox.MaxLength = 20
        Me.NumPiecesTextBox.Name = "NumPiecesTextBox"
        Me.NumPiecesTextBox.Size = New System.Drawing.Size(234, 22)
        Me.NumPiecesTextBox.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.ForeColor = System.Drawing.SystemColors.Control
        Me.CalculateButton.Location = New System.Drawing.Point(334, 363)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(129, 43)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(334, 461)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(129, 43)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(430, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(90, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Casual Workers PayRoll"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AmountEarnedTextBox)
        Me.GroupBox1.Controls.Add(Me.PiecesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.EmployeeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 173)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pay per piece"
        '
        'AmountEarnedTextBox
        '
        Me.AmountEarnedTextBox.Location = New System.Drawing.Point(134, 124)
        Me.AmountEarnedTextBox.Name = "AmountEarnedTextBox"
        Me.AmountEarnedTextBox.ReadOnly = True
        Me.AmountEarnedTextBox.Size = New System.Drawing.Size(155, 22)
        Me.AmountEarnedTextBox.TabIndex = 5
        '
        'PiecesTextBox
        '
        Me.PiecesTextBox.Location = New System.Drawing.Point(133, 85)
        Me.PiecesTextBox.Name = "PiecesTextBox"
        Me.PiecesTextBox.ReadOnly = True
        Me.PiecesTextBox.Size = New System.Drawing.Size(155, 22)
        Me.PiecesTextBox.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Pieces Completed:"
        '
        'EmployeeTextBox
        '
        Me.EmployeeTextBox.Location = New System.Drawing.Point(118, 21)
        Me.EmployeeTextBox.Multiline = True
        Me.EmployeeTextBox.Name = "EmployeeTextBox"
        Me.EmployeeTextBox.ReadOnly = True
        Me.EmployeeTextBox.Size = New System.Drawing.Size(170, 49)
        Me.EmployeeTextBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Employee Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Amount earned:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(115, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(241, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "WE SERVE AND WE PERFECT 👷‍♀️"
        '
        'SummaryButton
        '
        Me.SummaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryButton.Location = New System.Drawing.Point(334, 412)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(129, 43)
        Me.SummaryButton.TabIndex = 10
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(334, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 43)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 575)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.NumPiecesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WorkerNameTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(518, 622)
        Me.MinimumSize = New System.Drawing.Size(518, 622)
        Me.Name = "Form1"
        Me.Text = "Casual Workers Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WorkerNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumPiecesTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AmountEarnedTextBox As TextBox
    Friend WithEvents PiecesTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EmployeeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SummaryButton As Button
    Friend WithEvents Button1 As Button
End Class
