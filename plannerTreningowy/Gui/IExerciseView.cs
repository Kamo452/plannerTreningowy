using plannerTreningowy.Domain;

namespace plannerTreningowy.Gui
{
    /// <summary>Interfejs GUI – jeden kontrakt dla RÓŻNYCH kontrolek ćwiczeń.</summary>
    public interface IExerciseView
    {
        void Display(Exercise exercise);
    }
}
