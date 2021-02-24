<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Scheduler.aspx.cs" Inherits="MySwoleMate.Scheduler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="first">
    <div class="container">
      <div class="row">
        <div class="col-xs-10">
          <h1>SCHEDULER</h1>
        </div>
        <div class="col-xs-2">
          <a href="~/AddSchedule.aspx" runat="server" class="btn btn-success">Add New Appointment</a>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-12 text-center">
          <asp:GridView ID="ScheduleList" runat="server" CssClass="table table-bordered text-left" AutoGenerateColumns="false" DataKeyNames="ScheduleID">
            <Columns>
              <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="ScheduleID" DataNavigateUrlFormatString="~/EditSchedule.aspx?ScheduleID={0}" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-CssClass="text-center" />
              <asp:TemplateField ItemStyle-CssClass="text-center">
                <ItemTemplate>
                  <asp:Button runat="server" ID="DeleteButton" CommandName="Delete" CssClass="btn btn-xs btn-default" Text="Delete" OnClientClick="if(!confirm('Are you sure you wish to delete this appointment?')) return false;" />
                </ItemTemplate>
              </asp:TemplateField>
              
              <asp:BoundField DataField="ScheduleDtTime" HeaderText="Appointment Date & Time" />
              <asp:BoundField DataField="InputDtTime" HeaderText="Last Modeified" />
              <asp:BoundField DataField="FirstName" HeaderText="First Name" />
              <asp:BoundField DataField="LastName" HeaderText="Last Name" />
              <asp:BoundField DataField="Email" HeaderText="E-Mail" />
              <asp:BoundField DataField="Height" HeaderText="Height" />
              <asp:BoundField DataField="CellNbr" HeaderText="Cell-Phone" />
              <asp:BoundField DataField="Gender" HeaderText="Gender" />
              <asp:BoundField DataField="Age" HeaderText="Age" />
              <asp:HyperLinkField Text="Enter Measurements" DataNavigateUrlFormatString="~/AddMeasurement.aspx?ScheduleID={0}" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-CssClass="text-center" />
            </Columns>
          </asp:GridView>
        </div>
      </div>
    </div>
  </section>
</asp:Content>
