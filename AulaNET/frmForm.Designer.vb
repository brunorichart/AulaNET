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
        txtNome = New TextBox()
        txtEmail = New TextBox()
        txtTelefone = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(432, 76)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(310, 27)
        txtNome.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(432, 149)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(310, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtTelefone
        ' 
        txtTelefone.Location = New Point(432, 220)
        txtTelefone.Name = "txtTelefone"
        txtTelefone.Size = New Size(310, 27)
        txtTelefone.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(323, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nome: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(323, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 4
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(323, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 5
        Label3.Text = "Telefone: "
        ' 
        ' frmForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTelefone)
        Controls.Add(txtEmail)
        Controls.Add(txtNome)
        MaximizeBox = False
        Name = "frmForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
