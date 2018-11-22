<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPageApp.aspx.cs" Inherits="WebPageApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebSiteApp</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td >
                        <asp:Label class="col-md-4" ID="CustomerName" runat="server" Text="CustomerName"></asp:Label>
                    </td>
                    <td >
                         <asp:TextBox ID="TextBoxCustomerName" runat="server" OnTextChanged="TextBoxCustomerName_TextChanged"></asp:TextBox>                        
                    </td>
                </tr>
                <tr>
                    <td >
                       <asp:Label class="col-md-4" ID="CustomerEmail" runat="server" Text="CustomerEmail"></asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="TextBoxCustomerEmail" runat="server" OnTextChanged="TextBoxCustomerEmail_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>

                </tr>                
            </table>
                <td >
                    <asp:Button ID="btnInsertUpdate" runat="server" Text="InsertOrUpdate" OnClick="btnInsertUpdate_Click" />
                </td>
                <td >
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                </td>
            <div>
                <asp:Label ID="LabelQueryStatus" runat="server" Text=" "></asp:Label>
            </div>
            
        </div>
    </form>
</body>
</html>
