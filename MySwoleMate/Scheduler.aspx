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
          <div>
            <table class="table table-bordered text-left" cellspacing="0" rules="all" border="1" id="ScheduleList" style="border-collapse:collapse;">
              <tbody>
                <tr>
                  <th scope="col">&nbsp;</th>
                  <th scope="col">&nbsp;</th>
                  <th scope="col">Appoinment Date & Time</th>
                  <th scope="col">Trainee Name</th>
                  <th scope="col">Last Modified</th>
                  <th scope="col">&nbsp;</th>
                </tr>
                <tr class="warning">
                  <td class="text-center">
                    <a class="btn btn-success btn-xs" href="EditSchedule.aspx?ScheduleID="8">Edit</a>
                  </td>
                  <td class="text-center">
                    <input type="submit" name="DeleteButton" value="Delete" onclick="if(!confirm('Are you sure you wish to delete this appointment?')) return false;" id="DeleteButton0" class="btn btn-xs btn-default"/>
                  </td>
                  <td class="value">9/4/2016 11:00 PM</td>
                  <td>Christopher Chen</td>
                  <td>9/4/2016 10:58 PM</td>
                  <td class="text-center"></td>
                </tr>
                <tr class="warning">
			            <td class="text-center"><a class="btn btn-success btn-xs" href="EditSchedule.aspx?ScheduleID=16">Edit</a>
			            </td>
                  <td class="text-center">
                    <input type="submit" name="ctl00$ContentPlaceHolder1$ScheduleList$ctl03$DeleteButton" value="Delete" onclick="if(!confirm('Are you sure you wish to delete this appointment?')) return false;" id="DeleteButton" class="btn btn-xs btn-default"/>
                  </td>
                  <td class="value">9/10/2016 2:05 AM</td>
                  <td>Doug Stow</td>
                  <td>9/10/2016 2:03 AM</td>
                  <td class="text-center"></td>
		            </tr>
                <tr class="warning">
			            <td class="text-center"><a class="btn btn-success btn-xs" href="EditSchedule.aspx?ScheduleID=27">Edit</a>
			            </td>
                  <td class="text-center">
                    <input type="submit" name="ctl00$ContentPlaceHolder1$ScheduleList$ctl12$DeleteButton" value="Delete" onclick="if(!confirm('Are you sure you wish to delete this appointment?')) return false;" id="DeleteButton1" class="btn btn-xs btn-default"/>
                  </td>
                  <td class="value">11/12/2019 8:30 PM</td>
                  <td>Christopher Chen</td>
                  <td>11/12/2019 8:29 PM</td>
                  <td class="text-center">
                    <a class="btn btn-success btn-xs" href="AddMeasurement.aspx?ScheduleID=27">Enter Measurements</a>
                  </td>
		            </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </section>
</asp:Content>
