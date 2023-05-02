//using System;
//using DesignPrinciple.StrategyPattern;

//namespace BasicDesignPrinciple
//{
//    public class MainClass
//    {
//        public static void Main()
//        {
//            Duck duck1 = new MallardDuck(new FlyWithWings(), new Quack());
//            Duck duck2 = new RubberDuck(new NoFlyProperty(), new Squeek());
//            Duck duck3 = new WoodenDuck(new NoFlyProperty(), new MuteDuckSound());
//            duck1.PerformDuckSound();
//            duck1.PerformFly();
//            duck1.SetFlyingBehaviour(new NoFlyProperty());
//            duck1.SetDuckSoundBehaviour(new MuteDuckSound());
//            Console.WriteLine();
//            duck1.PerformFly();
//            duck1.PerformDuckSound();

//        }
//    }
//}