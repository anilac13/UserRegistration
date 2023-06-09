﻿using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        public const string NAME = @"^[A-Z][a-z]{2,}$";
        public const string EMAIL = @"^[a-zA-z0-9.+-]+[@][a-zA-z0-9]+[.][a-zA-z0-9.]{2,}$";
        public const string NUMBER = @"^[0-9 ]+[6-9][0-9]{9}$";
        public const string PASSWORD = @"^[A-Z]{1,}[a-zA-Z0-9]{0,}[0-9]{1,}[@#$%&*!]{1,}[a-zA-Z0-9]+$";
        public string ValidateFirstName(string firstName)
        {
            Regex regex = new Regex(NAME);
            if (regex.IsMatch(firstName))
                return "Valid";
            return "Invalid";
        }
        public string ValidateLastName(string lastName)
        {
            Regex regex = new Regex(NAME);
            if (regex.IsMatch(lastName))
                return "Valid";
            return "Invalid";
        }
        public string ValidateEmail(string email)
        {
            Regex regex = new Regex(EMAIL);
            if (regex.IsMatch(email))
                return "Valid";
            return "Invalid";
        }
        public string ValidatePhoneNumber(string number)
        {
            Regex regex = new Regex(NUMBER);
            if (regex.IsMatch(number))
                return "Valid";
            return "Invalid";
        }
        public string ValidatePassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
            if (regex.IsMatch(password))
                return "Valid";
            return "Invalid";
        }
        public string ValidateAllMails()
        {
            string[] emails = { "abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com",
            "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com", "abc@%*.com","abc..2002@gmail.com", "abc.@gmail.com","abc@abc@gmail.com", 
            "abc@gmail.com.1a","abc@gmail.com.aa.au"};
            foreach (string email in emails)
            {
                Regex regex = new Regex(EMAIL);
                if (regex.IsMatch(email))
                    return "Valid";
                return "Invalid";
            }
            return "";
        }
    }
}