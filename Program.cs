using System.Security.Cryptography.X509Certificates;

namespace Assignment5
{
    internal class Program
    {
        //1-a
        public static int cube(int num)
        {     // num is passed by value
              // therefore the original value of the number will not change
            return num * num * num;
        }
        //1-b
        static void SquareIt(ref int x)
        // The parameter x is passed by reference.
        // Changes to x will affect the original value of x.
        {
            x *= x;
            Console.WriteLine($"The value inside the method: {x}");
        }
        //2-a
        static void Change(int[] Array)
        {
            Array[0] = 888;  // This change affects the original element.
            Array = new int[5] { -3, -1, -2, -3, -4 };   // This change is local.
            Console.WriteLine($"Inside the method, the first element is: {Array[0]}");
        }
        //2-b
        static void Changeref(ref int[] Array)
        {
            //Both changes will affect the original value.
            Array[0] = 888;  
            Array = new int[5] { -3, -1, -2, -3, -4 };   
            Console.WriteLine($"Inside the method, the first element is: {Array[0]}");
        }
        
        //3
        public static void SumSub(int Num1, int Num2, out int sum, out int sub)
        {
            sum = Num1 + Num2;
            sub = Num1 - Num2;
        }
        [Flags] //attribute so that we can add permissions together
        enum Permissions : byte
        {
            Read=1 , Write=2 ,Delete=4 , Execute=8
        }

        static void Main(string[] args)
        {
            #region P1
            //1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //Value Type: A value type variable directly contains data in the memory.
            //1)By Value : Passing by value means passing a copy of the variable to the method and we operate on the copies without changing the original variables.
            //2)By reference : Passing by Reference  means Passing access to the original variable to the method
            //ex : on Value type parameter (passing by value)
            //
            //int val, number;
            //number = 5;
            ////Passing the copy value of number variable
            //val = Program.cube(number);
            //Console.Write(val); //125


            // ex on : Passing Value type parameter by reference

            //int number = 5;
            //Console.WriteLine($"The value before calling the function is {number}");
            //SquareIt(ref number);  // Passing the variable by reference.
            //Console.WriteLine($"The value after calling the method: {number}"); //The original value of the number has changed as we passed value type parameter by reference


            #endregion


            #region P2
            ////2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //// passing reference type (Array) by value
            //int[] arr1= { 1, 2,3 };
            //Change(arr1);
            //Console.WriteLine($"Inside Main, after calling the method, the first element is: {arr1[0]}");



            ////// Passing Reference type parameter by Reference : 
            ////int[] arr = { 1, 4, 5 };
            ////Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);

            ////Changeref(ref arr);
            ////Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);

            #endregion


            #region P3
            ////// 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            ////int A = 0, B=0;
            ////Console.WriteLine("Please enter the value of the first Number");
            ////A=int.Parse(Console.ReadLine());
            ////Console.WriteLine("Please enter the value of the second Number");
            ////B= int.Parse(Console.ReadLine());

            ////SumSub(A, B, out int sum, out int sub);

            ////Console.WriteLine($"The Value of the sum is {sum}");
            ////Console.WriteLine($"The Value of the sub is {sub}");

            #endregion

            #region P4
            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            /*Create Variable from previous Enum to Add and Remove Permission from variable
             check if specific Permission is existed inside variable
            */
            ////Permissions per = Permissions.Delete;
            ////Console.WriteLine($"permission now is set to : {per}");

            //////to add permission 
            ////per |= Permissions.Execute;
            ////per |= Permissions.Read;
            ////per |= Permissions.Write;

            ////Console.WriteLine($"after adding permissions , permission now is set to : {per}");


            ////// to remove permissions 

            ////per &= (~Permissions.Write);
            ////per &= (~Permissions.Read);
            
            ////Console.WriteLine($"after removing permissions , permission now is set to : {per}");

            /////// to check if a specific permission is existed or not

            ////if ((per & Permissions.Delete) == Permissions.Delete)
            ////{
            ////    Console.WriteLine("Delete exists");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Delete does not exist");
            ////}
            #endregion
        }
    }
}