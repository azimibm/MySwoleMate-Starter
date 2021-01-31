<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MySwoleMate.About" %>
<%--About Page--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="about">
        <div class="container">
            <div class="row">
                <div class="col-xs-6 text-left">
                    <h1>About</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-6 text-left">
                    <p>
                        MySwoleMate is the consummate personal fitness application, the ultimate solution for anyone who wants instant access to professional, certified, personal trainers.<br />
                        MySwoleMate provides professional client management on an individual basis. 
                        <br />
                        The goal is to increase the number of clients a personal trainer can handle without giving up the one-on-one personal training that a personal trainer can provide.<br />
                        MySwoleMate is ideal for anyone who wants to get in shape without the hassle of finding a personal trainer!
                    </p>
                </div>
            </div>
        </div>
    </header>
</asp:Content>
