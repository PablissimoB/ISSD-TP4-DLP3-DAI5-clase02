using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase2
{
    public partial class VerID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/archivo.txt");
                string[] lines = (streamReader.ReadToEnd()).Split('\n');
                streamReader.Close();
                int lineCount = 0;
                int lineReg = 0;
                foreach (string line in lines)
                {
                    lineCount++;
                    if (lineCount % 3 == 0)
                    {
                        lineReg++;
                        ListItem item = new ListItem();
                        item.Text = lineReg.ToString();
                        item.Value = lineReg.ToString();
                        DropDownList1.Items.Add(item);
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text= string.Empty;
            StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/archivo.txt");
            string[] lines = (streamReader.ReadToEnd()).Split('\n');
            streamReader.Close();
            int opcion = int.Parse(DropDownList1.SelectedItem.Text);
            int lineCount = 0;
            foreach (string line in lines)
            {
                lineCount++;
                if (lineCount == (opcion*3 ))
                {
                    Label1.Text += $"{lines[lineCount-3].ToString()} ";
                    Label1.Text += $"{lines[lineCount - 2].ToString()} ";
                    Label1.Text += $"{lines[lineCount - 1].ToString()} ";
                }
            }

        }
    }
}