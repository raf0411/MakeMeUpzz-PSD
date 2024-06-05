using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class MakeupTypeController
    {
        public static String checkName(String name)
        {
            String response = "";

            if (name.Equals(""))
            {
                response = "Name must be filled!";
            }
            else if(name.Length < 1 || name.Length > 99)
            {
                response = "Makeup Type must be between 1 and 99 characters!";
            }

            return response;
        }

        public static String validateMakeupType(String name)
        {
            String response = checkName(name);

            if (response.Equals(""))
            {
                response = "";
            }

            return response;
        }
    }
}