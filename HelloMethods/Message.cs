﻿using System;

namespace HelloMethods
{ 
	public class Message
	{
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else if (lang.Equals("tk"))
            {
                return "Selam Dünya";
            } else
            {
                return "Hello World";
            }
        }
    }
}

