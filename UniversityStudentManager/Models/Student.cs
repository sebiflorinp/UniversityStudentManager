using System;

namespace UniversityStudentManager.Models
{
    class Student
    {
        private int _id;
        private string _name;
        private int _year;

        public Student(int id, string name, int year)
        {
            this._id = id;
            this._name = name;
            this._year = year;
        }

        public int GetId()
        {
            return this._id;
        }

        public string GetName()
        {
            return this._name;
        }

        public int GetYear()
        {
            return this._year;
        }

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public void SetName(string newName)
        {
            this._name = newName;
        }

        public void SetYear(int newYear)
        {
            this._year = newYear;
        }
    }
}