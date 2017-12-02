using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1._1
{
    class Person
    {
        private string firstName;
        private string lastName;
        private System.DateTime date;

        public String _firstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String _lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public System.DateTime _date
        {
            get { return date; }
            set { date = value; }
        }

        public int year
        {
            get { return date.Year; }
            private set
            {
                date = new DateTime(value, date.Month, date.Day);
            }
        }

        public Person(String firstName, String lastName, System.DateTime date)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.date = date;
        }

        public Person()
        {
            firstName = "";
            lastName = "";
            date = new DateTime(1992, 1, 1);

        }

        public override string ToString()
        {
            return "LastName: " + _lastName + '\n' + 
                "FirstName: " + _firstName + '\n' +
                "Date: " + _date;
        }

        public virtual String ToShortStrig()
        {
            return "LastName: " + _lastName + '\n' +
                "FirstName: " + _firstName;
        }
    }
}
