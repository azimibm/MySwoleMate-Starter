using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySwoleMate
{
  public partial class AssignWorkout : System.Web.UI.Page
  {
    TraineeBLL tbll = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        //using GetTraineeById method to get the Trainee from the database, which we use to 
        //populate the data into the form.
        TraineeViewModel trainee = tbll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));
        FullName.Text = trainee.FirstName + " " + trainee.LastName;

        WorkoutBLL wbll = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        List<WorkoutViewModel> workouts = wbll.GetAllWorkouts();
        
        WorkoutList.DataSource = workouts;
        WorkoutList.DataTextField = "WorkoutName";
        WorkoutList.DataValueField = "WorkoutID";
        WorkoutList.DataBind();
        WorkoutList.Items.Insert(0, "--Select an option--");
      }
    }

    protected void WorkoutAssignButton_Click(object sender, EventArgs e)
    {
      if (Page.IsValid)
      {
        TraineeViewModel trainee = tbll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));
        trainee.TraineeID = Convert.ToInt32(Request.QueryString["TraineeID"]);
        trainee.WorkoutID = Convert.ToInt32(WorkoutList.SelectedValue);
        tbll.AssignWorkout(trainee);
        Response.Redirect("~/Trainees.aspx");
      }
    }
  }
}