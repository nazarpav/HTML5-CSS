using System;
using System.IO;

namespace ConsoleSenderEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            int action=0;
            do
            {
                Console.WriteLine("0. Exit\n1. Send to Email, email pattern");
                Console.Write("->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            string folder = "email";
                            string fileName = "index.html";
                            string pathFile = Path.Combine(folder,fileName);
                            string html = File.ReadAllText(pathFile);
                            using (SMTPSender sender = new SMTPSender())
                            {
                                Console.WriteLine("Enter your email: ");
                                string email = Console.ReadLine();
                                //novakvova@gmail.com
                                sender.SendMessage(email, html);
                            }
                            break;
                        }
                    default:
                        break;
                }
            } while (action != 0); ;
        }
    }
}
