using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Face_Recogntition_Web
{
    public class StudentDBHelper
    {
        public static List<Dictionary<string, object>> findData()
        {
            string sql = "select stu.*,re.date,case when re.ID is null then 0 else 1 end isrecode from student stu left join recode re on re.uid = stu.ID";
            DataTable dt = new MysqlHelper().getMySqlRead(sql);
            return GetTableRows(dt);
        }

        private static List<Dictionary<string, object>> GetTableRows(DataTable dtData)
        {
            List<Dictionary<string, object>> lstRows = new List<Dictionary<string, object>>();
            Dictionary<string, object> dictRow = null;

            foreach (DataRow dr in dtData.Rows)
            {
                dictRow = new Dictionary<string, object>();
                foreach (DataColumn col in dtData.Columns)
                {
                    dictRow.Add(col.ColumnName, dr[col]);
                }
                lstRows.Add(dictRow);
            }
            return lstRows;
        }
    }
}

