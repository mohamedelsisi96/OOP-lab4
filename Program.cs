namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region assosiation prob

            School school = new School() { Name = "estanha" };
            Teacher ehab = new Teacher() { Name = "Ehab" };
            school.OrganizeClass(ehab);

            #endregion

            #region aggrigation prob
            Team team = new Team();
            // Creating player objects
            Player player1 = new Player("Mostafa ali", "Forward");
            Player player2 = new Player("Ahmed Abdallah", "Midfielder");
            Player player3 = new Player("Ebrahim Elsisi", "Defender");

            // Adding players to the team using the indexer
            team[0] = player1;
            team[1] = player2;
            team[2] = player3;
            for (int i = 0; i < 3; i++)
            {
                Player currentPlayer = team[i];
                if (currentPlayer != null)
                {
                    Console.WriteLine($"Player {i + 1}: Name - {currentPlayer.Name}, Position - {currentPlayer.Position}");
                }
            }
            Player player4 = new Player("Omar Mohamed", "Forward");
            team[3] = player4;
            Console.WriteLine(team[3].Name);
            Console.WriteLine(team[3].Position);
            team[3].Name = "Mohamed Ehab";
            team[3].Position = "Midfielder";
            Console.WriteLine(team[3].Name);
            Console.WriteLine(team[3].Position);


            #endregion

            #region 	Composition prob

            House house =new House(4);
            Room room1 = new Room("Bedroom", 25);
            Room room2 = new Room("Kitchen", 30);
            Room room3 = new Room("Salone", 40);
            Room room4 = new Room("Bathroom", 10);
            //house[0]=room1;
            //house[1] = room2;
            //house[2] = room3;
            house.AddRoom(room1, 1);
            house.AddRoom(room2, 2);
            house.AddRoom(room3, 3);
            house.AddRoom(room4, 4);
            house.AllRoom();


            #endregion

        }
    }
}
