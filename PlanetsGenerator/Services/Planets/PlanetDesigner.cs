namespace PlanetsGenerator.Services.Planets
{
    public class PlanetDesigner
    {
        private static readonly int _radius = 13;

        public static void Draw(ConsoleColor color)
        {
            SetConsoleBackgroudColor(color);

            Console.ForegroundColor = color;

            for (int y = -_radius; y <= _radius; y++)
            {
                for (int x = -_radius; x <= _radius; x++)
                {
                    if ((x * x) + (y * y) < _radius * _radius)
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

        private static void SetConsoleBackgroudColor(ConsoleColor consoleColor)
        {
            if (consoleColor is not ConsoleColor.Black)
                return;

            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
