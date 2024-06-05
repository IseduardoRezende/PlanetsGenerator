namespace PlanetsGenerator.Services
{
    public abstract class Randomizer
    {
        protected static readonly Random _random = new();

        public static T[] GetRandomItems<T>(T[] items)
        {
            //SuperHeroBuilderInputValidation.ValidateInputs(items, nameof(items));
            return _random.GetItems(items, _random.Next(items.Length)).Distinct().ToArray();
        }

        public static T GetRandomItem<T>(T[] items)
        {
            //SuperHeroBuilderInputValidation.ValidateInput(items, nameof(items));
            return items.ElementAt(_random.Next(items.Length));
        }

    }
}
