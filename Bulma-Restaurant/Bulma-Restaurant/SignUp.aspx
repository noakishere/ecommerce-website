<%@ Page Title="Sign Up | Login" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Bulma_Restaurant.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Username"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Password"></asp:TextBox>
    <asp:Button ID="registerButton" runat="server" CssClass="btn btn-primary" Text="Register" OnClick="registerButton_Click" />  <asp:Button ID="loginButton" runat="server" CssClass="btn btn-success" Text="Login" OnClick="loginButton_Click" /> <br />
    <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
</asp:Content>
