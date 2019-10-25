using System;

namespace Mert_Kaymaz_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Department CET = new Department();
            CET.Code = "CET";
            CET.Name = "Bilgisayar ve Öğretim Teknolojileri";
            CET.CreditCount = 15;


            Department fled = new Department();
            fled.Code = "FLED";
            fled.Name = "Yabancı Diller Eğitimi";
            fled.CreditCount = 10;

            Student s1 = new Student();
            s1.StudentNumber = "2016100132";
            s1.NameSurname = "Mert Kaymaz";
            s1.Department = CET;

            Student s2 = new Student();
            s2.StudentNumber = "2018100123";
            s2.NameSurname = "Sude Vural";
            s2.Department = CET;

            Course cet101 = new Course();
            cet101.Code = "CET 101";
            cet101.Name = "Intro. to Edu. Tech.";
            cet101.Credit = 4;


            Course math101 = new Course();
            math101.Code = "MATH 101";
            math101.Name = "Calculus 1";
            math101.Credit = 4;

            Course phys101 = new Course();
            phys101.Code = "PHYS 101";
            phys101.Name = "Physics 1";
            phys101.Credit = 4;

            Course ed101 = new Course();
            ed101.Code = "ED 101";
            ed101.Name = "Intro. to Edu.";
            ed101.Credit = 3;

            Course ae111 = new Course();
            ae111.Code = "AE 111";
            ae111.Name = "Advanced English 1";
            ae111.Credit = 3;

            Course cet511 = new Course();
            cet511.Code = "CET 511";
            cet511.Name = "Theo. Found. of Tech. Based Learning Env.";
            cet511.Credit = 3;

            Course cet561 = new Course();
            cet561.Code = "CET 561";
            cet561.Name = "Research Methods in Educational Technology";
            cet561.Credit = 3;

            Course cet102 = new Course();
            cet102.Code = "CET 102";
            cet102.Name = "Info. Systems in Education and Information Design";
            cet102.Credit = 4;

            Course math201 = new Course();
            math201.Code = "MATH 201";
            math201.Name = "Calculus 2";
            math201.Credit = 4;

            Course phys130 = new Course();
            phys130.Code = "PHYS 130";
            phys130.Name = "Physics 2";
            phys130.Credit = 4;

            Course ae112 = new Course();
            ae112.Code = "AE 112";
            ae112.Name = "Advanced English 2";
            ae112.Credit = 3;

            Course cmpe150 = new Course();
            cmpe150.Code = "CMPE 150";
            cmpe150.Name = "Introduction to Computing";
            cmpe150.Credit = 3;




            StudentCourse MertCet101 = new StudentCourse(cet101, LetterGrade.BA, Semester.Fall);
            s1.Courses.Add(MertCet101);
            StudentCourse MertMath101 = new StudentCourse(math101, LetterGrade.BA, Semester.Fall);
            s1.Courses.Add(MertMath101);
            StudentCourse MertPhys101 = new StudentCourse(phys101, LetterGrade.CB, Semester.Fall);
            s1.Courses.Add(MertPhys101);
            StudentCourse MertAe111 = new StudentCourse(ae111, LetterGrade.AA, Semester.Fall);
            s1.Courses.Add(MertAe111);
            StudentCourse MertEd101 = new StudentCourse(ed101, LetterGrade.BB, Semester.Fall);
            s1.Courses.Add(MertEd101);
            StudentCourse MertCet102 = new StudentCourse(cet102, LetterGrade.AA, Semester.Spring);
            s1.Courses.Add(MertCet102);
            StudentCourse MertMath201 = new StudentCourse(math201, LetterGrade.AA, Semester.Spring);
            s1.Courses.Add(MertMath201);
            StudentCourse MertPhys130 = new StudentCourse(phys130, LetterGrade.CB, Semester.Spring);
            s1.Courses.Add(MertPhys130);
            StudentCourse MertAe112 = new StudentCourse(ae112, LetterGrade.BA, Semester.Spring);
            s1.Courses.Add(MertAe112);
            StudentCourse MertCmpe150 = new StudentCourse(cmpe150, LetterGrade.BB, Semester.Spring);
            s1.Courses.Add(MertCmpe150);






            StudentCourse SudeCet101 = new StudentCourse(cet101, LetterGrade.BA, Semester.Fall);
            s2.Courses.Add(SudeCet101);
            StudentCourse SudeMath101 = new StudentCourse(math101, LetterGrade.DC, Semester.Fall);
            s2.Courses.Add(SudeMath101);
            StudentCourse SudePhys101 = new StudentCourse(phys101, LetterGrade.AA, Semester.Fall);
            s2.Courses.Add(SudePhys101);
            StudentCourse SudeAe111 = new StudentCourse(ae111, LetterGrade.AA, Semester.Fall);
            s2.Courses.Add(SudeAe111);
            StudentCourse SudeEd101 = new StudentCourse(ed101, LetterGrade.DD, Semester.Fall);
            s2.Courses.Add(SudeEd101);
            StudentCourse SudeCet102 = new StudentCourse(cet102, LetterGrade.CC, Semester.Spring);
            s2.Courses.Add(SudeCet102);
            StudentCourse SudeMath201 = new StudentCourse(math201, LetterGrade.CC, Semester.Spring);
            s2.Courses.Add(SudeMath201);
            StudentCourse SudePhys130 = new StudentCourse(phys130, LetterGrade.F, Semester.Spring);
            s2.Courses.Add(SudePhys130);
            StudentCourse SudeAe112 = new StudentCourse(ae112, LetterGrade.BA, Semester.Spring);
            s2.Courses.Add(SudeAe112);
            StudentCourse SudeCmpe150 = new StudentCourse(cmpe150, LetterGrade.BB, Semester.Spring);
            s2.Courses.Add(SudeCmpe150);



            Console.WriteLine(s1.NameSurname + " / Department = " + s1.Department.Code);
            Console.WriteLine("GPA = " + s1.CalculateGPA() + " / Can Graduate = " + s1.CanGraduate());
            Console.WriteLine("COURSES");
            Console.WriteLine("Semester 1 / SPA: " + s1.CalculateSPA(Semester.Fall));
            Console.WriteLine(math101.Code + " / " + math101.Name + " / " + "Credit = " + math101.Credit + " / " + " Grade: " + MertMath101.Grade);
            Console.WriteLine(phys101.Code + " / " + phys101.Name + " / " + "Credit = " + phys101.Credit + " / " + " Grade: " + MertPhys101.Grade);
            Console.WriteLine(ae111.Code + " / " + ae111.Name + " / " + "Credit = " + phys101.Credit + " / " + " Grade: " + MertAe111.Grade);
            Console.WriteLine(cet101.Code + " / " + cet101.Name + " / " + "Credit = " + cet101.Credit + " / " + " Grade: " + MertCet101.Grade);
            Console.WriteLine(ed101.Code + " / " + ed101.Name + " / " + "Credit = " + ed101.Credit + " / " + " Grade: " + MertEd101.Grade);
            Console.WriteLine("Semester 2 / SPA: " + s1.CalculateSPA(Semester.Spring));
            Console.WriteLine(cet102.Code + " / " + cet102.Name + " / " + "Credit = " + cet102.Credit + " / " + " Grade: " + MertCet102.Grade);
            Console.WriteLine(math201.Code + " / " + math201.Name + " / " + "Credit = " + math201.Credit + " / " + " Grade: " + MertMath201.Grade);
            Console.WriteLine(phys130.Code + " / " + phys130.Name + " / " + "Credit = " + phys130.Credit + " / " + " Grade: " + MertPhys130.Grade);
            Console.WriteLine(cmpe150.Code + " / " + cmpe150.Name + " / " + "Credit = " + cmpe150.Credit + " / " + " Grade: " + MertCmpe150.Grade);
            Console.WriteLine(ae112.Code + " / " + ae112.Name + " / " + "Credit = " + ae112.Credit + " / " + " Grade: " + MertAe112.Grade);




            Console.WriteLine("\n" + s2.NameSurname + " / Department = " + s2.Department.Code);
            Console.WriteLine("GPA =" + s2.CalculateGPA() + " / Can Graduate = " + s2.CanGraduate());
            Console.WriteLine("COURSES");
            Console.WriteLine("Semester 1 / SPA: " + s2.CalculateSPA(Semester.Fall));
            Console.WriteLine(math101.Code + " / " + math101.Name + " / " + "Credit = " + math101.Credit + " / " + " Grade: " + SudeMath101.Grade);
            Console.WriteLine(phys101.Code + " / " + phys101.Name + " / " + "Credit = " + phys101.Credit + " / " + " Grade: " + SudePhys101.Grade);
            Console.WriteLine(ae111.Code + " / " + ae111.Name + " / " + "Credit = " + ae111.Credit + " / " + " Grade: " + SudeAe111.Grade);
            Console.WriteLine(cet101.Code + " / " + cet101.Name + " / " + "Credit = " + cet101.Credit + " / " + " Grade: " + SudeCet101.Grade);
            Console.WriteLine(ed101.Code + " / " + ed101.Name + " / " + "Credit = " + ed101.Credit + " / " + " Grade: " + SudeEd101.Grade);
            Console.WriteLine("Semester 2 / SPA: " + s2.CalculateSPA(Semester.Spring));
            Console.WriteLine(cet102.Code + " / " + cet102.Name + " / " + "Credit = " + cet102.Credit + " / " + " Grade: " + SudeCet102.Grade);
            Console.WriteLine(math201.Code + " / " + math201.Name + " / " + "Credit = " + math201.Credit + " / " + " Grade: " + SudeMath201.Grade);
            Console.WriteLine(phys130.Code + " / " + phys130.Name + " / " + "Credit = " + phys130.Credit + " / " + " Grade: " + SudePhys130.Grade);
            Console.WriteLine(cmpe150.Code + " / " + cmpe150.Name + " / " + "Credit = " + cmpe150.Credit + " / " + " Grade: " + SudeCmpe150.Grade);
            Console.WriteLine(ae112.Code + " / " + ae112.Name + " / " + "Credit = " + ae112.Credit + " / " + " Grade: " + SudeAe112.Grade);




            MasterStudent ms1 = new MasterStudent();
            Console.WriteLine("\nMaster Student");
            ms1.NameSurname = "Ayşe Başak Demir";
            ms1.Department = CET;
            StudentCourse BasakCet511 = new StudentCourse(cet511, LetterGrade.BA, Semester.Fall);
            ms1.Courses.Add(new StudentCourse(cet511, LetterGrade.BA, Semester.Fall));
            StudentCourse BasakCet561 = new StudentCourse(cet561, LetterGrade.CC, Semester.Fall);
            ms1.Courses.Add(new StudentCourse(cet561, LetterGrade.CC, Semester.Fall));
            ms1.ThesisTopic = "Distance Education";
            ms1.IsThesisCompleted = true;

            Console.WriteLine(ms1.NameSurname + " / Department = " + ms1.Department.Code);
            Console.WriteLine("Thesis Topic = " + ms1.ThesisTopic);
            Console.WriteLine("GPA =" + ms1.CalculateGPA() + " / Can Graduate = " + s1.CanGraduate());
            Console.WriteLine("COURSES");
            Console.WriteLine("Semester 1 / SPA: " + ms1.CalculateSPA(Semester.Fall) );
            Console.WriteLine(cet511.Code + " / " + cet511.Name + " / " + "Credit = " + cet511.Credit + " / " + " Grade: " + BasakCet511.Grade);
            Console.WriteLine(cet561.Code + " / " + cet561.Name + " / " + "Credit = " + cet561.Credit + " / " + " Grade: " + BasakCet561.Grade);


            Console.ReadLine();


        }
    }
}

