
namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    partial class Frm_Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Backup));
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btn_iniciar.FlatAppearance.BorderSize = 0;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_iniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iniciar.Location = new System.Drawing.Point(243, 117);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(62, 35);
            this.btn_iniciar.TabIndex = 62;
            this.btn_iniciar.TabStop = false;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(229, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Backup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_localizar);
            this.groupBox2.Controls.Add(this.txt_local);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(8, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 64);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // btn_localizar
            // 
            this.btn_localizar.BackColor = System.Drawing.Color.White;
            this.btn_localizar.FlatAppearance.BorderSize = 0;
            this.btn_localizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_localizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_localizar.Image")));
            this.btn_localizar.Location = new System.Drawing.Point(493, 24);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(35, 35);
            this.btn_localizar.TabIndex = 66;
            this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_localizar.UseVisualStyleBackColor = false;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // txt_local
            // 
            this.txt_local.Enabled = false;
            this.txt_local.Location = new System.Drawing.Point(6, 31);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(481, 22);
            this.txt_local.TabIndex = 1;
            this.txt_local.Text = "C:\\SIS_OFICINA\\BACKUP";
            this.txt_local.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Caminho";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(9, 117);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(35, 35);
            this.btn_voltar.TabIndex = 65;
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 164);
            this.ControlBox = false;
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Backup";
            this.Resizable = false;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_localizar;
    }
}