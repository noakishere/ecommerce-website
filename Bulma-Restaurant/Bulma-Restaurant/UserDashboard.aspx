<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserDashboard.aspx.cs" Inherits="Bulma_Restaurant.UserDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> <br /><br />
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark" Text="Logout" OnClick="Button1_Click" /> <br /><br />
    <asp:Button ID="Button3" runat="server" CssClass="btn btn-info" Text="Edit account" OnClick="Button3_Click" /> &nbsp; 
    <asp:TextBox ID="userNameTextBox" runat="server" Visible="False" placeholder="Username"></asp:TextBox> &nbsp; 
    <asp:TextBox ID="pswrdTextBox" runat="server" Visible="False" placeholder="Password"></asp:TextBox> &nbsp;  
    <asp:Button ID="confirmBtn" runat="server" CssClass="btn btn-success" Text="Confirm" OnClick="confirmBtn_Click" Visible="False" /> &nbsp; 
    <asp:Button ID="cancelBtn" runat="server" CssClass="btn btn-secondary" Text="Cancel" OnClick="cancelBtn_Click" Visible="False" /> <br /><br />
    <asp:Button ID="Button2" runat="server" CssClass="btn btn-danger" Text="Delete Account" OnClick="Button2_Click" /> <br /><br />
    <h5 style="border-top: 1px solid black;">Order history:</h5>
    <div class="text-center">
        
        <asp:GridView align="center" ID="GridView1" runat="server" CssClass="table table-striped">
        </asp:GridView>
    </div>
    

</asp:Content>
