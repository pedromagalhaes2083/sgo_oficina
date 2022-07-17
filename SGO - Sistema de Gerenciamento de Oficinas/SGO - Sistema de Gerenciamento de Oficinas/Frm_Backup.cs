using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BLL;


namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Backup : MetroForm
    {
        public Frm_Backup()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            txt_local.Text = dialog.SelectedPath;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                new Frm_Carregamento(new Task(() => Backup.Backup_Banco(txt_local.Text)), "Preparando arquivo...").ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
