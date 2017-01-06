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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrieLagenEmployees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> employeeList;
        public MainWindow()
        {
            InitializeComponent();
            this.employeeList = EmployeeDB.GetEmployees();
            if(this.employeeList.Count == 0)
            {
                showEmployeesButton.IsEnabled = false;
            }

        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow AEW = new AddEmployeeWindow();
            this.Hide();
            AEW.Show();
        }

        private void showEmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            ShowEmployeeWindow SEW = new ShowEmployeeWindow(ref this.employeeList);
            this.Hide();
            SEW.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var bericht = MessageBox.Show("Wil je de applicatie afsluiten?", "Afsluiten?", MessageBoxButton.YesNo);
            if(bericht == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
