using System;
using SneakerBox;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace DataServices;

    public class DataServicesBL
    {
        List<LoginShoes> ShoeUsers = new List<LoginShoes>();

        public DataServicesBL()
        {
            CreateShoeUserData();
        }
        private void CreateShoeUserData()
        {

            LoginShoes user1 = new LoginShoes()
            {
                username = "Liam",
                password = "Pogi",
            };

           LoginShoes user2 = new LoginShoes()
            {
                username = "Edwards",
                password = "mahalkita",

            };
            LoginShoes user3 = new LoginShoes()
            {
                username = "Rivera",
                password = "iloveyou",

            };
            ShoeUsers.Add(user1);
            ShoeUsers.Add(user2);
            ShoeUsers.Add(user3);
        }
        public LoginShoes GetUser(string username)
        {
            LoginShoes foundUser = new LoginShoes();
            foreach (var user in ShoeUsers)
            {
                if (user.username == username)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }

        public LoginShoes GetPassword(string password)
        {
            LoginShoes foundPassword = new LoginShoes();
            foreach (var user in ShoeUsers)
            {
                if (user.password == password)
                {
                    foundPassword = user;
                }
            }

            return foundPassword;


        }

    }
