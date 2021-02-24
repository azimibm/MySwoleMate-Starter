using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
  public class ScheduleTraineeDTO
  {
    /*
    public Schedule Sc { get; set; }
    public Trainee Tr { get; set; }
    */
    public int ScheduleID { set; get; }
    public System.DateTime ScheduleDtTime { set; get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Height { get; set; }
    public string CellNbr { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public System.DateTime InputDtTime { get; set; }
  }
}
