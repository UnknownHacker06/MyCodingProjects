using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace C_Projs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                // a fast food restaurant order program

                //variable declaration

                string foodname;
                int price;
                int bill = 0;
                string total = "->" ;
                int wantmore = 0;
                string reply;


                //------------------------------------------------------------------------------------------------------------------------

                Console.WriteLine("EVERYTHING SHOULD BE SMALL CASED!!!!"); //caution

                Console.WriteLine(); // left a line
                Console.WriteLine(); // left a line
                

                while (wantmore == 0)
                {
                    Console.WriteLine(); // left a line

                    Console.WriteLine("Hello sir welcome to xyz fast food chain!");

                    Console.WriteLine(); // left a line

                    Console.WriteLine("What would you like to oder today sir?");

                    Console.WriteLine(); //left a line

                    Console.WriteLine("-----------------Today's Menu-------------------- \n \n 1.mac & cheese $6 \n\n 2.burger $3 \n\n 3.chicken wings $7 \n\n 4.fries  $2(small)  $3(medium)  $5(large) \n\n 5.soda(any)  $1(small)  $2(medium)  $3(large) \n\n -------------------------------------------------");

                    Console.WriteLine(); //left a line

                    Console.Write("Thankyou, I would like to have : "); foodname = Console.ReadLine();

                    Console.WriteLine(); //left a line

                    if (foodname == "mac & cheese")
                    {

                        string foodquan;
                        int macprice = 6;

                        Console.WriteLine("Sir how many would you like?");

                        Console.Write("I would like the mac & cheese(s) to be (quantity) : "); foodquan = Console.ReadLine();

                        int foodquantity = Convert.ToInt32(foodquan); //conversion

                        bill += foodquantity * macprice;

                        total += foodname + foodquan;

                    }
                    else if (foodname == "burger")
                    {
                        string foodquan;
                        int burgerprice = 3;

                        Console.WriteLine("Sir how many would you like?");

                        Console.Write("I would like the burger(s) to be (quantity) : "); foodquan = Console.ReadLine();

                        int foodquantity = Convert.ToInt32(foodquan); //conversion

                        bill += foodquantity * burgerprice;

                        total += foodname + foodquan;
                    }
                    else if (foodname == "chicken wings")
                    {
                        string foodquan;
                        int wingprice = 3;

                        Console.WriteLine("Sir how many would you like?");

                        Console.Write("I would like the wing(s) to be (quantity) : "); foodquan = Console.ReadLine();

                        int foodquantity = Convert.ToInt32(foodquan); //conversion

                        bill += foodquantity * wingprice;

                        total += foodname + foodquan;
                    }
                    else if (foodname == "fries")
                    {
                        string foodquan;
                        string foodsize;
                        int fryprice = 0;

                        Console.WriteLine("Sir how many would you like?");

                        Console.Write("I would like the fries to be (quantity) : "); foodquan = Console.ReadLine();

                        Console.WriteLine(); // left a line

                        Console.WriteLine("Sir what size would you like?");

                        Console.WriteLine("I would like them (size) : "); foodsize = Console.ReadLine();

                        if (foodsize == "small")
                        {
                            fryprice = 2;
                        }
                        else if (foodsize == "medium")
                        {
                            fryprice = 3;
                        }
                        else if (foodsize == "large")
                        {
                            fryprice = 5;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! (Line115)");
                        }

                        int foodquantity = Convert.ToInt32(foodquan); //conversion

                        bill += foodquantity * fryprice;

                        total += foodname + foodquan;
                    }
                    else if (foodname == "soda")
                    {
                        string foodquan;
                        string sodasize;
                        int sodaprice = 0;

                        Console.WriteLine("Sir which soda would you like? (coke/7up/sprite/fanta) :"); foodname = Console.ReadLine();

                        Console.WriteLine(); // left a line

                        Console.WriteLine("Sir how many would you like?");

                        Console.Write("I would like the soda(s) to be (quantity) : "); foodquan = Console.ReadLine();

                        Console.WriteLine(); // left a line

                        Console.WriteLine("Sir what size would you like?");

                        Console.WriteLine("I would like them (size) : "); sodasize = Console.ReadLine();

                        if (sodasize == "small")
                        {
                            sodaprice = 2;
                        }
                        else if (sodasize == "medium")
                        {
                            sodaprice = 3;
                        }
                        else if (sodasize == "large")
                        {
                            sodaprice = 5;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! (Line151)");
                        }
                        int foodquantity = Convert.ToInt32(foodquan); //conversion

                        bill += foodquantity * sodaprice;

                        total += foodname + foodquan;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation");
                    }

                    Console.WriteLine(); // left a line

                    Console.Write("Sir do you want anything more? (yes/no) : "); reply = Console.ReadLine();

                    if (reply == "yes")
                    {
                        wantmore = 0;
                    }
                    else if (reply == "no")
                    {
                        wantmore = 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input (line178");
                    }

                }

                Console.WriteLine(); // left a line

                Console.WriteLine("Sir your order is " + total + " and your bill is " + bill + " dollars! \n \n Have A nice day ahead!");

                Console.WriteLine("Thankyou for ordering from us!");

                //program ends

            }
        }
    } }