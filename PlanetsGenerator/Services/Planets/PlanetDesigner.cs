namespace PlanetsGenerator.Services.Planets
{
    public class PlanetDesigner
    {
        private const int Radius = 13;

        public static void Draw(ConsoleColor planetColor)
        {
            SetConsoleBackgroudColor(planetColor);

            Console.ForegroundColor = planetColor;

            for (int y = -Radius; y <= Radius; y++)
            {
                for (int x = -Radius; x <= Radius; x++)
                {
                    if (Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(Radius, 2))
                    {
                        Console.Write(" ");
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }

        private static void SetConsoleBackgroudColor(ConsoleColor planetColor)
        {
            if (planetColor is not ConsoleColor.Black)
                return;

            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
