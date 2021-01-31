<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Trainees.aspx.cs" Inherits="MySwoleMate.Trainees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-10">
                    <h1>Trainees List</h1>
                </div>
                <div class="col-xs-2">
                    <a href="~/AddTrainee.aspx" runat="server" class="btn btn-success">Add New Trainee</a>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:GridView ID="TraineeList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowDeleting="TraineeList_RowDeleting" DataKeyNames="TraineeID">
                        <Columns>
                            <%--We use HyperLinkField in order to create an Edit button which passes the TraineeID as a Query String
                                You can see the query string after the "?" in the DataNavigateUrlFormatString property.
                                Anything after the "?" is considered a query string, which you can use to pass information to one
                                page to another. We use the Query String to pass the TraineeID to the EditTrainee Page.
                                The DataNavigateUrlFormatString replaces the {0} with the DataNavigateUrlFields property, which in 
                                our case is the TraineeID--%>
                            <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="TraineeID"
                                DataNavigateUrlFormatString="~/EditTrainee.aspx?TraineeID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" />
                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <%--The Delete functionality is --%>
                                    <asp:Button runat="server" ID="DeleteButton" CommandName="Delete"
                                        CssClass="btn btn-xs btn-default" Text="Delete"
                                        OnClientClick="if(!confirm('Are you sure you wish to delete this trainee?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                            <asp:BoundField DataField="Email" HeaderText="E-Mail" />
                            <asp:BoundField DataField="DisplayHeight" HeaderText="Height" />
                            <asp:BoundField DataField="Weight" HeaderText="Weight (lbs)" />
                            <asp:BoundField DataField="DisplayCellNbr" HeaderText="Cell #" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:HyperLinkField Text="AssignWorkout" DataNavigateUrlFields="TraineeID"
                                DataNavigateUrlFormatString="~/AssignWorkout.aspx?TraineeID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" />
                            <asp:HyperLinkField Text="ViewWorkout" DataNavigateUrlFields="TraineeID"
                                DataNavigateUrlFormatString="~/ViewWorkout.aspx?TraineeID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
