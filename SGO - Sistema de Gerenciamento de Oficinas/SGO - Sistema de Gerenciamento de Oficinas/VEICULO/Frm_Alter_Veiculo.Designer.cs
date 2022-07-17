namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Alter_Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Alter_Veiculo));
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_responsavel = new System.Windows.Forms.TextBox();
            this.chk_usa_placa = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_observacoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ano_fab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_chassi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_marca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_combustivel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_editar.Location = new System.Drawing.Point(262, 406);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(93, 35);
            this.btn_editar.TabIndex = 56;
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
            this.btn_voltar.Location = new System.Drawing.Point(8, 406);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 55;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(199, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "Editar Veículo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbx_combustivel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_responsavel);
            this.groupBox1.Controls.Add(this.chk_usa_placa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_observacoes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_ano_fab);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_cor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_chassi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbx_marca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_tipo);
            this.groupBox1.Controls.Add(this.txt_placa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 362);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Responsável";
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.Enabled = false;
            this.txt_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_responsavel.Location = new System.Drawing.Point(9, 30);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.Size = new System.Drawing.Size(459, 22);
            this.txt_responsavel.TabIndex = 73;
            // 
            // chk_usa_placa
            // 
            this.chk_usa_placa.AutoSize = true;
            this.chk_usa_placa.Checked = true;
            this.chk_usa_placa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_usa_placa.Location = new System.Drawing.Point(9, 337);
            this.chk_usa_placa.Name = "chk_usa_placa";
            this.chk_usa_placa.Size = new System.Drawing.Size(92, 20);
            this.chk_usa_placa.TabIndex = 71;
            this.chk_usa_placa.Text = "Usa placa.";
            this.chk_usa_placa.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(6, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "Observações";
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_observacoes.Location = new System.Drawing.Point(9, 162);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(586, 169);
            this.txt_observacoes.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(483, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "Ano Fab.";
            // 
            // txt_ano_fab
            // 
            this.txt_ano_fab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_ano_fab.Location = new System.Drawing.Point(486, 118);
            this.txt_ano_fab.Name = "txt_ano_fab";
            this.txt_ano_fab.Size = new System.Drawing.Size(109, 22);
            this.txt_ano_fab.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(344, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Cor";
            // 
            // txt_cor
            // 
            this.txt_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_cor.Location = new System.Drawing.Point(347, 118);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(133, 22);
            this.txt_cor.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(145, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Chassi";
            // 
            // txt_chassi
            // 
            this.txt_chassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_chassi.Location = new System.Drawing.Point(148, 118);
            this.txt_chassi.Name = "txt_chassi";
            this.txt_chassi.Size = new System.Drawing.Size(193, 22);
            this.txt_chassi.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(457, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Marca";
            // 
            // cbx_marca
            // 
            this.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_marca.FormattingEnabled = true;
            this.cbx_marca.Location = new System.Drawing.Point(457, 74);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Size = new System.Drawing.Size(138, 24);
            this.cbx_marca.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(305, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tipo";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "MOTO",
            "CARRO",
            "OUTROS"});
            this.cbx_tipo.Location = new System.Drawing.Point(308, 74);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(143, 24);
            this.cbx_tipo.TabIndex = 58;
            this.cbx_tipo.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_SelectedIndexChanged);
            // 
            // txt_placa
            // 
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_placa.Location = new System.Drawing.Point(9, 118);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(133, 22);
            this.txt_placa.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_nome.Location = new System.Drawing.Point(9, 74);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(290, 22);
            this.txt_nome.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(471, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 75;
            this.label12.Text = "Combustível";
            // 
            // cbx_combustivel
            // 
            this.cbx_combustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_combustivel.FormattingEnabled = true;
            this.cbx_combustivel.Items.AddRange(new object[] {
            "ÁLCOOL",
            "GASOLINA",
            "DIESEL",
            "GNV",
            "OUTRO"});
            this.cbx_combustivel.Location = new System.Drawing.Point(474, 30);
            this.cbx_combustivel.Name = "cbx_combustivel";
            this.cbx_combustivel.Size = new System.Drawing.Size(121, 24);
            this.cbx_combustivel.TabIndex = 74;
            // 
            // Frm_Alter_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_voltar);
            this.Name = "Frm_Alter_Veiculo";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Alter_Veiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.CheckBox chk_usa_placa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_observacoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ano_fab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_chassi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_combustivel;
    }
}