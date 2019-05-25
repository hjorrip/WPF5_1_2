namespace WPF5_1_2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WPF5_1_2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WPF5_1_2.Context.CourseDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WPF5_1_2.Context.CourseDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            CourseType ct1 = new CourseType()
            {
                Name = "Forritun"
            };

            CourseType ct2 = new CourseType()
            {
                Name = "Kerfisstjórn"
            };

            CourseType ct3 = new CourseType()
            {
                Name = "Grafísk Hönnun"
            };

            context.CourseTypes.AddOrUpdate(
                n => n.Name,
                ct1,
                ct2,
                ct3
                );

            context.SaveChanges();


            Course c1 = new Course()
            {
                Name = "WPF",
                CourseType = ct1,
            };

            Course c2 = new Course()
            {
                Name = "C#",
                CourseType = ct1,
            };

            Course c3 = new Course()
            {
                Name = "Cisco",
                CourseType = ct2,
            };

            Course c4 = new Course()
            {
                Name = "Adobe Photoshop",
                CourseType = ct3,
            };


            Student s1 = new Student()
            {
                FirstName = "Björn",
                LastName = "Bragi",
                DateOfBirth = new DateTime(1990, 08, 12)
            };

            Student s2 = new Student()
            {
                FirstName = "Helga",
                LastName = "Sveinsdóttir",
                DateOfBirth = new DateTime(1991, 09, 13)
            };

            Student s3 = new Student()
            {
                FirstName = "Albert",
                LastName = "Einstein",
                DateOfBirth = new DateTime(1992, 10, 14)
            };

            Student s4 = new Student()
            {
                FirstName = "Hafdís",
                LastName = "Þórhallsdóttir",
                DateOfBirth = new DateTime(1993, 11, 15)
            };


            c1.Students.Add(s1);
            c1.Students.Add(s2);

            c2.Students.Add(s3);
            c2.Students.Add(s4);

            c3.Students.Add(s3);

            context.Courses.AddOrUpdate(
                x => x.Name,
                c1,
                c2,
                c3,
                c4
                );

            context.Students.AddOrUpdate(
                x => new { x.FirstName, x.LastName },
                s1,
                s2,
                s3,
                s4
                );


            context.SaveChanges();

        }
    }
}
