using DEICO.CarWash.Service;
using DEICO.CarWash.Service.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DEICO.CarWash.UI.UserControls
{
    public partial class EntryConsole : UserControl
    {
        public EntryConsole()
        {
            InitializeComponent();
        }

        public void InitializeWashStepButtons(List<WashStep> washSteps)
        {
            int buttonWidth = tableLayoutPanelWashOptions.Width - 10;

            foreach (WashStep washStep in washSteps)
            {
                tableLayoutPanelWashOptions.RowStyles.Add(new RowStyle(SizeType.AutoSize, 35));

                Button washStepButton = new Button()
                {
                    Text = washStep.Name,
                    Width = buttonWidth
                };

                WashStepButtonClickedEventArgs buttonClickArgs = new WashStepButtonClickedEventArgs(washStep);

                washStepButton.Click += (sender, eventArgs) => { WashStepButton_Click(washStepButton, buttonClickArgs); };

                tableLayoutPanelWashOptions.Controls.Add(washStepButton);
            }
        }

        internal void ResetAll()
        {

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { ResetAll(); }));
            }
            else
            {
                foreach (Control item in tableLayoutPanelWashOptions.Controls)
                {
                    item.Enabled = true;
                }

                foreach (Button item in tableLayoutPanelWashOptions.Controls)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        internal void DisableAllButtons()
        {
            foreach (Control item in tableLayoutPanelWashOptions.Controls)
            {
                item.Enabled = false;
            }
        }

        private void WashStepButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button clickedButton))
            {
                return;
            }

            WashStep washStep = (e as WashStepButtonClickedEventArgs).ClickedWashStep;

            // Toggle isSelected
            washStep.IsSelected = !washStep.IsSelected;

            if (washStep.IsSelected)
            {
                clickedButton.BackColor = Color.Green;
            }
            else
            {
                clickedButton.BackColor = Color.White;
            }
        }

        internal void SelectHighPressureWashButton()
        {
            foreach (Button item in tableLayoutPanelWashOptions.Controls)
            {
                if (item.Text == "High Pressure Wash")
                {
                    item.BackColor = Color.Green;
                }
            }
        }

        public void SubscribeStartButtonClickEvent(EventHandler eventHandler)
        {
            buttonStart.Click += eventHandler;
        }
    }
}
