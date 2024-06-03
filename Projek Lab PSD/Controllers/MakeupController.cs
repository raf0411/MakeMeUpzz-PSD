using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class MakeupController
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
                response = "Name must be between 1 and 99 characters!";
            }
            
            return response;
        }

        public static String checkPrice(int price)
        {
            String response = "";

            if (price == 0)
            {
                response = "Price must be greater than 0";
            }
            else if (price < 0)
            {
                response = "Price must be greater than or equal than 1!";
            }

            return response;
        }

        public static String checkWeight(int weight)
        {
            String response = "";

            if(weight == 0)
            {
                response = "Weight must be greater than 0";
            }
            else if (weight > 1500)
            {
                response = "Weight can not be greater than 1500 grams";
            }

            return response;
        }

        public static String checkTypes(int typeIndex)
        {
            String response = "";

            if(typeIndex == -1)
            {
                response = "Makeup type must be selected!";
            }

            return response;
        }

        public static String checkBrands(int brandIndex)
        {
            String response = "";

            if (brandIndex == -1)
            {
                response = "Makeup brand must be selected!";
            }

            return response;
        }

        public static String validateMakeup(String name, int price, int weight, int typeIndex, int brandIndex)
        {
            String response = checkName(name);

            if (response.Equals(""))
            {
                response = checkPrice(price);

                if (response.Equals(""))
                {
                    response = checkWeight(weight);

                    if (response.Equals(""))
                    {
                        response = checkTypes(typeIndex);

                        if (response.Equals(""))
                        {
                            response = checkBrands(brandIndex);

                            if (response.Equals(""))
                            {
                                response = "";
                            }
                        }
                    }
                }
            }

            return response;
        }
    }
}