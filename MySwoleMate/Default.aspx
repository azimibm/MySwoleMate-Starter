<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySwoleMate.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="mainCarousel" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#mainCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#mainCarousel" data-slide-to="1"></li>
            <li data-target="#mainCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="Images/gym2.jpg" alt="Gym Image 1" />
                <div class="carousel-caption">
                    <h1 class="title">MySwoleMate</h1>
                    <h1>Your Soul Mate to get SWOLE</h1>
                </div>
            </div>
            <div class="item">
                <img src="Images/gym1.jpg" alt="Gym Image 2" />
                <div class="carousel-caption">
                    <h1>Personal Access to Your Trainees</h1>
                    <p>
                        Instant access to all of your Trainees, with a click of a button!
                    </p>
                    <p>
                        <a href="~/Trainees.aspx" runat="server" class="btn btn-lg btn-success">Go To Trainees List</a>
                    </p>
                </div>
            </div>
            <div class="item">
                <img src="Images/weights.jpg" alt="Weight Image 1" />
                <div class="carousel-caption">
                    <h1>Personalized 5-STEP Workout Plan</h1>
                    <p>Create personalized 5-Step Workout Plans for all of your Trainees and assign them to your Trainees! MySwoleMate is is the only app you will need to get your trainees SWOLE.</p>
                    <p>
                        <a href="~/Workout.aspx" runat="server" class="btn btn-lg btn-success">Create a Workout</a>
                    </p>
                </div>
            </div>
        </div>
        <a class="left carousel-control" href="#mainCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#mainCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <section class="success">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h2>Personal Access to Your Trainees</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <p>
                        Instant access to all of your Trainees, with a click of a button!
                    </p>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <br />
                    <a href="~/Trainees.aspx" runat="server" class="btn btn-lg btn-outline">Go To Trainees List</a>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h2>Personalized 5-Step Workout Plans</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <p>Create personalized 5-Step Workout Plans for all of your Trainees and assign them to your Trainees! MySwoleMate is is the only app you will need to get your trainees SWOLE.</p>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <br />
                    <a href="~/Workout.aspx" runat="server" class="btn btn-lg btn-success">Create a Workout</a>
                </div>
            </div>
        </div>
    </section>
    <section class="success">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h2>Want to know more about us?</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <br />
                    <a href="~/About.aspx" runat="server" class="btn btn-lg btn-outline">About</a>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
