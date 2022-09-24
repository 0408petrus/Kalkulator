using System;
using System.Text;
namespace Program
{
 class Program{
    
    static void Main(string[] args){
        double num,a,b;
        A:
        Console.WriteLine("Enter the action to be performed");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Substraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        num = Convert.ToDouble(Console.ReadLine());

        
        switch(num){
            case 1:
            Console.WriteLine("Enter 1st Input");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Input");
            b = Convert.ToDouble(Console.ReadLine());
            Addition(a,b);
                break; 
            case 2:
            Console.WriteLine("Enter 1st Input");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Input");
            b = Convert.ToDouble(Console.ReadLine());
            Substraction(a,b);
                break;
            case 3:
            Console.WriteLine("Enter 1st Input");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Input");
            b = Convert.ToDouble(Console.ReadLine());
            Multiplication(a,b);
                break;
            case 4:
            Console.WriteLine("Enter 1st Input");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Input");
            b = Convert.ToDouble(Console.ReadLine());
            Division(a,b);
                break;
            default:
                Console.WriteLine("Input wrong!");
                Console.ReadLine();
                Console.Clear();
                goto A;
        }
    }

    static void Addition(int a,int b){
        Console.WriteLine("The result is {0}",a+b);
    }
    static double Addition(double a,double b){
        Console.WriteLine("The result is {0}",a+b);
        return a+b;
    }
    static void Substraction(int a,int b){
        Console.WriteLine("The result is {0}",a-b);

    }
    static void Substraction(double a,double b){
        Console.WriteLine("The result is {0}",a-b);

    }
    static void Multiplication(int a,int b){
        Console.WriteLine("The result is {0}",a*b);

    }
    static void Multiplication(double a,double b){
        Console.WriteLine("The result is {0}",a*b);

    }
    static void Division(int a,int b){
        Console.WriteLine("The result is {0}",a/b);

    }
    static void Division(double a,double b){
        Console.WriteLine("The result is {0}",a/b);

    }

    //Method atau biasa dipanggil sebagai fungsi


 }   
}
