using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySwoleMate.BLL;
using MySwoleMate.Models;

namespace MySwoleMate
{
  public partial class AddMeasurements : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      ScheduleBLL scbll = new ScheduleBLL();
      Schedule sc = scbll.GetScheduleById(Convert.ToInt32(Request.QueryString["ScheduleID"]));
      if (sc != null)
      {
        ScheduleID.Text = sc.ScheduleID.ToString();
        TraineeID.Text = sc.TraineeID.ToString();
      }
    }

    protected void AddMeasurementButton_Click(object sender, EventArgs e)
    {
      if (Page.IsValid)
      {
        MeasurementBLL msbll = new MeasurementBLL();
        Measurement ms = new Measurement();
        ms.ScheduleID = Convert.ToInt32(ScheduleID.Text);
        ms.Weight = Convert.ToInt32(Weight.Text);
        ms.Waist = Convert.ToInt32(Waist.Text);
        ms.BodyFat = Convert.ToInt32(BodyFat.Text);
        ms.Chest = Convert.ToInt32(Chest.Text);
        ms.UpperArm = Convert.ToInt32(UpperArm.Text);

        int res = msbll.AddMeasuremnet(ms);
        if (res > 0)
        {
          Response.Redirect("~/Progress.aspx");
        }
      }
    }
  }
}