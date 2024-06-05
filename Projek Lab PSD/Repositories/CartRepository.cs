using Projek_Lab_PSD.Factories;
using Projek_Lab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek_Lab_PSD.Repositories
{
    public class CartRepository
    {
        private static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<Cart> GetCarts()
        {
            return (from x in db.Carts select x).ToList();
        }

        public List<Cart> GetCartsByUserID(int UserID)
        {
            return (from x in db.Carts where x.UserID == UserID select x).ToList();
        }

        public int GetLastCartID()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }

        public void InsertCart(int cartId, int userId, int makeupId, int quantity)
        {
            Cart cart = CartFactory.Create(cartId, userId, makeupId, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static int GetMakeupIDByUserID(int UserID)
        {
            return (from x in db.Carts where x.UserID == UserID select x.MakeupID).FirstOrDefault();
        }

        public static int GetQuantityByMakeupID(int MakeupID)
        {
            return (from x in db.Carts where x.MakeupID == MakeupID select x.Quantity).FirstOrDefault();
        }

        public void ClearCartByUserID(int UserID)
        {
            List<Cart> cart = (from x in db.Carts where x.UserID == UserID select x).ToList();

            foreach(var i in cart)
            {
                db.Carts.Remove(i);
            }

            db.SaveChanges();
        }
    }
}