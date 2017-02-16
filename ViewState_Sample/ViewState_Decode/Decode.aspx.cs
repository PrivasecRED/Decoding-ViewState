using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_Decode
{
    public partial class Decode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDecode_Click(object sender, EventArgs e)
        {
            //txtViewState.Text = "/wEPDwULLTE2MTY2ODcyMjkPFgQeCFVzZXJOYW1lBRBaaGx1a3RlbmtvRG15dHJvHghQYXNzd29yZAUMRmFpclBhc3N3MHJkZGTYg3KYdvKzt3ruNAH5muYXjCqiqe2DHke0TR3Egw/wBQ==";
            string str = System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(txtViewState.Text));
            lblDecodedString.Text = str;
        }
    }
}