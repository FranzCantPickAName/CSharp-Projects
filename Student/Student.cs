
namespace ConsoleApp1
{
    public class Student
    {
        public void DisplaySubjects(params string[] subjects)
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }
        }

        public void DisplayMarks(int marks1, int marks2, int marks3)
        {
            double avgMarks = getAverageMarks(marks1, marks2, marks3);
            Console.WriteLine("Marks 1: " + marks1);
            Console.WriteLine("Marks 2: " + marks2);
            Console.WriteLine("Marks 3: " + marks3);
            Console.WriteLine("Average Marks: " + avgMarks);

            static double getAverageMarks(int m1, int m2, int m3)
            {
                double avg;
                avg = (double)(m1 + m2 + m3) / 3;
                return avg;
            }

        }

        public double Fib(int number)
        {
            if (number > 1)
            {
                return Fib(number - 1) + Fib(number - 2);
            }
            return number;
        }

    }

        
}
