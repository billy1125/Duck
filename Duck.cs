using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_DP
{
    abstract class Duck
    {
        private string _name;
        private IFlyBehavior _fb;
        private IQuackBehavior _qb;

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //給予行為的設定，讓在執行期間的物件可以直接改變行為
        public IFlyBehavior SetFlyBehavior
        {
            //get
            //{
            //    return _fb;
            //}
            set
            {
                _fb = value;
            }
        }

        public IQuackBehavior SetQuackBehavior
        {
            //get
            //{
            //    return _qb;
            //}
            set
            {
                _qb = value;
            }
        }

        abstract public void Display(); 

        public void ShowName()
        {
            Console.WriteLine("My name is " + Name);
        }

        public void Swim() 
        { 
            Console.WriteLine("I can swim");
        }


        public virtual void PerformFly() 
        {
            //Console.WriteLine("I can fly");
            _fb.fly();
        }

        public virtual void performQuack()
        {
            //Console.WriteLine("I can quack");
            _qb.quack();
        }
    }
}
