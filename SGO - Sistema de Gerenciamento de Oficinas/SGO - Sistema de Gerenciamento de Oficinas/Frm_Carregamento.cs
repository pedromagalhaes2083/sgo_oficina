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
using MetroFramework;
using BLL;


namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Carregamento : MetroForm
    {
        static Frm_Carregamento aguarde;
        Task task;
        string texto;
        public Frm_Carregamento(Task task, string texto = null)
        {
            this.task = task;
            InitializeComponent();
            this.texto = texto;
        }
        public Frm_Carregamento()
        {
            InitializeComponent();
        }

        private void Frm_Carregamento_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(texto))
                label1.Text = texto;
            timer1.Start();
            try
            {
                task.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void ShowBox(Task task, string texto = null)
        {
            aguarde = new Frm_Carregamento(task, texto);
            aguarde.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (task.IsCompleted)
                Close();
        }
    }
}
