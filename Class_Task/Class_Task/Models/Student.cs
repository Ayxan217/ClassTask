using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task.Models
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool İsGraduated;
       

       
        
        public void CheckGradiation()
        {

   
           
            if (Point>65)
            {
                İsGraduated = true;
                Console.WriteLine("mezundur");

            }
            else
            {
                İsGraduated = false;
                Console.WriteLine("mezun olmayıb");
            }
        }
        public void Getİnfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point} Gratuation: {İsGraduated}");
        }
        public  void GetDiplomaDegree()
        {
          
                if (Point < 65)
                {
                    Console.WriteLine("diplom yoxdur");
                    
                }
                else if(Point>=65 && Point < 80)
                {
                    Console.WriteLine("adi diplom");
                    
                }
                else if(Point>80 && Point <= 90)
                {
                    Console.WriteLine("şeref diplomu");
                    
                }
                else if (Point >90)
                {
                    Console.WriteLine(" yüksek şeref diplomu");
                    

                }
            
        }
    }
}
