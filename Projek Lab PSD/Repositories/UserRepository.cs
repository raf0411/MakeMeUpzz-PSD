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

        public int GetLastUserID()
        {
            return (from x in db.Users select x.UserID).ToList().LastOrDefault();
        }

        public void InsertUser(int UserID, String Username, String UserEmail, DateTime UserDOB, String UserGender, String UserRole, String UserPassword)
        {
            User user = UserFactory.Create(UserID, Username, UserEmail, UserDOB, UserGender, UserRole, UserPassword);
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}