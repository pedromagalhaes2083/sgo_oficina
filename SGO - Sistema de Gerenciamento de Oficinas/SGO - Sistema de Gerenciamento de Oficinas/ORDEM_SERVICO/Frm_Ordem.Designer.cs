
namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Ordem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_nova_ordem = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_ordens = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordens)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pesquisar";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pesquisa.Location = new System.Drawing.Point(7, 56);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(360, 22);
            this.txt_pesquisa.TabIndex = 24;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // btn_nova_ordem
            // 
            this.btn_nova_ordem.BackColor = System.Drawing.Color.Crimson;
            this.btn_nova_ordem.FlatAppearance.BorderSize = 0;
            this.btn_nova_ordem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nova_ordem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nova_ordem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nova_ordem.Image = ((System.Drawing.Image)(resources.GetObject("btn_nova_ordem.Image")));
            this.btn_nova_ordem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nova_ordem.Location = new System.Drawing.Point(805, 441);
            this.btn_nova_ordem.Name = "btn_nova_ordem";
            this.btn_nova_ordem.Size = new System.Drawing.Size(141, 35);
            this.btn_nova_ordem.TabIndex = 23;
            this.btn_nova_ordem.Text = "Nova Ordem";
            this.btn_nova_ordem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nova_ordem.UseVisualStyleBackColor = false;
            this.btn_nova_ordem.Click += new System.EventHandler(this.btn_nova_ordem_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(7, 441);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 22;
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
            this.dgv_ordens.Location = new System.Drawing.Point(7, 84);
            this.dgv_ordens.Name = "dgv_ordens";
            this.dgv_ordens.ReadOnly = true;
            this.dgv_ordens.Size = new System.Drawing.Size(939, 351);
            this.dgv_ordens.TabIndex = 21;
            this.dgv_ordens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordens_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(361, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ordens de Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(370, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 42;
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
            this.cbx_status.Location = new System.Drawing.Point(373, 56);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(143, 21);
            this.cbx_status.TabIndex = 41;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // Frm_Ordem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 481);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.btn_nova_ordem);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_ordens);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Ordem";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Ordem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_nova_ordem;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_ordens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_status;
    }
}