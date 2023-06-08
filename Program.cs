using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Threading.Tasks;

namespace PassGenOrigin
{ 
    class Program
    {
         static void Main(string[] args)
         {
                try
                {
// Script

// Colors
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();

                    Console.WriteLine("Enter aplication name");
                    string Naz = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter expected password length");
                    int y = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Clear();
                    
// Arr's

                    string[] Pass = new string[y];
                    string[] charArr = new string[72] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };

// User info

                    Console.WriteLine("Aplication name: " + Naz);
                    Console.WriteLine("Password length: " + y);
                    Console.WriteLine("-------------------");

// Generate random string value

                    for (int i = 0; i < y; i++)
                    {
                        int x = new Random().Next(0, 71);
                        Pass[i] += charArr[x];
                    }

                    string passString = string.Join("", Pass);
                    Console.WriteLine("Generated password: " + passString);

                try
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string path = Path.Combine(desktopPath, "PassAll.txt");
                    
//If file exists, dont create new one..

                    if (File.Exists(path))
                    {
//Open&Write
                        using (StreamWriter writer = File.AppendText(path))
                        {
                            writer.WriteLine("Name: " + Naz);
                            writer.WriteLine("Password: " + passString);
                            writer.WriteLine("");
//End
                            writer.Close();
                        }
                    }
                    else
                    { 
//Write
                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine("Name: "+Naz);
                    writer.WriteLine("Password: " + passString);
                    writer.WriteLine("");
//End
                    writer.Close();
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }


// endscript

                    }

// catch
                    catch (Exception e)
                    {
                    Console.WriteLine("Error: " + e.Message);
                    
                    }
         }
    }  
}