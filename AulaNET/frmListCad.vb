Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class frmListCad

    Private Sub frmListCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarCadastros()

    End Sub

    Private Sub CarregarCadastros()

        Dim sql As String = "
            SELECT
                id,
                name,
                email,
                phone,
                created
            FROM Cadastro
            ORDER BY id DESC;
        "

        Using conexao As SqlConnection = Database.GetConnection()

            Using comando As New SqlCommand(sql, conexao)

                Try

                    conexao.Open()

                    Using reader As SqlDataReader = comando.ExecuteReader()

                        Dim tabela As New DataTable()

                        tabela.Load(reader)

                        dgvCadatros.DataSource = tabela

                    End Using

                    ' Tamanho das colunas
                    dgvCadatros.Columns("id").Width = 50
                    dgvCadatros.Columns("name").Width = 200
                    dgvCadatros.Columns("email").Width = 250
                    dgvCadatros.Columns("phone").Width = 150
                    dgvCadatros.Columns("created").Width = 150

                    ' Configurações do DataGridView
                    dgvCadatros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    dgvCadatros.ReadOnly = True
                    dgvCadatros.AllowUserToAddRows = False
                    dgvCadatros.AllowUserToDeleteRows = False
                    dgvCadatros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvCadatros.MultiSelect = False

                    ' Nome das colunas
                    dgvCadatros.Columns("id").HeaderText = "ID"
                    dgvCadatros.Columns("name").HeaderText = "Nome"
                    dgvCadatros.Columns("email").HeaderText = "E-mail"
                    dgvCadatros.Columns("phone").HeaderText = "Telefone"
                    dgvCadatros.Columns("created").HeaderText = "Data de Cadastro"

                Catch ex As Exception

                    MessageBox.Show(
                        "Erro ao carregar os cadastros: " & ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    )

                End Try

            End Using

        End Using

    End Sub

    Private Sub dgvCadatros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCadatros.CellDoubleClick

        ' Verifica se clicou em uma linha válida
        If e.RowIndex < 0 Then
            Return
        End If

        ' Obtém o ID do cadastro selecionado
        Dim id As Integer = Convert.ToInt32(
            dgvCadatros.Rows(e.RowIndex).Cells("id").Value
        )

        ' Confirma a exclusão
        Dim resposta As DialogResult = MessageBox.Show(
            "Deseja excluir este cadastro?",
            "Confirmar exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If resposta = DialogResult.Yes Then

            ExcluirCadastro(id)

        End If

    End Sub

    Private Sub ExcluirCadastro(id As Integer)

        Dim sql As String = "
        DELETE FROM Cadastro
        WHERE id = @id;
    "

        Using conexao As SqlConnection = Database.GetConnection()

            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@id", SqlDbType.Int).Value = id

                Try

                    conexao.Open()

                    Dim registrosAfetados As Integer = comando.ExecuteNonQuery()

                    If registrosAfetados > 0 Then

                        MessageBox.Show(
                            "Cadastro excluído com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        ' Atualiza o Grid
                        CarregarCadastros()

                    End If

                Catch ex As Exception

                    MessageBox.Show(
                        "Erro ao excluir o cadastro: " & ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    )

                End Try

            End Using

        End Using

    End Sub
End Class