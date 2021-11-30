
namespace ProjetoPimVIII
{
    partial class FrmCadastroPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label numeroLabel1;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label dddLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cpf;
            System.Windows.Forms.Label numeroLabel2;
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIMDataSet = new ProjetoPimVIII.PIMDataSet();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumeroEnd = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            this.txtDdd = new System.Windows.Forms.MaskedTextBox();
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.telefone_tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new ProjetoPimVIII.PIMDataSetTableAdapters.pessoaTableAdapter();
            this.tableAdapterManager = new ProjetoPimVIII.PIMDataSetTableAdapters.TableAdapterManager();
            this.enderecoTableAdapter = new ProjetoPimVIII.PIMDataSetTableAdapters.enderecoTableAdapter();
            this.telefone_tipoTableAdapter = new ProjetoPimVIII.PIMDataSetTableAdapters.telefone_tipoTableAdapter();
            this.telefoneTableAdapter = new ProjetoPimVIII.PIMDataSetTableAdapters.telefoneTableAdapter();
            this.pIMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            numeroLabel1 = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            dddLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cpf = new System.Windows.Forms.Label();
            numeroLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone_tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(49, 51);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 16;
            nomeLabel.Text = "Nome:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(41, 14);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(43, 13);
            idLabel.TabIndex = 17;
            idLabel.Text = "Código:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(25, 163);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(64, 13);
            logradouroLabel.TabIndex = 23;
            logradouroLabel.Text = "Logradouro:";
            // 
            // numeroLabel1
            // 
            numeroLabel1.AutoSize = true;
            numeroLabel1.Location = new System.Drawing.Point(356, 163);
            numeroLabel1.Name = "numeroLabel1";
            numeroLabel1.Size = new System.Drawing.Size(47, 13);
            numeroLabel1.TabIndex = 24;
            numeroLabel1.Text = "Número:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(201, 203);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 26;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(359, 203);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 27;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(43, 244);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 28;
            estadoLabel.Text = "Estado:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(53, 127);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 29;
            tipoLabel.Text = "Tipo:";
            // 
            // dddLabel
            // 
            dddLabel.AutoSize = true;
            dddLabel.Location = new System.Drawing.Point(216, 127);
            dddLabel.Name = "dddLabel";
            dddLabel.Size = new System.Drawing.Size(34, 13);
            dddLabel.TabIndex = 31;
            dddLabel.Text = "DDD:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(57, 203);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 33;
            cepLabel.Text = "CEP:";
            // 
            // cpf
            // 
            cpf.AutoSize = true;
            cpf.Location = new System.Drawing.Point(60, 88);
            cpf.Name = "cpf";
            cpf.Size = new System.Drawing.Size(30, 13);
            cpf.TabIndex = 33;
            cpf.Text = "CPF:";
            // 
            // numeroLabel2
            // 
            numeroLabel2.AutoSize = true;
            numeroLabel2.Location = new System.Drawing.Point(329, 127);
            numeroLabel2.Name = "numeroLabel2";
            numeroLabel2.Size = new System.Drawing.Size(73, 13);
            numeroLabel2.TabIndex = 34;
            numeroLabel2.Text = "Num. Tel/Cel:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNovo.Location = new System.Drawing.Point(116, 277);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 34);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(330, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Firebrick;
            this.btnGravar.Location = new System.Drawing.Point(225, 277);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 34);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Yellow;
            this.btnExcluir.Location = new System.Drawing.Point(433, 277);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 34);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "nome", true));
            this.txtNome.Location = new System.Drawing.Point(91, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(416, 20);
            this.txtNome.TabIndex = 1;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.pIMDataSet;
            // 
            // pIMDataSet
            // 
            this.pIMDataSet.DataSetName = "PIMDataSet";
            this.pIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "id", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(91, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 20);
            this.txtId.TabIndex = 18;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "logradouro", true));
            this.txtLogradouro.Location = new System.Drawing.Point(91, 160);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(252, 20);
            this.txtLogradouro.TabIndex = 6;
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataMember = "endereco";
            this.enderecoBindingSource.DataSource = this.pIMDataSet;
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "numero", true));
            this.txtNumeroEnd.Location = new System.Drawing.Point(407, 160);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEnd.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "bairro", true));
            this.txtBairro.Location = new System.Drawing.Point(243, 200);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "cidade", true));
            this.txtCidade.Location = new System.Drawing.Point(408, 203);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.AllowUserToAddRows = false;
            this.dgvPessoa.AllowUserToDeleteRows = false;
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.Location = new System.Drawing.Point(28, 317);
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.ReadOnly = true;
            this.dgvPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoa.Size = new System.Drawing.Size(541, 318);
            this.dgvPessoa.TabIndex = 18;
            this.dgvPessoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPessoa_MouseClick);
            // 
            // txtDdd
            // 
            this.txtDdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefoneBindingSource, "ddd", true));
            this.txtDdd.Location = new System.Drawing.Point(250, 124);
            this.txtDdd.Mask = "(00)";
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(25, 20);
            this.txtDdd.TabIndex = 4;
            // 
            // telefoneBindingSource
            // 
            this.telefoneBindingSource.DataMember = "telefone";
            this.telefoneBindingSource.DataSource = this.pIMDataSet;
            // 
            // txtCpf
            // 
            this.txtCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "cpf", true));
            this.txtCpf.Location = new System.Drawing.Point(91, 85);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // txtNumTel
            // 
            this.txtNumTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefoneBindingSource, "numero", true));
            this.txtNumTel.Location = new System.Drawing.Point(408, 124);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(100, 20);
            this.txtNumTel.TabIndex = 5;
            // 
            // txtCep
            // 
            this.txtCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "cep", true));
            this.txtCep.Location = new System.Drawing.Point(91, 200);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 8;
            // 
            // cboEstado
            // 
            this.cboEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enderecoBindingSource, "estado", true));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 13;
            this.cboEstado.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia  - BA",
            "Ceará - CE",
            "Distrito Federal  - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.cboEstado.Location = new System.Drawing.Point(91, 241);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(129, 21);
            this.cboEstado.TabIndex = 11;
            this.cboEstado.Text = "[Selecione]";
            // 
            // cboTipo
            // 
            this.cboTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefone_tipoBindingSource, "tipo", true));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 13;
            this.cboTipo.Items.AddRange(new object[] {
            "TEL",
            "CEL",
            "TEL COM."});
            this.cboTipo.Location = new System.Drawing.Point(90, 122);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(101, 21);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.Text = "[Selecione]";
            // 
            // telefone_tipoBindingSource
            // 
            this.telefone_tipoBindingSource.DataMember = "telefone_tipo";
            this.telefone_tipoBindingSource.DataSource = this.pIMDataSet;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.enderecoTableAdapter = this.enderecoTableAdapter;
            this.tableAdapterManager.pessoa_telefoneTableAdapter = null;
            this.tableAdapterManager.pessoaTableAdapter = this.pessoaTableAdapter;
            this.tableAdapterManager.telefone_tipoTableAdapter = this.telefone_tipoTableAdapter;
            this.tableAdapterManager.telefoneTableAdapter = this.telefoneTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoPimVIII.PIMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enderecoTableAdapter
            // 
            this.enderecoTableAdapter.ClearBeforeFill = true;
            // 
            // telefone_tipoTableAdapter
            // 
            this.telefone_tipoTableAdapter.ClearBeforeFill = true;
            // 
            // telefoneTableAdapter
            // 
            this.telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // pIMDataSetBindingSource
            // 
            this.pIMDataSetBindingSource.DataSource = this.pIMDataSet;
            this.pIMDataSetBindingSource.Position = 0;
            // 
            // FrmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 693);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(numeroLabel2);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(cpf);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(cepLabel);
            this.Controls.Add(dddLabel);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.dgvPessoa);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(numeroLabel1);
            this.Controls.Add(this.txtNumeroEnd);
            this.Controls.Add(logradouroLabel);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Name = "FrmCadastroPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Cadastro de Pessoas ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastroPessoas_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadastroPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone_tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private PIMDataSet pIMDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private PIMDataSetTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private PIMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PIMDataSetTableAdapters.telefoneTableAdapter telefoneTableAdapter;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private PIMDataSetTableAdapters.telefone_tipoTableAdapter telefone_tipoTableAdapter;
        private System.Windows.Forms.BindingSource telefone_tipoBindingSource;
        private PIMDataSetTableAdapters.enderecoTableAdapter enderecoTableAdapter;
        private System.Windows.Forms.BindingSource enderecoBindingSource;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNumeroEnd;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.DataGridView dgvPessoa;
        private System.Windows.Forms.MaskedTextBox txtDdd;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.BindingSource pIMDataSetBindingSource;
    }
}