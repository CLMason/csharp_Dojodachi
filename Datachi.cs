using System;

namespace Dojodachi.Models{
    public class Datchi
    {
        public int meals; 
        public int happiness;
        public int energy;
        public int fullness;
        public string image; 
        public string message;
        public bool isActive;
        public Datchi() //constructor
        {
            meals=3;
            happiness=20;
            fullness=20;
            energy=50;
            image="adopted_chick.gif";
            message="You just adopted a Dojodatchi!";
            isActive=true;
        }
        public void Feed()
        {
            this.image="eating_chick.gif";
            if(this.meals > 0) //if the meals are greater than 0
            {
                this.meals--;//reduce number of meals
                Random rand = new Random(); // we need to create a random 
                if (rand.Next(4)==0) //if it randomly gives us a number between 0 and 1 that is less than 0.25 then that's our 25% the Dojodatchi will like the food.
                { 
                    this.message="Oops! The meal was not good!";
                }
                else
                {
                    this.fullness += rand.Next(5,11);//this will increase the fullness
                    this.message="Wow! The food was good!";
                }
            }
            else //if the meals are less than 0
            {
                this.message="Oops!We don't have enough meals! Good-bye!";
            }
           
        }
        public void Play()
        {
            this.image="playing_chick.gif";
            this.energy -= 5; //playing with Dojodatchi will cost you 5 coins 
            Random rand = new Random();
            if(rand.Next(4)==0)//25% Dojodatchi didn't enjoy playing. 
            {
                this.message="Dojodachi is bored.";
            }
            else
            {
                this.happiness =+ rand.Next(5,11); //happiness will increase a random number between 5 and 10
                this.message = "Dojodachi had fun!";
            }
        }
        public void Sleep()
        {
            this.image ="sleeping_chick.gif";
            this.energy += 15;
            this.fullness -=5;
            this.happiness -= 5;
            this.message = "Dojodachi woke up rested!";
        }
        public void Work()
        {
            this.image="work_chick.gif";
            this.energy -= 5;//working cost 5 coins 
            Random rand = new Random();
            this.meals += rand.Next(1,4);
            this.message="Work completed.Dojodachi is tired...";
        }
        public bool _CheckGameOver()
        {
            if(happiness==0 || energy==0 || fullness==0)
            {
                this.message="You lost! Game over!";
                this.image="angry_chick.gif";
                isActive=false;
                return true;
            }
            else if(happiness > 99 && energy > 99 && fullness > 99)
            {
                this.message="You win!";
                this.image="win_chick.gif";
                isActive=false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}