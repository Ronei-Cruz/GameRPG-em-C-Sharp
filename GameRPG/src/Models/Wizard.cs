using System;

namespace GameRPG.src.Models
{
    public class Wizard : Characters
    {
        public Wizard(string Name, string HeroType, int Experience) : base (Name, HeroType, Experience)
        {
        }

         public override int Attack()
        {
            Random rnd = new Random();
            int attack = this.Level + rnd.Next(1,15);
            Console.WriteLine(this.Name + " Lançou magia causando " + attack + " dano");
            return attack;
        }

        public override int Damage(int live)
        {
            this.Experience = this.Experience - live;
            return this.Experience;
        }
    }
}