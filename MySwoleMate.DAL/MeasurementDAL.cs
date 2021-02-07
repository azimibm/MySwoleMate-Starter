using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwoleMate.Models;

namespace MySwoleMate.DAL
{
  class MeasurementDAL
  {
    public List<Measurement> getMeasurements()
    {
      List<Measurement> allMeasuremnets = new List<Measurement>();
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        allMeasuremnets = db.Measurements.ToList();
      }
      return allMeasuremnets;
    }

    //Get Measurement By Id
    public Measurement GetMeasurementById(int mId)
    {
      Measurement m = new Measurement();
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        m = db.Measurements.Find();
      }
      return m;
    }

    //Edit Measurement
    public int EditMeasurement(Measurement editMes)
    {
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        var m = new Measurement { MeasurementID = editMes.MeasurementID, Weight = editMes.Weight, Waist = editMes.Waist, 
                                  BodyFat = editMes.BodyFat, Chest = editMes.Chest, UpperArm = editMes.UpperArm};
        db.Entry(m).State = System.Data.Entity.EntityState.Modified;
        return db.SaveChanges();
      }
    }

    //Add a Measurement
    public int AddMeasurement(Measurement newMes)
    {
      Measurement mes = new Measurement()
      {
        Weight = newMes.Weight,
        Waist = newMes.Waist,
        BodyFat = newMes.BodyFat,
        Chest = newMes.Chest,
        UpperArm = newMes.UpperArm,
        ScheduleID = newMes.ScheduleID
      };

      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        db.Measurements.Add(mes);
        return db.SaveChanges();
      }
    }

    //Delete a Measurement
    public void DeleteMeasurement(int mesId)
    {
      Measurement deleteMes = new Measurement()
      {
        MeasurementID = mesId
      };
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        db.Entry(deleteMes).State = System.Data.Entity.EntityState.Deleted;
        db.SaveChanges();
      }
    }
  }
}
