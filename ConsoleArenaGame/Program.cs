using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }

        
        
        static void Main(string[] args)
        {
            GameEngine gameEngine = new GameEngine()
            {
                /*HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")*/
                
                //HeroA = new SpellCaster("Mage", 5, 10, new RodOfAges("ROA"), 40),
                HeroA = new FuryWarrior("FuryWarrior", 1, 10, new BloodThirster("BT")),
                HeroB = new Knight("Knight", 1, 10, new DeadmanPlate("DeadMan's Plate")),
                NotificationsCallBack = ConsoleNotification,
                
            };
            gameEngine.Fight();
            
            
            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}