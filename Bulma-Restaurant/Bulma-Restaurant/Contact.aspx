<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Bulma_Restaurant.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <div id="myContact" class="container">
      <div class="row">
        <div class="col">
            <div id="info">
                <h6>ADDRESS:</h6>

                <p><i class="fa fa-home" style="color:orangered;"></i> 138 Atlantis Ln Kingsport Illinois 12164</p>

                <h6>PHONES:</h6>

                <p>
                   <i class="fa fa-phone" style="color:orangered;"></i> 800-2345-6789
                </p>
                <p>
                   <i class="fa fa-fax" style="color:orangered;"></i> 800-2345-6789
                </p>

                <h6>E-MAIL:</h6>

                <i class="fa fa-envelope" style="color:orangered;"></i><a href="mailto:mail@demolinkg.org"> mail@demolink.org</a>
                <p>
                    Download newsletter here: <a href="#">PDF</a>
                </p>
            </div>
            
        </div>
        <div class="col">
            <div>
                <h6>MISCELLANEUOUS INFORMATION:</h6>

                <p>
                    Email us with any questions, complaints or inquiries or use our contact data.
                </p>
                
                <div class="row">
                    <div class="col">
                        <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
                    </div>
                    <div class="col">
                        <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
                    </div>
                    <div class="col">
                        <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control" placeholder="Phone"></asp:TextBox>  
                    </div>
                </div>
                <br />

                <asp:TextBox ID="messageTextBox" runat="server" CssClass="form-control" placeholder="Message" Rows="3" Height="100px"></asp:TextBox>
                <br />

                <div class="row">
                    <div class="col">
                        <asp:Button ID="SendButton" runat="server" Text="Send" CssClass="btn btn-warning" OnClick="SendButton_Click" />
                    </div>
                    <div class="col">
                        <asp:Button ID="Clear" runat="server" Text="Clear" CssClass="btn btn-warning" OnClick="Clear_Click"/>
                    </div>

                    <div class="col"></div>
                    <div class="col"></div>
                    <div class="col"></div>
                    <div class="col"></div>
                    

                    <asp:Label ID="ResultLabel" runat="server"></asp:Label>
                </div>
                
            </div>
        </div>
      </div>
    </div>

</asp:Content>
