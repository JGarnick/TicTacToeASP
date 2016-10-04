<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Tic Tac Toe</title>
    <style type="text/css">
        .auto-style1 {
            width: 170px;
        }
        .auto-style2 {
            width: 170px;
            height: 161px;
        }
        .auto-style3 {
            height: 161px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <p style="width: 174px; margin-left: 160px">
            <asp:Image ID="TitleImage" runat="server" ImageUrl="~/Images/ttt.jpg" Width="153px" />
        </p>
        <asp:Table runat="server" style="width: 38%; height: 481px;">
            <asp:TableRow>
                <asp:TableCell style="border: solid red 1px;" CssClass="auto-style1">
                    <asp:ImageButton ID="Image1" runat="server" BorderColor="Red" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image1_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
                <asp:TableCell style="border: solid red 1px;" CssClass="auto-style2">
                    <asp:ImageButton ID="Image2" runat="server" BorderColor="Red" Height="152px" ImageUrl="~/Images/blank.jpg" Width="164px" OnClick="Image2_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
                <asp:TableCell style="border: solid red 1px;" CssClass="auto-style3">
                    <asp:ImageButton ID="Image3" runat="server" BorderColor="Red" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image3_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell style="border:solid red 1px;" CssClass="auto-style1">
                    <asp:ImageButton ID="Image4" runat="server" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image4_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
                <asp:TableCell style="border:solid red 1px;" CssClass="auto-style2">
                    <asp:ImageButton ID="Image5" runat="server" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image5_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
                <asp:TableCell style="border:solid red 1px;" CssClass="auto-style3">
                    <asp:ImageButton ID="Image6" runat="server" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image6_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell style="border:solid red 1px;" CssClass="auto-style1">
                    <asp:ImageButton ID="Image7" runat="server" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image7_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
                <asp:TableCell style="border:solid red 1px;" CssClass="auto-style2">
                    <asp:ImageButton ID="Image8" runat="server" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image8_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
                <asp:TableCell style="border:solid red 1px;" CssClass="auto-style3">
                    <asp:ImageButton ID="Image9" runat="server" Height="152px" ImageUrl="~/Images/blank.jpg" Width="163px" OnClick="Image9_Click" ViewStateMode="Enabled" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p style="width: 166px; margin-left: 160px;">
            <asp:Label ID="results" runat="server" BorderColor="Black"></asp:Label>
        </p>

    </form>
</body>
</html>
