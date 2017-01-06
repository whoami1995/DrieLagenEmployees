using DrieLagenEmployeesBusiness;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {

        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utility.allFilled(employeeFirstNameTextBox,employeeLastNameTextBox,employeeGenderComboBox,employeeBirthdayDatePicker,employeeHireDateDatePicker))
                {
                    ComboBoxItem genderItem = (ComboBoxItem)employeeGenderComboBox.SelectedItem;
                    var emp = new Employee
                    {
                        emp_no = EmployeeDB.GetNextID(),
                        first_name = employeeFirstNameTextBox.Text,
                        last_name = employeeLastNameTextBox.Text,
                        gender = genderItem.Content.ToString(),
                        birth_date = employeeBirthdayDatePicker.SelectedDate.Value,
                        hire_date = employeeHireDateDatePicker.SelectedDate.Value
                    };
                    EmployeeDB.InsertEmployee(emp);
                    MessageBox.Show("Employee Added!");
                    Utility.ClearFunction(employeeFirstNameTextBox, employeeLastNameTextBox, employeeGenderComboBox, employeeBirthdayDatePicker, employeeHireDateDatePicker);
                }
            }
            catch(SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Er ging iets fout");
                Utility.ClearFunction(employeeFirstNameTextBox, employeeLastNameTextBox, employeeGenderComboBox, employeeBirthdayDatePicker, employeeHireDateDatePicker);
            }
        }

        

        private void clearBoxesButton_Click(object sender, RoutedEventArgs e)
        {
            Utility.ClearFunction(employeeFirstNameTextBox, employeeLastNameTextBox, employeeGenderComboBox, employeeBirthdayDatePicker, employeeHireDateDatePicker);
        }



        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
