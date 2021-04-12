using DEICO.CarWash.Service;
using DEICO.CarWash.Service.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DEICO.CarWash.UI
{
    public partial class MainForm : Form
    {
        private List<WashStep> _washSteps;
        private bool _isWashStarted;
        private Thread _washingThread;

        public MainForm()
        {
            InitializeComponent();

            CenterToScreen();

            FillWashSteps();

            InitializeCarWashDisplay();

            InitializeEntryConsole();

            InitializeCarPositionSlider();

            _isWashStarted = false;

        }

        private void InitializeCarPositionSlider()
        {
            carPositionSlider.ResetAll();
        }

        private void InitializeCarWashDisplay()
        {
            carWashDisplay.InitializeCarWashIndicators(_washSteps);
            carWashDisplay.ResetAll();
        }

        private void InitializeEntryConsole()
        {
            entryConsole.InitializeWashStepButtons(_washSteps);
            entryConsole.SubscribeStartButtonClickEvent(StartButtonClicked);
            entryConsole.ResetAll();
        }

        private void StartButtonClicked(object sender, EventArgs e)
        {
            // If program is already running do nothing
            if (_isWashStarted)
            {
                return;
            }

            _isWashStarted = true;

            // Disable all Wash Options buttons
            entryConsole.DisableAllButtons();

            //The controller should signal the start of the wash by changing the color of the Wash
            //Entry LED to red and displaying Wash In Progress
            carWashDisplay.SetWashButtonRed();

            //High Pressure Wash must be added to the options programmatically after the user clicks Start
            entryConsole.SelectHighPressureWashButton();
            _washSteps.Find(ws => ws.StepType == Wash_Step_Type.HighPressureWash).IsSelected = true;

            _washingThread = new Thread(StartWashingProcedure);

            _washingThread.Start();
        }

        private void StartWashingProcedure()
        {
            // Get all selected wash steps
            List<WashStep> selectedWashSteps = _washSteps.Where(ws => ws.IsSelected).ToList();

            // Get the very first washing step
            WashStep currentWashStep = selectedWashSteps[0];

            // Flag value
            bool isWashingCompleted = false;

            // Timer used for calculating the time elapsed
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            while (true)
            {
                // Check if washing is completed
                if (isWashingCompleted)
                {
                    stopWatch.Stop();

                    carWashDisplay.SetElapsedTime(0.0f);

                    if (!carWashDisplay.IsOutOfPosLampActive)
                    {
                        carWashDisplay.ActivateVehicleOutOfPosition();
                    }
                    
                    if (carPositionSlider.GetCurrentStation() == Station.Exit)
                    {
                        StopWashingProcedure();
                    }
                    continue;
                }

                // Display elapsed time
                float elapsedTime = stopWatch.ElapsedMilliseconds / 1000f;
                carWashDisplay.SetElapsedTime(elapsedTime);

                // Check if time is up
                if (currentWashStep.StepTimeInSeconds <= elapsedTime)
                {
                    // Restart timer
                    stopWatch.Restart();

                    // Mark wash step to done
                    currentWashStep.IsDone = true;

                    // Deactivate the lamp
                    carWashDisplay.DeactivateWashStep(currentWashStep);

                    // Find next wash step
                    currentWashStep = selectedWashSteps.Find(ws => ws.IsDone == false);

                    // If there is no remaining wash step
                    if (currentWashStep == null)
                    {
                        isWashingCompleted = true;
                    }
                }

                else
                {
                    // If car is at correct position
                    if (carPositionSlider.GetCurrentStation() == currentWashStep.RequiredStation)
                    {
                        if (!stopWatch.IsRunning)
                        {
                            stopWatch.Start();
                        }

                        carWashDisplay.ActivateWashStep(currentWashStep);

                        carWashDisplay.DeactivateVehicleOutOfPosition();

                        continue;
                    }

                    // If car is not at correct position
                    else
                    {
                        stopWatch.Stop();
                        if (!carWashDisplay.IsOutOfPosLampActive)
                        {
                            carWashDisplay.ActivateVehicleOutOfPosition();
                        }
                        carWashDisplay.DeactivateWashStep(currentWashStep);
                    }
                }
            }
        }

        private void StopWashingProcedure()
        {
            _isWashStarted = false;

            carPositionSlider.ResetAll();

            carWashDisplay.ResetAll();

            entryConsole.ResetAll();

            _washSteps.ForEach(ws => { ws.IsSelected = false; ws.IsDone = false; });

            _washingThread.Abort();
        }

        private void FillWashSteps()
        {
            _washSteps = new List<WashStep>()
            {
                new WashStep("Under Body Wash",Wash_Step_Type.UnderBodyWash ,5,Station.Station1),
                new WashStep("Bug Remover",Wash_Step_Type.BugRemover,5,Station.Station1),
                new WashStep("Pre-Soak",Wash_Step_Type.PreSoak,5,Station.Station2),
                new WashStep("High Pressure Wash",Wash_Step_Type.HighPressureWash ,5,Station.Station2),
                new WashStep("Low Pressure Wax",Wash_Step_Type.LowPressureWax ,5,Station.Station2),
                new WashStep("Spot Free Rinse",Wash_Step_Type.SpotFreeRinse ,5,Station.Station2),
                new WashStep("Tire Shine Foam",Wash_Step_Type.TireShineFoam,5,Station.Station3),
                new WashStep("Air Dry",Wash_Step_Type.AirDry,5,Station.Station3),
            };
        }

        private void StopProgramClicked(object sender, EventArgs e)
        {
            // If program is already stopped just reset all
            if (_isWashStarted == false)
            {
                carPositionSlider.ResetAll();

                carWashDisplay.ResetAll();

                entryConsole.ResetAll();

                return;
            }


            // Avoid re-running this event after unchecking the box on the next step
            if (checkBoxStopProgram.Checked == false)
            {
                return;
            }

            StopWashingProcedure();

            checkBoxStopProgram.Checked = false;
        }
    }
}
