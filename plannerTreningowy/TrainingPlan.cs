using System.Collections.Generic;
using plannerTreningowy.Domain;

namespace plannerTreningowy.Plans
{
    /// <summary>
    /// Klasa bazowa dla wszystkich planów treningowych.
    /// Pokazuje hermetyzację (prywatna lista) i polimorfizm (PlanType).
    /// </summary>
    public abstract class TrainingPlan
    {
        // hermetyzacja – prywatne pole
        private readonly List<Exercise> _exercises = new List<Exercise>();

        /// <summary>Dostęp tylko do odczytu – „bezpieczne” udostępnienie treningwo.</summary>
        public IReadOnlyList<Exercise> Exercises
        {
            get { return _exercises.AsReadOnly(); }
        }

        /// <summary>Dodaje ćwiczenie do planu.</summary>
        public void Add(Exercise exercise)
        {
            _exercises.Add(exercise);
        }

        /// <summary>Nazwa/typ planu – implementowana w klasach pochodnych.</summary>
        public abstract string PlanType { get; }
    }

    /// <summary>Plan nastawiony na cardio.</summary>
    public class CardioPlan : TrainingPlan
    {
        public override string PlanType
        {
            get { return "Cardio"; }
        }
    }

    /// <summary>Plan nastawiony na siłę.</summary>
    public class StrengthPlan : TrainingPlan
    {
        public override string PlanType
        {
            get { return "Siłowy"; }
        }
    }
}
