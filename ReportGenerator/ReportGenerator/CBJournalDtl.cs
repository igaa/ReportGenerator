using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReportGenerator
{
    public class CBJournalDtl
    {
        public string dtl_guid { get; set; }
        public string hdr_guid { get; set; }
        public string coa { get; set; }
        public string coa_name { get; set; }
        public string nama_coa { get; set; }
        public string coa_description { get; set; }
        public string sub_account_type { get; set; }
        public string sub_account_id { get; set; }
        public string sub_account_detail_name { get; set; }
        public string sub_account_type2 { get; set; }
        public string sub_account_id2 { get; set; }
        public string sub_account_detail_name2 { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
        public string sub_dept { get; set; }
        public string persil { get; set; }
        public string customer { get; set; }
        public string supplier { get; set; }
        public string daftar_aktiva { get; set; }
        public string kode_alat { get; set; }
        public string kode_tanam { get; set; }
        public string remark { get; set; }
        public long cf_key { get; set; }
        public string cash_flow_no { get; set; }
        public string cf_name { get; set; }
        public string company_id { get; set; }
        public string created_by { get; set; }
        public string created_by_name { get; set; }
        public string created_by_position { get; set; }
        public DateTime created_date { get; set; }
        public string last_updated_by { get; set; }
        public string last_updated_by_name { get; set; }
        public string last_updated_by_position { get; set; }
        public DateTime last_updated_date { get; set; }
        public string computer { get; set; }
        public DateTime computer_date { get; set; }

    }

}
