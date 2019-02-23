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
        Me.ResponseTextBox = New System.Windows.Forms.TextBox()
        Me.TypedMessageTextBox = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.AvailableRadiosCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.MessagesListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ResponseTextBox
        '
        Me.ResponseTextBox.Location = New System.Drawing.Point(13, 233)
        Me.ResponseTextBox.Name = "ResponseTextBox"
        Me.ResponseTextBox.Size = New System.Drawing.Size(221, 20)
        Me.ResponseTextBox.TabIndex = 0
        Me.ResponseTextBox.Text = "Response Box - Message Sent Success!"
        '
        'TypedMessageTextBox
        '
        Me.TypedMessageTextBox.Location = New System.Drawing.Point(240, 425)
        Me.TypedMessageTextBox.Multiline = True
        Me.TypedMessageTextBox.Name = "TypedMessageTextBox"
        Me.TypedMessageTextBox.Size = New System.Drawing.Size(366, 69)
        Me.TypedMessageTextBox.TabIndex = 1
        Me.TypedMessageTextBox.Text = "Type your message here..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 500)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(593, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'AvailableRadiosCheckedListBox
        '
        Me.AvailableRadiosCheckedListBox.FormattingEnabled = True
        Me.AvailableRadiosCheckedListBox.Location = New System.Drawing.Point(13, 12)
        Me.AvailableRadiosCheckedListBox.Name = "AvailableRadiosCheckedListBox"
        Me.AvailableRadiosCheckedListBox.Size = New System.Drawing.Size(221, 214)
        Me.AvailableRadiosCheckedListBox.TabIndex = 3
        '
        'MessagesListBox
        '
        Me.MessagesListBox.FormattingEnabled = True
        Me.MessagesListBox.Location = New System.Drawing.Point(240, 12)
        Me.MessagesListBox.Name = "MessagesListBox"
        Me.MessagesListBox.Size = New System.Drawing.Size(365, 407)
        Me.MessagesListBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 535)
        Me.Controls.Add(Me.MessagesListBox)
        Me.Controls.Add(Me.AvailableRadiosCheckedListBox)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TypedMessageTextBox)
        Me.Controls.Add(Me.ResponseTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResponseTextBox As TextBox
    Friend WithEvents TypedMessageTextBox As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents AvailableRadiosCheckedListBox As CheckedListBox
    Friend WithEvents MessagesListBox As ListBox
End Class
