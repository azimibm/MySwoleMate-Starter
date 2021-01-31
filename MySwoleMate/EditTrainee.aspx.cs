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
    public partial class EditTrainee : System.Web.UI.Page
    {
        //Create a new instance of the business logic class for Trainees, we created the instance
        //here so that we can use it with both the Page_Load and Click event for TraineeEditButton
        TraineeBLL bll = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        /// <summary>
        /// Method for Load event to load values into the form for edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Only load the values if the request is not a PostBack
            if (!IsPostBack)
            {
                //We pass the TraineeID by a Query String from the GridView on Trainees.aspx. See how we passed 
                //TraineeID to this page from Trainees.aspx by looking at HyperLinkField in the GridView control
                //on the Trainees.aspx page for clarification
                TraineeViewModel trainee = bll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));
                //We use the GetTraineeById method to get the Trainee from the database, which we use to 
                //populate the data into the form.
                FirstName.Text = trainee.FirstName;
                LastName.Text = trainee.LastName;
                Email.Text = trainee.Email;
                Height.Text = trainee.Height.ToString();
                Weight.Text = trainee.Weight.ToString();
                CellNbr.Text = trainee.CellNbr;
                Gender.SelectedValue = trainee.Gender;
                Age.Text = trainee.Age.ToString();
            }
        }

        protected void TraineeEditButton_Click(object sender, EventArgs e)
        {
            //Check to see if all ValidationControls are valid
            if (Page.IsValid)
            {
                //Create new empty ViewModel to pass in the new values
                TraineeViewModel trainee = new TraineeViewModel();
                //Use the same query string to fill the ID
                trainee.TraineeID = Convert.ToInt32(Request.QueryString["TraineeID"]);
                trainee.FirstName = FirstName.Text;
                trainee.LastName = LastName.Text;
                trainee.Email = Email.Text;
                trainee.Height = Convert.ToInt32(Height.Text);
                trainee.Weight = Convert.ToInt32(Weight.Text);
                trainee.CellNbr = CellNbr.Text;
                trainee.Gender = Gender.SelectedValue;
                trainee.Age = Convert.ToInt32(Age.Text);
                //Call the EditTrainee() method passing in the new values
                bll.EditTrainee(trainee);
                //Redirect to the Trainees.aspx page
                Response.Redirect("~/Trainees.aspx");
            }
        }
    }
}