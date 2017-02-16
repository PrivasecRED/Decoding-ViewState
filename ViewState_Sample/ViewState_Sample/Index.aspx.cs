using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_Sample
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["UserName"] = "ZhluktenkoDmytro";
            ViewState["Password"] = "FairPassw0rd";
            
        }
    }
}