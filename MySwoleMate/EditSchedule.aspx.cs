using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySwoleMate.BLL;
using MySwoleMate.Models;
using MySwoleMate.DAL;

namespace MySwoleMate
{
  public partial class EditSchedule : System.Web.UI.Page
  {
    // Accessing database using ADO.NET
    TraineeBLL tbll = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        ScheduleBLL scbll = new ScheduleBLL();
        Schedule sc = scbll.GetScheduleById(Convert.ToInt32(Request.QueryString["ScheduleID"]));
 
        // Loading the dropdownlist
        List<TraineeViewModel> trainees = tbll.GetAllTrainees();
        TraineeList.DataSource = trainees;
        TraineeList.DataTextField = "FirstName";
        TraineeList.DataValueField = "TraineeID";
        TraineeList.DataBind();
        TraineeList.Items.Insert(0, "--Select a trainee from the list--");
        TraineeList.SelectedValue = sc.TraineeID.ToString();
        DateOfAppointment.Text = sc.ScheduleDtTime.ToString("yyyy-MM-dd"); //The format has to be like this: "yyyy-mm-dd" otherwise it won't show in the browser
        //DateOfAppointment.Text = sc.DisplayScheduleDtTime.ToString();
        TimeOfAppointment.Text = sc.InputDtTime.ToString("HH:mm");
      }
    }

    protected void ScheduleAddButton_Click(object sender, EventArgs e)
    {
      if (Page.IsValid)
      {
        ScheduleBLL scbll = new ScheduleBLL();
        Schedule sc = scbll.GetScheduleById(Convert.ToInt32(Request.QueryString["ScheduleID"]));
        sc.ScheduleDtTime = System.DateTime.Parse(DateOfAppointment.Text);
        sc.InputDtTime = System.DateTime.Now;
        sc.TraineeID = Convert.ToInt32(TraineeList.SelectedValue);

        int res = scbll.EditSchedule(sc);
        
        if (res > 0)
        {
          Response.Redirect("http://localhost:54175/Scheduler.aspx");
        }
      }
    }
  }
}