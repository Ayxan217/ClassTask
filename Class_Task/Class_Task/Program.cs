using Class_Task.Models;

namespace Class_Task
{
    public class Program:Student
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Ayxan",
                Surname = "Mammadli",
                Group = "TK-96",
                Point = 37,
                
            };

            student.CheckGradiation();
            student.Getİnfo();
            student.GetDiplomaDegree();
            Console.Read();// yene console problemi


        }
    }
}
