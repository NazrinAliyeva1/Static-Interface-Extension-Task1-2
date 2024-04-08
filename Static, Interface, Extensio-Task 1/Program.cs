using Static__Interface__Extensio_Task_1.Extensions;
using Static__Interface__Extensio_Task_1.Models;
using System.Text.RegularExpressions;

namespace Static__Interface__Extensio_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = " SaLdfKDF21 ";
            string capitalized = example.Capitalize();
            Console.WriteLine(capitalized);

            // Check IsOdd and IsEven

            int number = 4;
            bool isOdd = Helper.CheckIsOdd(number);
            bool isEven = Helper.CheckIsEven(number);
            Helper.IsOdd = isOdd;
            Helper.IsEven = isEven;

     
            if (isOdd)
            {
                Console.WriteLine($"{number} is odd.");
            }
            else
            {
                Console.WriteLine($"{number} is not odd.");
            }
            if (isEven)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is not even.");
            }

            //Check if Password is valid
            Console.WriteLine("Lutfen bir sifre daxil edin:");
            string password = Console.ReadLine();
            bool isPasswordValid = Helper.CheckPassword(password);
            if( isPasswordValid )
            {
                Console.WriteLine("Sifre kecerlidir.");
            }
            else
            {
                Console.WriteLine("Sifre yanlisdir.");
            }




            //Check if a string has at least one digit
            string inputString = "JDl4SJ87fg";
            bool hasDigit = Helper.CheckHasDigit(inputString);

            if (hasDigit)
            {
                Console.WriteLine($"{inputString} contains at least one digit.");
            }
            else
            {
                Console.WriteLine($"{inputString} does not contains any digits. ");
            }

            //Extension metodu istifade etme
            string capitalizedname = "NaZRiN".Capitalize();
            Console.WriteLine($"\nCapitalized Name: {capitalizedname}");


            //Group yaratma

            Group group1 = new Group("Kimya");
            Group group2 = new Group("Fizika");
            Group group3 = new Group("Riyaziyyat");


            //Student numuneleri yaratmaq
            Student student = new Student("sahil", "sahilli");
            Student student2 = new Student("asil", "asilli");
            Student student3 = new Student("nazrin", "aliyeva");

            Student student4 = new Student("Cahid", "Camalli");
            Student student5 = new Student("Cavid", "Ceferli");
            Student student6 = new Student("Ramiz", "Rasidzade");

            Student student7 = new Student("Fariz", "Ferrux");
            Student student8 = new Student("Nergiz", "Mikayilova");

            group1.AddStudent(student);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
             
            group2.AddStudent(student4);
            group2.AddStudent(student5);
            group2.AddStudent(student6);

            group3.AddStudent(student7);
            group3.AddStudent(student8);


            
            // Grup melumatlarini almaq
            Console.WriteLine("Group Information:");
            group1.GetGroupInfo(group1);
            student.GetInfo();
            student2.GetInfo();
            student3.GetInfo();

            group2.GetGroupInfo(group2);
            student4.GetInfo();
            student5.GetInfo();
            student6.GetInfo();

            group3.GetGroupInfo(group3);
            student7.GetInfo();
            student8.GetInfo();




            Console.WriteLine($"Total number of students in the group: {group1.GroupId}");


            Console.WriteLine("\nBefore removing group:");
            group1.GetGroupInfo(group1);
            group2.GetGroupInfo(group2);
            group3.GetGroupInfo(group3);

            int groupIdToRemove = group1.GroupId;
            group2.RemoveGroup(groupIdToRemove);

            Console.WriteLine("\nAfter removing group:");





        }
    }
}
