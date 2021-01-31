<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="AddTrainee.aspx.cs" Inherits="MySwoleMate.AddTrainee" %>
<%--Add Trainee Form--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Add Trainee</h1>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"
                        AssociatedControlID="FirstName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="FirstName" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="FirstNameRequired" runat="server" ErrorMessage="First Name is Required"
                                    ControlToValidate="FirstName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="LastNameLabel" runat="server" Text="Last Name"
                        AssociatedControlID="LastName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="LastName" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="LastNameRequired" runat="server" ErrorMessage="Last Name is Required"
                                    ControlToValidate="LastName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="EmailLabel" runat="server" Text="E-Mail"
                        AssociatedControlID="Email" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Email" runat="server" CssClass="form-control" TextMode="Email" MaxLength="50"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ErrorMessage="Email is Required"
                                    ControlToValidate="Email" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="HeightLabel" runat="server" Text="Height (inches)"
                        AssociatedControlID="Height" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Height" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="HeightRequired" runat="server" ErrorMessage="Height is Required"
                                    ControlToValidate="Height" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="HeightValidator" runat="server" ControlToValidate="Height" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="100"
                                    ErrorMessage="Please enter a number representing Height of trainee (inches)" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="WeightLabel" runat="server" Text="Weight (lbs)"
                        AssociatedControlID="Weight" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Weight" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="WeightRequired" runat="server" ErrorMessage="Weight is Required"
                                    ControlToValidate="Weight" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="WeightValidator" runat="server" ControlToValidate="Weight" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="500"
                                    ErrorMessage="Please enter a number representing Weight of trainee (lbs)" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="CellLabel" runat="server" Text="Cell Phone # (Numbers only)"
                        AssociatedControlID="CellNbr" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="CellNbr" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="CellNbrRequired" runat="server" ErrorMessage="Cell Phone # is Required"
                                    ControlToValidate="CellNbr" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="CellNbrValidator" runat="server" ControlToValidate="CellNbr" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="2000000000" MaximumValue="9999999999"
                                    ErrorMessage="Please enter a valid US Cell Phone Number, only numbers please no hyphens (ex: xxxxxxxxxx)" Type="String"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="GenderLabel" runat="server" Text="Gender"
                        AssociatedControlID="Gender" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:DropDownList ID="Gender" runat="server" CssClass="form-control">
                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                            <asp:ListItem Value="M">Male</asp:ListItem>
                            <asp:ListItem Value="F">Female</asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="GenderRequired" runat="server" ErrorMessage="Gender is Required" InitialValue="0"
                                    ControlToValidate="Gender" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="AgeLabel" runat="server" Text="Age"
                        AssociatedControlID="Age" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Age" runat="server" CssClass="form-control" TextMode="Number" MaxLength="3"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="AgeRequired" runat="server" ErrorMessage="Age is Required"
                                    ControlToValidate="Age" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="AgeValidator" runat="server" ControlToValidate="Age" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="130"
                                    ErrorMessage="Please enter a valid Age in Years" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <asp:Button ID="TraineeAddButton" runat="server" Text="Submit" CssClass="btn btn-success"
                            OnClick="TraineeAddButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Trainees.aspx" runat="server" Text="Back" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>