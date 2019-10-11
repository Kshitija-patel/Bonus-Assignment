<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise_2.aspx.cs" Inherits="BonusAssignment.Weekly_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Select the days of your work:</p>
            <asp:CheckBoxList runat="server" ID="week_days">
                <asp:ListItem Value="Monday">Monday</asp:ListItem>
                <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="Friday">Friday</asp:ListItem>
                <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>

            <section>
                <asp:Button runat="server" Text="Submit"/>
            </section>

              <div runat="server" id="workday_summary"></div>
        </div>
    </form>
</body>
</html>
