using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trial2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            HttpCookieCollection cook = Request.Cookies;

            


            if (cook.Count > 0)
            {

                


                for(int i = 0; i < cook.Count; i++)
                {

                    ListBox1.Items.Add(cook[i].Value);

                }
            }

            
        }
        
    }
}