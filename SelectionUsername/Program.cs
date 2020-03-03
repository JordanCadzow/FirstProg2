using System;

namespace SelectionUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string sysUsername = "Bob";
            string sysPassword = "Password";

            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            string password = "";

            if(username == sysUsername){
                Console.WriteLine("Please enter your password");
                password = Console.ReadLine();
                if(password == sysPassword){
                    Console.WriteLine("Login successful");
                }
                else{
                    Console.WriteLine("Incorrect password");
                }
            }
            else{
                Console.WriteLine("User does not exist");
            }



        }
    }
}
