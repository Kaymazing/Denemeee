using System;
using System.Collections.Generic;
using System.Text;

namespace Mert_Kaymaz_HW2
{
    public class MasterStudent : Student
    {
        public MasterStudent() : base()
        {
            mininumGPAForGraduation = 3.0f;
        }
        public string ThesisTopic { get; set; }
        public bool IsThesisCompleted { get; set; }
        public override bool CanGraduate()
        {
            return base.CanGraduate() && IsThesisCompleted;
        }
    }
}