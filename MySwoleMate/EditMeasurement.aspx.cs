using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySwoleMate.Models;
using MySwoleMate.BLL;

namespace MySwoleMate
{
  public partial class EditMeasurement : System.Web.UI.Page
  {

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        MeasurementBLL msbll = new MeasurementBLL();
        Measurement ms = msbll.GetMeasurementById(Convert.ToInt32(Request.QueryString["MeasurementID"]));
        if (ms != null)
        {
          Weight.Text = ms.Weight.ToString();
          Waist.Text = ms.Waist.ToString();
          BodyFat.Text = ms.BodyFat.ToString();
          Chest.Text = ms.BodyFat.ToString();
          UpperArm.Text = ms.UpperArm.ToString();
        }
      }
    }

    protected void MeasurementSubmitButton_Click(object sender, EventArgs e)
    {
      if (Page.IsValid)
      {
        MeasurementBLL msbll = new MeasurementBLL();
        Measurement ms = msbll.GetMeasurementById(Convert.ToInt32(Request.QueryString["MeasurementID"]));
        
        ms.Weight = Convert.ToInt32(Weight.Text);
        ms.Waist = Convert.ToInt32(Waist.Text);
        ms.BodyFat = Convert.ToInt32(BodyFat.Text);
        ms.Chest = Convert.ToInt32(Chest.Text);
        ms.UpperArm = Convert.ToInt32(UpperArm.Text);

        int res = msbll.EditMesurement(ms);
        if (res > 0)
        {
          Response.Redirect("~/Progress.aspx");
        }
      }
    }
  }
}