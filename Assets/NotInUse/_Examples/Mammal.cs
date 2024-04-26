//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Rendering;

//public abstract class Mammal : Animal
//{
   
//    public override void Move()
//    {
        
//        Debug.Log("Moving");
        
//    }

//    public abstract void GiveBirth();
//    public Mammal()
//    {

//    }
//    public Mammal(string name, int health) : base(name)
//    {
//        this.name = name;
//        this.health = health;
//    }

//    public override void Eat()
//    {

//    }

//    public class Lion : Mammal
//    {
//        public override void GiveBirth()
//        {
            
//        }
//    }
//    public class Bat : Mammal, IFly
//    {

//        public override void Move()
//        {
//            base.Move();
//            Fly();
//        }

//        public void Fly()
//        {

//        }
//        public override void GiveBirth()
//        {
            
//        }
//    }
//    public class Platypus : Mammal, ILayEggs
//    {
//        public override void GiveBirth()
//        {
            
//        }

//        public void ILayEggs()
//        {

//        }
//    }
//}


