using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_2024
{
    public class Group
    {
        private int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get => _studentLimit;

            set
            {
                if (value > 5 && value < 18)
                {
                    _studentLimit = value;
                }
            }
        }
        public Student[] Students;
        public Group(string GroupNo, int StudentLimit)
        {
            Students = new Student[0];
        }
        public bool CheckGroupNo(string groupNo)
        {

            int numberOfLetters = 0;
            int numberOfDigit = 0;

            if (groupNo.Length != 5)
            {
                return false;
            }

            for (int i = 0; i < 2; i++)
            {
                if (char.IsLetter(groupNo[i]))
                {
                    numberOfLetters++;
                }
            }

            for (int i = 2; i <= 5; i++)
            {
                if (char.IsDigit(groupNo[i]))
                {
                    numberOfDigit++;
                }
            }

            return numberOfLetters == 2 && numberOfDigit == 3;
        }

        public void AddStudent(Student student)
        {
            while (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length + 1] = student;
            }
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
    }


}