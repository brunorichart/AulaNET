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
        SuspendLayout()
        ' 
        ' btnClickMe
        ' 
        btnClickMe.Location = New Point(336, 204)
        btnClickMe.Name = "btnClickMe"
        btnClickMe.Size = New Size(94, 29)
        btnClickMe.TabIndex = 0
        btnClickMe.Text = "Click Me"
        btnClickMe.UseVisualStyleBackColor = True
        ' 
        ' btnVariaveis
        ' 
        btnVariaveis.Location = New Point(339, 244)
        btnVariaveis.Name = "btnVariaveis"
        btnVariaveis.Size = New Size(94, 29)
        btnVariaveis.TabIndex = 1
        btnVariaveis.Text = "Varivéis"
        btnVariaveis.UseVisualStyleBackColor = True
        ' 
        ' btnSqlServer
        ' 
        btnSqlServer.Location = New Point(340, 286)
        btnSqlServer.Name = "btnSqlServer"
        btnSqlServer.Size = New Size(94, 29)
        btnSqlServer.TabIndex = 2
        btnSqlServer.Text = "SQL Server"
        btnSqlServer.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSqlServer)
        Controls.Add(btnVariaveis)
        Controls.Add(btnClickMe)
        Name = "frmMain"
        Text = "Meu Aplicativo"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClickMe As Button
    Friend WithEvents btnVariaveis As Button
    Friend WithEvents btnSqlServer As Button

End Class
