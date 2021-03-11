<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Bulma_Restaurant.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .auto-style2 {
            position: fixed;
            left: 13px;
            top: 81px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style2">
        <asp:Panel ID="Panel2" runat="server" Height="51px">
            
            <h2 style="border-bottom: 1px solid black">Your Cart:</h2>
             <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label2" runat="server" Text="0.00" Visible="False"></asp:Label><br />
            <asp:Button ID="cartButton" runat="server" CssClass="btn btn-primary" Text="Go to Checkout" OnClick="cartButton_Click"/>
        </asp:Panel>
    </div>
    <asp:Panel ID="Panel1" runat="server" Height="51px">
        <h3 class="text-center">All orders over $25 ---> FREE SHIPPING!!</h3> <br />
    </asp:Panel>
    
    

</asp:Content>
