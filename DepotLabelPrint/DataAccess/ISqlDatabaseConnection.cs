using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;


namespace DepotLabelPrint.DataAccess
{
    public interface ISqlDatabaseConnection
    {
        MsSqlConnectionParameters DatabaseConnection { get; }

        SqlDataSource DataSource { get;  }
    }
}
