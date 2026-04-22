using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using mgr_1_2_TI.DAL;
using mgr_1_2_TI.Enums;
using mgr_1_2_TI.Models;

namespace mgr_1_2_TI.Structure
{
    public static class CartManager
    {
        public static void AddToCart(ISession session, MovieContext db, int movieId)
        {
            var basket = GetManyFromCart(session, db);

            var currentMovie = basket.Find(f => f.Movie.Id == movieId);

            if (currentMovie != null)
            {
                currentMovie.Count++;
                currentMovie.FullPrice += currentMovie.UnitPrice;
                return;
            }

            var movieToAdd = db.T_Movies.Find(movieId);

            if (movieToAdd == null)
            {
                return;
            }

            var basketItem = new BasketItem
            {
                Movie = movieToAdd,
                Count = 1,
                UnitPrice = movieToAdd.Price,
                FullPrice = movieToAdd.Price,
            };
            basket.Add(basketItem);

            SessionHelper.ObjectToJson<List<BasketItem>>(session, BasketEnum.CartSessionKey, basket);
        }

        public static List<BasketItem> GetManyFromCart(ISession session, MovieContext db)
        {
            var basket = SessionHelper.GetObjectFromJson<List<BasketItem>>(session, BasketEnum.CartSessionKey);

            // if it's new, initialise it
            basket ??= [];

            return basket;
        }
        // public static List<CartItem> GetFromCart() { }
    }

}