using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    coordinate_summary.InnerHtml = "";
                    //get the value for x and y and store in variables

                    double X = Convert.ToDouble(x_value.Text);
                    double Y = Convert.ToDouble(y_value.Text);


                    //what if x and y both are +ve
                    //which quadrant they fall in

                    if (X > 0)
                    {
                        if (Y > 0)
                        {
                            coordinate_summary.InnerText += "(" + X + "," + Y + ")" + "falls in Quadrant I";
                        }
                        //what if x is +ve and y is -ve
                        else
                        {
                            coordinate_summary.InnerText += "(" + X + "," + Y + ")" + "falls in Quadrant IV";
                        }
                    }
                    //what if x is -ve and y is +ve
                    if (X<0)
                    { 
                        if (Y > 0)
                        {
                            coordinate_summary.InnerText += "(" + X + "," + Y + ")" + "falls in Quadrant II";
                        }
                        //what if x and y both are -ve
                        else
                        {
                            coordinate_summary.InnerText += "(" + X + "," + Y + ")" + "falls in Quadrant III";
                        }
                    }
                }
            }

        }

        //Validating inputs to assume that x and y are non-zero
        protected void xy_Validate(object sender, ServerValidateEventArgs e)
        {
            double xy = Convert.ToDouble(e.Value);

            if (xy != 0)
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }

        }
    }
}