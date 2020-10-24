using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_DP
{
    //1.介面只能宣告，不能實作，且只能為公開(public)。 * 預設就是公開所以不用特別加上public
    //2.介面可以繼承介面
    //3.介面不可以繼承類別
    //4.可以同時繼承多個介面
    //5.繼承介面的類別必須實作所有的屬性與方法。

    interface IFlyBehavior
    {
        void fly();
    }

    interface IQuackBehavior
    {
        void quack();
    }

    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I fly with wings");
        }
    }

    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I dont fly");
        }
    }

    class FlyWithRocket : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I fly with rocket!!!");
        }
    }

    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!!!!");
        }
    }

    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!!!!");
        }
    }
}
