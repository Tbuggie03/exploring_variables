namespace Variable_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string heroFirstName = "Tommy";
            string heroLastName = "Seternus";
            string heroFullName;
            string villainTitle = "Prince of Evil";
            string minionTitle = "Goon";
            string villainName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            //Begin Coding
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the glorious hero of programming, whose name is " + heroFullName);

            villainName = "Jonkler";
            minion1Name = "Rick";
            minion2Name = "Stick";

            // Boss Time
            Console.WriteLine(heroFullName + "'s arch enemy is " + villainName + " the " + villainTitle);

            // Minion Time
            Console.WriteLine(villainName + " the " + villainTitle + " is helped by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

            // Are you Ready?!
            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's Health: " + heroHealth);
            Console.WriteLine("Boss's Health: " + bossHealth);
            Console.WriteLine("Minion 1's Health: " + minion1Health);
            Console.WriteLine("Minion 2's Health: " + minion2Health);

            // Time to Fight!
            // Bad guy's attack first
            // Boss attacks
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            // Subtract the Health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            // Minions attack
            Console.WriteLine("The minions are attacking now!");
            Console.WriteLine(minionTitle + " " + minion1Name + " deals " + minionStrength + " damage!");
            // Subtract the Health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " deals " + minionStrength + " damage!");
            // Subtract the Health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            // Hero attacks
            Console.WriteLine(heroFullName + " attack each villain for " + heroStrength + " damage!");
            // Combination assignment and Arithmetic operator
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            // Display new villain health
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            // Minions have been defeated1
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");
            // End of Round Buff
            Console.WriteLine(heroFullName + " has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " drinks a potion to restore some health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            // Finish the Fight
            Console.WriteLine("The remaining fighters continue to fight!");
            Console.WriteLine("Hero's health:" + heroHealth);
            Console.WriteLine("Boss's health:" + bossHealth);
            // Boss attacks first
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            // Subtract the Health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            // Hero attacks
            Console.WriteLine(heroFullName + " attacks " + villainName + " the " + villainTitle + " for " + heroStrength + " damage!");
        }
    }
}
