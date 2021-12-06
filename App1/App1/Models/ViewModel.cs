using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{

    public class ViewModel
    {
        public List<Person> Data { get; set; }
        public ViewModel()
        {
            Data = new List<Person>()
            {
                new Person("David", 180),
                new Person("Micheal", 170),
                new Person("Steve", 160),
                new Person("Joel", 182)
            };
        }
    }

}
