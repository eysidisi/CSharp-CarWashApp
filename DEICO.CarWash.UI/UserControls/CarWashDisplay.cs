using DEICO.CarWash.Service;
using DEICO.CarWash.Service.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEICO.CarWash.UI.UserControls
{
    public partial class CarWashDisplay : UserControl
    {
        public CarWashDisplay()
        {
            InitializeComponent();
        }
        public bool IsOutOfPosLampActive { get; private set; } = false;

        public void InitializeCarWashIndicators(List<WashStep> washSteps)
        {
            foreach (WashStep washStep in washSteps)
            {
                CarWashIndicator carWashIndicator = new CarWashIndicator(washStep);
                tableLayoutPanelIndicators.Controls.Add(carWashIndicator);
            }

            // Add Vehicle Out Of Position
            WashStep washStepOutOfPos =
               new WashStep("Vehicle Out of Position", Wash_Step_Type.CarOutOfPosition, 0, Station.Exit);

            CarWashIndicator outOfPosIndicator = new CarWashIndicator(washStepOutOfPos);

            tableLayoutPanelIndicators.Controls.Add(outOfPosIndicator);
        }

        public void ResetAll()
        {
            buttonWashVacant.BackColor = Color.LightGreen;

            foreach (var item in tableLayoutPanelIndicators.Controls)
            {
                CarWashIndicator carWashIndicator = item as CarWashIndicator;

                carWashIndicator.DeactivateLamp();
            }
            IsOutOfPosLampActive = false;
            SetElapsedTime(0.0);
        }

        public void SetWashButtonRed()
        {
            buttonWashVacant.BackColor = Color.Red;
        }

        public void SetElapsedTime(double time)
        {
            // Avoid cross thread problems
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { SetElapsedTime(time); }));
            }

            else
            {
                textBoxElapsedTime.Text = $"{time:f1}";
            }
        }

        public void ActivateVehicleOutOfPosition()
        {
            // Avoid cross thread problems
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { ActivateVehicleOutOfPosition(); }));
            }

            else
            {
                foreach (var item in tableLayoutPanelIndicators.Controls)
                {
                    CarWashIndicator carWashIndicator = item as CarWashIndicator;

                    if (carWashIndicator.WashStep.StepType == Wash_Step_Type.CarOutOfPosition)
                    {
                        carWashIndicator.ActivateLamp();
                        IsOutOfPosLampActive = true;
                    }
                }
            }
        }

        public void DeactivateVehicleOutOfPosition()
        {
            // Avoid cross thread problems
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { DeactivateVehicleOutOfPosition(); }));
            }

            else
            {
                foreach (var item in tableLayoutPanelIndicators.Controls)
                {
                    CarWashIndicator carWashIndicator = item as CarWashIndicator;

                    if (carWashIndicator.WashStep.StepType == Wash_Step_Type.CarOutOfPosition)
                    {
                        carWashIndicator.DeactivateLamp();
                        IsOutOfPosLampActive = false;
                    }
                }
            }
        }

        public void ActivateWashStep(WashStep washStep)
        {
            foreach (var item in tableLayoutPanelIndicators.Controls)
            {
                CarWashIndicator carWashIndicator = item as CarWashIndicator;

                if (carWashIndicator.WashStep == washStep)
                {
                    carWashIndicator.ActivateLamp();
                }
            }
        }

        public void DeactivateWashStep(WashStep washStep)
        {
            foreach (var item in tableLayoutPanelIndicators.Controls)
            {
                CarWashIndicator carWashIndicator = item as CarWashIndicator;

                if (carWashIndicator.WashStep == washStep)
                {
                    carWashIndicator.DeactivateLamp();
                }
            }
        }
    }
}
