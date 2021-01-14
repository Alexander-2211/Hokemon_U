using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Hokemon
    {
       // Members include 

        //Attributes
        
       
        private string name;
        private int Health;
        private int Max_health;
        private int Attack;
        private int Speed;
        private int Defence;
    
    // Properties are a combination of a field and method
    // This keeps variables / attributes private 
    // and allows us to perform checks on what is input

    public string Name {


            get { return name; }  //access to the name attribute
            set { Name = value;  }
        }
    public int Health
     { 
       get { return health;  } 
       set { health = value;  }
     }

        //Methods
        public Hokemon()  //constructor method
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defence = random_int_generator(10, 100);
        }

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon: ")
            name = Console.ReadLine();

        }
        public void get_details()
        {
            Console.WriteLine("\n\n**********\n" +
                "Name: {0}\n" +
                "Health: {1}/{2}\n" +
                "Attack Value: {3}\n" +
                " Speed Value: {4}\n " +
                "Defence Value: {5}",name, Health, max_health, attack, speed, defence);
        }
        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();     // Creating a new OBJECT called rnd and this is an instance of RANDOM class

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);  //Using the NEXT method from the RADNOM class found in rnd OBJECT

           return randomValue;
        }
    
    
    
    
  
    }
}

