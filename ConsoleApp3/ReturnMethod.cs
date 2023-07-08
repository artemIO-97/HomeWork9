using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    public class ClassExeption
    {
        public string login { get; set; }
        public string password { get; set; }
        public string confrimPassword { get; set; }


        public static bool MethodExeption(string Login, string Password, string ConfrimPassword)
        {

            //================================================Login block
            var startLenghtLogin = 20;
            var loginLenghtReturn = true;
            var loginSpaseReturn = true;
            var spaseSymbol = ' ';
            //======================================
            if (Login.Length > startLenghtLogin)
            {
                loginLenghtReturn = false;                  //проверка длины логина
            }
            //======================================
            foreach (char symbol in Login)
            {
                if (spaseSymbol == symbol)
                {
                    loginSpaseReturn = false;
                    break;                                  // проверка на наличие пробела
                }
            }
            try
            {
                if ((loginLenghtReturn & loginSpaseReturn))
                {
                    
                }
                else
                {
                    throw new UserExeption("WrongLoginException");
                }
            }
            catch (UserExeption ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            //======================================
            //======================================================== Password Block
            var startLenghtPassword = 20;
            var passwordLenghtReturn = true;
            var passwordSpaseReturn = true;
            var passwordDigitReturn = true;
            //======================================
            if (Password.Length > startLenghtPassword)
            {
                passwordLenghtReturn = false;               // проверка длины пароля
            }
            //======================================
            foreach (char symbol in Password)
            {
                if (spaseSymbol == symbol)
                {                                          // проверка на наличие пробела
                    passwordSpaseReturn = false;
                    break;
                }
            }
            //======================================
            var countDigit = 0;
            foreach (char symbol in Password)
            {
                if (char.IsDigit(symbol))
                {
                    countDigit = countDigit++;              // проверка на наличие хотя бы одной цифры
                }

            }
            if (countDigit < 1)
            {
                passwordDigitReturn = false;

            }
            try
            {
                if ((passwordDigitReturn & passwordLenghtReturn & passwordSpaseReturn))
                {

                }
                else
                {
                    throw new PasswordExeption("WrongPasswordException");
                }
            }
            catch (PasswordExeption ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            //======================================
            // ConfrimPassword
            var returnConfrimPassword = true;
            if (ConfrimPassword != Password)
            {
                returnConfrimPassword = false;
            }
            //======================================

            if ((loginLenghtReturn & loginSpaseReturn & passwordDigitReturn & passwordLenghtReturn & passwordSpaseReturn & returnConfrimPassword))
            {
                Console.WriteLine("Данные валидны");
                return true;

            }
            else
            {
                Console.WriteLine("Данные не валидны!");
                return false;

            }




        }
    }


}
