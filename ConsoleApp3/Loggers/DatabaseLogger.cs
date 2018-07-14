using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace CodersLab.DependencyInjection
{
    class DatabaseLogger : ILogger
    {
	    public void Log(string message)
	    {
		    var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

		    var db = new SqlConnection("Data source=.;Initial catalog=CodersLab;Integrated security=true");
			var sql = new SqlCommand($"INSERT INTO dbo.Logs (Date, Message) VALUES ('{now}', '{message}')", db);

		    db.Open();

		    sql.ExecuteNonQuery();

			db.Close();
	    }
    }
}
