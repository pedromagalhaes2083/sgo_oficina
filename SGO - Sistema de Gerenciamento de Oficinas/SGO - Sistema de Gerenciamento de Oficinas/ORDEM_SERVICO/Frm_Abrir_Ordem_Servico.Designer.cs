namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Abrir_Ordem_Servico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Abrir_Ordem_Servico));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_abrir_ordem = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.tab_servico = new System.Windows.Forms.TabPage();
            this.dgv_servicos_fazer = new System.Windows.Forms.DataGridView();
            this.dgv_servicos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pesquisa_servico = new System.Windows.Forms.TextBox();
            this.tab_ordem = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_ano_fab = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.txt_obs_cliente = new System.Windows.Forms.TextBox();
            this.txt_obs_avaria = new System.Windows.Forms.TextBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.txt_veiculo = new System.Windows.Forms.TextBox();
            this.txt_responsavel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_combustivel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tab_veiculo = new System.Windows.Forms.TabPage();
            this.dgv_veiculos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_pesquisa_veiculo = new System.Windows.Forms.TextBox();
            this.tbc_Controle = new System.Windows.Forms.TabControl();
            this.tab_nota = new System.Windows.Forms.TabPage();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.tab_servico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos_fazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).BeginInit();
            this.tab_ordem.SuspendLayout();
            this.tab_veiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos)).BeginInit();
            this.tbc_Controle.SuspendLayout();
            this.tab_nota.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(275, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Abrir ordem de serviço";
            // 
            // btn_abrir_ordem
            // 
            this.btn_abrir_ordem.BackColor = System.Drawing.Color.Crimson;
            this.btn_abrir_ordem.Enabled = false;
            this.btn_abrir_ordem.FlatAppearance.BorderSize = 0;
            this.btn_abrir_ordem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir_ordem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir_ordem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_abrir_ordem.Image = ((System.Drawing.Image)(resources.GetObject("btn_abrir_ordem.Image")));
            this.btn_abrir_ordem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abrir_ordem.Location = new System.Drawing.Point(347, 360);
            this.btn_abrir_ordem.Name = "btn_abrir_ordem";
            this.btn_abrir_ordem.Size = new System.Drawing.Size(134, 35);
            this.btn_abrir_ordem.TabIndex = 15;
            this.btn_abrir_ordem.Text = "Abrir Ordem";
            this.btn_abrir_ordem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_abrir_ordem.UseVisualStyleBackColor = false;
            this.btn_abrir_ordem.Click += new System.EventHandler(this.btn_abrir_ordem_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(6, 360);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 14;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // tab_servico
            // 
            this.tab_servico.Controls.Add(this.dgv_servicos_fazer);
            this.tab_servico.Controls.Add(this.dgv_servicos);
            this.tab_servico.Controls.Add(this.label9);
            this.tab_servico.Controls.Add(this.txt_pesquisa_servico);
            this.tab_servico.Location = new System.Drawing.Point(4, 25);
            this.tab_servico.Name = "tab_servico";
            this.tab_servico.Size = new System.Drawing.Size(809, 285);
            this.tab_servico.TabIndex = 2;
            this.tab_servico.Text = "Serviços";
            this.tab_servico.UseVisualStyleBackColor = true;
            // 
            // dgv_servicos_fazer
            // 
            this.dgv_servicos_fazer.AllowUserToAddRows = false;
            this.dgv_servicos_fazer.AllowUserToDeleteRows = false;
            this.dgv_servicos_fazer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_servicos_fazer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_servicos_fazer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicos_fazer.Location = new System.Drawing.Point(407, 51);
            this.dgv_servicos_fazer.Name = "dgv_servicos_fazer";
            this.dgv_servicos_fazer.ReadOnly = true;
            this.dgv_servicos_fazer.Size = new System.Drawing.Size(391, 229);
            this.dgv_servicos_fazer.TabIndex = 25;
            this.dgv_servicos_fazer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicos_fazer_CellDoubleClick);
            // 
            // dgv_servicos
            // 
            this.dgv_servicos.AllowUserToAddRows = false;
            this.dgv_servicos.AllowUserToDeleteRows = false;
            this.dgv_servicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_servicos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicos.Location = new System.Drawing.Point(10, 51);
            this.dgv_servicos.Name = "dgv_servicos";
            this.dgv_servicos.ReadOnly = true;
            this.dgv_servicos.Size = new System.Drawing.Size(391, 229);
            this.dgv_servicos.TabIndex = 24;
            this.dgv_servicos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicos_CellDoubleClick);
            this.dgv_servicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicos_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(7, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Serviço";
            // 
            // txt_pesquisa_servico
            // 
            this.txt_pesquisa_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pesquisa_servico.Location = new System.Drawing.Point(10, 23);
            this.txt_pesquisa_servico.Name = "txt_pesquisa_servico";
            this.txt_pesquisa_servico.Size = new System.Drawing.Size(327, 22);
            this.txt_pesquisa_servico.TabIndex = 23;
            this.txt_pesquisa_servico.TextChanged += new System.EventHandler(this.txt_pesquisa_servico_TextChanged);
            // 
            // tab_ordem
            // 
            this.tab_ordem.Controls.Add(this.label12);
            this.tab_ordem.Controls.Add(this.txt_marca);
            this.tab_ordem.Controls.Add(this.txt_ano_fab);
            this.tab_ordem.Controls.Add(this.txt_cor);
            this.tab_ordem.Controls.Add(this.txt_obs_cliente);
            this.tab_ordem.Controls.Add(this.txt_obs_avaria);
            this.tab_ordem.Controls.Add(this.txt_placa);
            this.tab_ordem.Controls.Add(this.txt_veiculo);
            this.tab_ordem.Controls.Add(this.txt_responsavel);
            this.tab_ordem.Controls.Add(this.label4);
            this.tab_ordem.Controls.Add(this.label5);
            this.tab_ordem.Controls.Add(this.label8);
            this.tab_ordem.Controls.Add(this.label7);
            this.tab_ordem.Controls.Add(this.label6);
            this.tab_ordem.Controls.Add(this.cbx_combustivel);
            this.tab_ordem.Controls.Add(this.label3);
            this.tab_ordem.Controls.Add(this.label1);
            this.tab_ordem.Controls.Add(this.label11);
            this.tab_ordem.Location = new System.Drawing.Point(4, 25);
            this.tab_ordem.Name = "tab_ordem";
            this.tab_ordem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ordem.Size = new System.Drawing.Size(809, 285);
            this.tab_ordem.TabIndex = 1;
            this.tab_ordem.Text = "Ordem de Serviço";
            this.tab_ordem.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(662, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Marca";
            // 
            // txt_marca
            // 
            this.txt_marca.Enabled = false;
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_marca.Location = new System.Drawing.Point(665, 66);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(138, 22);
            this.txt_marca.TabIndex = 58;
            // 
            // txt_ano_fab
            // 
            this.txt_ano_fab.Enabled = false;
            this.txt_ano_fab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_ano_fab.Location = new System.Drawing.Point(550, 66);
            this.txt_ano_fab.Name = "txt_ano_fab";
            this.txt_ano_fab.ReadOnly = true;
            this.txt_ano_fab.Size = new System.Drawing.Size(109, 22);
            this.txt_ano_fab.TabIndex = 56;
            // 
            // txt_cor
            // 
            this.txt_cor.Enabled = false;
            this.txt_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_cor.Location = new System.Drawing.Point(411, 66);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.ReadOnly = true;
            this.txt_cor.Size = new System.Drawing.Size(133, 22);
            this.txt_cor.TabIndex = 54;
            // 
            // txt_obs_cliente
            // 
            this.txt_obs_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_obs_cliente.Location = new System.Drawing.Point(409, 110);
            this.txt_obs_cliente.Multiline = true;
            this.txt_obs_cliente.Name = "txt_obs_cliente";
            this.txt_obs_cliente.ReadOnly = true;
            this.txt_obs_cliente.Size = new System.Drawing.Size(394, 169);
            this.txt_obs_cliente.TabIndex = 53;
            // 
            // txt_obs_avaria
            // 
            this.txt_obs_avaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_obs_avaria.Location = new System.Drawing.Point(6, 110);
            this.txt_obs_avaria.Multiline = true;
            this.txt_obs_avaria.Name = "txt_obs_avaria";
            this.txt_obs_avaria.ReadOnly = true;
            this.txt_obs_avaria.Size = new System.Drawing.Size(394, 169);
            this.txt_obs_avaria.TabIndex = 52;
            // 
            // txt_placa
            // 
            this.txt_placa.Enabled = false;
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_placa.Location = new System.Drawing.Point(593, 22);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.ReadOnly = true;
            this.txt_placa.Size = new System.Drawing.Size(125, 22);
            this.txt_placa.TabIndex = 39;
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Enabled = false;
            this.txt_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_veiculo.Location = new System.Drawing.Point(6, 66);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.ReadOnly = true;
            this.txt_veiculo.Size = new System.Drawing.Size(399, 22);
            this.txt_veiculo.TabIndex = 37;
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.Enabled = false;
            this.txt_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_responsavel.Location = new System.Drawing.Point(6, 22);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.ReadOnly = true;
            this.txt_responsavel.Size = new System.Drawing.Size(581, 22);
            this.txt_responsavel.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(547, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ano Fab.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(408, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Cor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(406, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Observações do cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(3, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Observações de avaria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(721, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Combustível";
            // 
            // cbx_combustivel
            // 
            this.cbx_combustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_combustivel.FormattingEnabled = true;
            this.cbx_combustivel.Items.AddRange(new object[] {
            "1",
            "3/4",
            "1/2",
            "1/4",
            "0"});
            this.cbx_combustivel.Location = new System.Drawing.Point(724, 22);
            this.cbx_combustivel.Name = "cbx_combustivel";
            this.cbx_combustivel.Size = new System.Drawing.Size(79, 24);
            this.cbx_combustivel.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(590, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Veículo";
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
            // tab_veiculo
            // 
            this.tab_veiculo.Controls.Add(this.dgv_veiculos);
            this.tab_veiculo.Controls.Add(this.label10);
            this.tab_veiculo.Controls.Add(this.txt_pesquisa_veiculo);
            this.tab_veiculo.Location = new System.Drawing.Point(4, 25);
            this.tab_veiculo.Name = "tab_veiculo";
            this.tab_veiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_veiculo.Size = new System.Drawing.Size(809, 285);
            this.tab_veiculo.TabIndex = 0;
            this.tab_veiculo.Text = "Veículo";
            this.tab_veiculo.UseVisualStyleBackColor = true;
            // 
            // dgv_veiculos
            // 
            this.dgv_veiculos.AllowUserToAddRows = false;
            this.dgv_veiculos.AllowUserToDeleteRows = false;
            this.dgv_veiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_veiculos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veiculos.Location = new System.Drawing.Point(8, 50);
            this.dgv_veiculos.Name = "dgv_veiculos";
            this.dgv_veiculos.ReadOnly = true;
            this.dgv_veiculos.Size = new System.Drawing.Size(792, 229);
            this.dgv_veiculos.TabIndex = 21;
            this.dgv_veiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_veiculos_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Responsável/Apelido/Veículo";
            // 
            // txt_pesquisa_veiculo
            // 
            this.txt_pesquisa_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pesquisa_veiculo.Location = new System.Drawing.Point(9, 22);
            this.txt_pesquisa_veiculo.Name = "txt_pesquisa_veiculo";
            this.txt_pesquisa_veiculo.Size = new System.Drawing.Size(327, 22);
            this.txt_pesquisa_veiculo.TabIndex = 20;
            this.txt_pesquisa_veiculo.TextChanged += new System.EventHandler(this.txt_pesquisa_veiculo_TextChanged);
            // 
            // tbc_Controle
            // 
            this.tbc_Controle.Controls.Add(this.tab_veiculo);
            this.tbc_Controle.Controls.Add(this.tab_ordem);
            this.tbc_Controle.Controls.Add(this.tab_nota);
            this.tbc_Controle.Controls.Add(this.tab_servico);
            this.tbc_Controle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbc_Controle.Location = new System.Drawing.Point(6, 40);
            this.tbc_Controle.Name = "tbc_Controle";
            this.tbc_Controle.SelectedIndex = 0;
            this.tbc_Controle.Size = new System.Drawing.Size(817, 314);
            this.tbc_Controle.TabIndex = 4;
            this.tbc_Controle.TabStop = false;
            this.tbc_Controle.SelectedIndexChanged += new System.EventHandler(this.tbc_Controle_SelectedIndexChanged);
            // 
            // tab_nota
            // 
            this.tab_nota.Controls.Add(this.txt_nota);
            this.tab_nota.Location = new System.Drawing.Point(4, 25);
            this.tab_nota.Name = "tab_nota";
            this.tab_nota.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nota.Size = new System.Drawing.Size(809, 285);
            this.tab_nota.TabIndex = 3;
            this.tab_nota.Text = "Nota";
            this.tab_nota.UseVisualStyleBackColor = true;
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(4, 6);
            this.txt_nota.Multiline = true;
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(800, 273);
            this.txt_nota.TabIndex = 0;
            // 
            // Frm_Abrir_Ordem_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 402);
            this.ControlBox = false;
            this.Controls.Add(this.tbc_Controle);
            this.Controls.Add(this.btn_abrir_ordem);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Abrir_Ordem_Servico";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Abrir_Ordem_Servico_Load);
            this.tab_servico.ResumeLayout(false);
            this.tab_servico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos_fazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).EndInit();
            this.tab_ordem.ResumeLayout(false);
            this.tab_ordem.PerformLayout();
            this.tab_veiculo.ResumeLayout(false);
            this.tab_veiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos)).EndInit();
            this.tbc_Controle.ResumeLayout(false);
            this.tab_nota.ResumeLayout(false);
            this.tab_nota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_abrir_ordem;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TabPage tab_servico;
        private System.Windows.Forms.DataGridView dgv_servicos_fazer;
        private System.Windows.Forms.DataGridView dgv_servicos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pesquisa_servico;
        private System.Windows.Forms.TabPage tab_ordem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_ano_fab;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.TextBox txt_obs_cliente;
        private System.Windows.Forms.TextBox txt_obs_avaria;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.TextBox txt_veiculo;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_combustivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tab_veiculo;
        private System.Windows.Forms.DataGridView dgv_veiculos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_pesquisa_veiculo;
        private System.Windows.Forms.TabControl tbc_Controle;
        private System.Windows.Forms.TabPage tab_nota;
        private System.Windows.Forms.TextBox txt_nota;
    }
}