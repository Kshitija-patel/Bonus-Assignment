<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise_3.aspx.cs" Inherits="BonusAssignment.Exercise_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Raffle Bundle</h1>
        <div>
            Enter number of tickets ordered:
            <asp:TextBox runat="server" ID="ticket_value"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="ticket_value"></asp:RequiredFieldValidator>

            <section>
                <asp:Button runat="server" Text="Submit"/>
            </section>

            <div runat="server" id="ticket_summary"></div>
        </div>

    </form>
</body>
</html>
