using System;

namespace College
{
    /// <summary>
    /// Represents examination attempted by the student
    /// </summary>
    public class Examination
    {
        public string ExaminationName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int MaxMarks { get; set; }
        public int SecuredMarks { get; set; }
    }
}
