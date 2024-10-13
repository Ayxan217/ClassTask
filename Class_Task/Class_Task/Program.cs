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
                Group = "BP-217",
                Point = 97,
                
            };

            student.CheckGradiation();
            student.Getİnfo();
            student.GetDiplomaDegree();
            Console.Read();// yene console problemi


        }
    }
}
