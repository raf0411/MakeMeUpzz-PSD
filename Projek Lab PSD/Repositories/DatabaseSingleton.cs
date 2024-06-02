using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class DatabaseSingleton
    {
        public static MakeMeUpzzDatabaseEntities db = new MakeMeUpzzDatabaseEntities();

        public static MakeMeUpzzDatabaseEntities GetInstance()
        {
            if(db == null)
            {
                db = new MakeMeUpzzDatabaseEntities();
            }

            return db;
        }
    }
}