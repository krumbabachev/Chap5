using System;

namespace Chap5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1--------------------------------------------------

            {
                Console.Write("A: ");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = Int32.Parse(Console.ReadLine());

                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }

                Console.WriteLine("A - {0}, B - {1}.", a, b);
            }

            //2--------------------------------------------------
            Console.Write("C : ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("D : ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("E : ");
            int e = Int32.Parse(Console.ReadLine());


            if (c < 0 && d < 0 && e < 0)
            {
                Console.WriteLine("-");
            }
            else if (c >= 0 && d >= 0 && e >= 0)
            {
                Console.WriteLine("+");
            }

            else if (c < 0 && d < 0 && e >= 0)
            {
                Console.WriteLine("+");
            }
            else if (c < 0 && d >= 0 && e < 0)
            {
                Console.WriteLine("+");
            }
            else if (c >= 0 && d < 0 && e < 0)
            {
                Console.WriteLine("+");
            }
            else if (c < 0 && d >= 0 && e >= 0)
            {
                Console.WriteLine("-");
            }
            else if (c >= 0 && d < 0 && e >= 0)
            {
                Console.WriteLine("-");
            }
            else if (c >= 0 && d >= 0 && e < 0)
            {
                Console.WriteLine("-");
            }


            //3-----------------------------------------------------


            Console.Write("F : ");
            int f = Int32.Parse(Console.ReadLine());
            Console.Write("G : ");
            int g = Int32.Parse(Console.ReadLine());
            Console.Write("H : ");
            int h = Int32.Parse(Console.ReadLine());


            if (f > g)
            {
                if (f > h)
                {
                    Console.WriteLine("F is the biggest");
                }
                else if (f < h)
                {
                    Console.WriteLine("H is the biggest");
                }
                else
                {
                    Console.WriteLine("F is equal to C > G");
                }
            }

            else if (g > f)
            {
                if (g > h)
                {
                    Console.WriteLine("G is the biggest");
                }
                else if (g < h)
                {
                    Console.WriteLine("H is the biggest");
                }
                else
                {
                    Console.WriteLine("G is equal to H > F");
                }
            }
            else if (g == f)
            {
                if (g == h)
                {
                    Console.WriteLine("All are equal");

                }

                else if (g < h)
                {

                    Console.WriteLine("H is the biggest");
                }
                else
                {
                    Console.WriteLine("G equals F > H");
                }


            }

            //4----------------------------------------------------------



            Console.Write("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Int32.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    num1 = num1 + num3;
                    num3 = num1 - num3;
                    num1 = num1 - num3;

                    if (num2 > num3)
                    {
                        num1 = num1 + num2;
                        num2 = num1 - num2;
                        num1 = num1 - num2;
                    }
                }
                else if (num1 >= num3)
                {
                    num1 = num1 + num2;
                    num2 = num1 - num2;
                    num1 = num1 - num2;
                }
            }
            else if (num1 == num2)
            {
                if (num1 < num3)
                {
                    num1 = num1 + num3;
                    num3 = num1 - num3;
                    num1 = num1 - num3;
                }
            }
            else
            {
                if (num2 < num3)
                {
                    num2 = num2 + num3;
                    num3 = num2 - num3;
                    num2 = num2 - num3;
                }
                if (num1 < num2)
                {
                    num1 = num1 + num2;
                    num2 = num1 - num2;
                    num1 = num1 - num2;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
            Console.ReadLine();

            //5------------------------------------------------------------------

            Console.Write("Enter number: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: Console.WriteLine("Nula"); break;
                case 1: Console.WriteLine("Edno"); break;
                case 2: Console.WriteLine("Dve"); break;
                case 3: Console.WriteLine("Tri"); break;
                case 4: Console.WriteLine("Chetiri"); break;
                case 5: Console.WriteLine("Pet"); break;
                case 6: Console.WriteLine("Shest"); break;
                case 7: Console.WriteLine("Sedem"); break;
                case 8: Console.WriteLine("Osem"); break;
                case 9: Console.WriteLine("Devet"); break;
                default: Console.WriteLine("Wrong input"); break;

            }

            //6------------------------------------------------------------------

            Console.Write("Input par1 (not 0) = ");
            sbyte par1 = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input par2  = ");
            sbyte par2 = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input par3 = ");
            sbyte par3 = Convert.ToSByte(Console.ReadLine());

            sbyte par4 = (sbyte)(par2 * par2 - 4 * par1 * par3);
            if (par4 < 0)
            {

                Console.WriteLine("\nD = {0}\n No real roots", par4);
            }
            else if (par4 == 0)
            {
                sbyte x1 = (sbyte)(-par2 / 2 * par1);
                Console.WriteLine("\nX={0}", x1);
            }
            else
            {
                sbyte x1 = (sbyte)(-par2 + Math.Sqrt(par4) / 2 * par1);
                sbyte x2 = (sbyte)(-par2 - Math.Sqrt(par4) / 2 * par1);
                Console.WriteLine("\nx1 = {0}\nx2 = {1}", x1, x2);


            }

            //7-----------------------------------------------------------------

            Console.Write("Enter Number = ");
            int a1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Anohter Number = ");
            int b1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Another Number = ");
            int c1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Another number = ");
            int d1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Anohter Number = ");
            int e1 = Int32.Parse(Console.ReadLine());


            if (a1 < b1) a1 = b1;
            if (a1 < c1) a1 = c1;
            if (a1 < d1) a1 = d1;
            if (a1 < e1) a1 = e1;

            Console.WriteLine("{0} is the biggest of the numbers", a1);



            //8-----------------------------------------------------------------


            Console.Write("Enter variable type : ");
            int intVar = Int32.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        intVar = Int32.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int  +1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double  +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String  +* = {0}", stringVar);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong input"); break;


                    //9----------------------------------------------------------------------










                    //10----------------------------------------------------------------


                    byte points;
                    Console.Write("Enter points between 1 and 9: ");
                    points = Convert.ToByte(Console.ReadLine());
                    if (points >= 1 && points <= 3)
                        Console.WriteLine("Points * 10: {0}", points * 10);
                    else if (points >= 4 && points <= 6)
                        Console.WriteLine("Points * 100: {0}", points * 100);
                    else if (points >= 7 && points <= 9)
                        Console.WriteLine("Points * 1000: {0}", points * 1000);
                    else
                        Console.WriteLine("Wrong Input!");
                    Console.ReadLine();



                    //11-----------------------------------------------------------------











            }
        }
    }
}


            








































































        
    
