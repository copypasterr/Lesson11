using System;

namespace Lesson11
{
    public class VisitorsData
    {
        public static Visitor VisitorsDataFunc(int id)
        {
            Visitor visitor1 = new Lesson11.Visitor
            {
                ID = 1,
                Age = 25,
                Fullname =﻿"Koman Nadiy",
                PhoneNumber = "066233464",
                Adress = "Nadiyna 22"
            };

            Visitor visitor2 = new Lesson11.Visitor
            {
                ID = 2,
                Age = 28,
                Fullname = "Zhelehivsky Zoryan",
                PhoneNumber = "065233454",
                Adress = "Zoryana 12"
            };

            Visitor visitor3 = new Lesson11.Visitor
            {
                ID = 3,
                Age = 21,
                Fullname = "Samborsky Kvitan",
                PhoneNumber = "099233423",
                Adress = "Kvitna 10"
            };

            if (id < visitor1.ID) id = 1;
            else if (id > visitor3.ID) id = 3;

            if (visitor1.ID == id) return visitor1;
            else if (visitor2.ID == id) return visitor2;
            else if (visitor3.ID == id) return visitor3;
            else
            {
                Console.WriteLine("Error, wrong id");
                return null;
            }
        }

        public static void VisitorsShow()
        {
            for (int i = 1; i <= 3; i++)
                Console.WriteLine($"Visitor: {i}, Full name: {VisitorsDataFunc(i).Fullname}," +
                                  $" Phone number: 0{VisitorsDataFunc(i).PhoneNumber}, " +
                                  $"Adress: {VisitorsDataFunc(i).Adress}");
        }


    }
}
