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
                Point = 78,
                İsGraduated =false
            };

            student.Getİnfo();
            student.CheckGradiation();
            student.GetDiplomaDegree();


        }
    }
}
