using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantClass
{
    class Review
    {
        int restID;
        int accountID;
        string restName;
        int food;
        int service;
        int price;
        string comments;



        public Review()
        {
        }


        public Review(int rID, int aID, string rName, int FOOD, int SERVICE, int PRICE, string COMMENT)
        {
            restID = rID;
            accountID = aID;
            restName = rName;
            food = FOOD;
            service = SERVICE;
            price = PRICE;
            comments = COMMENT;
        }

        public int getRestID
        {
            get { return restID; }
            set { restID = value; }
        }

        public int getAccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public int getFood
        {
            get { return food; }
            set { food = value; }
        }

        public int getService
        {
            get { return service; }
            set { service = value; }
        }

        public int getPrice
        {
            get { return price; }
            set { price = value; }
        }






    }
}
