using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
  public class MeasurementScheduleTraineeDTO
  {
    public int TraineeID { set; get; }
    public int MeasurementID { set; get; }
    public string FirstName { set; get; }
    public System.DateTime ScheduleDtTime { set; get; }
    public int Weight { get; set; }
    public int Waist { get; set; }
    public int BodyFat { get; set; }
    public int Chest { get; set; }
    public int UpperArm { get; set; }
    public string name { set; get; }
  }
}
