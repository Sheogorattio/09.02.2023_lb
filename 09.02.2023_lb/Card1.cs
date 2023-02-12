using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class Card
    {

        private string cvc;
        public string CVC
        {
            get
            {
                return cvc;
            }
            set
            {
                try
                {
                    
                    if (value.Length > 3 || value.Length < 3) throw new Exception("CVC is 3-signed number. Incorrect number.");
                    for (int i = 0; i < value.Length; i++) if (value[i] < 48 || value[i] > 57) throw new Exception("CVC contain only digits. Input error.");
                    cvc = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
            }
            
        }

        private string number;
        public string Number
        {
            get { return number; }
            set
            {
                try
                {
                    if (value.Length > 16 || value.Length < 16) throw new Exception("Card number is 16-signed number. Incorrect input.");
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] > 57 || value[i] < 48) throw new Exception("Input error.");
                    }
                    number = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(2);
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                try
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!((value[i] <= 90 && value[i] >= 65) || (value[i] >= 97 && value[i] <= 122))) throw new Exception("Name must contain only letters. Input error");
                    }
                    name = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(3);
                }
            }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                try
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!((value[i] <= 90 && value[i] >= 65) || (value[i] >= 97 && value[i] <= 122))) throw new Exception("Surname must contain only letters. Input error");
                    }
                    surname = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(4);
                }
            }
        }

        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set
            {
                try
                {
                    if (value.Date > DateTime.UtcNow) throw new Exception("Incorrect expiration date.");
                    expirationDate = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(5);
                }
            }
        }
    }
}
