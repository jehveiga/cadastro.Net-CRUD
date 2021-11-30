using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pessoa.DAO;

namespace ProjetoPimVIII
{
    public partial class FrmConsultaPessoa : Form
    {
        public FrmConsultaPessoa()
        {
            InitializeComponent();
        }

        private void FrmConsultaPessoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeuFormulario.FormConsulta = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde.";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT pessoa.id AS Código, pessoa.nome AS Nome, pessoa.cpf AS CPF, endereco.logradouro AS Logradouro, endereco.numero AS Número, endereco.cep AS CEP, endereco.bairro AS Bairro, endereco.cidade AS Cidade, endereco.estado AS Estado, telefone.ddd AS DDD, telefone.numero AS NúmeroTelefone, telefone_tipo.tipo AS Tipo FROM pessoa INNER JOIN endereco ON pessoa.id = endereco.id " +
                        "INNER JOIN telefone ON pessoa.id = telefone.id INNER JOIN telefone_tipo ON pessoa.id = telefone_tipo.id";

                    // recebe os dados das tabelas após a execução de um Select
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        // objeto DataTable pode representar uma ou mais tabelas de dados
                        using (DataTable dt = new DataTable())
                        {
                            //recebendo os dados da instrução select
                            da.Fill(dt);
                            dgvConsultaPessoa.DataSource = dt;
                        }
                    }
                    toolStripStatusLabel1.Text = "Pronto.";
                    statusStrip1.Refresh();

                }

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha.";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar \n\n" + ex.Message);
            }
        }


        private void FrmConsultaPessoa_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtBuscaCpf_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaCpf.Text != "")
            {
                toolStripStatusLabel1.Text = "Conectando, aguarde.";
                statusStrip1.Refresh();

                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        using (SqlCommand cm = new SqlCommand()) {
                            cn.Open();

                            cm.CommandText = "SELECT pessoa.id AS Código, pessoa.nome AS Nome, pessoa.cpf AS CPF, endereco.logradouro AS Logradouro, endereco.numero AS Número, endereco.cep AS CEP, endereco.bairro AS Bairro, endereco.cidade AS Cidade, endereco.estado AS Estado, telefone.ddd AS DDD, telefone.numero AS NúmeroTelefone, telefone_tipo.tipo AS Tipo FROM pessoa INNER JOIN endereco ON pessoa.id = endereco.id " +
                                "INNER JOIN telefone ON pessoa.id = telefone.id INNER JOIN telefone_tipo ON pessoa.id = telefone_tipo.id WHERE pessoa.cpf like ('" + txtBuscaCpf.Text + "%')";
                            cm.Connection = cn;

                            // recebe os dados das tabelas após a execução de um Select
                            using (SqlDataAdapter da = new SqlDataAdapter(cm.CommandText, cn))
                            {
                                // objeto DataTable pode representar uma ou mais tabelas de dados
                                using (DataTable dt = new DataTable())
                                {
                                    //recebendo os dados da instrução select
                                    da.Fill(dt); // Preenche o datatable
                                    dgvConsultaPessoa.DataSource = dt;
                                    cn.Close();
                                }
                            }
                            toolStripStatusLabel1.Text = "Pronto.";
                            statusStrip1.Refresh();


                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Falha.";
                    statusStrip1.Refresh();
                    MessageBox.Show("Falha ao tentar conectar \n\n" + ex.Message);
                }
            }else
            {
                dgvConsultaPessoa.DataSource = null;
            }
        }
    }
}
