using System; 
namespace Addition
 {
   class Add 
      {
        int a ; 
        public void accept() 
             {
              Console.WriteLine("enter the number");
               int a=int.Parse(Console.ReadLine());
              Console.WriteLine("number is "+a);
             }
      public static void Main(String[] args)
         {
          Add x= new Add();   //WHY USE THIS? WHEN WE GET ANSWER DIRECTLY FROM CONSOLE
           x.accept();
         }
   }

}