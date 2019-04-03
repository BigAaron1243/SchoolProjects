using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] LineValues = { };
            int Checkpoint = 0;
            int MaxHealth = 0;
            int Health = 0;
            int Attack = 0;
            int WeaponID = 0;
            bool repeat = true;
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1. Continue Game");
            Console.WriteLine(" 2. New Game");
            while (repeat) {
                string MenuInput = Console.ReadLine();
                switch (MenuInput)
                {
                case "1":
                    try
                    {
                        Console.Clear();
                        LineValues = LoadGame().Split(' ');
                        Checkpoint = int.Parse(LineValues[0]);
                        MaxHealth = int.Parse(LineValues[1]);
                        Health = int.Parse(LineValues[2]);
                        Attack = int.Parse(LineValues[3]);
                        WeaponID = int.Parse(LineValues[4]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("Choose Class:");
                        Console.WriteLine(" 1. Knight");
                        Console.WriteLine(" 2. Adventurer");
                        Console.WriteLine(" 3. Scout");
                        while (repeat)
                        {
                            repeat = false;
                            string ClassInput = Console.ReadLine();
                            switch (ClassInput)
                            {
                                case "1":
                                    SaveGame(1, 200, 200, 12, 1);
                                    break;
                                case "2":
                                    SaveGame(1, 150, 150, 16, 1);
                                    break;
                                case "3":
                                    SaveGame(1, 125, 125, 17, 1);
                                    break;
                                default:
                                    Console.WriteLine("please input valid number");
                                    repeat = true;
                                    break;
                            }
                        }
                        //game happens in here
                        while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Map:");
                            }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("please input valid number");
                    repeat = true;
                    break;

                }
            }
        }
        static void SaveGame(int Checkpoint, int MaxHealth, int Health, int Attack, int WeaponID)
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("C:\\Users\\Administrator\\Documents\\Savefile.txt");

            //Write a line of text
            sw.Write(Checkpoint + " ");
            sw.Write(MaxHealth + " ");
            sw.Write(Health + " ");
            sw.Write(Attack + " ");
            sw.Write(WeaponID + " ");

            //Close the file
            sw.Close();
        }
        static string LoadGame()
        {
            StreamReader sr = new StreamReader("C:\\Users\\Administrator\\Documents\\Savefile.txt");
            string ValueString = sr.ReadLine();
            return ValueString;
        }
    }
}
