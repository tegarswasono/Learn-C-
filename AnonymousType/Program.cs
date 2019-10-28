using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousType
{
    public class Student
    {
        public int StudentID { set; get; }
        public string StudentName { set; get; }
        public int Age { set; get; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //basic 
            var myAnonymousType = new {
                nim = 13650055,
                nama = "Tegar Swasono",
                aktif = true
            };

            
            //nested anonymous type
            var myAnonymousType2 = new
            {
                nim = 13650055,
                nama = "Tegar Swasono",
                aktif = true,
                alamat= new
                {
                    desa = "Kademangan RT.15 RW.02",
                    kecamatan = "Pagelaran",
                    kabupaten = "Malang"
                }
            };


            //working with linq query
            IList<Student> studentList = new List<Student>
            {
                new Student() {StudentID = 1, StudentName = "Tegar", Age=21},
                new Student() {StudentID = 2, StudentName = "Swasono", Age=24}
            };

            var anonymouse = from s in studentList select new { studentID = s.StudentID, StudentName = s.StudentName };
            var anonymouse2 = from s in studentList select new { studentID = s.StudentID, StudentName = s.StudentName };

            


            Console.WriteLine("Hello World!");
        }
    }
}
