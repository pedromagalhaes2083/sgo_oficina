
namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Cad_Registro_Servico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cad_Registro_Servico));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tab_cliente = new System.Windows.Forms.TabPage();
            this.tab_registro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_observacoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.mkt_valor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tab_main.SuspendLayout();
            this.tab_cliente.SuspendLayout();
            this.tab_registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
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
            this.btn_cadastrar.Location = new System.Drawing.Point(275, 388);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(119, 35);
            this.btn_cadastrar.TabIndex = 19;
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
            this.btn_voltar.Location = new System.Drawing.Point(5, 388);
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
            this.label5.Location = new System.Drawing.Point(244, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Novo Registro";
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tab_cliente);
            this.tab_main.Controls.Add(this.tab_registro);
            this.tab_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tab_main.Location = new System.Drawing.Point(5, 40);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(658, 342);
            this.tab_main.TabIndex = 20;
            this.tab_main.SelectedIndexChanged += new System.EventHandler(this.tab_resgistro_SelectedIndexChanged);
            // 
            // tab_cliente
            // 
            this.tab_cliente.Controls.Add(this.dgv_clientes);
            this.tab_cliente.Controls.Add(this.txt_pesquisa);
            this.tab_cliente.Controls.Add(this.label1);
            this.tab_cliente.Location = new System.Drawing.Point(4, 25);
            this.tab_cliente.Name = "tab_cliente";
            this.tab_cliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cliente.Size = new System.Drawing.Size(650, 313);
            this.tab_cliente.TabIndex = 0;
            this.tab_cliente.Text = "Cliente";
            this.tab_cliente.UseVisualStyleBackColor = true;
            // 
            // tab_registro
            // 
            this.tab_registro.Controls.Add(this.mkt_valor);
            this.tab_registro.Controls.Add(this.label6);
            this.tab_registro.Controls.Add(this.label4);
            this.tab_registro.Controls.Add(this.txt_observacoes);
            this.tab_registro.Controls.Add(this.label3);
            this.tab_registro.Controls.Add(this.dtp_data);
            this.tab_registro.Controls.Add(this.txt_descricao);
            this.tab_registro.Controls.Add(this.label2);
            this.tab_registro.Location = new System.Drawing.Point(4, 25);
            this.tab_registro.Name = "tab_registro";
            this.tab_registro.Padding = new System.Windows.Forms.Padding(3);
            this.tab_registro.Size = new System.Drawing.Size(650, 313);
            this.tab_registro.TabIndex = 1;
            this.tab_registro.Text = "Registro";
            this.tab_registro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(7, 24);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(311, 22);
            this.txt_pesquisa.TabIndex = 1;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(7, 53);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.Size = new System.Drawing.Size(638, 232);
            this.dgv_clientes.TabIndex = 2;
            this.dgv_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(6, 22);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(427, 22);
            this.txt_descricao.TabIndex = 1;
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.Location = new System.Drawing.Point(6, 66);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(639, 229);
            this.txt_observacoes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observações";
            // 
            // dtp_data
            // 
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(439, 22);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(102, 22);
            this.dtp_data.TabIndex = 4;
            // 
            // mkt_valor
            // 
            this.mkt_valor.Location = new System.Drawing.Point(547, 24);
            this.mkt_valor.Name = "mkt_valor";
            this.mkt_valor.Size = new System.Drawing.Size(100, 22);
            this.mkt_valor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor";
            // 
            // Frm_Cad_Registro_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 429);
            this.ControlBox = false;
            this.Controls.Add(this.tab_main);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label5);
            this.Name = "Frm_Cad_Registro_Servico";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Frm_Cad_Registro_Servico_Load);
            this.tab_main.ResumeLayout(false);
            this.tab_cliente.ResumeLayout(false);
            this.tab_cliente.PerformLayout();
            this.tab_registro.ResumeLayout(false);
            this.tab_registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tab_cliente;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_registro;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.TextBox txt_observacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkt_valor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}