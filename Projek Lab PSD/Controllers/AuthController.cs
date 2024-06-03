using Projek_Lab_PSD.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class AuthController
    {
        public static String checkUsername(String username)
        {
            String response = "";

            if (username.Equals(""))
            {
                response = "Username may not be empty!";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                response = "Username must be between 5 and 15 characters!";
            }

            return response;
        }

        public static String checkPassword(String password)
        {
            String response = "";

            if (password.Equals(""))
            {
                response = "Password may not be empty!";
            }
            else if (password.Length < 5 || password.Length > 15)
            {
                response = "Username must be between 5 and 15 characters!";
            }
            else if (!IsAlphanumeric(password))
            {
                response = "Password must be alphanumeric!";
            }

            return response;
        }

        public static String checkConfirmPassword(String password, String confirmPassword)
        {
            String response = "";

            if (password.Equals(""))
            {
                response = "Password may not be empty!";
            }
            else if (password.Length < 5 || password.Length > 15)
            {
                response = "Username must be between 5 and 15 characters!";
            }
            else if (!IsAlphanumeric(password))
            {
                response = "Password must be alphanumeric!";
            }
            else if (confirmPassword != password)
            {
                response = "Confirmed Password must match!";
            }

            return response;
        }

        public static String checkEmail(String email)
        {
            String response = "";

            if (email == "")
            {
                response = "Email may not be empty!";
            }
            else if (!email.EndsWith(".com"))
            {
                response = "Enter a valid email!";
            }

            return response;
        }

        public static String checkDOB(String dob)
        {
            String response = "";

            if (dob.Equals(""))
            {
                response = "Date of birth must be filled!";
            }

            return response;
        }

        public static String checkGender(int genderListIndex)
        {
            String response = "";

            if (genderListIndex == -1)
            {
                response = "Gender must be selected!";
            }

            return response;
        }

        public static String doLogin(String username, String password)
        {
            String response = checkUsername(username);

            if (response.Equals(""))
            {
                response = checkPassword(password);

                if (response.Equals(""))
                {
                    response = UserHandler.doLogin(username, password);
                }
            }

            return response;
        }

        public static String doRegister(String username, String password, String email, String dob, int gender, String confirmPassword)
        {
            String response = checkUsername(username);

            if (response.Equals(""))
            {
                response = checkEmail(email);

                if (response.Equals(""))
                {
                    response = checkGender(gender);

                    if (response.Equals(""))
                    {
                        response = checkConfirmPassword(password, confirmPassword);

                        if (response.Equals(""))
                        {
                            response = checkDOB(dob);

                            if(response.Equals(""))
                            {
                                response = "Success";
                            }
                        }
                    }
                }
            }

            return response;
        }

        private static bool IsAlphanumeric(String password)
        {
            // Regular expression to check if the password is alphanumeric
            String pattern = @"^[a-zA-Z0-9]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }
    }
}