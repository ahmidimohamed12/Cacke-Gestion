using System;
using System.Collections.Generic;
using System.Net.Http;
using cacke.Models;
using Newtonsoft.Json;

namespace cacke.helprs
{
    public class Helpers_api
    {
        public Helpers_api()
        {
        }


        public static List<user> get_List_user()
        {

            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://api1337.1337center.de/api/users").Result;
            var f = JsonConvert.DeserializeObject<List<user>>(response);
            return f;
        }


        public static List<> get_allworks()
        {

        }



        public static List<> get_allwebsite()
        {

        }


        public static List<>  get_allmonteur()
        {

        }



        //1

        public user get_user(int id)
        {

        }

        public website get_website(int id)
        {

        }

        public monteur get_monteur(int id)
        {

        }












        public static user loggin_test(string log,string pas)
        {
            user us = new user();

            for (int i = 0;i<get_List_user().Count;i++)
            {
                if (get_List_user()[i].username == log && get_List_user()[i].userpass == pas)
                {
                    us = get_List_user()[i];
                    break;
                }
            }
            return us;
        }


    }
}
