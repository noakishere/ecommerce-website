<%@ Page Title="Bulma Restaurant" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Bulma_Restaurant.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="Images/banner.jpg" class="img-fluid" style="width:100%;" alt="...">

    <div class="card-group">
      <div class="card">
        <h5 class="card-title">Japanese authenticity</h5>
        <img src="Images/thumbnail01.jpg" class="card-img-top" alt="...">
        <div class="card-body">
          <h6>Spend a weekend with us</h6>
          <p class="card-text">
              Have the best meals with us !
          </p>
          <a href="#" id="homeButtons" class="btn btn-warning">More</a>
        </div>
      </div>
      <div class="card">
        <h5 class="card-title">Best Time to Visit</h5>
        <img src="Images/thumbnail02.jpg" class="card-img-top" alt="...">
        <div class="card-body">
          <h6>Amazing deals</h6>
          <p class="card-text">
              Lorem Ipsum Lorem Ipsum Lorem Ipsum v Lorem Ipsum
          </p>
          <a href="#" id="homeButtons" class="btn btn-warning">More</a>
        </div>
      </div>
      <div class="card">
        <h5 class="card-title">Beautiful Restaurant</h5>
        <img src="Images/thumbnail03.jpg" class="card-img-top" alt="...">
        <div class="card-body">
          <h6>Explore Japan's unique culture</h6>
          <p class="card-text">
              Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum Lorem Ipsum v Lorem Ipsum
          </p> 
          <a href="#" id="homeButtons" class="btn btn-warning">More</a>
        </div>
      </div>
    </div>
</asp:Content>
