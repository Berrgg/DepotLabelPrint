using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Sql;

namespace DepotLabelPrint.DataAccess
{
    public class MySqlQuery
    {
        public CustomSqlQuery QueryDepotList()
        {
            CustomSqlQuery query = new CustomSqlQuery
            {
                Name = "DepotList",
                Sql = "SELECT customername FROM si_sop_customers WHERE master_customer='msho' and active=-1 and customer_type='D' and payment_type=2"
            };

            return query;
        }
    }
}
