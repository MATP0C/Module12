﻿using System;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            
            Console.WriteLine("Введите Имя: ");
            string userName = Console.ReadLine();
            Random random = new Random();
            string userLogin = Convert.ToString(random.Next(10000000, 99999999));
            Console.WriteLine("Ваш логин: {0}", userLogin);
            bool userIsPremium = false;
            User user = new User(userName, userLogin, userIsPremium);
            users.Add(user);


            if (userIsPremium == true)
            {
                Console.WriteLine("Здравствуйте {0}", userName);
            }
            else
            {
                Show.ShowAds();
            }
        }
    }
    class User
    {
        public User(string name, string login, bool ispremium)
        {
            Name = name;
            Login = login;
            IsPremium = ispremium;
        }
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
    class Show
    {
        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}