using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> Teachers = new List<Teacher>();
            Teachers.Add(new Teacher("Ebbe", 1, 24000));
            Teachers.Add(new Teacher("Soeren", 2, 22000));
            Teachers.Add(new Teacher("Peter", 3, 23000));
            Teachers.Add(new Teacher("Lars", 4, 30000));


             //Query Syntax
            //var QuerySyntaxAll = from t in Teachers select t._name;

            //foreach (var teacher in QuerySyntaxAll)
            //{
            //    Console.WriteLine(teacher);
            //}


            //Expression Syntax
            //var ExpressionSyntaxAll = Teachers.Select(teach => teach._name);
            //foreach (var teacher in ExpressionSyntaxAll)
            //{
            //    Console.WriteLine(teacher);
            //}


            // Query Syntax
            //var QuerySyntaxHighSalary = from t in Teachers where t._salary > 23000 select t._name;
            //foreach (var teacher in QuerySyntaxHighSalary)
            //{
            //    Console.WriteLine(teacher);
            //}

            //Expression Syntax
            //var ExpressionSyntaxHighSalary = Teachers.Where(teach => teach._salary > 23000);

            //foreach (var teacher in ExpressionSyntaxHighSalary)
            //{
            //    Console.WriteLine(teacher._name);
            //}


            //Query Syntax
            //var QuerySyntaxOrderedNames = from t in Teachers orderby t._name select t._name;
            //foreach (var teacher in QuerySyntaxOrderedNames)
            //{
            //    Console.WriteLine(teacher);
            //}


            //Expression Syntax
            //var ExpressionSyntaxOrderedByNames = Teachers.OrderBy(teach => teach._name);

            //foreach (var teacher in ExpressionSyntaxOrderedByNames)
            //{
            //    Console.WriteLine(teacher._name);
            //}

        }
    }
}
