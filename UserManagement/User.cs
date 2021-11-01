﻿namespace UserManagement
{
    public class User
    {
        public User(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }

        public int Id { get; set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
}
