using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                //Id = Guid.NewGuid(),
                Age = 17,
                Name = "Juena",
                LastName = "Galle",
                Nit = "256468251"

            });

            Students.Add(new Student
            {
                //Id = Guid.NewGuid(),
                Age = 28,
                Name = "Morena",
                LastName = "Gale",
                Nit = "551468251"

            });

            Students.Add(new Student
            {
                //Id = Guid.NewGuid(),
                Age = 87,
                Name = "Juan",
                LastName = "alle",
                Nit = "65768251"

            });
        }

        internal void EditStudent(Student student)
        {
            Student currentStudent = GetStudentById(student.Id);
            currentStudent.Nit = student.Nit;
            currentStudent.Name = student.Name;
            currentStudent.LastName = student.LastName;
            currentStudent.Age = student.Age;

        }

        internal Student GetStudentById(Guid id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        internal void AddStudent(Student student)
        {

            Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }
    }
}
