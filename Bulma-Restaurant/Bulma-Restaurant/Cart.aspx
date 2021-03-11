<%@ Page Title="Cart" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Bulma_Restaurant.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server" Text="Label" ID="answer"></asp:Label>
        <br />
        <asp:Label runat="server" Text="" ID="priceLabel"></asp:Label>
        <br />
        <asp:Label runat="server" Text="" ID="deliveryAmount"></asp:Label>
        <br />
        <asp:TextBox runat="server" CssClass="form-control" ID="nameTextBox" placeholder="Name"></asp:TextBox>
        <asp:TextBox runat="server" CssClass="form-control" ID="addressTextBox" placeholder="Address"></asp:TextBox> <br />
        <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" OnClick="Button1_Click" Text="Place Order" />
    </div>
    
</asp:Content>
