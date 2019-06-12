using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PeopleManagementMVVM
{
    public class ViewModel : ViewModelBase
    {
        private string firstName;
        private string lastName;
        private string age;
        private string email;

        private Person person;

        public bool addCommandCheck;
        public bool deleteCommandCheck;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(this.FirstName != value)
                {
                    this.firstName = value;
                    this.OnPropertyChanged(nameof(this.FirstName));
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if(this.LastName != value)
                {
                    this.lastName = value;
                    this.OnPropertyChanged(nameof(this.LastName));
                }
            }
        }

        public string Age
        {
            get { return this.age; }
            set
            {
                if(this.Age != value)
                {
                    this.age = value;
                    this.OnPropertyChanged(nameof(this.Age));
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if(this.Email != value)
                {
                    this.email = value;
                    this.OnPropertyChanged(nameof(this.Email));
                }
            }
        }

        public Person Person
        {
            get { return this.person; }
            set
            {
                if(this.Person != value)
                {
                    this.person = value;
                    this.OnPropertyChanged(nameof(this.Person));
                }
            }
        }

        public ObservableCollection<Person> people { get; set; }

        public ICommand Add { get; set; }
        public ICommand Delete { get; set; }

        public ViewModel()
        {
            this.people = new ObservableCollection<Person>
            {
                new Person{FirstName = "Ivan", LastName = "Todorov", Age = "30", Email = "itodorov@abv.bg"}
            };

            this.Person = this.people.FirstOrDefault();

            this.Add = new LambdaCommand(() =>
            {
                this.people.Add(new Person
                {
                    FirstName = this.FirstName,
                    LastName = this.LastName,
                    Age = this.Age,
                    Email = this.Email
                });
                this.FirstName = string.Empty;
                this.LastName = string.Empty;
                this.Age = string.Empty;
                this.Email = string.Empty;
                addCommandCheck = true;
            });

            this.Delete = new LambdaCommand(() =>
            {
                if (this.Person != null)
                {
                    this.people.Remove(this.Person);
                    this.Person = this.people.FirstOrDefault();
                }
                deleteCommandCheck = true;
            });
        }
    }
}
