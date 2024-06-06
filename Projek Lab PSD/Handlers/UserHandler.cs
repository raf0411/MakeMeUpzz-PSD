using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Handlers
{
    public class UserHandler
    {
        public static String doLogin(String username, String password)
        {
            UserRepository userRepo = new UserRepository();
            User user = userRepo.GetUser(username, password);

            return user != null ? "Success" : "Username or Password is incorrect";
        }

        public static void doRegister(String username, String password, String email, String dob, String gender)
        {
            UserRepository userRepo = new UserRepository();

            int newID = GenerateUserID();
            String newUsername = username;
            String newEmail = email;
            DateTime newDOB = Convert.ToDateTime(dob);
            String newGender = gender;
            String newRole = "Customer";
            String newPassword = password;

            userRepo.InsertUser(newID, newUsername, newEmail, newDOB, newGender, newRole, newPassword);
        }

        public static void UpdateUser(int UserID, String Username, String Email, String Gender, DateTime UserDOB)
        {
            UserRepository userRepo = new UserRepository();
            userRepo.UpdateUserByID(UserID, Username, Email, Gender, UserDOB);
        }

        public static void UpdatePassword(int UserID, String Password)
        {
            UserRepository userRepo = new UserRepository();
            userRepo.UpdatePasswordByID(UserID, Password);
        }

        public static int GenerateUserID()
        {
            UserRepository userRepo = new UserRepository();

            int newID = 0;
            int lastID = userRepo.GetLastUserID();

            if (lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }

            newID = lastID;

            return newID;
        }
    }
}