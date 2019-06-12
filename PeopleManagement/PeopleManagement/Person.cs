using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PeopleManagement
{
    public class Person
    {
 
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string Age { get; set; }

        public string Email { get; set; }
    }
}

