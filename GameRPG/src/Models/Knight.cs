namespace GameRPG.src.Models
{
    public class Knight : Characters
    {
        public Knight(string Name, string HeroType, int Experience) : base (Name, HeroType, Experience)
        {            
        }

        public override int Attack()
        {
            Random rnd = new Random();
            int attack = this.Level + rnd.Next(1,15);
            Console.WriteLine(this.Name + " Ataque com sua espada causando " + attack + " dano");
            return attack;
        }

        public override int Damage(int live)
        {
            this.Experience = this.Experience -live;
            return this.Experience;
        }

    }
}