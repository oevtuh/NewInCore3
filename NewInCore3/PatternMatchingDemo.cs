using System;
using System.Collections.Generic;
using System.Text;


namespace NewInCore3
{    
    public class PatternMatchingDemo
    {
        public static void DoPositionalPatternDemo()
        {
            var mathTeacher = new Teacher("Alex", "Smith", "Math");
            var student = new Student("John", "Doe", mathTeacher, 7);

            var result = PositionalPatternSample.IsInSeventhGradeMath(student);

            Console.WriteLine($"{student.FirstName} is in 7th grade math? {result}");
        }

        public static void DoPropertyPatternDemo()
        {
            var ukManager = new Employee
            {
                FirstName = "David",
                LastName = "Smith",
                Region = "UK",
                Type = "Global Director"
            };

            var employee = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
                Region = "US",
                ReportsTo = ukManager,
                Type = "Director"
            };

            var result = PropertyPatternSample.IsUsBasedWithUkManager(employee);

            Console.WriteLine($"{employee.FirstName} is US-based with UK-manager? {result}");
        }

        public static void DoSwitchExpressionDemo()
        {
            var shape = new Rectangle(5, 5);

            Console.WriteLine(SwitchExpressionSample.DisplayShapeInfo(shape));
        }

        public static void DoTupleExpressionDemo()
        {
            Console.WriteLine($"{TuplePatternSample.GetColor(Color.Blue, Color.Red)}");
            Console.WriteLine($"{TuplePatternSample.GetColor(Color.Blue, Color.Blue)}");
        }
    }    
}
