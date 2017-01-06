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
    /// Interaction logic for ShowEmployeeWindow.xaml
    /// </summary>
    public partial class ShowEmployeeWindow : Window
    {
        private List<Employee> employeeList = null;
        private int selected = 0;
        public ShowEmployeeWindow(ref List<Employee> emplist)
        {
            InitializeComponent();
            this.employeeList = emplist;
            if(this.employeeList.Count >= 1)
            {
                Utility.updateGUI(this.employeeList, this.selected, employeeGenderCombobox, employeeIdTextBlock, employeeFirstNameTextBlock, employeeLastNameTextBlock, employeeBirthdayDatePicker, employeeHiredayDatePicker);
                employeeGenderCombobox.IsEnabled = false;
                employeeBirthdayDatePicker.IsEnabled = false;
                employeeHiredayDatePicker.IsEnabled = false;
            }            
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.selected != 0)
            {
                this.selected--;
                Utility.updateGUI(this.employeeList, this.selected, employeeGenderCombobox, employeeIdTextBlock, employeeFirstNameTextBlock, employeeLastNameTextBlock, employeeBirthdayDatePicker, employeeHiredayDatePicker);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.selected != employeeList.Count-1)
            {
                this.selected++;
                Utility.updateGUI(this.employeeList, this.selected, employeeGenderCombobox, employeeIdTextBlock, employeeFirstNameTextBlock, employeeLastNameTextBlock, employeeBirthdayDatePicker, employeeHiredayDatePicker);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditEmployeeWindow EEW = new EditEmployeeWindow(ref employeeList,selected);
            EEW.ShowDialog();
            Utility.updateGUI(this.employeeList, this.selected, employeeGenderCombobox, employeeIdTextBlock, employeeFirstNameTextBlock, employeeLastNameTextBlock, employeeBirthdayDatePicker, employeeHiredayDatePicker);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDB.DeleteEmployee(this.employeeList[selected]);
            this.employeeList.Remove(this.employeeList[selected]);
            this.selected = 0;
            try
            {
                Utility.updateGUI(this.employeeList, this.selected, employeeGenderCombobox, employeeIdTextBlock, employeeFirstNameTextBlock, employeeLastNameTextBlock, employeeBirthdayDatePicker, employeeHiredayDatePicker);
            }
            catch(Exception)
            {
                MainWindow win = new MainWindow();
                this.Hide();
                win.Show();
            }
        }
    }
}
