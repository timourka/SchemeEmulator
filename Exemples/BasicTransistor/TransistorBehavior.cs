using Models;

namespace Exemples.BasicTransistor
{
    internal class TransistorBehavior : IBehaviorScript
    {
        public bool IsRunning { get; set; }
        public Device? Device { get; set; }

        public void Loop()
        {
            //TODO: Transistor behavior
        }

        public void Setup()
        {
        }
    }
}