namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Ordem_Financeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordem_Financeiro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_ordens = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordens)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Pesquisar";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pesquisa.Location = new System.Drawing.Point(6, 55);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(341, 22);
            this.txt_pesquisa.TabIndex = 36;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.Color.Crimson;
            this.btn_relatorio.Enabled = false;
            this.btn_relatorio.FlatAppearance.BorderSize = 0;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatorio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_relatorio.Image = ((System.Drawing.Image)(resources.GetObject("btn_relatorio.Image")));
            this.btn_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_relatorio.Location = new System.Drawing.Point(829, 450);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(116, 35);
            this.btn_relatorio.TabIndex = 35;
            this.btn_relatorio.Text = "Relatório";
            this.btn_relatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_relatorio.UseVisualStyleBackColor = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(6, 450);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 34;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_ordens
            // 
            this.dgv_ordens.AllowUserToAddRows = false;
            this.dgv_ordens.AllowUserToDeleteRows = false;
            this.dgv_ordens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ordens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ordens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordens.Location = new System.Drawing.Point(7, 83);
            this.dgv_ordens.Name = "dgv_ordens";
            this.dgv_ordens.ReadOnly = true;
            this.dgv_ordens.Size = new System.Drawing.Size(938, 361);
            this.dgv_ordens.TabIndex = 33;
            this.dgv_ordens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordens_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(352, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ordens - Financeiro";
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackColor = System.Drawing.Color.Crimson;
            this.btn_quitar.Enabled = false;
            this.btn_quitar.FlatAppearance.BorderSize = 0;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitar.Location = new System.Drawing.Point(737, 450);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(86, 35);
            this.btn_quitar.TabIndex = 38;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(350, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Status";
            // 
            // cbx_status
            // 
            this.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "MOTO",
            "CARRO",
            "OUTROS"});
            this.cbx_status.Location = new System.Drawing.Point(353, 55);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(143, 21);
            this.cbx_status.TabIndex = 39;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // Frm_Ordem_Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 490);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_ordens);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Ordem_Financeiro";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Ordem_Financeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_ordens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_status;
    }
}