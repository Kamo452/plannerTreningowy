using System.Collections.Generic;
using plannerTreningowy.Domain;

namespace plannerTreningowy.Plans
{
    /// <summary>Plan treningowy – klasa bazowa (dziedziczenie).</summary>
    public abstract class TrainingPlan
    {
        private readonly List<Exercise> _exercises = new();   // ← hermetyzacja

        public IReadOnlyList<Exercise> Exercises => _exercises.AsReadOnly();

        public void Add(Exercise ex) => _exercises.Add(ex);

        public abstract string PlanType { get; }
    }

    public class CardioPlan : TrainingPlan
    {
        public override string PlanType => "Cardio";
    }

    public class StrengthPlan : TrainingPlan
    {
        public override string PlanType => "Siłowy";
    }
}
