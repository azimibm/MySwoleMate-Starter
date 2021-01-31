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
  public partial class AddWorkout : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Add Workout to DB from user input form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void WorkoutAddButton_Click(object sender, EventArgs e)
    {
      //Checks to see if all Validation Controls are valid
      if (Page.IsValid)
      {
        //Grab connectionString from web.config file
        string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
        //Create new instance of WorkoutBLL
        WorkoutBLL bll = new WorkoutBLL(connectionString);
        //Create new instance of WorkoutViewModel with data from the user
        WorkoutViewModel workout = new WorkoutViewModel();
        //The Text property of each control will contain the data from the user
        workout.WorkoutName = WorkoutName.Text;
        workout.Exercise1 = Exercise1.Text;
        //Since the Text property returns a string, some properties would need to be converted
        workout.Exercise1Sets = Convert.ToInt32(Exercise1Sets.Text);
        workout.Exercise1Reps = Convert.ToInt32(Exercise1Reps.Text);
        workout.Exercise2 = Exercise2.Text;
        workout.Exercise2Sets = Convert.ToInt32(Exercise2Sets.Text);
        workout.Exercise2Reps = Convert.ToInt32(Exercise2Reps.Text); 
        workout.Exercise3 = Exercise3.Text;
        workout.Exercise3Sets = Convert.ToInt32(Exercise3Sets.Text);
        workout.Exercise3Reps = Convert.ToInt32(Exercise3Reps.Text);
        workout.Exercise4 = Exercise4.Text;
        workout.Exercise4Sets = Convert.ToInt32(Exercise4Sets.Text);
        workout.Exercise4Reps = Convert.ToInt32(Exercise4Reps.Text);
        workout.Exercise5 = Exercise5.Text;
        workout.Exercise5Sets = Convert.ToInt32(Exercise5Sets.Text);
        workout.Exercise5Reps = Convert.ToInt32(Exercise5Reps.Text);
       
        //Call the Business Logic method to add workout
        bll.AddWorkout(workout);
        //Return to the Workouts list after adding the workout to database
        Response.Redirect("~/Workout.aspx");
      }
    }
  }
}