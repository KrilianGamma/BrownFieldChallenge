using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.

    //For some reason i don't know why it dosen't count the entries in ents 
namespace ConsoleUI
{
    class Program
    {
        //It didn't have the public
        public static void Main(string[] args)
        {
            string w;
            //assign a value for ttl variable
            int i, t, ttl = 0;
            //made a new variable for selecting if the user wants to add or no
            bool varia = true;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            t = int.Parse(Console.ReadLine());
            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time:");
            //added string to detect if is yes or no then convert to true or false, also added another variable to kepp trak of errors in the input in case of wrong output it asks again
                String cont = Console.ReadLine();
                cont = cont.ToLower();
            if (cont == "yes")
            {
                varia = true;
            }
            else if (cont == "no")
            {
                varia = false;
                //I have Put the exit comand here with all the calculus, so when you say no, will make the calculs
                for (i = 0; i < ents.Count; i++)
                {
                    if (ents[i].WorkDone.Contains("Acme"))
                    {
                        ttl += 1;
                    }
                }
                Console.WriteLine("Simulating Sending email to Acme");
                Console.WriteLine("Your bill is $" + ttl * (150 * t) + " for the hours worked.");
                //Re-initializing the ttl value each time we use it
                ttl = 0;
                for (i = 0; i < ents.Count; i++)
                {
                    if (ents[i].WorkDone.Contains("ABC"))
                    {
                        ttl += 1;
                    }
                }
                Console.WriteLine("Simulating Sending email to ABC");
                Console.WriteLine("Your bill is $" + ttl * (125 * t) + " for the hours worked.");
                for (i = 0; i < ents.Count; i++)
                {
                    ttl += ents[i].HoursWorked;
                }
                ttl = 0;
                if (ttl > 40)
                {
                    Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
                }
                else
                {
                    Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
                }
                Console.WriteLine();
                Console.Write("Press any key to exit application...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Invalid Statment");
            }
            while (varia == true)
            {
                //we do the same that up there
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                t = int.Parse(Console.ReadLine());
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);
                Console.Write("Do you want to enter more time:");
                cont = Console.ReadLine();
                cont = cont.ToLower();
                if (cont == "yes")
                {
                    varia = true;
                }
                else if (cont == "no")
                {
                    varia = false;
                    for (i = 0; i < ents.Count; i++)
                    {
                        if (ents[i].WorkDone.Contains("Acme"))
                        {
                            ttl += 1;
                        }
                    }
                    Console.WriteLine("Simulating Sending email to Acme");
                    Console.WriteLine("Your bill is $" + ttl * (150 * t) + " for the hours worked.");
                    for (i = 0; i < ents.Count; i++)
                    {
                        if (ents[i].WorkDone.Contains("ABC"))
                        {
                            ttl += 1;
                        }
                    }
                    ttl = 0;
                    Console.WriteLine("Simulating Sending email to ABC");
                    Console.WriteLine("Your bill is $" + ttl * (125 * t) + " for the hours worked.");
                    for (i = 0; i < ents.Count; i++)
                    {
                        ttl += ents[i].HoursWorked;
                    }
                    ttl = 0;
                    if (ttl > 40)
                    {
                        Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
                    }
                    else
                    {
                        Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
                    }
                    Console.WriteLine();
                    Console.Write("Press any key to exit application...");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Invalid Statment");
                }
            }
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
