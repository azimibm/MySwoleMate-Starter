using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwoleMate.Models;
using MySwoleMate.DAL;

namespace MySwoleMate.BLL
{
  public class MeasurementBLL
  {
    private MeasurementDAL data;
    public MeasurementBLL()
    {
      data = new MeasurementDAL();
    }

    public List<Measurement> GetMeasurements()
    {
      List<Measurement> measurements = data.GetMeasurements();
      return measurements;
    }

    public int EditMesurement(Measurement edit)
    {
      return data.EditMeasurement(edit);
    }

    public int AddMeasuremnet(Measurement add)
    {
      return data.AddMeasurement(add);
    }

    public void DeleteMeasurement(int meID)
    {
      data.DeleteMeasurement(meID);
    }

    public Measurement GetMeasurementById(int meID)
    {
      return data.GetMeasurementById(meID);
    }

    public List<MeasurementScheduleTraineeDTO> GetMeasurementPerTrainee()
    {
      return data.GetMeasurementPerTrainee();
    }

    public List<MeasurementScheduleTraineeDTO> GetMeasurementByTraineeId(int tID)
    {
      return data.GetMeasurementByTraineeId(tID);
    }
  }
}

