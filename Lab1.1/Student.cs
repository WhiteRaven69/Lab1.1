using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1._1
{
    class Student : Person
    {
        private Person datePerson;
        private Education formOfTraining;
        private int? groupNumber;
        private List<Exam> passedExam;

        public Person _datePerson
        {
            get { return datePerson; }
            set { datePerson = value; }
        }

        public Education _formOfTraining
        {
            get { return formOfTraining; };
            set { formOfTraining = value; }
        }

        public int? _groupNumber
        {
            get { return groupNumber; }
            set
            {
                if (value <= 100 || value >= 699) throw new Exception("Error! \n Range of value (100 - 699)");
                else groupNumber = value;
            }
        }

        public List<Exam> _passedExam
        {
            get { return passedExam; }
            set { passedExam = value; }
        }
        public Student(Person datePerson, Education formOfTraining, int groupNumber)
        {
            this.datePerson = datePerson;
            this.formOfTraining = formOfTraining;
            this.groupNumber = groupNumber;
            passedExam = new List<Exam>();
        }

        public Student()
        {
            datePerson = null;
            formOfTraining = 0;
            groupNumber = null;
            passedExam = new List<Exam>();
        }


    }
}
