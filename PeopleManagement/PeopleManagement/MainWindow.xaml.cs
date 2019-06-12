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

namespace PeopleManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            people.Items.Add(new Person { FirstName = "Ivan", LastName = "Todorov", Age = "23", Email = "ivantodorov@abv.bg" });
            people.Items.Refresh();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            this.people.Items.Add(new Person
            {
                FirstName = $"{_FirstName.Text}",
                LastName = $"{_LastName.Text}",
                Age = $"{_Age.Text}",
                Email = $"{_Email.Text}"
            });
            people.Items.Refresh();
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            var item = people.SelectedItem as Person;
            this.people.Items.Remove(item);
            people.Items.Refresh();
        }
    }
}
