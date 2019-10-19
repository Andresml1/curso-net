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
                Id = Guid.NewGuid(),
                Age = 17,
                Name = "Juena",
                LastName = "Galle",
                Nit = "256468251"

            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 28,
                Name = "Morena",
                LastName = "Gale",
                Nit = "551468251"

            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 87,
                Name = "Juan",
                LastName = "alle",
                Nit = "65768251"

            });
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }
    }
}
