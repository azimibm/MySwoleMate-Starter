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
  public partial class ViewWorkout : System.Web.UI.Page
  {
    TraineeBLL tbll = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
      TraineeViewModel trainee = tbll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));

      if (!IsPostBack)
      {  
        if (trainee.WorkoutID == 0)
        {
          NoWorkout.Text = "THERE IS NO WORKOUT ASSIGNED TO: \r\n" + trainee.FirstName + " " + trainee.LastName;
        } else {
          WorkoutBLL wbll = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());

          WorkoutViewModel workout = wbll.GetWorkoutById(Convert.ToInt32(trainee.WorkoutID));

          NoWorkout.Text = trainee.FirstName + " " + trainee.LastName;
          WorkoutName.Text = workout.WorkoutName;
          DisplayExercise1.Text = workout.DisplayExercise1;
          DisplayExercise2.Text = workout.DisplayExercise2;
          DisplayExercise3.Text = workout.DisplayExercise3;
          DisplayExercise4.Text = workout.DisplayExercise4;
          DisplayExercise5.Text = workout.DisplayExercise5;
        }
      }
    }
  }
}