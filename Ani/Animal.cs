using Ani;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ani
{
    public abstract class Animal
    {
        protected int Weight { get; set; }
        protected int Height { get; set; }

        public Animal(int weight, int height)
        {
            this.Weight = weight;
            this.Height = height;
        }
        public abstract void PrintInfo();
    }



    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(int weight, int height, string name) : base(weight, height)
        {
            this.Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Weight:{0}" +" va "+ "Height:{1}" + " va " + "Name:{2}",this.Height,this.Weight,this.Name);
           
        }
    } 
}

