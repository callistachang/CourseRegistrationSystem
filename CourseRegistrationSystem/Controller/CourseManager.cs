﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseRegistrationSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistrationSystem.Controller
{
    public class CourseManager
    {
        public readonly DbSet<Course> Courses;

        public CourseManager(DbSet<Course> courses)
        {
            Courses = courses;
        }
    }
}
