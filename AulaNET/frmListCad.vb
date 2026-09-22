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
                    dgvCadatros.AllowUserToDeleteRows = True
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

End Class