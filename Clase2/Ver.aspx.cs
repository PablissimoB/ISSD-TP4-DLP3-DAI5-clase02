using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase2
{
    public partial class Ver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath(".") + "/archivo.txt"))
            {
                StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/archivo.txt");
                string[] lines = (streamReader.ReadToEnd()).Split('\n');
                streamReader.Close();
                Label1.Text = "<hr>";
                int lineCount = 0;

                foreach (string line in lines)
                {
                    lineCount++;
                    if (lineCount%3 ==0)
                    {
                        Label1.Text += $"{line} <br/>";
                        Label1.Text += "<hr>";
                    }
                    else
                    {
                        Label1.Text += $"{line} <br/>";
                    }

                }
            }
            else
            {
                Label1.Text = "No existen datos";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}