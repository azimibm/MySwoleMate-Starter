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
  public partial class Scheduler : System.Web.UI.Page
  {

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindData();
      }
    }

    private void BindData()
    {
      ScheduleBLL schedule = new ScheduleBLL();
      ScheduleList.DataSource = schedule.GetScheduleOfTrainees();
      ScheduleList.DataBind();
    }
  }
}