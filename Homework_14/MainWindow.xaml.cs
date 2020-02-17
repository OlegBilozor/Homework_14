using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Homework_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            DataContext = this;
        }
        private void LoadData()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee { Name = "Olga", Age = 26, Salary = 6100, Experience = 6 });
            Employees.Add(new Employee { Name = "Victor", Age = 25, Salary = 4500, Experience = 4 });
            Employees.Add(new Employee { Name = "Jason", Age = 27, Salary = 7600, Experience = 9 });
            Employees.Add(new Employee { Name = "Petro", Age = 23, Salary = 3400, Experience = 2 });
            Employees.Add(new Employee { Name = "Tom", Age = 28, Salary = 8700, Experience = 10 });

            
        }
    }
}
