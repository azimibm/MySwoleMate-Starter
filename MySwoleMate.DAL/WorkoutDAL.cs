using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.DAL
{
  //DAL stands for Data Access Layer. Data Access Layer is the layer which communicates to the database.
  public class WorkoutDAL
  {
    //uses connection string for connecting to database
    private string _connectionString;

    public WorkoutDAL(string connectionString)
    {
      _connectionString = connectionString;
    }

    //Returns All Workouts
    public List<WorkoutViewModel> GetWorkouts()
    {
      //SQL command for selecting all from Workout table
      string sqlQuery = "SELECT * FROM Workout";

      //Empty list of WorkoutViewModel to add and return
      List<WorkoutViewModel> workouts = new List<WorkoutViewModel>();

      //Using SqlConnection to establish connection to database
      //using SqlCommand passing in the SqlConnection and the sqlQuery
      using (SqlConnection con = new SqlConnection(_connectionString))
      using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
      {
        //open the connection
        con.Open();
        //SqlDataReader is used because we are reading data from the database
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            //store each value into the properties of WorkoutViewModel
            WorkoutViewModel temp = new WorkoutViewModel()
            {
              WorkoutID = Convert.ToInt32(reader["WorkoutID"]),
              WorkoutName = reader["WorkoutName"].ToString(),
              Exercise1 = reader["Exercise1"].ToString(),
              Exercise1Reps = Convert.ToInt32(reader["Exercise1Reps"]),
              Exercise1Sets = Convert.ToInt32(reader["Exercise1Sets"]),
              Exercise2 = reader["Exercise2"].ToString(),
              Exercise2Reps = Convert.ToInt32(reader["Exercise2Reps"]),
              Exercise2Sets = Convert.ToInt32(reader["Exercise2Sets"]),
              Exercise3 = reader["Exercise3"].ToString(),
              Exercise3Reps = Convert.ToInt32(reader["Exercise3Reps"]),
              Exercise3Sets = Convert.ToInt32(reader["Exercise3Sets"]),
              Exercise4 = reader["Exercise4"].ToString(),
              Exercise4Reps = Convert.ToInt32(reader["Exercise4Reps"]),
              Exercise4Sets = Convert.ToInt32(reader["Exercise4Sets"]),
              Exercise5 = reader["Exercise5"].ToString(),
              Exercise5Reps = Convert.ToInt32(reader["Exercise5Reps"]),
              Exercise5Sets = Convert.ToInt32(reader["Exercise5Sets"])
            };
            //Add the workout object to the list of Workouts
            workouts.Add(temp);
          }
        }
      }
      return workouts;
    }

    //Get Workout By Id, returns one instance of WorkoutViewModel
    //Very similar to GetWorkouts() method above
    public WorkoutViewModel GetWorkoutById(int id)
    {
      WorkoutViewModel workout = new WorkoutViewModel();
      string sqlQuery = "SELECT * FROM Workout WHERE WorkoutID=@ID";

      using (SqlConnection con = new SqlConnection(_connectionString))
      using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
      {
        con.Open();
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            workout.WorkoutID = Convert.ToInt32(reader["WorkoutID"]);
            workout.WorkoutName = reader["WorkoutName"].ToString();
            workout.Exercise1 = reader["Exercise1"].ToString();
            workout.Exercise1Reps = Convert.ToInt32(reader["Exercise1Reps"]);
            workout.Exercise1Sets = Convert.ToInt32(reader["Exercise1Sets"]);
            workout.Exercise2 = reader["Exercise2"].ToString();
            workout.Exercise2Reps = Convert.ToInt32(reader["Exercise1Reps"]);
            workout.Exercise2Sets = Convert.ToInt32(reader["Exercise2Sets"]);
            workout.Exercise3 = reader["Exercise3"].ToString();
            workout.Exercise3Reps = Convert.ToInt32(reader["Exercise3Reps"]);
            workout.Exercise3Sets = Convert.ToInt32(reader["Exercise3Sets"]);
            workout.Exercise4 = reader["Exercise4"].ToString();
            workout.Exercise4Reps = Convert.ToInt32(reader["Exercise4Reps"]);
            workout.Exercise4Sets = Convert.ToInt32(reader["Exercise4Sets"]);
            workout.Exercise5 = reader["Exercise5"].ToString();
            workout.Exercise5Reps = Convert.ToInt32(reader["Exercise5Reps"]);
            workout.Exercise5Sets = Convert.ToInt32(reader["Exercise5Sets"]);
          }
        }
      }
      return workout;
    }

    //Edits Workout using "UPDATE" Sql Query passing in values to edit depending on the TraineeID
    public int EditWorkout(WorkoutViewModel edit)
    {
      string sqlQuery = "UPDATE Workout Set WorkoutName=@WorkoutName, Exercise1=@Exercise1, Exercise1Reps=@Exercise1Reps, Exercise1Sets=@Exercise1Sets, Exercise2=@Exercise2, Exercise2Reps=@Exercise2Reps, Exercise2Sets=@Exercise2Sets, Exercise3=@Exercise3, Exercise3Reps=@Exercise3Reps, Exercise3Sets=@Exercise3Sets, " +
        "Exercise4=@Exercise4, Exercise4Reps=@Exercise4Reps, Exercise4Sets=@Exercise4Sets, Exercise5=@Exercise5, Exercise5Reps=@Exercise5Reps, Exercise5Sets=@Exercise5Sets";

      //No need to use SqlDataReader here since we are just using the sql Query to persist to database
      using (SqlConnection con = new SqlConnection(_connectionString))
      using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
      {
        con.Open();
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = edit.WorkoutID;
        cmd.Parameters.Add("@WorkoutName", SqlDbType.VarChar).Value = edit.WorkoutName;
        cmd.Parameters.Add("@Exercise1", SqlDbType.VarChar).Value = edit.Exercise1;
        cmd.Parameters.Add("@Exercise1Reps", SqlDbType.Int).Value = edit.Exercise1Reps;
        cmd.Parameters.Add("@Exercise1Sets", SqlDbType.Int).Value = edit.Exercise1Sets;
        cmd.Parameters.Add("@Exercise2", SqlDbType.VarChar).Value = edit.Exercise2;
        cmd.Parameters.Add("@Exercise2Reps", SqlDbType.Int).Value = edit.Exercise2Reps;
        cmd.Parameters.Add("@Exercise2Sets", SqlDbType.Int).Value = edit.Exercise2Sets;
        cmd.Parameters.Add("@Exercise3", SqlDbType.VarChar).Value = edit.Exercise3;
        cmd.Parameters.Add("@Exercise3Reps", SqlDbType.Int).Value = edit.Exercise3Reps;
        cmd.Parameters.Add("@Exercise3Sets", SqlDbType.Int).Value = edit.Exercise3Sets;
        cmd.Parameters.Add("@Exercise4", SqlDbType.VarChar).Value = edit.Exercise4;
        cmd.Parameters.Add("@Exercise4Reps", SqlDbType.Int).Value = edit.Exercise4Reps;
        cmd.Parameters.Add("@Exercise4Sets", SqlDbType.Int).Value = edit.Exercise4Sets;
        cmd.Parameters.Add("@Exercise5", SqlDbType.VarChar).Value = edit.Exercise5;
        cmd.Parameters.Add("@Exercise5Reps", SqlDbType.Int).Value = edit.Exercise5Reps;
        cmd.Parameters.Add("@Exercise5Sets", SqlDbType.Int).Value = edit.Exercise5Sets;
        return cmd.ExecuteNonQuery();
      }
    }

    //Add Workout using "INSERT" Sql Query depending on the values, very similar to EditWorkout
    //method above
    public int AddWorkout(WorkoutViewModel add)
    {
      string sqlQuery = "INSERT INTO Workout (WorkoutName, Exercise1, Exercise1Reps, Exercise1Sets, Exercise2, Exercise2Reps, Exercise2Sets, Exercise3, Exercise3Reps, Exercise3Sets, Exercise4, Exercise4Reps, Exercise4Sets, Exercise5, Exercise5Reps, Exercise5Sets) VALUES (@WorkoutName, @Exercise1, @Exercise1Reps, @Exercise1Sets, @Exercise2, @Exercise2Reps, @Exercise2Sets, @Exercise3, @Exercise3Reps, @Exercise3Sets, @Exercise4, @Exercise4Reps, @Exercise4Sets, @Exercise5, @Exercise5Reps, @Exercise5Sets) ";

      using (SqlConnection con = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
      {
        con.Open();
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = add.WorkoutID;
        cmd.Parameters.Add("@WorkoutName", SqlDbType.VarChar).Value = add.WorkoutName;
        cmd.Parameters.Add("@Exercise1", SqlDbType.VarChar).Value = add.Exercise1;
        cmd.Parameters.Add("@Exercise1Reps", SqlDbType.Int).Value = add.Exercise1Reps;
        cmd.Parameters.Add("@Exercise1Sets", SqlDbType.Int).Value = add.Exercise1Sets;
        cmd.Parameters.Add("@Exercise2", SqlDbType.VarChar).Value = add.Exercise2;
        cmd.Parameters.Add("@Exercise2Reps", SqlDbType.Int).Value = add.Exercise2Reps;
        cmd.Parameters.Add("@Exercise2Sets", SqlDbType.Int).Value = add.Exercise2Sets;
        cmd.Parameters.Add("@Exercise3", SqlDbType.VarChar).Value = add.Exercise3;
        cmd.Parameters.Add("@Exercise3Reps", SqlDbType.Int).Value = add.Exercise3Reps;
        cmd.Parameters.Add("@Exercise3Sets", SqlDbType.Int).Value = add.Exercise3Sets;
        cmd.Parameters.Add("@Exercise4", SqlDbType.VarChar).Value = add.Exercise4;
        cmd.Parameters.Add("@Exercise4Reps", SqlDbType.Int).Value = add.Exercise4Reps;
        cmd.Parameters.Add("@Exercise4Sets", SqlDbType.Int).Value = add.Exercise4Sets;
        cmd.Parameters.Add("@Exercise5", SqlDbType.VarChar).Value = add.Exercise5;
        cmd.Parameters.Add("@Exercise5Reps", SqlDbType.Int).Value = add.Exercise5Reps;
        cmd.Parameters.Add("@Exercise5Sets", SqlDbType.Int).Value = add.Exercise5Sets;
        return cmd.ExecuteNonQuery();
      }
    }

    //Delete using "DELETE" Sql Query by the WorkoutID
    //Very similar to the EditWorkout and AddWorkout methods using SqlCommand
    public int DeleteWorkout(int id)
    {
      string sqlQuery = "DELETE from Workout WHERE WorkoutID=@ID";
      using (SqlConnection con = new SqlConnection(_connectionString))
      using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
      {
        con.Open();
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
        return cmd.ExecuteNonQuery();
      }
    }
  }
}
