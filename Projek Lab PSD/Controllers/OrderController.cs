using Projek_Lab_PSD.Handlers;
using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Controllers
{
    public class OrderController
    {
        public static List<Cart> GetCartsByUserID(int UserID)
        {
            return OrderHandler.GetCartsByUserID(UserID);
        }

        public static void DeleteCartByUserID(int userId)
        {
            OrderHandler.DeleteCartByUserID(userId); 
        }

        public static void InsertCart(int userId, int makeupId, int quantity)
        {
            OrderHandler.InsertCart(userId, makeupId, quantity);
        }

        public static String checkQuantity(int quantity)
        {
            String response = "";

            if(quantity <= 0)
            {
                response = "Quantity must be more than 0!";
            }

            return response;
        }

        public static String validateOrder(int quantity)
        {
            String response = checkQuantity(quantity);

            if (response.Equals(""))
            {
                response = "";
            }

            return response;
        }
    }
}