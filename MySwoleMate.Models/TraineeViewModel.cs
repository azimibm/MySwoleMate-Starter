using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
    public class TraineeViewModel
    {
        public int TraineeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string CellNbr { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int WorkoutID { get; set; }
        public string DisplayHeight { get; set; }
        public string DisplayCellNbr { get; set; }
        public string DisplayGender
        {
            get
            {
                if (this.Gender == "M")
                    return "Male";
                else if (this.Gender == "F")
                    return "Female";
                else
                    return "Not Specified";
            }
        }
    }
}
