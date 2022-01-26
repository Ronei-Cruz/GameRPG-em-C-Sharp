using System;

namespace GameRPG
{
    public abstract class Characters
    {
        
        public Characters(string Name, string HeroType, int Experience)
        {
            this.Name = Name;
            this.Level = 1;
            this.HeroType = HeroType;
            this.HitPoint = 10;
            this.Experience = Experience;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HitPoint;
        public int Experience;

        public override string? ToString()
        {
            return "Nome: " +this.Name + "\n" 
            + "Level: " + this.Level + "\n" 
            + "Tipo: " + this.HeroType + "\n"
            + "HP: " + this.HitPoint + "\n"
            + "XP: " + this.Experience;
        }

        public virtual int Attack()
        {
            Random rnd = new Random();
            int attack = this.HitPoint + rnd.Next(1,15);
            Console.WriteLine(this.Name + " Ataque efetivo com " + attack + " dano");
            return attack;
        }

        public virtual int Damage(int live)
        {
            this.Experience = this.Experience - live;
            return this.Experience;
        }
        
    }
}