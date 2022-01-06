using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class Repo_CBJournalParams
    {
        public int site { get; set; }
        public DateTime tanggal
        {
            get; set;
        }
        public string company_id { get; set; }
        public string currency_asal { get; set; }
        public string trans_type { get; set; }
        public DateTime? date2 { get; set; }
        public string reff_no { get; set; }
        public string cash_bank_code { get; set; }
        public string cash_bank_name { get; set; }
        public string from_to { get; set; }
        public string coa { get; set; }
        public string nama_coa { get; set; }
        public string terbilang { get; set; }
        public string currency_id { get; set; }
        public decimal currency_rate { get; set; }
        public decimal amount_cb { get; set; }
        public string disetujui { get; set; }
        public string disetujui_jabatan { get; set; }
        public string diketahui { get; set; }
        public string diketahui_jabatan { get; set; }
        public string diperiksa { get; set; }
        public string diperiksa_jabatan { get; set; }
        public string dibayar { get; set; }
        public string dibayar_jabatan { get; set; }
        public string diterima { get; set; }
        public string diterima_jabatan { get; set; }
    }
}
