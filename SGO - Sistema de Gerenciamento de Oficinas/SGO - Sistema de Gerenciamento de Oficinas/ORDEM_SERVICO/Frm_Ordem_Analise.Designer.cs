
namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Ordem_Analise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordem_Analise));
            this.tab_servico = new System.Windows.Forms.TabPage();
            this.dgv_servicos = new System.Windows.Forms.DataGridView();
            this.tab_ordem = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.dgv_ordens = new System.Windows.Forms.DataGridView();
            this.tab_servico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).BeginInit();
            this.tab_ordem.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordens)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_servico
            // 
            this.tab_servico.Controls.Add(this.dgv_servicos);
            this.tab_servico.Location = new System.Drawing.Point(4, 25);
            this.tab_servico.Name = "tab_servico";
            this.tab_servico.Padding = new System.Windows.Forms.Padding(3);
            this.tab_servico.Size = new System.Drawing.Size(809, 340);
            this.tab_servico.TabIndex = 1;
            this.tab_servico.Text = "Serviços";
            this.tab_servico.UseVisualStyleBackColor = true;
            // 
            // dgv_servicos
            // 
            this.dgv_servicos.AllowUserToAddRows = false;
            this.dgv_servicos.AllowUserToDeleteRows = false;
            this.dgv_servicos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicos.Location = new System.Drawing.Point(0, 0);
            this.dgv_servicos.Name = "dgv_servicos";
            this.dgv_servicos.ReadOnly = true;
            this.dgv_servicos.Size = new System.Drawing.Size(809, 340);
            this.dgv_servicos.TabIndex = 77;
            // 
            // tab_ordem
            // 
            this.tab_ordem.Controls.Add(this.dgv_ordens);
            this.tab_ordem.Location = new System.Drawing.Point(4, 25);
            this.tab_ordem.Name = "tab_ordem";
            this.tab_ordem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ordem.Size = new System.Drawing.Size(809, 340);
            this.tab_ordem.TabIndex = 0;
            this.tab_ordem.Text = "Ordem";
            this.tab_ordem.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ordem);
            this.tabControl1.Controls.Add(this.tab_servico);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(6, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 369);
            this.tabControl1.TabIndex = 22;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(6, 458);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 21;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(306, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ordem - Análise";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(369, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Status";
            // 
            // cbx_status
            // 
            this.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            ""});
            this.cbx_status.Location = new System.Drawing.Point(372, 55);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(143, 21);
            this.cbx_status.TabIndex = 45;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(3, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Pesquisar";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pesquisa.Location = new System.Drawing.Point(6, 55);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(360, 22);
            this.txt_pesquisa.TabIndex = 43;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // dgv_ordens
            // 
            this.dgv_ordens.AllowUserToAddRows = false;
            this.dgv_ordens.AllowUserToDeleteRows = false;
            this.dgv_ordens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ordens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordens.Location = new System.Drawing.Point(0, 0);
            this.dgv_ordens.Name = "dgv_ordens";
            this.dgv_ordens.ReadOnly = true;
            this.dgv_ordens.Size = new System.Drawing.Size(809, 340);
            this.dgv_ordens.TabIndex = 22;
            this.dgv_ordens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordens_CellClick);
            // 
            // Frm_Ordem_Analise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Ordem_Analise";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Ordem_Analise_Load);
            this.tab_servico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).EndInit();
            this.tab_ordem.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tab_servico;
        private System.Windows.Forms.DataGridView dgv_servicos;
        private System.Windows.Forms.TabPage tab_ordem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.DataGridView dgv_ordens;
    }
}