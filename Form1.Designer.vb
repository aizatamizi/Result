<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("STXinwei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(224, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 86)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTER YOUR RESULT "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(323, 145)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(125, 27)
        Me.txt1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("STXinwei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(336, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "RESULT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim score As Integer = txt1.Text
        Dim message As String

        Select Case score

            Case 80 To 100
                message = "Your grade is between 80-100 and your pointer in 4.00"
            Case 75 To 79
                message = "Your grade is between 79-75 and your pointer in 3.67"

            Case 70 To 74
                message = "Your grade is between 70-74 and your pointer in 3.33"

            Case 65 To 69
                message = "Your grade is between 65-69 and your pointer in 3.00"

            Case 60 To 64
                message = "Your grade is between 60-64 and your pointer in 2.67"

            Case 55 To 59
                message = "Your grade is between 55-59 and your pointer in 2.33"

            Case 50 To 54
                message = "Your grade is between 50-54 and your pointer in 2.00"

            Case 47 To 49
                message = "Your grade is between 47-49 and your pointer in 1.67"

            Case 44 To 46
                message = "Your grade is between 44-46 and your pointer in 1.33"

            Case 40 To 43
                message = "Your grade is between 40-43 and your pointer in 1.00"

            Case 40 To 43
                message = "Your grade is between 40-43 and your pointer in 1.00"

            Case 30 To 39
                message = "Your grade is between 30-39 and your pointer in 0.67"

            Case 20 To 29
                message = "Your grade is between 20-29 and your pointer in 0.33"

            Case 0 To 19
                message = "Your grade is between 0-19 and your pointer in 0.00"

        End Select
        MessageBox.Show(message, "Your Grade And Pointer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub
End Class
