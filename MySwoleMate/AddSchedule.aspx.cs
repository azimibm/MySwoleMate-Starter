using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.UI;


namespace MySwoleMate
{
  public partial class AddSchedule : System.Web.UI.Page
  {
    // Accessing database using ADO.NET
    TraineeBLL tbll = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        // retrieve data from database and populate it into the drodown list
        List<TraineeViewModel> trainees = tbll.GetAllTrainees();
        TraineeList.DataSource = trainees;
        TraineeList.DataTextField = "FirstName";
        TraineeList.DataValueField = "TraineeID";
        TraineeList.DataBind();
        TraineeList.Items.Insert(0, "--Select a trainee from the list--");
      }
    }
    protected void ScheduleAddButton_Click(object sender, EventArgs e)
    {
      if (Page.IsValid)
      {
        Schedule sc = new Schedule();
        sc.ScheduleDtTime = System.DateTime.Parse(DateOfAppointment.Text);
        sc.InputDtTime = System.DateTime.Now;
        sc.TraineeID = Convert.ToInt32(TraineeList.SelectedValue);

        int res = -1;
        using (MySwoleMateEntities db = new MySwoleMateEntities())
        {
          ScheduleBLL scbll = new ScheduleBLL();
          res = scbll.AddSchedule(sc);
        }
        if (res > 0)
        {
          Response.Redirect("http://localhost:54175/Scheduler.aspx");
        } 
      }
    }
  }
}