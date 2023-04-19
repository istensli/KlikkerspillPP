namespace KlikkerspillPP
{
    internal class Program
    {

        /*Skriv om til mer objektorientert ved å innføre en klasse ClickerGame med objektvariabler for de tre int-variablene og en metode for hver kommando.
         * Innfør også et interface ICommand med kun én metode, Run. Lag så en klasse for hver kommando i applikasjonen.
         Lag også en egen klasse CommandSet.
         Denne har en array med et objekt av hver kommando.
         Når brukeren taster et tegn, skal dette sendes til metoden RunCommand i CommandSet.
         Der slår den opp hvilken kommando som har den aktuelle bokstaven og kjører så Run på denne kommandoen.
         */
        static void Main(string[] args)
        {            
            var clickerGame = new ClickerGame();
            var commandSet = new CommandSet(clickerGame);

            while(true)
            {
                clickerGame.Show();
                var commandFromUser = Console.ReadKey(true).KeyChar;
                commandSet.RunCommand(commandFromUser);
            }
        }
    }
}