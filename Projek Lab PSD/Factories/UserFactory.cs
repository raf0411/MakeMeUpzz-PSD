using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Factories
{
    public class UserFactory
    {
        public static User Create(int UserID, String Username, String UserEmail, DateTime UserDOB, String UserGender, String UserRole, String UserPassword)
        {
            User user = new User();

            user.UserID = UserID;
            user.Username = Username;
            user.UserEmail = UserEmail;
            user.UserGender = UserGender;
            user.UserRole = UserRole;
            user.UserPassword = UserPassword;

            return user;
        }
    }
}