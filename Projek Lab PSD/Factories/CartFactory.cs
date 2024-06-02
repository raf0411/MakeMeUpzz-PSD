using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Factories
{
    public class CartFactory
    {
        public static Cart Create(int CartID, int UserID, int MakeupID, int Quantity)
        {
            Cart cart = new Cart();

            cart.CartID = CartID;
            cart.UserID = UserID;
            cart.MakeupID = MakeupID;
            cart.Quantity = Quantity;

            return cart;
        }
    }
}