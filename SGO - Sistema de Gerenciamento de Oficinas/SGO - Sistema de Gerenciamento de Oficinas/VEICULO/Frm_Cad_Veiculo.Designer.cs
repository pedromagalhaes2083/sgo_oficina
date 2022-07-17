namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Cad_Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cad_Veiculo));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.tbc_Controle = new System.Windows.Forms.TabControl();
            this.Responsavel = new System.Windows.Forms.TabPage();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.Veiculo = new System.Windows.Forms.TabPage();
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
            this.tbc_Controle.SuspendLayout();
            this.Responsavel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.Veiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(199, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cadastrar Veículo";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Crimson;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(250, 421);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(119, 35);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(6, 421);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // tbc_Controle
            // 
            this.tbc_Controle.Controls.Add(this.Responsavel);
            this.tbc_Controle.Controls.Add(this.Veiculo);
            this.tbc_Controle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbc_Controle.Location = new System.Drawing.Point(6, 40);
            this.tbc_Controle.Name = "tbc_Controle";
            this.tbc_Controle.SelectedIndex = 0;
            this.tbc_Controle.Size = new System.Drawing.Size(608, 379);
            this.tbc_Controle.TabIndex = 13;
            this.tbc_Controle.SelectedIndexChanged += new System.EventHandler(this.tbc_Controle_SelectedIndexChanged);
            // 
            // Responsavel
            // 
            this.Responsavel.Controls.Add(this.dgv_clientes);
            this.Responsavel.Controls.Add(this.label10);
            this.Responsavel.Controls.Add(this.txt_pesquisa);
            this.Responsavel.Location = new System.Drawing.Point(4, 25);
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.Padding = new System.Windows.Forms.Padding(3);
            this.Responsavel.Size = new System.Drawing.Size(600, 350);
            this.Responsavel.TabIndex = 0;
            this.Responsavel.Text = "Responsável";
            this.Responsavel.UseVisualStyleBackColor = true;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(9, 50);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.Size = new System.Drawing.Size(583, 294);
            this.dgv_clientes.TabIndex = 21;
            this.dgv_clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellDoubleClick);
            this.dgv_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nome";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pesquisa.Location = new System.Drawing.Point(9, 22);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(327, 22);
            this.txt_pesquisa.TabIndex = 20;
            // 
            // Veiculo
            // 
            this.Veiculo.Controls.Add(this.label12);
            this.Veiculo.Controls.Add(this.cbx_combustivel);
            this.Veiculo.Controls.Add(this.label11);
            this.Veiculo.Controls.Add(this.txt_responsavel);
            this.Veiculo.Controls.Add(this.chk_usa_placa);
            this.Veiculo.Controls.Add(this.label9);
            this.Veiculo.Controls.Add(this.txt_observacoes);
            this.Veiculo.Controls.Add(this.label8);
            this.Veiculo.Controls.Add(this.txt_ano_fab);
            this.Veiculo.Controls.Add(this.label7);
            this.Veiculo.Controls.Add(this.txt_cor);
            this.Veiculo.Controls.Add(this.label6);
            this.Veiculo.Controls.Add(this.txt_chassi);
            this.Veiculo.Controls.Add(this.label5);
            this.Veiculo.Controls.Add(this.label4);
            this.Veiculo.Controls.Add(this.cbx_marca);
            this.Veiculo.Controls.Add(this.label3);
            this.Veiculo.Controls.Add(this.cbx_tipo);
            this.Veiculo.Controls.Add(this.txt_placa);
            this.Veiculo.Controls.Add(this.label1);
            this.Veiculo.Controls.Add(this.txt_nome);
            this.Veiculo.Location = new System.Drawing.Point(4, 25);
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.Padding = new System.Windows.Forms.Padding(3);
            this.Veiculo.Size = new System.Drawing.Size(600, 350);
            this.Veiculo.TabIndex = 1;
            this.Veiculo.Text = "Veículo";
            this.Veiculo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Responsável";
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.Enabled = false;
            this.txt_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_responsavel.Location = new System.Drawing.Point(6, 22);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.Size = new System.Drawing.Size(459, 22);
            this.txt_responsavel.TabIndex = 35;
            // 
            // chk_usa_placa
            // 
            this.chk_usa_placa.AutoSize = true;
            this.chk_usa_placa.Checked = true;
            this.chk_usa_placa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_usa_placa.Location = new System.Drawing.Point(6, 329);
            this.chk_usa_placa.Name = "chk_usa_placa";
            this.chk_usa_placa.Size = new System.Drawing.Size(92, 20);
            this.chk_usa_placa.TabIndex = 33;
            this.chk_usa_placa.Text = "Usa placa.";
            this.chk_usa_placa.UseVisualStyleBackColor = true;
            this.chk_usa_placa.CheckedChanged += new System.EventHandler(this.chk_usa_placa_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(3, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Observações";
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_observacoes.Location = new System.Drawing.Point(6, 154);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(586, 169);
            this.txt_observacoes.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(480, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ano Fab.";
            // 
            // txt_ano_fab
            // 
            this.txt_ano_fab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_ano_fab.Location = new System.Drawing.Point(483, 110);
            this.txt_ano_fab.Name = "txt_ano_fab";
            this.txt_ano_fab.Size = new System.Drawing.Size(109, 22);
            this.txt_ano_fab.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(341, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cor";
            // 
            // txt_cor
            // 
            this.txt_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_cor.Location = new System.Drawing.Point(344, 110);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(133, 22);
            this.txt_cor.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(142, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Chassi";
            // 
            // txt_chassi
            // 
            this.txt_chassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_chassi.Location = new System.Drawing.Point(145, 110);
            this.txt_chassi.Name = "txt_chassi";
            this.txt_chassi.Size = new System.Drawing.Size(193, 22);
            this.txt_chassi.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(454, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Marca";
            // 
            // cbx_marca
            // 
            this.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_marca.FormattingEnabled = true;
            this.cbx_marca.Location = new System.Drawing.Point(454, 66);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Size = new System.Drawing.Size(138, 24);
            this.cbx_marca.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(302, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 21;
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
            this.cbx_tipo.Location = new System.Drawing.Point(305, 66);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(143, 24);
            this.cbx_tipo.TabIndex = 20;
            this.cbx_tipo.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_SelectedIndexChanged);
            // 
            // txt_placa
            // 
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_placa.Location = new System.Drawing.Point(6, 110);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(133, 22);
            this.txt_placa.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_nome.Location = new System.Drawing.Point(6, 66);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(290, 22);
            this.txt_nome.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(468, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 47;
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
            this.cbx_combustivel.Location = new System.Drawing.Point(471, 20);
            this.cbx_combustivel.Name = "cbx_combustivel";
            this.cbx_combustivel.Size = new System.Drawing.Size(121, 24);
            this.cbx_combustivel.TabIndex = 46;
            // 
            // Frm_Cad_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 462);
            this.ControlBox = false;
            this.Controls.Add(this.tbc_Controle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_voltar);
            this.Name = "Frm_Cad_Veiculo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Cad_Veiculo_Load);
            this.tbc_Controle.ResumeLayout(false);
            this.Responsavel.ResumeLayout(false);
            this.Responsavel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.Veiculo.ResumeLayout(false);
            this.Veiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TabControl tbc_Controle;
        private System.Windows.Forms.TabPage Responsavel;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.TabPage Veiculo;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_combustivel;
    }
}