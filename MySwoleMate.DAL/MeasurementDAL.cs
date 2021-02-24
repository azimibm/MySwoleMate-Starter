using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwoleMate.Models;

namespace MySwoleMate.DAL
{
  public class MeasurementDAL
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

    public List<MeasurementScheduleTraineeDTO> GetMeasurementByTraineeId(int tID)
    {
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        //select Trainee.FirstName, Schedule.ScheduleDtTime, Measurement.Weight, 
        //Measurement.Waist, Measurement.BodyFat, Measurement.Chest, Measurement.UpperArm
        //From((Trainee
        //INNER JOIN Schedule ON Trainee.TraineeID = Schedule.TraineeID)
        //INNER JOIN Measurement ON Schedule.ScheduleID = Measurement.ScheduleID);

        // Using Navigational Properties to join 3 tables
        var data = from Mes in db.Measurements
                   where Mes.Schedule.TraineeID == tID
                   select new MeasurementScheduleTraineeDTO
                   {
                     TraineeID = Mes.Schedule.TraineeID,
                     MeasurementID = Mes.MeasurementID,
                     FirstName = Mes.Schedule.Trainee.FirstName,
                     ScheduleDtTime = Mes.Schedule.ScheduleDtTime,
                     Weight = Mes.Weight,
                     Waist = Mes.Waist,
                     BodyFat = Mes.BodyFat,
                     Chest = Mes.BodyFat,
                     UpperArm = Mes.UpperArm,
                     name = Mes.Schedule.Trainee.FirstName + " " + Mes.Schedule.Trainee.LastName
                   };
        return data.ToList();
      }
    }
      public List<MeasurementScheduleTraineeDTO> GetMeasurementPerTrainee()
      {
        using (MySwoleMateEntities db = new MySwoleMateEntities())
        {
          //select Trainee.FirstName, Schedule.ScheduleDtTime, Measurement.Weight, 
          //Measurement.Waist, Measurement.BodyFat, Measurement.Chest, Measurement.UpperArm
          //From((Trainee
          //INNER JOIN Schedule ON Trainee.TraineeID = Schedule.TraineeID)
          //INNER JOIN Measurement ON Schedule.ScheduleID = Measurement.ScheduleID);

          // Using Navigational Properties to join 3 tables
          var data = from Mes in db.Measurements
                     select new MeasurementScheduleTraineeDTO
                     {
                       TraineeID = Mes.Schedule.TraineeID,
                       MeasurementID = Mes.MeasurementID,
                       FirstName = Mes.Schedule.Trainee.FirstName,
                       ScheduleDtTime = Mes.Schedule.ScheduleDtTime,
                       Weight = Mes.Weight,
                       Waist = Mes.Waist,
                       BodyFat = Mes.BodyFat,
                       Chest = Mes.BodyFat,
                       UpperArm = Mes.UpperArm,
                       name = Mes.Schedule.Trainee.FirstName + " " + Mes.Schedule.Trainee.LastName
                     };

          /*
          // Using explicit sql join to join 3 tables
          var data = from Tr in db.Trainees
                     join Sc in db.Schedules
                         on Tr.TraineeID equals Sc.TraineeID 
                     join Mes in db.Measurements
                         on Sc.ScheduleID equals Mes.ScheduleID
                     select new MeasurementScheduleTraineeDTO
                     {
                       MeasurementID = Mes.ScheduleID,
                       ScheduleDtTime = Sc.ScheduleDtTime,
                       FirstName = Tr.FirstName,
                       Weight = Mes.Weight,
                       Waist = Mes.Waist,
                       BodyFat = Mes.BodyFat,
                       Chest = Mes.Chest,
                       UpperArm = Mes.UpperArm
                     };
          */
          return data.ToList();

        }
      }
  }
}
