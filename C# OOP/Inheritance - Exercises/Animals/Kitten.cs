﻿using System;
namespace Animals
{
    internal class Kitten : Cat
    {
        private const string gender = "Female";
        public Kitten(string name, int age) : base(name, age, gender)
        {
        }

        public override string  ProduceSound()
        {
            return "Meow";
        }
    }
}
