using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1._1
{
    class Exam
    {
        public string objName;
        public int valuation;
        public DateTime examDate;
        
        public Exam(string objName, int valuation, DateTime examDate)
        {
            this.objName = objName;
            this.valuation = valuation;
            this.examDate = examDate;
        }

        public Exam()
        {
            objName = "";
            valuation = 0;
            examDate = new DateTime(1999, 4, 22);
        }

        public override string ToString()
        {
            return "ObjectName: " + objName + '\n' +
                "Valuation: " + valuation + '\n' +
                "ExamDate: " + examDate;
        }
    }
}
