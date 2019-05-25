using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF5_1_2.Models;

namespace WPF5_1_2.Context
{
    class CourseDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
