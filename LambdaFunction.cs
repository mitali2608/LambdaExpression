using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LambdaExpression
{
    class LambdaFunctions
    {

        public static string pattern = "^[A-Z]{1}[a-z]{3,}$";
        public static string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_mobilenum = "^(91)?\\s{0,2}[0-9]{10}$";
        public static string Regex_password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$";

        public bool validateName(string Name)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }


        /// regex check using lambada function/expression

        public static Func<string, bool> validateuserFname = Name => Regex.IsMatch(Name, pattern);
        public static Func<string, bool> validateuserLname = Name => Regex.IsMatch(Name, pattern);
        public bool validateEmail(string Email)
        {
            Regex mail = new Regex(Regex_Email);
            bool email = mail.IsMatch(Email);
            return email;
        }
        public static Func<string, bool> validateUserEmail = Email => Regex.IsMatch(Email, Regex_Email);

        public bool validatePhone(string Mobile)
        {
            Regex Mob = new Regex(Regex_mobilenum);
            bool mobile = Mob.IsMatch(Mobile);
            return mobile;
        }
        public static Func<string, bool> validateuserMobile = Mobile => Regex.IsMatch(Mobile, Regex_mobilenum);
        public bool validatePassword(string Pass)
        {
            Regex pass = new Regex(Regex_password);
            bool password = pass.IsMatch(Pass);
            return password;
        }
        public static Func<string, bool> validateuserpassword = Pass => Regex.IsMatch(Pass, Regex_mobilenum);

    }
}