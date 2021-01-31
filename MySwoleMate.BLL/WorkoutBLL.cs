using MySwoleMate.DAL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.BLL
{
  public class WorkoutBLL
  {
    //Instance of the Data Access Layer class for Workouts
    private WorkoutDAL data;

    //Constructor that accepts a connectionString from the Presentation Layer,
    //Use the connectionString to pass into a new instance of the Data Access Layer class
    //WorkoutDAL
    public WorkoutBLL(string connectionString)
    {
      data = new WorkoutDAL(connectionString);
    }

    //Gets all Trainees in a List of WorkoutViewModel
    public List<WorkoutViewModel> GetAllWorkouts()
    {      
      List<WorkoutViewModel> workouts = data.GetWorkouts();
      return workouts;
    }

    //Returns ViewModel of Workout by the Id
    public WorkoutViewModel GetWorkoutById(int id)
    {
      return data.GetWorkoutById(id);
    }

    //Edits the Workout accepting a WorkoutViewModel
    public int EditWorkout(WorkoutViewModel edit)
    {
      return data.EditWorkout(edit);
    }

    //Adds a new Workout
    public int AddWorkout(WorkoutViewModel add)
    {
      return data.AddWorkout(add);
    }

    //Deletes a workout by the Id, Delete only needs the id of Workout
    public int DeleteWorkout(int id)
    {
      return data.DeleteWorkout(id);
    }
  }
}
 