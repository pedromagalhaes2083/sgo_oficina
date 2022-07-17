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
using Microsoft.Reporting.WinForms;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Relatorio : MetroForm
    {
        public Frm_Relatorio(string nomeRelatorio)
        {
            InitializeComponent();
            this.nomeRelatorio = nomeRelatorio;
        }
        public Frm_Relatorio(string nomeRelatorio, DataTable table)
        {
            InitializeComponent();
            this.nomeRelatorio = nomeRelatorio;
            this.dt_table = table;
        }
        string nomeRelatorio;
        DataTable dt_table;
        private void Frm_Relatorio_Load(object sender, EventArgs e)
        {
         //   reportViewer.LocalReport.ReportEmbeddedResource = nomeRelatorio;
            if(string.Compare(nomeRelatorio, "nota_ordem_servico.rdlc") == 0 && dt_table.Rows.Count > 0)
            {
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.dt_table));
             //   rreportViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
            }
            this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer.ZoomMode = ZoomMode.Percent;
            this.reportViewer.ZoomPercent = 100;
            this.reportViewer.RefreshReport();
        }
        private void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            if (e.ReportPath == "Sub_Servicos_Ordem.rdlc")
            {
                e.DataSources.Add(new ReportDataSource("Servicos", dt_table));
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
