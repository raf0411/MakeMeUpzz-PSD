using Projek_Lab_PSD.Models;
using Projek_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Handlers
{
    public class OrderHandler
    {
        public static int GenerateCartID()
        {
            CartRepository cartRepo = new CartRepository();

            int newID = 0;
            int lastID = cartRepo.GetLastCartID();

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

        public static void InsertCart(int userId, int makeupId, int quantity)
        {
            CartRepository cartRepo = new CartRepository();

            int cartID = GenerateCartID();
            int userID = userId;
            int makeupID = makeupId;
            int Quantity = quantity;

            cartRepo.InsertCart(cartID, userID, makeupID, Quantity);
        }

        public static List<Cart> GetCartsByUserID(int UserID)
        {
            CartRepository cartRepo = new CartRepository();
            return cartRepo.GetCartsByUserID(UserID);
        }

        public static void DeleteCartByUserID(int userId)
        {
            CartRepository cartRepo = new CartRepository();
            cartRepo.ClearCartByUserID(userId); 
        }
    }
}