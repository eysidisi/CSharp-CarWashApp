using DEICO.CarWash.Service.Util;
using System;
using System.Windows.Forms;

namespace DEICO.CarWash.UI.UserControls
{
    public partial class CarPositionSlider : UserControl
    {
        public CarPositionSlider()
        {
            InitializeComponent();
        }

        public void ResetAll()
        {
            // Avoid cross thread problems
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { ResetAll(); }));
            }

            else
            {
                trackBar.Value = 0;
            }
        }

        public Station GetCurrentStation()
        {
            // Avoid cross thread problems
            if (InvokeRequired)
            {
                return (Station)Invoke(
                      new Func<Station>(() => GetCurrentStation()));
            }
            else
            {
                return (Station)trackBar.Value;
            }
        }
    }
}
