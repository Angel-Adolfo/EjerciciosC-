﻿using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Menu menu = new Menu();
        await menu.DisplayMenuAsync();
    }
}
