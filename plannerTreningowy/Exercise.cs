using System;

namespace plannerTreningowy.Domain
{
    /// <summary>Klasa bazowa – każde ćwiczenie MA nazwę i liczy kalorie.</summary>
    /// 
    public abstract class Exercise
    {
        private readonly string _name;               // ← hermetyzacja (pole prywatne)

        protected Exercise(string name) => _name = name ?? throw new ArgumentNullException(nameof(name));

        public string Name => _name;                 // ← publiczny „getter”

        /// <summary>Zwraca kalorie spalone w ciągu <paramref name="minutes"/> minut.</summary>
        public abstract int BurnedCalories(int minutes);

        public override string ToString() => Name;

        private string _description = "";

        public string Description
        {
            get => _description;
            set => _description = value ?? "";
        }

    }

    public class CardioExercise : Exercise
    {
        public CardioExercise(string name) : base(name) { }

        public override int BurnedCalories(int minutes) => 8 * minutes;
    }

    public class StrengthExercise : Exercise
    {
        public StrengthExercise(string name) : base(name) { }

        public override int BurnedCalories(int minutes) => 6 * minutes;
    }

}
