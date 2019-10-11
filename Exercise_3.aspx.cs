using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class Exercise_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                
                if (Page.IsValid)
                {
                    ticket_summary.InnerHtml = "";
                    //gather information of value of number of ticket and store it in a variable
                    int x = Convert.ToInt32(ticket_value.Text);
                    //calculate final price
                    double total = x * (0.25);

                    //initialise leftover ticket to zero
                    int remainingTicket = 0;

                    //number of tickets under 50(including 50) are bundled individually
                    if (x <= 50)
                    {
                        for (int i = 1; i <= x; i++)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 1! That’s " + i + " ticket(s)! <br>";                        }                        remainingTicket = x % 1;
                    }
                    //number of tickets between 51(including 51) and 150(including 150) are bundled in sets of 2
                    else if (x > 50 && x <= 150)
                    {
                        for (int i = 2; i <= x; i += 2)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 2! That’s " + i + " ticket(s)! <br>";
                        }
                        remainingTicket = x % 2;
                    }
                    //number of tickets between 151(including 151) and 300(including 300) are bundled in sets of 3
                    else if (x > 150 && x <= 300)
                    {
                        for (int i = 3; i <= x; i += 3)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 3! That’s " + i + " ticket(s)! <br>";
                        }
                        remainingTicket = x % 3;
                    }
                    //number of tickets over 301(including 301) are bundled in sets of 5
                    else
                    {
                        for (int i = 5; i <= x; i += 5)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 5! That’s " + i + " ticket(s)! <br>";
                        }
                        remainingTicket = x % 5;
                    }


                    //check for remaining tickets
                    if(remainingTicket!=0)
                    {
                        ticket_summary.InnerHtml += "Your leftover is "+remainingTicket+" ticket(s). That’s "+x+" ticket(s)! <br>";
                    }
                    ticket_summary.InnerHtml += "<br> Your total ticket(s) is " + x + " and your cost is $" + total+" cad";


                }
             }

         }
    }
}