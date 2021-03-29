using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySwoleMate.BLL;

namespace MySwoleMate
{
  public partial class Progress : System.Web.UI.Page
  {

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindData();
      }
    }

    protected void ProgressList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      MeasurementBLL mes = new MeasurementBLL();
      if (e.Row.RowType == DataControlRowType.DataRow) // Fill or load child gridviews for every parent grid row  
      {
        int rowId = Convert.ToInt32(ProgressListParent.DataKeys[e.Row.RowIndex].Value);
        GridView cgv = (GridView)e.Row.FindControl("ProgressListChild");
        cgv.DataSource = mes.GetMeasurementByTraineeId(rowId);
        cgv.DataBind();
        foreach(GridViewRow row in cgv.Rows)
        {
          row.CssClass = "saharCssClass";
        }
      }
    }

    public void BindData()
    {
      
      MeasurementBLL mes = new MeasurementBLL();
      List<Models.Measurement> mesList = mes.GetMeasurements();
      //ProgressListParent.DataSource = mes.GetMeasurementPerTrainee();
      //ProgressListParent.DataBind();
      
      string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
      TraineeBLL trainee = new TraineeBLL(connectionString);
      ProgressListParent.DataSource = trainee.GetAllTrainees();
      ProgressListParent.DataBind();
    }
  }
}