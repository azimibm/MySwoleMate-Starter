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

    public List<Measurement> GetSchedules()
    {
      List<Measurement> measurements = data.getMeasurements();
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
  }
}

