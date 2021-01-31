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
    public class TraineeDAL
    {
        //uses connection string for connecting to database
        private string _connectionString;
        public TraineeDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Returns All Trainees
        public List<TraineeViewModel> GetTrainees()
        {
            //SQL command for selecting all from Trainee table
            string sqlQuery = "SELECT * FROM Trainee";

            //Empty list of TraineeViewModel to add and return
            List<TraineeViewModel> trainees = new List<TraineeViewModel>();

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
                    //while there are records in the database
                    while (reader.Read())
                    {
                        //store each value into the properties of TraineeViewModel
                        TraineeViewModel temp = new TraineeViewModel()
                        {
                            TraineeID = Convert.ToInt32(reader["TraineeID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Height = Convert.ToInt32(reader["Height"]),
                            Weight = Convert.ToInt32(reader["Weight"]),
                            CellNbr = reader["CellNbr"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Age = Convert.ToInt32(reader["Age"])
                        };
                        //Add the Trainee object to the List of Trainee
                        trainees.Add(temp);
                    }
                }
            }
            return trainees;
        }

        //Get Trainee By Id, returns one instance of TraineeViewModel
        //Very similar to GetTrainees() method above
        public TraineeViewModel GetTraineeById(int id)
        {
            TraineeViewModel trainee = new TraineeViewModel();
            string sqlQuery = "Select * from Trainee where TraineeId=@ID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        trainee.TraineeID = Convert.ToInt32(reader["TraineeID"]);
                        trainee.FirstName = reader["FirstName"].ToString();
                        trainee.LastName = reader["LastName"].ToString();
                        trainee.Email = reader["Email"].ToString();
                        trainee.Height = Convert.ToInt32(reader["Height"]);
                        trainee.Weight = Convert.ToInt32(reader["Weight"]);
                        trainee.CellNbr = reader["CellNbr"].ToString();
                        trainee.Gender = reader["Gender"].ToString();
                        trainee.Age = Convert.ToInt32(reader["Age"]);
                        if (Convert.IsDBNull(reader["WorkoutID"]))
                        {
                          trainee.WorkoutID = 0;
                        }
                        else
                        {
                          trainee.WorkoutID = Convert.ToInt32(reader["WorkoutID"]);
                        }
                    }
                }
            }
            return trainee;
        }

        //Edits Trainee using "UPDATE" Sql Query passing in values to edit depending on the TraineeID
        public int EditTrainee(TraineeViewModel edit)
        {
            string sqlQuery = "Update Trainee Set FirstName=@FirstName, LastName=@LastName, " +
                "Email=@Email, Height=@Height, Weight=@Weight, CellNbr=@CellNbr, Gender=@Gender, " +
                "Age=@Age Where TraineeID=@ID";

            //No need to use SqlDataReader here since we are just using the Sql Query to persist to database
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = edit.TraineeID;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = edit.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = edit.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = edit.Email;
                cmd.Parameters.Add("@Height", SqlDbType.Int).Value = edit.Height;
                cmd.Parameters.Add("@Weight", SqlDbType.Int).Value = edit.Weight;
                cmd.Parameters.Add("@CellNbr", SqlDbType.VarChar).Value = edit.CellNbr;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = edit.Gender;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = edit.Age;
                return cmd.ExecuteNonQuery();
            }
        }

        //Add Trainee using "INSERT" Sql Query depending on the values, very similar to EditTrainee
        //method above
        public int AddTrainee(TraineeViewModel add)
        {
            string sqlQuery = "INSERT into Trainee (FirstName, LastName, Email, Height, " +
                "Weight, CellNbr, Gender, Age) VALUES (@FirstName, @LastName, @Email, @Height, " +
                "@Weight, @CellNbr, @Gender, @Age)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = add.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = add.LastName;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = add.Email;
                cmd.Parameters.Add("@Height", SqlDbType.Int).Value = add.Height;
                cmd.Parameters.Add("@Weight", SqlDbType.Int).Value = add.Weight;
                cmd.Parameters.Add("@CellNbr", SqlDbType.VarChar).Value = add.CellNbr;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = add.Gender;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = add.Age;
                return cmd.ExecuteNonQuery();
            }
        }

        //Delete using "DELETE" Sql Query by the TraineeID
        //Very similar to the EditTrainee and AddTrainee methods using SqlCommand
        public int DeleteTrainee(int id)
        {
            string sqlQuery = "DELETE from Trainee Where TraineeID=@ID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                return cmd.ExecuteNonQuery();
            }
        }

        public int AssignWorkout(TraineeViewModel trainee)
        {
          string sqlQuery = "Update Trainee Set WorkoutID=@WorkoutID Where TraineeID=@ID";

          //No need to use SqlDataReader here since we are just using the Sql Query to persist to database
          using (SqlConnection con = new SqlConnection(_connectionString))
          using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
          {
            con.Open();
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = trainee.TraineeID;
            cmd.Parameters.Add("@WorkoutID", SqlDbType.Int).Value = trainee.WorkoutID;
            return cmd.ExecuteNonQuery();
           }
        }
    }
}
