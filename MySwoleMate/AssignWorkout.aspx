<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="AssignWorkout.aspx.cs" Inherits="MySwoleMate.AssignWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="first">
    <div class="container">
      <div class="row">
        <div class="col-xs-12 text-center">
          <h1>ASSIGN 5-STEP WORKOUT</h1> 
        </div> 
      </div>
      <div class="row">
        <div class="col-xs-12 text-center">
          <h3><asp:Literal ID="FullName" runat="server"></asp:Literal></h3>
        </div> 
      </div>
      <div class="form-Group">
        <div class="col-xs-8 col-xs-offset-2 text-center">
         <asp:DropDownList ID="WorkoutList" runat="server" CssClass="form-control" AppendDataBoundItems="true">
         </asp:DropDownList>
           <div class="has-error">
             <span class="help-block">
               <asp:RequiredFieldValidator ID="WorkoutListRequired" runat="server" ControlToValidate="WorkoutList" ErrorMessage="Workout is Required" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
             </span>
           </div>
          </div>
        </div>
      <div class="form-Group">
        <div class="col-xs-8 col-xs-offset-2 text-center">
          <asp:Button ID="WorkoutAssignButton" runat="server" Text="Assign Workout" CssClass="btn btn-success" OnClick="WorkoutAssignButton_Click" ValidationGroup="AllValidators" />
          <!--ASP.NET HyperLink Control is used as a Back button to go back to the Trainee.aspx page listing-->
          <asp:hyperlink cssclass="btn btn-default" navigateurl="~/Trainees.aspx" runat="server" text="Back" />
        </div>
      </div>
    </div>
  </section>
</asp:Content>
