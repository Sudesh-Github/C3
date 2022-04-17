using System;
using System.Collections;

namespace Employee5b
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList EmployeeList = new ArrayList();
            EmployeeList.Add("Sandeep");
            EmployeeList.Add("Bhargav");
            EmployeeList.Add("Sujatha");
            EmployeeList.Add("Ganesh");
            EmployeeList.Add("Ranjith");
            EmployeeList.Add("Anamika");
            EmployeeList.Add("Umar");

            ArrayList EmployeeNoList = new ArrayList();
            EmployeeNoList.Add("1234");
            EmployeeNoList.Add("890");
            EmployeeNoList.Add("945");
            EmployeeNoList.Add("1010");
            EmployeeNoList.Add("556");
            EmployeeNoList.Add("334");
            EmployeeNoList.Add("21");
            
           
            foreach (var item in EmployeeList)
            {
                string arrayItem = string.Format($"EmpName  is {item} ");
                Console.WriteLine(arrayItem);
            }


            EmployeeList.AddRange(EmployeeNoList);

            foreach (var item2 in EmployeeNoList)
            {
                string arrayItem2 = string.Format($"EmpNo  is {item2} and ");
                Console.WriteLine(arrayItem2);
            }
            Console.Read();
        }
    }
}