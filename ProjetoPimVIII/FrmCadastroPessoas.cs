using System;
using System.Data;
using System.Windows.Forms;
using Pessoa.DAO;
using System.Data.SqlClient;

namespace ProjetoPimVIII
{
    public partial class FrmCadastroPessoas : Form
    {
        public FrmCadastroPessoas()
        {
            InitializeComponent();
        }

        //Metódo criado para exlusão de registros
        private void excluirTelefoneTipoDados()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    int cd = Convert.ToInt32(txtId.Text);
                    cn.Open();
                    SqlCommand cm = new SqlCommand();
                    string strSql = "DELETE FROM telefone_tipo WHERE id = @id";

                    cm.CommandText = strSql;
                    cm.Connection = cn;
                    cm.Parameters.AddWithValue("@id", txtId.Text);

                    cm.ExecuteNonQuery();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao tentar conectar \n\n" + erro.Message);
            }
        }

        //Metódo criado para exlusão de registros
        private void excluirTelefoneDados()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    int cd = Convert.ToInt32(txtId.Text);
                    cn.Open();
                    SqlCommand cm = new SqlCommand();
                    string strSql = "DELETE FROM telefone WHERE id = @id";

                    cm.CommandText = strSql;
                    cm.Connection = cn;
                    cm.Parameters.AddWithValue("@id", txtId.Text);

                    cm.ExecuteNonQuery();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao tentar conectar \n\n" + erro.Message);
            }
        }

        //Metódo criado para exlusão de registros
        private void excluirEnderecoDados()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    int cd = Convert.ToInt32(txtId.Text);
                    cn.Open();
                    SqlCommand cm = new SqlCommand();
                    string strSql = "DELETE FROM endereco WHERE id = @id";

                    cm.CommandText = strSql;
                    cm.Connection = cn;
                    cm.Parameters.AddWithValue("@id", txtId.Text);

                    cm.ExecuteNonQuery();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao tentar conectar \n\n" + erro.Message);
            }
        }

        //Metódo criado para exlusão de registros
        private void excluirPessoaDados()
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    int cd = Convert.ToInt32(txtId.Text);
                    cn.Open();
                    SqlCommand cm = new SqlCommand();
                    string strSql = "DELETE FROM pessoa WHERE id = @id";
                                                                    
                    cm.CommandText = strSql;
                    cm.Connection = cn;
                    cm.Parameters.AddWithValue("@id", txtId.Text);

                    cm.ExecuteNonQuery();
   
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Falha ao tentar conectar \n\n" + erro.Message);
            }
        }

        // Método de pesquisa no banco de dados
        private void carregaDados() 
        {
            try
            {
                // Carregamento da consulta de cadastro de pessoas juntando todas as tabelas dentro do DataGridView
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT pessoa.id AS Código, pessoa.nome AS Nome, pessoa.cpf AS CPF, endereco.logradouro AS Logradouro, endereco.numero AS Número, endereco.cep AS CEP, endereco.bairro AS Bairro, endereco.cidade AS Cidade, endereco.estado AS Estado, telefone.ddd AS DDD, telefone.numero AS NúmeroTelefone, telefone_tipo.tipo AS Tipo FROM pessoa INNER JOIN endereco ON pessoa.id = endereco.id " +
                        "INNER JOIN telefone ON pessoa.id = telefone.id INNER JOIN telefone_tipo ON pessoa.id = telefone_tipo.id";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvPessoa.DataSource = dt;
                        }
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao tentar conectar \n\n" + ex.Message);
            }
        }

        // Metódo responsável por carregar dados do DataGridView dentro dos campos no cadastro
        private void consultaDados()
        {
            txtId.Text = dgvPessoa.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dgvPessoa.SelectedRows[0].Cells[1].Value.ToString();
            txtCpf.Text = dgvPessoa.SelectedRows[0].Cells[2].Value.ToString();
            cboTipo.Text = dgvPessoa.SelectedRows[0].Cells[11].Value.ToString();
            txtDdd.Text = dgvPessoa.SelectedRows[0].Cells[9].Value.ToString();
            txtNumTel.Text = dgvPessoa.SelectedRows[0].Cells[10].Value.ToString();
            txtLogradouro.Text = dgvPessoa.SelectedRows[0].Cells[3].Value.ToString();
            txtNumeroEnd.Text = dgvPessoa.SelectedRows[0].Cells[4].Value.ToString();
            txtCep.Text = dgvPessoa.SelectedRows[0].Cells[5].Value.ToString();
            txtBairro.Text = dgvPessoa.SelectedRows[0].Cells[6].Value.ToString();
            txtCidade.Text = dgvPessoa.SelectedRows[0].Cells[7].Value.ToString();
            cboEstado.Text = dgvPessoa.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void habilitaCampos()
        {
            // Habilita os campos para preenchimento
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumTel.Enabled = true;
            cboTipo.Enabled = true;
            txtDdd.Enabled = true;
            txtNumeroEnd.Enabled = true;
            txtCep.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cboEstado.Enabled = true;
        }

        private void desabilitaCampos()
        {
            // Desabilita os campos para preenchimento
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumTel.Enabled = false;
            cboTipo.Enabled = false;
            txtDdd.Enabled = false;
            txtNumeroEnd.Enabled = false;
            txtCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cboEstado.Enabled = false;
        }

        //Na ação de fechar o formuário recebe o valor de "null"
        private void FrmCadastroPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeuFormulario.FormCadastro = null;
        }

        // Método resposável por adicionar um novo cadastro
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();

            this.pessoaBindingSource.AddNew();
            this.enderecoBindingSource.AddNew();
            this.telefoneBindingSource.AddNew();
            this.telefone_tipoBindingSource.AddNew();
        }

        // Método resposável pela gravação do cadastro e atualização do banco de dados
        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtNome.Text != "" && txtCpf.Text != "")
                {
                
                this.Validate();
                this.pessoaBindingSource.EndEdit();
                this.enderecoBindingSource.EndEdit();
                this.telefoneBindingSource.EndEdit();
                this.telefone_tipoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pIMDataSet);
        
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Pessoa cadastrada com sucesso!");

                    // Após a gravação o Formulário carrega novamente os dados do Dataset
                    // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.endereco'. 
                    this.enderecoTableAdapter.Fill(this.pIMDataSet.endereco);
                    // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.telefone_tipo'. 
                    this.telefone_tipoTableAdapter.Fill(this.pIMDataSet.telefone_tipo);
                    // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.telefone'. 
                    this.telefoneTableAdapter.Fill(this.pIMDataSet.telefone);
                    // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.pessoa'. 
                    this.pessoaTableAdapter.Fill(this.pIMDataSet.pessoa);

                }
                else
                {
                    MessageBox.Show("Não Foi possível armazenar a pessoa informada!");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Atenção: " + erro.Message, "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            carregaDados();

        }

        // Método resposável pelo carregamento do formuário de Cadastro
        private void FrmCadastroPessoas_Load(object sender, EventArgs e)
        {
            carregaDados();

            desabilitaCampos();

            //Carrega a primeira seleção dentro das tabaelas de cadastro nos respectivos campos do cadastro
            // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.endereco'. 
            this.enderecoTableAdapter.Fill(this.pIMDataSet.endereco);
            // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.telefone_tipo'. 
            this.telefone_tipoTableAdapter.Fill(this.pIMDataSet.telefone_tipo);
            // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.telefone'. 
            this.telefoneTableAdapter.Fill(this.pIMDataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'pIMDataSet.pessoa'. 
            this.pessoaTableAdapter.Fill(this.pIMDataSet.pessoa);

        }

                
        // Método resposável pelo cancelamento da edição do cadastro
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Desabilita os campos para preenchimento
            desabilitaCampos();
            this.pessoaBindingSource.CancelEdit();
            this.enderecoBindingSource.CancelEdit();
            this.telefoneBindingSource.CancelEdit();
            this.telefone_tipoBindingSource.CancelEdit();

            carregaDados();
        }

        // Método resposável pela exclusão do cadastro e atualização do banco de dados
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza da exclusão do cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Chamando método para exclusão dos dados
                    excluirPessoaDados();
                    excluirEnderecoDados();
                    excluirTelefoneDados();
                    excluirTelefoneTipoDados();

                    MessageBox.Show("Pessoa excluida com sucesso!");
                }
            }
            // Tratamento de erro e solicitação de preenchimento dos dados novamente
            catch(Exception erro)
            {
                MessageBox.Show("O registro não pode ser excluído" + erro.Message, "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pessoaTableAdapter.Fill(pIMDataSet.pessoa);
            }

            carregaDados();
        }

        // Método que é chamado quando clicado no cadastro dentro do DataGridView
        private void dgvPessoa_MouseClick(object sender, MouseEventArgs e)
        {
            // Chamar método para habilitar os campos no cadastro de pessoas
            habilitaCampos();

            // Chamar método para trazer os valores no DataGridView para os campos de Texto no cadastro de pessoas
            consultaDados();

        }
    }
}
