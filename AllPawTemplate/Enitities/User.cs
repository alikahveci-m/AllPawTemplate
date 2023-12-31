﻿namespace AllPawTemplate.Enitities
{
    public class User
    {
        public int UserId { get; set; }
        public int UserType { get; set; }
        public int PackageType { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePhoto { get; set; }
        public string  PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}