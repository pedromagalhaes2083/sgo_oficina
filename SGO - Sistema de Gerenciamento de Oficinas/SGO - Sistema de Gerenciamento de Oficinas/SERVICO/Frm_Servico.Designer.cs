namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Servico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Servico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_novo_servico = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_servicos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(4, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pesquisar";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pesquisa.Location = new System.Drawing.Point(7, 64);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(360, 22);
            this.txt_pesquisa.TabIndex = 24;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // btn_novo_servico
            // 
            this.btn_novo_servico.BackColor = System.Drawing.Color.Crimson;
            this.btn_novo_servico.FlatAppearance.BorderSize = 0;
            this.btn_novo_servico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_servico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_novo_servico.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo_servico.Image")));
            this.btn_novo_servico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo_servico.Location = new System.Drawing.Point(690, 449);
            this.btn_novo_servico.Name = "btn_novo_servico";
            this.btn_novo_servico.Size = new System.Drawing.Size(141, 35);
            this.btn_novo_servico.TabIndex = 23;
            this.btn_novo_servico.Text = "Novo Serviço";
            this.btn_novo_servico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo_servico.UseVisualStyleBackColor = false;
            this.btn_novo_servico.Click += new System.EventHandler(this.btn_novo_servico_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(7, 449);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 22;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_servicos
            // 
            this.dgv_servicos.AllowUserToAddRows = false;
            this.dgv_servicos.AllowUserToDeleteRows = false;
            this.dgv_servicos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_servicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicos.Location = new System.Drawing.Point(7, 92);
            this.dgv_servicos.Name = "dgv_servicos";
            this.dgv_servicos.ReadOnly = true;
            this.dgv_servicos.Size = new System.Drawing.Size(824, 351);
            this.dgv_servicos.TabIndex = 21;
            this.dgv_servicos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicos_CellDoubleClick);
            this.dgv_servicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicos_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(362, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Serviços";
            // 
            // Frm_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 491);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.btn_novo_servico);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_servicos);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Servico";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Servico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_novo_servico;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_servicos;
        private System.Windows.Forms.Label label2;
    }
}