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
                Sql = "SELECT customercode, customername FROM si_sop_customers WHERE master_customer='msho' and active=-1 and customer_type='D' and payment_type=2"
            };

            return query;
        }

        public CustomSqlQuery QuerySSCCList(string customerCode, string depotDate)
        {
            QueryParameter parameter = new QueryParameter
            {
                Name = "@CustomerCode",
                Type = typeof(string),
                Value = customerCode
            };

            QueryParameter dateParameter = new QueryParameter
            {
                Name = "@DepotDate",
                Type = typeof(string),
                Value = depotDate
            };

            CustomSqlQuery query = new CustomSqlQuery()
            {
                Name = "SSCCList",
                Sql = "select sscc, orderpallet from DEA2153_Customer_DeliveryDate_sscc where customer = @CustomerCode and requested_delivery = @DepotDate"
            };

            query.Parameters.Add(parameter);
            query.Parameters.Add(dateParameter);

            return query;
        }
    }
}
