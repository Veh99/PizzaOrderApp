﻿namespace PizzaOrderApp
{
    public class JwtOptions
    {
        public int ExpiredHours { get; set; }
        public string SecretKey { get; set; }
    }
}