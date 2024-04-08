//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Static__Interface__Extensio_Task_1.Models
using System;
using Static__Interface__Extensio_Task_1.Models;

namespace Static__Interface__Extensio_Task_1
{
    public class Group
    {

        public static Group[] Groups = new Group[10];

        public int GroupId { get; set; } 

        public string GroupName { get; set; }
        public Student[] Students { get; set; }

        public static int GroupCount = 0;



        public Group(string groupname)
        {
            GroupCount++;
            GroupId = GroupCount;
            GroupName = groupname; ;
            Students = new Student[10];


        }
        public void GetGroupInfo(Group  studunt)
        {

            Console.WriteLine("Students infos: ");
            foreach(var student in Students)
            {
                if(student != null)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Student Count: {student.Id}");
                }
            }

        }

        public static void AddStudent(Group group, Student student)
        {
            bool added = false;
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i] == null)
                {
                    group.Students[i] = student;
                    added = true;
                    Console.WriteLine($"Student added to Group '{group.GroupName}': {student.Name} {student.Surname}");
                    break;

                }
            }
            if (!added)
            {
                Console.WriteLine("Grup sayi artiq dolub. Yeni qrup acilisini gozleyin. ");
            }
        }




        public Student GetStudent(int id)
        {
            foreach(var student in Students)
            {
                if (student != null && student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
        public void Search (string searchname, string searchsurname)
        {
            foreach (var student in Students)
            {
                if (student != null && (student.Name.Contains(searchname) && student.Surname.Contains(searchsurname)))
                {
                    Console.WriteLine($"Id {student.Id} {student.Name} {student.Surname}");
                    break;

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz telebe yoxdur.");
                    break;

                }
            }
        }
        public void ShowStudents()
        {
            Console.WriteLine($"Students in Group '{GroupName}'");

            foreach (var student in Students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}");
            }

        }
        public int StudentCount()
        {
            int count = 0;
            foreach(var student in Students)
            {
                if(student != null)
                {
                    count++;
                }
            }
            return count;

        }
        public override string ToString()
        {
            return $"Group Id: {GroupId}, Group Name: {GroupName}, Number of Students: {StudentCount}";
        }
        public static void AddGroup(Group group)
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i] == null)
                {
                    Groups[i] = group;
                    break;
                }
            }
        }
        public void RemoveGroup(int id)
        {
            for(int i=0; i < Groups.Length; i++)
            {
                if (Groups[i] != null && Groups[i].GroupId == id)
                {
                    Groups[i] = null;
                    Console.WriteLine($"Group with Id {id} removed successully");
                    return;
                }
            }

            Console.WriteLine($"Group with Id {id} not found.");
        }
        public Group GetGroup(int id)
        {
            foreach(var group in Groups)
            {
                if(group !=null && GroupId == id)
                {
                    return group;
                }
            }
            return null;
        }

        public void AddStudent(Student student)
        {
            Console.WriteLine("sasd");
        }



        //internal void AddStudent(Student student)
        //{
        //    throw new NotImplementedException("shds");
        //}
    }
}
