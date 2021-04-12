using DEICO.CarWash.Service.Util;

namespace DEICO.CarWash.Service
{
    /// <summary>
    /// Class is used for defining wash steps with features
    /// </summary>
    public class WashStep
    {
        public WashStep(string name,Wash_Step_Type stepType, int stepTime, Station requiredStation)
        {
            Name = name;
            StepType = stepType;
            StepTimeInSeconds = stepTime;
            RequiredStation = requiredStation;
        }

        public bool IsSelected { get; set; } = false;
        public bool IsDone { get; set; } = false;
        public string Name { get; private set; }
        public int StepTimeInSeconds { get; private set; }
        public Station RequiredStation { get; private set; }
        public Wash_Step_Type StepType{ get; private set; }
    }
}
