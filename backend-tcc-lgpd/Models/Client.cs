using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_tcc_lgpd.Models
{
    public class Client
    {
        public string client_id { get; set; }
        public string status { get; set; }
        public int age { get; set; }
        public char gender { get; set; }
        public int dependent_count { get; set; }
        public string education_Level { get; set; }
        public string marital_Status { get; set; }
        public string income_category { get; set; }
        public string card_category { get; set; }
        public int mounths_active { get; set; }
        public int credit_limit { get; set; }
        public int credit_remaining { get; set; }
        public int credit_usage { get; set; }
        public int total_trans_amt { get; set; }
        public int total_trans_ct { get; set; }
        public int avg_utilization_ratio { get; set; }
    }
}
