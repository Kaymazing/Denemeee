using System;
using System.Collections.Generic;
using System.Text;

namespace Mert_Kaymaz_HW2
{
    public enum LetterGrade { F, DD = 2, DC, CC, CB, BB, BA, AA }
    public enum Semester { Fall, Spring, Summer }
    public class StudentCourse
    {
        public StudentCourse(Course course, LetterGrade grade, Semester semester)
        {
            Course = course;
            Grade = grade;
            Semester = semester;
        }
        public Course Course { get; set; }
        public LetterGrade Grade { get; set; }
        public Semester Semester { get; set; }
        public float GradeValue
        {
            get
            {
                return ((int)Grade) / 2f;
            }
        }
    }

}

