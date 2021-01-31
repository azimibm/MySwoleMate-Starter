<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Workout.aspx.cs" Inherits="MySwoleMate.Workout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="first"> 
    <div class="container"> 
      <div class="row"> 
        <div class="col-xs-10"> 
          <h1>5-Step Workout list</h1> 
        </div> 
        <div class="col-xs-2"> 
          <!--an anchor tag is used to provide a link to another resource (either in the same application or outside)--> 
          <!--The ~ symbol is used as a relative URL path to specify the resource is in the same application root--> 
          <a href="~/AddWorkout.aspx" runat="server" class="btn btn-success">Add New Workout</a> 
        </div>
      </div>
      <div class="row"> 
        <div class="col-lg-12 text-center">
          <asp:GridView ID="WorkoutList" runat="server" CssClass="table table-bordered text-left" AutoGenerateColumns="false" OnRowDeleting="WorkoutList_RowDeleting" DataKeyNames="WorkoutID">
            <Columns>
              <%--We use HyperLinkField in order to create an Edit button which passes the TraineeID as a Query String
                                You can see the query string after the "?" in the DataNavigateUrlFormatString property.
                                Anything after the "?" is considered a query string, which you can use to pass information to one
                                page to another. We use the Query String to pass the TraineeID to the EditTrainee Page.
                                The DataNavigateUrlFormatString replaces the {0} with the DataNavigateUrlFields property, which in 
                                our case is the TraineeID--%>
              <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="WorkoutID" DataNavigateUrlFormatString="~/EditWorkout.aspx?WorkoutID={0}" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-CssClass="text-center" />
              <asp:TemplateField ItemStyle-CssClass="text-center">
                <ItemTemplate>
                  <%--The Delete functionality is --%>
                  <asp:Button runat="server" ID="DeleteButton" CommandName="Delete" CssClass="btn btn-xs btn-default" Text="Delete" OnClientClick="if(!confirm('Are you sure you wish to delete this workout?')) return false;" />
                </ItemTemplate>
              </asp:TemplateField>
              <asp:BoundField DataField="WorkoutName" HeaderText="Workout" />
              <asp:BoundField DataField="DisplayExercise1" HeaderText="Step1" />
              <asp:BoundField DataField="DisplayExercise2" HeaderText="Step2" />
              <asp:BoundField DataField="DisplayExercise3" HeaderText="Step3" />
              <asp:BoundField DataField="DisplayExercise4" HeaderText="Step4" />
              <asp:BoundField DataField="DisplayExercise5" HeaderText="Step5" />
            </Columns>
          </asp:GridView>
        </div>
      </div>
    </div>
  </section>
</asp:Content>
