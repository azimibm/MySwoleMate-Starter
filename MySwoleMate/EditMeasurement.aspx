<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="EditMeasurement.aspx.cs" Inherits="MySwoleMate.EditMeasurement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="first">
    <div class="container">
      <div class="row">
        <div class="col-xs-12 text-center">
          <h1>EDIT MEASUREMENT</h1>
        </div>
      </div>
      <div class="form-horizontal">
        <div class="form-group">
          <asp:Label ID="WeightLabel" runat="server" Text="Weight (lb)" AssociatedControlID="Weight" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:TextBox ID="Weight" runat="server" CssClass="form-control"></asp:TextBox>
            <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="WeightRequired" runat="server" ErrorMessage="Weight is Required" InitialValue="0" ControlToValidate="Weight" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
          </div>
        </div>
        <div class="form-group">
          <asp:Label ID="WaistLabel" runat="server" Text="Waist (in)" AssociatedControlID="Waist" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:TextBox ID="Waist" runat="server" CssClass="form-control"></asp:TextBox>
            <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="WaistRequired" runat="server" ErrorMessage="Waist is Required" InitialValue="0" ControlToValidate="Waist" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
          </div>
        </div>
        <div class="form-group">
          <asp:Label ID="BodyFatLabel" runat="server" Text="BodyFat (%)" AssociatedControlID="BodyFat" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:TextBox ID="BodyFat" runat="server" CssClass="form-control"></asp:TextBox>
            <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="BodyFatRequired" runat="server" ErrorMessage="BodyFat is Required" InitialValue="0" ControlToValidate="BodyFat" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
          </div>
        </div>
        <div class="form-group">
          <asp:Label ID="ChestLabel" runat="server" Text="Chest (in)" AssociatedControlID="Chest" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:TextBox ID="Chest" runat="server" CssClass="form-control"></asp:TextBox>
            <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="ChestRequired" runat="server" ErrorMessage="Chest is Required" InitialValue="0" ControlToValidate="Chest" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
          </div>
        </div>
        <div class="form-group">
          <asp:Label ID="UpperArmLabel" runat="server" Text="UpperArm (in)" AssociatedControlID="UpperArm" CssClass="col-xs-4 control-label"></asp:Label>
          <div class="col-xs-4">
            <asp:TextBox ID="UpperArm" runat="server" CssClass="form-control"></asp:TextBox>
            <div class="has-error">
              <span class="help-block">
                <asp:RequiredFieldValidator ID="UpperArmRequired" runat="server" ErrorMessage="UpperArm is Required" InitialValue="0" ControlToValidate="UpperArm" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
              </span>
            </div>
          </div>
        </div>
        <div class="form-group">
          <div class="col-xs-4 col-xs-offset-4">
            <asp:Button ID="MeasurementSubmitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="MeasurementSubmitButton_Click" ValidationGroup="AllValidators" />
            <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Progress.aspx" runat="server" Text="Back" />
          </div>
        </div>
      </div>
    </div>
  </section>
</asp:Content>
