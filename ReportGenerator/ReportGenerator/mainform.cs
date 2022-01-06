using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGenerator
{
    public partial class mainform : Form
    {
        private List<CBJournalDtl> _listCBdetail = new List<CBJournalDtl>();

        private Repo_CBJournalParams param; 
        public mainform()
        {
            InitializeComponent();
            
        }

        private void mainform_Load(object sender, EventArgs e)
        {

            this._reportViewer.RefreshReport();
        }

        private Repo_CBJournalParams _set_param()
        {
            param = new Repo_CBJournalParams();

            param.site = 1;
            param.tanggal = DateTime.Now;
            param.company_id = "RSUP";
            param.currency_asal = "IDR";
            param.trans_type = "transType";
            param.date2 = DateTime.Now;
            param.reff_no = "00090";
            param.cash_bank_code = "1.0.00909";
            param.cash_bank_name = "KAS BESAR";
            param.from_to = "MANDIRI";
            param.coa = "COA";
            param.nama_coa = "Nama COA";
            param.terbilang = "Seratus Ribu";
            param.currency_id = "IDR";
            param.currency_rate = 1; 
            param.amount_cb = 2000000;
            param.disetujui = "TEST ";
            param.disetujui_jabatan = "TEST 2";
            param.diketahui = "TEst 3";
            param.diketahui_jabatan = "test 4";
            param.diperiksa = "test 5";
            param.diperiksa_jabatan = "test 6";
            param.dibayar = "test 7";
            param.dibayar_jabatan = "test 8";
            param.diterima = "testg 9";
            param.diterima_jabatan = "test 10";

            return param; 
        }
        private void _generate_Click(object sender, EventArgs e)
        {
            int line = 8; 

            int site = 1;

            for (int y = 0; y < line; y++)
            {
                _listCBdetail.Add(new CBJournalDtl
                {
                    dtl_guid = string.Empty
                });
            }

            PageSettings pg = new PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 20;
            pg.Margins.Left = 10;
            pg.Margins.Right = 10;
            pg.Landscape = true;
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.Custom;
            size.Height = 950;
            size.Width = 650;
            pg.PaperSize = size;

            _reportViewer.SetPageSettings(pg);

            _reportViewer.SetDisplayMode(DisplayMode.PrintLayout);

            _reportViewer.LocalReport.DisplayName = "Test";
            _reportViewer.ZoomMode = ZoomMode.Percent;
            _reportViewer.ZoomPercent = 100;

            param = _set_param(); 

            var parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter("site", param.site.ToString()));
            parameters.Add(new ReportParameter("tanggal", DateTime.Now.ToString("dd/MM/yyyy")));
            parameters.Add(new ReportParameter("company_id", param.company_id));
            parameters.Add(new ReportParameter("currency_rate", param.currency_rate.ToString()));
            parameters.Add(new ReportParameter("currency_id", param.currency_id));
            parameters.Add(new ReportParameter("currency_asal", param.currency_asal));
            parameters.Add(new ReportParameter("trans_type", param.currency_asal));
            parameters.Add(new ReportParameter("reff_no", param.reff_no));
            parameters.Add(new ReportParameter("cash_bank_code", param.cash_bank_code));
            parameters.Add(new ReportParameter("cash_bank_name", param.cash_bank_name));
            parameters.Add(new ReportParameter("from_to", param.from_to));
            parameters.Add(new ReportParameter("coa", param.coa));
            parameters.Add(new ReportParameter("nama_coa", param.nama_coa));
            parameters.Add(new ReportParameter("terbilang", param.terbilang));
            parameters.Add(new ReportParameter("date2", param.date2.ToString()));
            parameters.Add(new ReportParameter("amount_cb", param.amount_cb.ToString()));
            parameters.Add(new ReportParameter("dibayar", param.dibayar));
            parameters.Add(new ReportParameter("dibayar_jabatan", param.dibayar_jabatan));
            parameters.Add(new ReportParameter("diketahui", param.diketahui));
            parameters.Add(new ReportParameter("diketahui_jabatan", param.diketahui_jabatan));
            parameters.Add(new ReportParameter("diperiksa", param.diperiksa));
            parameters.Add(new ReportParameter("diperiksa_jabatan", param.diperiksa_jabatan));
            parameters.Add(new ReportParameter("disetujui", param.disetujui));
            parameters.Add(new ReportParameter("disetujui_jabatan", param.disetujui_jabatan));
            parameters.Add(new ReportParameter("diterima", param.diterima));
            parameters.Add(new ReportParameter("diterima_jabatan", param.diterima_jabatan));

            _reportViewer.LocalReport.SetParameters(parameters);


            ReportDataSource datasource = new ReportDataSource("ListCBJournal", _listCBdetail);
            _reportViewer.LocalReport.DataSources.Clear();
            _reportViewer.LocalReport.DataSources.Add(datasource);
            _reportViewer.RefreshReport(); 
            

        }
    }
}
