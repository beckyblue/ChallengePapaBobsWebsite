using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total = 0.0;
        
                if (smallRadioButton.Checked)
                {
                    total = 10.0;
                }
                else if (mediumRadioButton.Checked)
                {
                    total = 13.0;
                }
                else
                {
                    total = 16.0;
                }
                if (deepRadioButton.Checked)
                    total = total + 2.0;
            
            
                total = (peperoniCheckBox.Checked) ? total + 1.5 : total;
                total = (onionsCheckBox.Checked) ? total + 0.75 : total;
                total = (greenPeppersCheckBox.Checked) ? total + 0.5 : total;
                total = (redPeppersCheckBox.Checked) ? total + 0.75 : total;
                total = (anchoviesCheckBox.Checked) ? total + 2.0 : total;

                if((peperoniCheckBox.Checked && greenPeppersCheckBox.Checked && anchoviesCheckBox.Checked) 
                    || (peperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked))
                {
                    total -= 2.0;
                }

              resultLabel.Text = "$" + total.ToString();
        
        }

    }
}