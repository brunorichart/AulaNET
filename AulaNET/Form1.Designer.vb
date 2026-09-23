<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnClickMe = New Button()
        btnVariaveis = New Button()
        btnSqlServer = New Button()
        btnInsert = New Button()
        btnForm = New Button()
        btnListCad = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnClickMe
        ' 
        btnClickMe.Location = New Point(346, 81)
        btnClickMe.Name = "btnClickMe"
        btnClickMe.Size = New Size(94, 29)
        btnClickMe.TabIndex = 0
        btnClickMe.Text = "Click Me"
        btnClickMe.UseVisualStyleBackColor = True
        ' 
        ' btnVariaveis
        ' 
        btnVariaveis.Location = New Point(349, 121)
        btnVariaveis.Name = "btnVariaveis"
        btnVariaveis.Size = New Size(94, 29)
        btnVariaveis.TabIndex = 1
        btnVariaveis.Text = "Varivéis"
        btnVariaveis.UseVisualStyleBackColor = True
        ' 
        ' btnSqlServer
        ' 
        btnSqlServer.Location = New Point(350, 163)
        btnSqlServer.Name = "btnSqlServer"
        btnSqlServer.Size = New Size(94, 29)
        btnSqlServer.TabIndex = 2
        btnSqlServer.Text = "SQL Server"
        btnSqlServer.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(350, 204)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(94, 29)
        btnInsert.TabIndex = 3
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnForm
        ' 
        btnForm.Location = New Point(293, 252)
        btnForm.Name = "btnForm"
        btnForm.Size = New Size(215, 29)
        btnForm.TabIndex = 4
        btnForm.Text = "Chamar Form"
        btnForm.UseVisualStyleBackColor = True
        ' 
        ' btnListCad
        ' 
        btnListCad.Location = New Point(294, 295)
        btnListCad.Name = "btnListCad"
        btnListCad.Size = New Size(214, 29)
        btnListCad.TabIndex = 5
        btnListCad.Text = "Listar Dados"
        btnListCad.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(350, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnListCad)
        Controls.Add(btnForm)
        Controls.Add(btnInsert)
        Controls.Add(btnSqlServer)
        Controls.Add(btnVariaveis)
        Controls.Add(btnClickMe)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Meu Aplicativo"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClickMe As Button
    Friend WithEvents btnVariaveis As Button
    Friend WithEvents btnSqlServer As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnForm As Button
    Friend WithEvents btnListCad As Button
    Friend WithEvents Button1 As Button

End Class
