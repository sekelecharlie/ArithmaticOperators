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
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnCalculate = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(386, 162)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(150, 31)
        txtNumber1.TabIndex = 0
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(386, 101)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(150, 31)
        txtNumber2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(220, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 25)
        Label2.TabIndex = 1
        Label2.Text = "Enter Second Number"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(283, 222)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(253, 108)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Calculate!"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(283, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(228, 25)
        Label3.TabIndex = 3
        Label3.Text = "Please Never Leave Blank !!!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(btnCalculate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label3 As Label
End Class
