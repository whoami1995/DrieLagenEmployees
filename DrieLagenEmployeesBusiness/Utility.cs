using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DrieLagenEmployeesBusiness
{
    public static class Utility
    {
        public static bool allFilled(TextBox fn, TextBox ln, ComboBox gender, DatePicker bd, DatePicker hd)
        {
            if (fn.Text != string.Empty && ln.Text != string.Empty &&
                gender.SelectedIndex != -1 && bd.SelectedDate != null && hd.SelectedDate != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ClearFunction(TextBox t1, TextBox t2, ComboBox b1, DatePicker d1, DatePicker d2)
        {
            t1.Text = string.Empty;
            t2.Text = string.Empty;
            b1.SelectedIndex = -1;
            d1.SelectedDate = null;
            d2.SelectedDate = null;
        }


        public static void updateGUI(List<Employee> employeeList, int selected, ComboBox cb1,TextBlock tb1, TextBlock tb2,TextBlock tb3, DatePicker d1, DatePicker d2)
        {

                switch (employeeList[selected].gender)
                {
                    case "Male":
                        cb1.SelectedIndex = 0;
                        break;
                    case "Female":
                        cb1.SelectedIndex = 1;
                        break;

                }
                tb1.DataContext = employeeList[selected];
                tb2.DataContext = employeeList[selected];
                tb3.DataContext = employeeList[selected];
                d1.DataContext = employeeList[selected];
                d2.DataContext = employeeList[selected];

         
        }

        public static void updateGUI(List<Employee> employeeList, int selected, ComboBox cb1, TextBox tb1, TextBox tb2, DatePicker d1, DatePicker d2)
        {
            
                switch (employeeList[selected].gender)
                {
                    case "Male":
                        cb1.SelectedIndex = 0;
                        break;
                    case "Female":
                        cb1.SelectedIndex = 1;
                        break;

                }
                tb1.DataContext = employeeList[selected];
                tb2.DataContext = employeeList[selected];
                d1.DataContext = employeeList[selected];
                d2.DataContext = employeeList[selected];
         
            
        }
    }
}
