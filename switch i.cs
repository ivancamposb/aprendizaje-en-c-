using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    
   string week; 
   int semana;
   int resultado;
   
   conversion c1 = new conversion ();
   
   Console.WriteLine("Seleccione un día de la semana");
   week = Console.ReadLine();
   semana = int.Parse(week);
   
   resultado = c1.f(semana);
   switch (resultado) 
      {
         case 3: 
         Console.WriteLine("Today is Wednesday"); 
         break; 
        case 4: 
        Console.WriteLine("Today is Thursday");
        break; 
        case 5: 
        Console.WriteLine("Today is Friday!");
        break;
        case 6: 
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
          
         }
   
   
    }
  }
}
     
     public class conversion {
     
     
     public int f (int semana)
     {
     
     int a;
     a = semana; 
     return a; 
      
    
   
     }
     
     
     }
     