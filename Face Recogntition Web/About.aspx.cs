using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Face_Recogntition_Web;
using MySql.Data.MySqlClient;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = StudentDBHelper.findData();

        foreach (var item in data)
        {
            item["imgstr"] = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])(item["Image"]));
        }

        var data_str = Newtonsoft.Json.JsonConvert.SerializeObject(data);

        Response.Write(data_str);
        Response.ContentType = "application/json";
        Response.End();
    }

    
}