using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_2024
{
    public class Group
    {
        public int GroupNo { get; set; }
        public int StudentLimit { get; set; }
        public Student[] Students { get; set; }
        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
            {
                return false;
            }


            for (int i = 0; i < 2; i++)
            {
                if (char.IsLetter(groupNo[i]))
                {

                    for (int j = 2; j <= 5; j++)
                    {
                        if (char.IsDigit(groupNo[j]))
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
                else
                    return false;
            }


        }
    }
}


