using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwoleMate.Models;
using MySwoleMate.DAL;

namespace MySwoleMate.BLL
{
  //The ScheduleBLL class will pass data through the Data Access Layer to the Web Forms application.
  public class ScheduleBLL
  {
    private ScheduleDAL data;
    public ScheduleBLL()
    {
      data = new ScheduleDAL();
    }

    public List<Schedule> GetSchedules()
    {
      return data.GetSchedules();
    }

    public Schedule GetScheduleById(int scID)
    {
      return data.GetScheduleById(scID);
    }

    public List<ScheduleTraineeDTO> GetScheduleOfTrainees()
    {
      return data.GetScheduleOfTrainees();
    }

    public int EditSchedule(Schedule edit)
    {
      return data.EditSchedule(edit);
    }

    public int AddSchedule(Schedule add)
    {
      return data.AddSchedule(add);
    }

    public void DeleteSchedule(int scID)
    {
      data.DeleteSchedule(scID);
    }
  }
}
