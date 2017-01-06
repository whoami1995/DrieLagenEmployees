using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DrieLagenEmployeesBusiness
{
    public class Employee
    {
        public int emp_no { get; set; }
        public DateTime birth_date { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public DateTime hire_date { get; set; }

        public Employee()
        {

        }

        public Employee(int emp_no, DateTime bd,string fn, string ln, string gender, DateTime hd)
        {
            this.emp_no = emp_no;
            this.birth_date = bd;
            this.first_name = fn;
            this.last_name = ln;
            this.gender = gender;
            this.hire_date = hd;
        }

        



    }
}
