using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms.Xaml;

namespace Lab6ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Employee>  Employees  { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;
         

            employees.Add(new Employee { DisplayName = "Rob Finerty" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "Doctor Geri -Beth Hooper" });
            employees.Add(new Employee { DisplayName = "Dr. Keitch Joyce-Purdy" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick" });
           
        }
    }
}