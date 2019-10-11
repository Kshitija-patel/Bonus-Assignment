<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise_1.aspx.cs" Inherits="BonusAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #coordinate_summary{
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Co-ordinate values</h1>
            <section>
                Value of X:
                <asp:TextBox runat="server" ID="x_value"></asp:TextBox>
                    <section>
                        <asp:CustomValidator runat="server" ControlToValidate="x_value" OnServerValidate="xy_Validate" ErrorMessage="Value of x must not be 0"></asp:CustomValidator>
                    </section>    
                Value of Y:
                <asp:TextBox runat="server" ID="y_value"></asp:TextBox>
                    <section>
                        <asp:CustomValidator runat="server" ControlToValidate="y_value" OnServerValidate="xy_Validate" ErrorMessage="Value of y must not be 0"></asp:CustomValidator>
                    </section>
            </section>
           

            <section>
                <asp:Button runat="server" Text="Submit"/>
            </section>

            <div runat="server" id="coordinate_summary"></div>
  
       </div>
    </form>
</body>
</html>
