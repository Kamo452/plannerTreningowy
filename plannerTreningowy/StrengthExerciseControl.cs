using System.Windows.Forms;
using plannerTreningowy.Domain;

namespace plannerTreningowy.Gui
{
    public partial class StrengthExerciseControl : UserControl, IExerciseView
    {
        public StrengthExerciseControl()
        {
            InitializeComponent();
        }

        public void Display(Exercise exercise)
        {
            lblName.Text = exercise.Name;
            lblKcal.Text = $"{exercise.BurnedCalories(30)} kcal / 30 min";
        }

        #region Designer
        private Label lblName;
        private Label lblKcal;

        private void InitializeComponent()
        {
            lblName = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Trebuchet MS", 10F,
                          System.Drawing.FontStyle.Bold)
            };

            lblKcal = new Label
            {
                AutoSize = true,
                Top = 25,
                Font = new System.Drawing.Font("Trebuchet MS", 9F)
            };

            Controls.Add(lblName);
            Controls.Add(lblKcal);

            Width = 200;
            Height = 50;
            BackColor = System.Drawing.Color.Honeydew;
        }
        #endregion
    }
}
