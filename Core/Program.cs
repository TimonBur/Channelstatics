﻿using System;
using Channelstatics;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Authorization auth = new Authorization();


            auth.ConnectAsync();


        }
    }
}
