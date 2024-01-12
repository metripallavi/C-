

using System;
namespace circle
{
 class AREA
   {
     public static void Main (String[] args)
       { 
          int r= int.Parse(args[0]);
         Console.WriteLine(" r= "+ r);
         Console.WriteLine("area = " + (3.142*r*r));
         Console.WriteLine("Perimeter ="+ (2*3.142*r));

        }
   }

}