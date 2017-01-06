using DrieLagenEmployeesBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DrieLagenEmployees
{
    /// <summary>
    /// Interaction logic for EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : Window
    {
        private List<Employee> emplist;
        private int selected;
        

        public EditEmployeeWindow(ref List<Employee> emplist, int selected)
        {
            InitializeComponent();
            this.emplist = emplist;
            this.selected = selected;

            Utility.updateGUI(this.emplist, this.selected, employeeGenderComboBox, employeeFirstNameTextBox, employeeLastNameTextBox, employeeBirthdayDatePicker, employeeHireDateDatePicker);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)employeeGenderComboBox.SelectedItem;
            this.emplist[selected].first_name = employeeFirstNameTextBox.Text;
            this.emplist[selected].last_name = employeeLastNameTextBox.Text;
            this.emplist[selected].gender = item.Content.ToString();
            this.emplist[selected].birth_date = employeeBirthdayDatePicker.SelectedDate.Value;
            this.emplist[selected].hire_date = employeeHireDateDatePicker.SelectedDate.Value;
            MessageBox.Show("Employee Updated!");
            EmployeeDB.UpdateEmployee(this.emplist[selected]);
            this.Hide();
        }


    }
}
