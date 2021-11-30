
namespace ProjetoPimVIII
{
    partial class FrmConsultaPessoa
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
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvConsultaPessoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaCpf = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultarTodos.Location = new System.Drawing.Point(26, 547);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(106, 39);
            this.btnConsultarTodos.TabIndex = 0;
            this.btnConsultarTodos.Text = "Consultar Todos os Cadastros";
            this.btnConsultarTodos.UseVisualStyleBackColor = false;
            this.btnConsultarTodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1147, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dgvConsultaPessoa
            // 
            this.dgvConsultaPessoa.AllowUserToAddRows = false;
            this.dgvConsultaPessoa.AllowUserToDeleteRows = false;
            this.dgvConsultaPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPessoa.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaPessoa.Name = "dgvConsultaPessoa";
            this.dgvConsultaPessoa.ReadOnly = true;
            this.dgvConsultaPessoa.Size = new System.Drawing.Size(1123, 522);
            this.dgvConsultaPessoa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o CPF:";
            // 
            // txtBuscaCpf
            // 
            this.txtBuscaCpf.Location = new System.Drawing.Point(532, 554);
            this.txtBuscaCpf.Name = "txtBuscaCpf";
            this.txtBuscaCpf.Size = new System.Drawing.Size(150, 20);
            this.txtBuscaCpf.TabIndex = 5;
            this.txtBuscaCpf.TextChanged += new System.EventHandler(this.txtBuscaCpf_TextChanged);
            // 
            // FrmConsultaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 631);
            this.Controls.Add(this.txtBuscaCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultaPessoa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConsultarTodos);
            this.Name = "FrmConsultaPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Consulta de Pessoas ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaPessoa_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaPessoa_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dgvConsultaPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaCpf;
    }
}