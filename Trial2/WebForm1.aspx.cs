using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trial2
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        public static int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            


            int product = CalculateProduct();

            

            HttpCookie cook = new HttpCookie(i++.ToString() , product.ToString());
           
            
            

            Response.Cookies.Add(cook);
        }

        private int CalculateProduct()
        {
            
            int product = 0;

            try
            {
                
                int num1 = int.Parse(TextBox1.Text);
                int num2 = int.Parse(TextBox2.Text);

               
                for (int i = 0; i < num2; i++)
                {
                    product += num1;
                }

                Label3.Text = product.ToString();
            }
            catch (FormatException)
            {
                
                Label3.Text = "Error: Please enter valid integers.";
            }
            catch (OverflowException)
            {
                
                Label3.Text = "Error: The numbers are too large to be parsed to integers.";
            }

            return product;
        }
    }
        
    
}