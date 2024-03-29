﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mert_Kaymaz_HW2
{
    public class Student
    {
        public Student()
        {
            Courses = new List<StudentCourse>();
            mininumGPAForGraduation = 2.0f;
        }
        public string NameSurname { get; set; }
        public string StudentNumber { get; set; }

        protected float mininumGPAForGraduation;
        public Department Department { get; set; }

        public float GPA { get; private set; }

        public List<StudentCourse> Courses { get; private set; }

        public virtual bool CanGraduate()
        {
            if (Department == null)
            {
                throw new Exception("Department is not defined");
            }
            if (CalculateGPA() >= mininumGPAForGraduation && HasNoFGrade() && GetTotalCredit() >= Department.CreditCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetTotalCredit()
        {
            int totalCredit = 0;
            foreach (var studentCourse in Courses)
            {
                totalCredit += studentCourse.Course.Credit;
            }
            return totalCredit;
        }

        private bool HasNoFGrade()
        {
            foreach (var studentCourse in Courses)
            {
                if (studentCourse.Grade == LetterGrade.F) return false;
            }
            return true;
        }
        public float CalculateSPA(Semester semester)  
        {
            float gradeCredit = 0f;
            int totalCredit = 0;
            foreach (var studentCourse in Courses)
            {
                if (studentCourse.Semester == semester)
                {
                    totalCredit += studentCourse.Course.Credit;
                    gradeCredit += studentCourse.Course.Credit * studentCourse.GradeValue;
                }
            }


            if (totalCredit == 0) return 0f;

            return gradeCredit / totalCredit;

        }






        public float CalculateGPA()
        {
            float gradeCredit = 0f;
            int totalCredit = 0;
            foreach (var studentCourse in Courses)
            {
                totalCredit += studentCourse.Course.Credit;
                gradeCredit += studentCourse.Course.Credit * studentCourse.GradeValue;
            }


            if (totalCredit == 0) return 0f;

            return (gradeCredit / totalCredit);

        }
    }
}