﻿using System;
using System.Linq;

namespace Framework.Utils
{
    class RandomGenerator
    {
        public static string GetRandomString(int length)
        {
            string chars = "qwertyuiopasdfghjklzxcvbnm0123456789";
            Random random = new Random();
            string result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }
    }
}
