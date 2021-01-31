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
    public partial class AddTrainee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add Trainee to DB from user input form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void TraineeAddButton_Click(object sender, EventArgs e)
        {
            //Checks to see if all Validation Controls are valid
            if (Page.IsValid)
            {
                //Grab connectionString from web.config file
                string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
                //Create new instance of TraineeBLL
                TraineeBLL bll = new TraineeBLL(connectionString);
                //Create new instance of ViewModel with data from the user
                TraineeViewModel trainee = new TraineeViewModel();
                //The Text property of each control will contain the data from the user
                trainee.FirstName = FirstName.Text;
                trainee.LastName = LastName.Text;
                trainee.Email = Email.Text;
                //Since the Text property returns a string, some properties would need to be converted
                trainee.Height = Convert.ToInt32(Height.Text);
                trainee.Weight = Convert.ToInt32(Weight.Text);
                trainee.CellNbr = CellNbr.Text;
                trainee.Gender = Gender.SelectedValue;
                trainee.Age = Convert.ToInt32(Age.Text);
                //Call the Business Logic method to add trainee
                bll.AddTrainee(trainee);
                //Return to the Trainees list after adding the trainee to database
                Response.Redirect("~/Trainees.aspx");
            }
        }
    }
}