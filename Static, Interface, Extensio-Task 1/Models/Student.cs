using Static__Interface__Extensio_Task_1.Extensions;

using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface__Extensio_Task_1.Models
{
    public class Student
    {
        public static int Count = 0;
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name, string surname)
        {
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Count++;
            Id = Count;
            
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Id}");
        }

        public static implicit operator int(Student v)
        {
            throw new NotImplementedException();
        }
    }
}
