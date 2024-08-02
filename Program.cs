namespace Test2
{
    internal class Program
    {
        public abstract class Monster
        {
            public string Name { get; set; }

            public Monster(string name)
            {
                Name = name;
            }

            public abstract void Attack();
        }

        public class  Pikachu : Monster
        {
            public Pikachu(string name) : base(name) { }

            public override void Attack() 
            {
                Console.WriteLine("백만볼트!");
            }
        }

        public class Charmander : Monster
        {
            public Charmander(string name) : base(name) { }

            public override void Attack()
            {
                Console.WriteLine("화염방사!");
            }
        }

        public class Squirtle : Monster
        {
            public Squirtle(string name) : base(name) { }

            public override void Attack()
            {
                Console.WriteLine("물총발사!");
            }
        }

        public class Bulbasaur : Monster
        {
            public Bulbasaur(string name) : base(name) { }

            public override void Attack()
            {
                Console.WriteLine("덩굴채찍!");
            }
        }

        static void Main(string[] args)
        {
            Monster[] monsters = new Monster[5];
            monsters[0] = new Pikachu("피카츄");
            monsters[1] = new Charmander("파이리");
            monsters[2] = new Squirtle("꼬부기");
            monsters[3] = new Bulbasaur("이상해씨");
            monsters[4] = new Pikachu("털뭉치");

            foreach(Monster monster in monsters)
            {
                Console.WriteLine($"{monster.Name} 공격해!");
                monster.Attack();
                Console.WriteLine();
            }
        }
    }
}
