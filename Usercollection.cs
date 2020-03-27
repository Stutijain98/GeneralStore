//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("This are Users");
            var Users= new List<User>
        {
            new User() { UserId=1,UserName="stutijain", Password="abcd"},
            new User() { UserId=2,UserName="leenaluhana",Password="xyz"},
            new User() { UserId=3,UserName="heervaishnav", Password="12345"},
            new User() { UserId=4,UserName="divyaparmar", Password="1234"}
        };
        

    foreach (User theuser in Users)
    {
        Console.WriteLine(theuser.UserId + "  " + theuser.UserName+" "+ theuser.Password);
    }}
            
            public class User
{
    public int UserId { get; set; }
    public string UserName { get; set;}           
    public string Password { get; set; }
}
        }
    }

