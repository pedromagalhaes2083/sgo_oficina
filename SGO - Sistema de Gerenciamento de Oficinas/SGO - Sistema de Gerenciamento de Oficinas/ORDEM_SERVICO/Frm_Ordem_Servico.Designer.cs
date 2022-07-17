
namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Ordem_Servico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordem_Servico));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_ordem = new System.Windows.Forms.TabPage();
            this.txt_data_abertura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_combustivel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_ano_fab = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_veiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_responsavel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tab_servico = new System.Windows.Forms.TabPage();
            this.btn_andamento = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_pecas = new System.Windows.Forms.Button();
            this.btn_aguardar = new System.Windows.Forms.Button();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.dgv_servicos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_recalcular = new System.Windows.Forms.Button();
            this.txt_estimado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_orcamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_emitir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_ordem.SuspendLayout();
            this.tab_servico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(8, 410);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 17;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(306, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ordem - Serviços";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ordem);
            this.tabControl1.Controls.Add(this.tab_servico);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(6, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 369);
            this.tabControl1.TabIndex = 19;
            // 
            // tab_ordem
            // 
            this.tab_ordem.Controls.Add(this.txt_data_abertura);
            this.tab_ordem.Controls.Add(this.label10);
            this.tab_ordem.Controls.Add(this.txt_combustivel);
            this.tab_ordem.Controls.Add(this.label7);
            this.tab_ordem.Controls.Add(this.txt_nota);
            this.tab_ordem.Controls.Add(this.label6);
            this.tab_ordem.Controls.Add(this.txt_placa);
            this.tab_ordem.Controls.Add(this.label3);
            this.tab_ordem.Controls.Add(this.label12);
            this.tab_ordem.Controls.Add(this.txt_marca);
            this.tab_ordem.Controls.Add(this.txt_ano_fab);
            this.tab_ordem.Controls.Add(this.txt_cor);
            this.tab_ordem.Controls.Add(this.label4);
            this.tab_ordem.Controls.Add(this.label5);
            this.tab_ordem.Controls.Add(this.txt_veiculo);
            this.tab_ordem.Controls.Add(this.label1);
            this.tab_ordem.Controls.Add(this.txt_responsavel);
            this.tab_ordem.Controls.Add(this.label11);
            this.tab_ordem.Location = new System.Drawing.Point(4, 25);
            this.tab_ordem.Name = "tab_ordem";
            this.tab_ordem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ordem.Size = new System.Drawing.Size(809, 340);
            this.tab_ordem.TabIndex = 0;
            this.tab_ordem.Text = "Ordem";
            this.tab_ordem.UseVisualStyleBackColor = true;
            // 
            // txt_data_abertura
            // 
            this.txt_data_abertura.Enabled = false;
            this.txt_data_abertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_data_abertura.Location = new System.Drawing.Point(462, 22);
            this.txt_data_abertura.Name = "txt_data_abertura";
            this.txt_data_abertura.ReadOnly = true;
            this.txt_data_abertura.Size = new System.Drawing.Size(125, 22);
            this.txt_data_abertura.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(459, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 73;
            this.label10.Text = "Abertura";
            // 
            // txt_combustivel
            // 
            this.txt_combustivel.Enabled = false;
            this.txt_combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_combustivel.Location = new System.Drawing.Point(724, 22);
            this.txt_combustivel.Name = "txt_combustivel";
            this.txt_combustivel.ReadOnly = true;
            this.txt_combustivel.Size = new System.Drawing.Size(79, 22);
            this.txt_combustivel.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(3, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 71;
            this.label7.Text = "Nota";
            // 
            // txt_nota
            // 
            this.txt_nota.Enabled = false;
            this.txt_nota.Location = new System.Drawing.Point(6, 111);
            this.txt_nota.Multiline = true;
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.ReadOnly = true;
            this.txt_nota.Size = new System.Drawing.Size(797, 223);
            this.txt_nota.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(721, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Combustível";
            // 
            // txt_placa
            // 
            this.txt_placa.Enabled = false;
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_placa.Location = new System.Drawing.Point(593, 22);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.ReadOnly = true;
            this.txt_placa.Size = new System.Drawing.Size(125, 22);
            this.txt_placa.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(590, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Placa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(662, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Marca";
            // 
            // txt_marca
            // 
            this.txt_marca.Enabled = false;
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_marca.Location = new System.Drawing.Point(665, 67);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(138, 22);
            this.txt_marca.TabIndex = 64;
            // 
            // txt_ano_fab
            // 
            this.txt_ano_fab.Enabled = false;
            this.txt_ano_fab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_ano_fab.Location = new System.Drawing.Point(550, 67);
            this.txt_ano_fab.Name = "txt_ano_fab";
            this.txt_ano_fab.ReadOnly = true;
            this.txt_ano_fab.Size = new System.Drawing.Size(109, 22);
            this.txt_ano_fab.TabIndex = 62;
            // 
            // txt_cor
            // 
            this.txt_cor.Enabled = false;
            this.txt_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_cor.Location = new System.Drawing.Point(411, 67);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.ReadOnly = true;
            this.txt_cor.Size = new System.Drawing.Size(133, 22);
            this.txt_cor.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(547, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ano Fab.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(408, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Cor";
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Enabled = false;
            this.txt_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_veiculo.Location = new System.Drawing.Point(6, 67);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.ReadOnly = true;
            this.txt_veiculo.Size = new System.Drawing.Size(399, 22);
            this.txt_veiculo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Veículo";
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.Enabled = false;
            this.txt_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_responsavel.Location = new System.Drawing.Point(6, 22);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.ReadOnly = true;
            this.txt_responsavel.Size = new System.Drawing.Size(450, 22);
            this.txt_responsavel.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Responsável";
            // 
            // tab_servico
            // 
            this.tab_servico.Controls.Add(this.btn_andamento);
            this.tab_servico.Controls.Add(this.btn_cancel);
            this.tab_servico.Controls.Add(this.btn_pecas);
            this.tab_servico.Controls.Add(this.btn_aguardar);
            this.tab_servico.Controls.Add(this.btn_concluir);
            this.tab_servico.Controls.Add(this.dgv_servicos);
            this.tab_servico.Controls.Add(this.groupBox1);
            this.tab_servico.Location = new System.Drawing.Point(4, 25);
            this.tab_servico.Name = "tab_servico";
            this.tab_servico.Padding = new System.Windows.Forms.Padding(3);
            this.tab_servico.Size = new System.Drawing.Size(809, 340);
            this.tab_servico.TabIndex = 1;
            this.tab_servico.Text = "Serviços";
            this.tab_servico.UseVisualStyleBackColor = true;
            // 
            // btn_andamento
            // 
            this.btn_andamento.BackColor = System.Drawing.Color.White;
            this.btn_andamento.FlatAppearance.BorderSize = 0;
            this.btn_andamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_andamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_andamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_andamento.Image = ((System.Drawing.Image)(resources.GetObject("btn_andamento.Image")));
            this.btn_andamento.Location = new System.Drawing.Point(727, 28);
            this.btn_andamento.Name = "btn_andamento";
            this.btn_andamento.Size = new System.Drawing.Size(35, 35);
            this.btn_andamento.TabIndex = 81;
            this.btn_andamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_andamento.UseVisualStyleBackColor = false;
            this.btn_andamento.Click += new System.EventHandler(this.btn_andamento_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(604, 29);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(35, 35);
            this.btn_cancel.TabIndex = 80;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_pecas
            // 
            this.btn_pecas.BackColor = System.Drawing.Color.White;
            this.btn_pecas.FlatAppearance.BorderSize = 0;
            this.btn_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pecas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pecas.Image = ((System.Drawing.Image)(resources.GetObject("btn_pecas.Image")));
            this.btn_pecas.Location = new System.Drawing.Point(645, 25);
            this.btn_pecas.Name = "btn_pecas";
            this.btn_pecas.Size = new System.Drawing.Size(35, 35);
            this.btn_pecas.TabIndex = 79;
            this.btn_pecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pecas.UseVisualStyleBackColor = false;
            this.btn_pecas.Click += new System.EventHandler(this.btn_pecas_Click);
            // 
            // btn_aguardar
            // 
            this.btn_aguardar.BackColor = System.Drawing.Color.White;
            this.btn_aguardar.FlatAppearance.BorderSize = 0;
            this.btn_aguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aguardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_aguardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_aguardar.Image")));
            this.btn_aguardar.Location = new System.Drawing.Point(686, 29);
            this.btn_aguardar.Name = "btn_aguardar";
            this.btn_aguardar.Size = new System.Drawing.Size(35, 35);
            this.btn_aguardar.TabIndex = 78;
            this.btn_aguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aguardar.UseVisualStyleBackColor = false;
            this.btn_aguardar.Click += new System.EventHandler(this.btn_aguardar_Click);
            // 
            // btn_concluir
            // 
            this.btn_concluir.BackColor = System.Drawing.Color.White;
            this.btn_concluir.FlatAppearance.BorderSize = 0;
            this.btn_concluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_concluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_concluir.Image")));
            this.btn_concluir.Location = new System.Drawing.Point(768, 29);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(35, 35);
            this.btn_concluir.TabIndex = 20;
            this.btn_concluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_concluir.UseVisualStyleBackColor = false;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // dgv_servicos
            // 
            this.dgv_servicos.AllowUserToAddRows = false;
            this.dgv_servicos.AllowUserToDeleteRows = false;
            this.dgv_servicos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicos.Location = new System.Drawing.Point(6, 66);
            this.dgv_servicos.Name = "dgv_servicos";
            this.dgv_servicos.ReadOnly = true;
            this.dgv_servicos.Size = new System.Drawing.Size(797, 268);
            this.dgv_servicos.TabIndex = 77;
            this.dgv_servicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_recalcular);
            this.groupBox1.Controls.Add(this.txt_estimado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_orcamento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 57);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // btn_recalcular
            // 
            this.btn_recalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_recalcular.FlatAppearance.BorderSize = 0;
            this.btn_recalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recalcular.ForeColor = System.Drawing.Color.White;
            this.btn_recalcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_recalcular.Image")));
            this.btn_recalcular.Location = new System.Drawing.Point(244, 16);
            this.btn_recalcular.Name = "btn_recalcular";
            this.btn_recalcular.Size = new System.Drawing.Size(35, 35);
            this.btn_recalcular.TabIndex = 82;
            this.btn_recalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recalcular.UseVisualStyleBackColor = false;
            this.btn_recalcular.Click += new System.EventHandler(this.btn_recalcular_Click);
            // 
            // txt_estimado
            // 
            this.txt_estimado.Enabled = false;
            this.txt_estimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_estimado.Location = new System.Drawing.Point(145, 29);
            this.txt_estimado.Name = "txt_estimado";
            this.txt_estimado.ReadOnly = true;
            this.txt_estimado.Size = new System.Drawing.Size(94, 22);
            this.txt_estimado.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(142, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 77;
            this.label9.Text = "Estimado (Hrs)";
            // 
            // txt_orcamento
            // 
            this.txt_orcamento.Enabled = false;
            this.txt_orcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_orcamento.Location = new System.Drawing.Point(6, 29);
            this.txt_orcamento.Name = "txt_orcamento";
            this.txt_orcamento.ReadOnly = true;
            this.txt_orcamento.Size = new System.Drawing.Size(133, 22);
            this.txt_orcamento.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Orçamento";
            // 
            // btn_emitir
            // 
            this.btn_emitir.BackColor = System.Drawing.Color.Crimson;
            this.btn_emitir.Enabled = false;
            this.btn_emitir.FlatAppearance.BorderSize = 0;
            this.btn_emitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emitir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_emitir.Image = ((System.Drawing.Image)(resources.GetObject("btn_emitir.Image")));
            this.btn_emitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emitir.Location = new System.Drawing.Point(704, 410);
            this.btn_emitir.Name = "btn_emitir";
            this.btn_emitir.Size = new System.Drawing.Size(119, 35);
            this.btn_emitir.TabIndex = 20;
            this.btn_emitir.Text = "Emitir Nota";
            this.btn_emitir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_emitir.UseVisualStyleBackColor = false;
            this.btn_emitir.Click += new System.EventHandler(this.btn_emitir_Click);
            // 
            // Frm_Ordem_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 454);
            this.ControlBox = false;
            this.Controls.Add(this.btn_emitir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Ordem_Servico";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Ordem_Servico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_ordem.ResumeLayout(false);
            this.tab_ordem.PerformLayout();
            this.tab_servico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_ordem;
        private System.Windows.Forms.TabPage tab_servico;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_veiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_ano_fab;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Button btn_aguardar;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.DataGridView dgv_servicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_estimado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_orcamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_pecas;
        private System.Windows.Forms.TextBox txt_combustivel;
        private System.Windows.Forms.TextBox txt_data_abertura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_andamento;
        private System.Windows.Forms.Button btn_recalcular;
        private System.Windows.Forms.Button btn_emitir;
    }
}