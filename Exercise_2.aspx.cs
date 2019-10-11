using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class Weekly_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //as oct 1st is tuesday add days in that order
            List<string> all_days = new List<string>();
            all_days.Add("Tuesday");
            all_days.Add("Wednesday");
            all_days.Add("Thursday");
            all_days.Add("Friday");
            all_days.Add("Saturday");
            all_days.Add("Sunday");
            all_days.Add("Monday");

            if (Page.IsPostBack)
            {
                Page.Validate();
               
                if (Page.IsValid)
                {
                    workday_summary.InnerHtml = "";
                    //loop for month
                    for (int i = 1; i < 32; i++)
                    {
                        //looping for weekdays
                        foreach (string weekday in all_days)
                        {
                            
                            foreach (ListItem weekdays in week_days.Items)
                            {
                                if (i >= 32)
                                {
                                    break;
                                }
                                if (weekday == weekdays.Value)
                                {
                                    //to check if the weekday is selected or not
                                    if (weekdays.Selected == true)
                                    {
                                        //display code for time to work
                                        workday_summary.InnerHtml += "Oct " + (i++) + " is a " + weekdays.Value +"!Time to work...."+ "<br>";
                                    }
                                    else
                                    {
                                        //display code for have fun
                                        workday_summary.InnerHtml += "Oct " + (i++) + " is a " + weekdays.Value +"!Time to have fun!"+"<br>";
                                    }
                                    break;
                                }
                            }
                        }
                        i--;
                    }
                }
            }
        }
    }
}