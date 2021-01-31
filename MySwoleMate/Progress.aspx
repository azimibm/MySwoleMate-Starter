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
          <div>
            <table class="table table-bordered text-left" cellspacing="0" rules="all" border="1" id="TraineeList" style="border-collapse: collapse;">
              <tbody>
                <tr>
                  <th scope="col">&nbsp;</th>
                  <th scope="col">Progress Tracker</th>
                </tr>
                <tr>
                  <td class="text-center">
                    <a class="btn btn-success btn-xs" href="EditTrainee.aspx?TraineeID=2">Christopher Chen</a>
                  </td>
                  <td>
                    <div>
                      <table class="table table-bordered text-left progress" cellspacing="0" rules="all" border="1" id="ProgressTracker_0" style="border-collapse: collapse;">
                        <tbody>
                          <tr>
                            <th scope="col">&nbsp;</th>
                            <th scope="col">Date & Time of Appointment</th>
                            <th scope="col">Weight (lbs)</th>
                            <th scope="col">Waist</th>
                            <th scope="col">Body Fat %</th>
                            <th scope="col">Chest (in)</th>
                            <th scope="col">Upper Arm (in)</th>
                          </tr>
                          <tr>
                            <td class="text-center">
                              <a class="btn btn-success btn-xs" href="EditMeasurement.aspx?ID=5">Edit</a>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_ScheduledDT_0">9/4/2016 11:00 PM</span>
                            </td>
                            <td class="value">
                              <span id="ProgressTracker_0_Weight_0">60</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_Waist_0">30</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_BodyFat_0">3</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_Chest_0">30</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_UpperArm_0">16</span>
                            </td>
                          </tr>
                          <tr class="info">
                            <td class="text-center">
                              <a class="btn btn-success btn-xs" href="EditMeasurement.aspx?ID=6">Edit</a>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_ScheduledDT_1">8/30/2017 6:30 PM</span>
                            </td>
                            <td class="value">
                              <span id="ProgressTracker_0_Weight_1">100</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_Waist_1">23</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_BodyFat_1">1</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_Chest_1">25</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_0_UpperArm_1">16</span>
                            </td>
                          </tr>
                        </tbody>
                      </table>
                    </div>
                  </td>
                </tr>
                <tr>
                  <td class="text-center">
                    <a class="btn btn-success btn-xs" href="EditTrainee.aspx?TraineeID=3">Manny Storey</a>
                  </td>
                  <td>
                    <div>
                      <table class="table table-bordered text-left progress" cellspacing="0" rules="all" border="1" id="ProgressTracker_1" style="border-collapse: collapse;">
                        <tbody>
                          <tr>
                            <th scope="col">&nbsp;</th>
                            <th scope="col">Date & Time of Appointment</th>
                            <th scope="col">Weight (lbs)</th>
                            <th scope="col">Waist</th>
                            <th scope="col">Body Fat %</th>
                            <th scope="col">Chest (in)</th>
                            <th scope="col">Upper Arm (in)</th>
                          </tr>
                          <tr>
                            <td class="text-center">
                              <a class="btn btn-success btn-xs" href="EditMeasurement.aspx?ID=9">Edit</a>
                            </td>
                            <td>
                              <span id="ProgressTracker_1_ScheduledDT_0">9/4/2016 11:00 PM</span>
                            </td>
                            <td class="value">
                              <span id="ProgressTracker_1_Weight_0">60</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_1_Waist_0">30</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_1_BodyFat_0">3</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_1_Chest_0">30</span>
                            </td>
                            <td>
                              <span id="ProgressTracker_1_UpperArm_0">16</span>
                            </td>
                          </tr>
                        </tbody>
                      </table>
                    </div>
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
