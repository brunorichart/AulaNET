<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(300, 90)
        txtName.Name = "txtName"
        txtName.Size = New Size(310, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(300, 163)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(310, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(300, 234)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(310, 27)
        txtPhone.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(191, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 3
        Label1.Text = "Name: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(191, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 4
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(191, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 5
        Label3.Text = "Phone: "
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(191, 332)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Subimit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' frmForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        MaximizeBox = False
        Name = "frmForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSubmit As Button
End Class
