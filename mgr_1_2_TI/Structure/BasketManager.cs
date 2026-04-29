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
    public static class BasketManager
    {
        public static void AddToBasket(ISession session, MovieContext db, int movieId)
        {
            var basket = GetManyFromBasket(session, db);

            var currentMovie = basket.Find(f => f.Movie.Id == movieId);

            if (currentMovie != null)
            {
                currentMovie.Count++;
                currentMovie.FullPrice += currentMovie.UnitPrice;
            }
            else
            {
                var movieToAdd = db.T_Movies.Find(movieId);

                if (movieToAdd == null)
                {
                    Console.WriteLine($"No movie found {movieId}");
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
            }
            SessionHelper.ObjectToJson<List<BasketItem>>(session, BasketEnum.CartSessionKey, basket);
        }
        public static int RemoveFromBasket(ISession session, MovieContext db, int movieId)
        {
            // returns number of items left in a field
            var basket = GetManyFromBasket(session, db);

            var currentMovie = basket.Find(f => f.Movie.Id == movieId);
            if (currentMovie == null)
            {
                return 0;
            }

            currentMovie.Count--;
            currentMovie.FullPrice = currentMovie.UnitPrice * currentMovie.Count;
            if (currentMovie.Count <= 0)
            {
                basket.Remove(currentMovie);
            }

            SessionHelper.ObjectToJson<List<BasketItem>>(session, BasketEnum.CartSessionKey, basket);
            return currentMovie.Count;
        }


        public static List<BasketItem> GetManyFromBasket(ISession session, MovieContext db)
        {
            var basket = SessionHelper.GetObjectFromJson<List<BasketItem>>(session, BasketEnum.CartSessionKey);

            // if it's new, initialise it
            if (basket == null)
            {
                basket = [];
            }

            return basket;
        }
        // public static List<CartItem> GetFromCart() { }

        public static decimal GetItemFullPrice(ISession session, MovieContext db, int id)
        {
            // returns number of items left in a field
            var basket = GetManyFromBasket(session, db);

            var currentMovie = basket.Find(f => f.Movie.Id == id);
            if (currentMovie == null)
            {
                return 0;
            }
            return currentMovie.FullPrice;
        }
        public static decimal GetSumValueFromBasket(ISession session, MovieContext db)
        {
            decimal sum = 0;
            foreach (BasketItem item in GetManyFromBasket(session, db))
            {
                VerifyItemIntegrity(item);
                sum += item.FullPrice;
            }
            return sum;
        }
        public static void VerifyItemIntegrity(BasketItem item)
        {

            if (item.Count * item.UnitPrice != item.FullPrice)
            {
                throw new Exception($"Mismatch value between full price and item price in basket. MovieId:{item.Movie.Id}" +
                $" FullPrice:{item.FullPrice} != Count:{item.Count}*UnitPrice:{item.UnitPrice}");
            }
        }
    }
}