<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="ViewWorkout.aspx.cs" Inherits="MySwoleMate.ViewWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="first">
    <div class="container">
      <div class="row">
        <div class="col-xs-12">
          <h1>5-STEP WORKOUT</h1>
          <h1 class="text-center"><asp:Literal ID="NoWorkout" runat="server"></asp:Literal></h1>
        </div> 
      </div>
      <div class="row">
        <div class="col-lg-12 text-center">
          <h2><asp:Literal ID="WorkoutName" runat="server"></asp:Literal></h2>
          <h3><asp:Literal ID="DisplayExercise1" runat="server"></asp:Literal></h3>
          <h3><asp:Literal ID="DisplayExercise2" runat="server"></asp:Literal></h3>
          <h3><asp:Literal ID="DisplayExercise3" runat="server"></asp:Literal></h3>
          <h3><asp:Literal ID="DisplayExercise4" runat="server"></asp:Literal></h3>
          <h3><asp:Literal ID="DisplayExercise5" runat="server"></asp:Literal></h3>
        </div> 
      </div>
      <div class="row">
        <div class="col-xs-8 col-xs-offset-2 text-center">
          <asp:hyperlink cssclass="btn btn-success" navigateurl="~/AssignWorkout.aspx" runat="server" text="Assign Workout" />
          <asp:hyperlink cssclass="btn btn-default" navigateurl="~/Trainees.aspx" runat="server" text="Back" />
        </div>
      </div>
    </div>
  </section>
</asp:Content>
