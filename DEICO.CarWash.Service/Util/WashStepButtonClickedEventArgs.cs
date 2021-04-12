using DEICO.CarWash.Service;
using System;

namespace DEICO.CarWash.Service.Util
{
    public class WashStepButtonClickedEventArgs : EventArgs
    {
        public WashStepButtonClickedEventArgs(WashStep clickedWashStep)
        {
            ClickedWashStep = clickedWashStep;
        }

        public WashStep ClickedWashStep { get; private set; }
    }
}
