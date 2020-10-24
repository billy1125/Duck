using System;
using System.Collections.Generic;

namespace Duck_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckController dc = new DuckController();
            //dc.AddDuck(new Duck()); //抽象類別不能實作。因為設計邏輯上屬於一個未完整的類別。

            dc.AddDuck(new DuckCanFly());
            dc.AddDuck(new DuckDontFly());
            dc.AddDuck(new RedHeadDuck());
            //dc.AddDuck(new RubberDuck());
            //dc.AddDuck(new ModelDuck());

            //超級鴨子，利用存取子修改飛行方法
            IFlyBehavior _FlyWithRocket = new FlyWithRocket();

            DuckCanFly SuperDuck = new DuckCanFly();
            SuperDuck.SetFlyBehavior = _FlyWithRocket;
            SuperDuck.Name = "Super Duck!!!!";
 
            dc.AddDuck(SuperDuck);

            //橡膠鴨，叫法用覆寫的方式修改
            dc.AddDuck(new RubberDuck());

            dc.AddDuck(new AlienDuck());


            dc.DuckBehaviors();

            Console.ReadLine();
        }
    }

    class DuckCanFly : Duck
    {
        private IFlyBehavior _FlyWithWings = new FlyWithWings();
        private IQuackBehavior _QuackBehavior = new Quack();

        public DuckCanFly()
        {
            SetFlyBehavior = _FlyWithWings;
            SetQuackBehavior = _QuackBehavior;
            Name = "Duck";
        }

        public override void Display()
        {
            Console.WriteLine("I'm a duck who can fly!");
        }
    }         

    class DuckDontFly : Duck
    {
        private IFlyBehavior _FlyNoWay = new FlyNoWay();
        private IQuackBehavior _QuackBehavior = new Quack();

        public DuckDontFly()
        {
            SetFlyBehavior = _FlyNoWay;
            SetQuackBehavior = _QuackBehavior;
            Name = "No Fly Duck";
        }

        public override void Display()
        {
            Console.WriteLine("I'm a duck but I don't fly!");
        }
    }

    class RedHeadDuck : DuckCanFly
    {
        public RedHeadDuck()
        {
            Name = "Red Head Duck";
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Red Head Duck");
        }
    }

    class RubberDuck : DuckDontFly
    {
        private IQuackBehavior _squeak = new Squeak();
        public RubberDuck()
        {
            Name = "Rubber Duck";
        }

        public override void Display()
        {
            Console.WriteLine("I'm Rubber duck");
        }

        public override void performQuack()
        {
            _squeak.quack();
        }
    }


    class AlienDuck : DuckDontFly
    {
        public AlienDuck()
        {
            Name = "Alien Duck";
        }

        public override void Display()
        {
            Console.WriteLine("I'm Alien duck");
        }

        public void TravelInSpace()
        {

        }
    }


    class DuckController
    {
        protected List<Duck> _duckList = new List<Duck>();

        public void AddDuck(Duck Duck)
        {
            _duckList.Add(Duck);
        }

        public void DuckBehaviors()
        {
            foreach (var item in _duckList)
            {
                item.ShowName();
                item.Display();
                item.PerformFly();
                item.performQuack();
                item.Swim();
                //item.SetFlyBehavior.PerformFly();

                Console.WriteLine("-------------------");
            }
        }

    }
}
