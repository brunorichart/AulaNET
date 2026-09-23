<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        lbSelect = New ListBox()
        lbSelected = New ListBox()
        btnSelect = New Button()
        btnBack = New Button()
        lblSoma = New Label()
        SuspendLayout()
        ' 
        ' lbSelect
        ' 
        lbSelect.FormattingEnabled = True
        lbSelect.Items.AddRange(New Object() {"GTA", "NFS", "Tetris", "Dama", "Xadrez"})
        lbSelect.Location = New Point(135, 173)
        lbSelect.Name = "lbSelect"
        lbSelect.Size = New Size(150, 104)
        lbSelect.TabIndex = 0
        ' 
        ' lbSelected
        ' 
        lbSelected.FormattingEnabled = True
        lbSelected.Location = New Point(516, 173)
        lbSelected.Name = "lbSelected"
        lbSelected.Size = New Size(150, 104)
        lbSelected.TabIndex = 1
        ' 
        ' btnSelect
        ' 
        btnSelect.Location = New Point(352, 188)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(94, 29)
        btnSelect.TabIndex = 2
        btnSelect.Text = ">>"
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(350, 228)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 3
        btnBack.Text = "<<"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblSoma
        ' 
        lblSoma.AutoSize = True
        lblSoma.Location = New Point(380, 323)
        lblSoma.Name = "lblSoma"
        lblSoma.Size = New Size(64, 20)
        lblSoma.TabIndex = 4
        lblSoma.Text = "lblSoma"
        ' 
        ' frmSelect
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSoma)
        Controls.Add(btnBack)
        Controls.Add(btnSelect)
        Controls.Add(lbSelected)
        Controls.Add(lbSelect)
        MaximizeBox = False
        Name = "frmSelect"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Trabalhando com Select"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbSelect As ListBox
    Friend WithEvents lbSelected As ListBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblSoma As Label
End Class
