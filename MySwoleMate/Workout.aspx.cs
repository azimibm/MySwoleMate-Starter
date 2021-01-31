using MySwoleMate.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySwoleMate
{
  public partial class Workout : System.Web.UI.Page
  {
    string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
    //MySwoleMateDataContext db = new MySwoleMateDataContext(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
    //Page Load event is where you do most of your data binding for any controls. Below you will see the code
    //for Data Binding the GridView with the list of workouts called WorkoutList.

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindData();
      }      
    }
    protected void WorkoutList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
      int workoutID = Convert.ToInt32(WorkoutList.DataKeys[e.RowIndex].Value.ToString());
      WorkoutBLL bll = new WorkoutBLL(connectionString);
      bll.DeleteWorkout(workoutID);
      BindData();
    }

    private void BindData()
    {
      WorkoutBLL workout = new WorkoutBLL(connectionString);
      WorkoutList.DataSource = workout.GetAllWorkouts();
      WorkoutList.DataBind();
    }
  }
}