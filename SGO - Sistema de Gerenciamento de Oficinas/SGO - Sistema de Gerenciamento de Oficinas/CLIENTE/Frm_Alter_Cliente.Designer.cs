namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Alter_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Alter_Cliente));
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.txt_observacoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mkt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_apelido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.label7);
            this.groupbox.Controls.Add(this.cbx_status);
            this.groupbox.Controls.Add(this.txt_observacoes);
            this.groupbox.Controls.Add(this.label6);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.mkt_telefone);
            this.groupbox.Controls.Add(this.txt_apelido);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.txt_endereco);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.txt_nome);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupbox.Location = new System.Drawing.Point(6, 39);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(650, 182);
            this.groupbox.TabIndex = 16;
            this.groupbox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status";
            // 
            // cbx_status
            // 
            this.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(503, 77);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(139, 24);
            this.cbx_status.TabIndex = 10;
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.Location = new System.Drawing.Point(9, 121);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(633, 49);
            this.txt_observacoes.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Observações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // mkt_telefone
            // 
            this.mkt_telefone.Location = new System.Drawing.Point(8, 77);
            this.mkt_telefone.Mask = "(999) 00000-0000";
            this.mkt_telefone.Name = "mkt_telefone";
            this.mkt_telefone.Size = new System.Drawing.Size(118, 22);
            this.mkt_telefone.TabIndex = 6;
            // 
            // txt_apelido
            // 
            this.txt_apelido.Location = new System.Drawing.Point(434, 32);
            this.txt_apelido.Name = "txt_apelido";
            this.txt_apelido.Size = new System.Drawing.Size(208, 22);
            this.txt_apelido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apelido";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(132, 77);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(365, 22);
            this.txt_endereco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(8, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(420, 22);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Crimson;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(285, 227);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(93, 35);
            this.btn_editar.TabIndex = 19;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(6, 227);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 18;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(245, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Editar Cliente";
            // 
            // Frm_Alter_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 266);
            this.ControlBox = false;
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label5);
            this.Name = "Frm_Alter_Cliente";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Alter_Cliente_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.TextBox txt_observacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mkt_telefone;
        private System.Windows.Forms.TextBox txt_apelido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_status;
    }
}