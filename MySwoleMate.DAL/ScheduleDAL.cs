using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwoleMate.Models;


namespace MySwoleMate.DAL
{
  public class ScheduleDAL
  {
    //Returns All Schedules
    public List<Schedule> GetSchedules()
    {
      List<Schedule> allSchedules = new List<Schedule>();
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        allSchedules = db.Schedules.ToList();
      }
      return allSchedules;
    }

    public List<ScheduleTraineeDTO> GetScheduleOfTrainees()
    {
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        //select Schedule.ScheduleDtTime, Trainee.FirstName, Trainee.LastName, Trainee.Email, Trainee.Height, Trainee.CellNbr,
        //Trainee.Gender, Trainee.Age, Schedule.InputDtTime from Schedule INNER JOIN Trainee ON Schedule.TraineeID = Trainee.TraineeID;

        var data = from Sc in db.Schedules
                   join Tr in db.Trainees
                   on Sc.TraineeID equals Tr.TraineeID
                   select new ScheduleTraineeDTO
                   {
                     //Sc = Sc, Tr = Tr

                     ScheduleID = Sc.ScheduleID,
                     ScheduleDtTime = Sc.ScheduleDtTime,
                     FirstName = Tr.FirstName,
                     LastName = Tr.LastName,
                     Email = Tr.Email,
                     Height = Tr.Height,
                     CellNbr = Tr.CellNbr,
                     Gender = Tr.Gender,
                     Age = Tr.Age,
                     InputDtTime = Sc.InputDtTime
                   };
        return data.ToList();
        
      }
    }

    //Get Schedule By Id
    public Schedule GetScheduleById(int scId)
    {
      Schedule sc = new Schedule();
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        sc = db.Schedules.Find();
      }
      return sc;
    }

    //Edit Schedule
    public int EditSchedule(Schedule editSc)
    {
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        var sc = new Schedule { ScheduleID = editSc.ScheduleID, ScheduleDtTime = editSc.ScheduleDtTime, InputDtTime = editSc.ScheduleDtTime};
        db.Entry(sc).State = System.Data.Entity.EntityState.Modified;
        return db.SaveChanges();
      }
    }

    //Add a Schedule
    public int AddSchedule(Schedule newSc)
    {
      Schedule sc = new Schedule()
      {
        ScheduleDtTime = newSc.ScheduleDtTime,
        InputDtTime = newSc.InputDtTime,
        TraineeID = newSc.TraineeID
      };

      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        db.Schedules.Add(sc);
        return db.SaveChanges();
      }
    }

    //Delete a Schedule
    public void DeleteSchedule(int scId)
    {
      Schedule deleteSc = new Schedule()
      {
        ScheduleID = scId
      };
      using (MySwoleMateEntities db = new MySwoleMateEntities())
      {
        db.Entry(deleteSc).State = System.Data.Entity.EntityState.Deleted;
        db.SaveChanges();
      }
    }
  }
}
