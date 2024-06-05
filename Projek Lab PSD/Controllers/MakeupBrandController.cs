﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class MakeupBrandController
    {
        public static String checkName(String name)
        {
            String response = "";

            if(name.Equals(""))
            {
                response = "Name must be filled!";
            }
            else if(name.Length < 1 || name.Length > 99)
            {
                response = "Name must be between 1 and 99 characters!";
            }

            return response;
        }

        public static String checkRating(int rating)
        {
            String response = "";

            if(rating < 0 || rating > 100)
            {
                response = "Rating must be between 1 and 100";
            }

            return response;
        }

        public static String validateMakeupBrand(String name, int rating)
        {
            String response = checkName(name);

            if (response.Equals(""))
            {
                response = checkRating(rating);

                if (response.Equals(""))
                {
                    response = "";
                }
            }

            return response;
        }
    }
}