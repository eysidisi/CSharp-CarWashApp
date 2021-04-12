using DEICO.CarWash.Service;
using System.Drawing;
using System.Windows.Forms;

namespace DEICO.CarWash.UI.UserControls
{
    public partial class CarWashIndicator : UserControl
    {
        private WashStep _washStep;

        public WashStep WashStep { get => _washStep; }
        public CarWashIndicator(WashStep washStep)
        {
            InitializeComponent();
            InitializeIndicator(washStep);
        }

        private void InitializeIndicator(WashStep washStep)
        {
            labelIndicatorName.Text = washStep.Name;
            _washStep = washStep;
            DeactivateLamp();
        }

        public void DeactivateLamp()
        {
            pictureBoxLamp.BackColor = Color.DarkGreen;
        }

        public void ActivateLamp()
        {
            pictureBoxLamp.BackColor = Color.LightGreen;
        }
    }
}
