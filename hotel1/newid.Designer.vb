<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newid
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUSTOMER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AADHAR ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(391, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 38)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(391, 304)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(365, 38)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(391, 188)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(365, 38)
        Me.TextBox2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 102)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(555, 497)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(361, 103)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'newid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1669, 812)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newid"
        Me.Text = "newid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
