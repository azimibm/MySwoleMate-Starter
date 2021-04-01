<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Progress.aspx.cs" Inherits="MySwoleMate.Progress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="first">
    <div class="container">
      <div class="row">
        <div class="col-xs-10">
          <h1>PROGRESS TRACKER</h1>
        </div>
        <div class="col-xs-2">
        </div>
      </div>
      <div class="row">
        <div class="col-lg-12 text-center">
          <asp:GridView ID="ProgressListParent" runat="server" CssClass="table table-bordered text-left" AutoGenerateColumns="false" DataKeyNames="TraineeID" OnRowDataBound="ProgressList_RowDataBound">
            <Columns>
              <asp:HyperLinkField DataTextField="FirstName" runat="server" DataNavigateUrlFields="TraineeID" DataNavigateUrlFormatString="~/EditTrainee.aspx?TraineeID={0}" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-CssClass="text-center"/>
              <asp:TemplateField HeaderText="Progress Tracker">
                <ItemTemplate>
                  <asp:GridView ID="ProgressListChild" runat="server" CssClass="table table-bordered text-left Benji" AutoGenerateColumns="false" DataKeyNames="TraineeID">
                      <Columns>
                        <asp:HyperLinkField Text="Edit" runat="server" DataNavigateUrlFields="MeasurementID" DataNavigateUrlFormatString="~/EditMeasurement.aspx?MeasurementID={0}" ControlStyle-CssClass="btn btn-success btn-xs behavior" ItemStyle-CssClass="text-center"/>
                        <asp:BoundField runat="server" DataField="ScheduleDtTime" HeaderText="Appointment Date and Time"/>
                        <asp:BoundField runat="server" DataField="Weight" HeaderText="Weight(lb)"/>
                        <asp:BoundField runat="server" DataField="Waist" HeaderText="Waist(in)" />
                        <asp:BoundField runat="server" DataField="BodyFat" HeaderText="Body Fat %" />
                        <asp:BoundField runat="server" DataField="Chest" HeaderText="Chest(in)" />
                        <asp:BoundField runat="server" DataField="UpperArm" HeaderText="Upper Arm(in)"/>
                      </Columns>
                  </asp:GridView>
                </ItemTemplate>
              </asp:TemplateField>
            </Columns>
          </asp:GridView>
        </div>
      </div>
    </div>
  </section>
  <script src="https://code.jquery.com/jquery-2.1.4.min.js" type="text/javascript"></script>
  <script>
    $(document).ready(function () {
      $("#<%=ProgressListParent.ClientID%> > tbody > tr").each(function () {
        var childGridRows = $(this).find(".Benji > tbody > tr.saharCssClass");
        if (childGridRows.length > 1) {
          childGridRows.each(function () {
            var currentweight = $(this).find("td:eq(2)").html();
            var prevWeight = $(this).prev().find("td:eq(2)").html();
            if (prevWeight != null) {
              if (parseInt(currentweight) > parseInt(prevWeight)) {
                this.classList.add("alert-warning");
              } else if (parseInt(currentweight) < parseInt(prevWeight)) {
                this.classList.add("alert-info");
                // The Progress Tracker Listing should apply the "warning" CSS class if the weight of the Trainee increases from the previous Measurement, and apply the "info" CSS class if the weight of the Trainee decreases from the previous measurement.
              }
            }
          });
        }
      });
    });
  </script>
</asp:Content>
