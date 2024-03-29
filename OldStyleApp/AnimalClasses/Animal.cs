﻿using System;
using System.Collections;

namespace OldStyleApp
{
	public class Animal
	{
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        //Has A Relationship
        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIdInfo.IDNum = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"The animal has the id of {this.animalIdInfo.IDNum} and is owned by {this.animalIdInfo.Owner}");
        }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true; // Assuming the animal is hungry by default
        }

        // Method to simulate the animal making a sound
        public virtual void MakeSound() //virtual can be overriten by classes that inherit
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        // Method for the animal to eat
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
                IsHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry right now.");
            }
        }

        // Method for the animal to play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
            IsHungry = true; // Playing might make the animal hungry
        }

        public void PolymorphismExample()
        {
            Console.WriteLine("This method is rom animal.");
        }

        //Modify to string method of base class
        public override string ToString()
        {
            string hunger = IsHungry ? "" : "not ";
            return string.Format($"{Name} is {Age} years old and is {hunger}hungry");
        }
    }
}

