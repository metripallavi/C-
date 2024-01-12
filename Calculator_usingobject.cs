using System;
namespace Calculator
  {
    class Calculator 
       {
         int a,b,c;
          public void Accept()
          {
           Console.WriteLine("enter a \n");
           int a=int.Parse(Console.ReadLine()args[0]);
           Console.WriteLine("enter b \n");
           int b=int.Parse(Console.ReadLine());
           Console.WriteLine( " Result of C are " );
           int c=int.Parse(Console.ReadLine());
           c=a+b;
          
          }
          public void Add()        //USE SWITCH
           {
            
            
            c=a+b;

            }
          public void Sub() 
           {
     
            Console.WriteLine(" substraction of 2 numbers is" +c);
            c=a-b;

            }
           public void Mul()
          
           {

            Console.WriteLine(" Multiplication of 2 numbers is " +c);
            c=a*b;

            }

          public void Div()
           {

            Console.WriteLine(" division of 2 numbers is " +c);
            c=a/b;

            }
  public static void Main(String[] args)
     {
        Calculator w=new Calculator();
          w.Accept();
          w.Add();
          w.Sub();
          w.Mul();
          w.Div();
      }
   }
}
 
       