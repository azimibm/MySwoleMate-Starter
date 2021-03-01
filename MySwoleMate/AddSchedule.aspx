<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="AddSchedule.aspx.cs" Inherits="MySwoleMate.AddSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="first">
    <div class="container">
      <div class="row">
        <div class="col-xs-12 text-center">
          <h1>ADD SCHEDULE</h1>
        </div>
      </div>
      <div class="form-horizontal">
        <div class="form-group">
          <asp:Label ID="TraineeLabel" runat="server" Text="Trainee" AssociatedControlID="TraineeList" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:DropDownList ID="TraineeList" runat="server" CssClass="form-control">
              <asp:ListItem Value="0">--Select a Trainee--</asp:ListItem>
            </asp:DropDownList>
            <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="TraineeNameRequired" runat="server" ErrorMessage="Trainee Name is Required" InitialValue="0" ControlToValidate="TraineeList" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
          </div>
        </div>
        <div class="form-group">
          <asp:Label ID="DateOfAppointmentLabel" runat="server" Text="Date of Appointment" AssociatedControlID="DateOfAppointment" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:TextBox ID="DateOfAppointment" runat="server" CssClass="form-control" TextMode="Date">
            </asp:TextBox>
          </div>
          <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="DateOfAppointmentRequired" runat="server" ErrorMessage="Date of Appointment is Required" InitialValue="0" ControlToValidate="DateOfAppointment" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
        </div>
        <div class="form-group">
          <asp:Label ID="TimeOfAppointmentLabel" runat="server" Text="Time of Appointment" AssociatedControlID="TimeOfAppointment" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:TextBox ID="TimeOfAppointment" runat="server" CssClass="form-control" TextMode="Time">
           </asp:TextBox>
          </div>
          <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="TimeOfAppointmnetRequired" runat="server" ErrorMessage="Time of Appointment is Required" InitialValue="0" ControlToValidate="TimeOfAppointment" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
        </div>
        <div class="form-group">
          <div class="col-xs-4 col-xs-offset-4">
            <asp:Button ID="ScheduleAddButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="ScheduleAddButton_Click" ValidationGroup="AllValidators" />
            <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Scheduler.aspx" runat="server" Text="Back" />
          </div>
        </div>
      </div>
    </div>
  </section>
</asp:Content>
