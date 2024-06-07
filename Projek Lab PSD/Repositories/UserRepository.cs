using Projek_Lab_PSD.Factories;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class UserRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<User> GetUsers()
        {
            return (from x in db.Users select x).ToList();
        }

        public List<User> GetCustomers()
        {
            return (from x in db.Users where x.UserRole.Equals("Customer") select x).ToList();
        }

        public User GetUser(String username, String password)
        {
            return (from x in db.Users
                    where x.Username.Equals(username) 
                         && x.UserPassword.Equals(password)
                    select x)
                    .FirstOrDefault();
        }

        public int GetLastUserID()
        {
            return (from x in db.Users select x.UserID).ToList().LastOrDefault();
        }

        public User GetUserByID(int UserID)
        {
            return db.Users.Find(UserID);
        }

        public void InsertUser(int UserID, String Username, String UserEmail, DateTime UserDOB, String UserGender, String UserRole, String UserPassword)
        {
            User user = UserFactory.Create(UserID, Username, UserEmail, UserDOB, UserGender, UserRole, UserPassword);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void UpdateUserByID(int UserID, String Username, String UserEmail, String UserGender, DateTime UserDOB)
        {
            User updateUser = GetUserByID(UserID);
            updateUser.Username = Username;
            updateUser.UserEmail = UserEmail;
            updateUser.UserGender = UserGender;
            updateUser.UserDOB = UserDOB;

            db.SaveChanges();
        }

        public void UpdatePasswordByID(int UserID, String Password)
        {
            User updateUser = GetUserByID(UserID);
            updateUser.UserPassword = Password;
            db.SaveChanges();
        }
    }
}