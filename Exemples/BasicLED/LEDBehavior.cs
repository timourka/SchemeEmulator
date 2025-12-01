using Models;

namespace Exemples.BasicLED
{
    internal class LEDBehavior : IBehaviorScript
    {
        public bool IsRunning { get; set; }
        public Device? Device { get; set; }

        private Image _shiningImage;
        private Image _notShiningImage;

        public LEDBehavior()
        {
            _shiningImage = Image("./shiningLEDImage.png");
            _notShiningImage = Image("./LEDImage.png");
        }

        private void checkAndChange()
        {
            if (Device.connectors[0].curentVoltage - Device.connectors[1].curentVoltage > 3)
            {
                Device.presentation[0].image = _shiningImage;
            }
            else
            {
                Device.presentation[0].image = _notShiningImage;
            }
        }

        public void Loop()
        {
            checkAndChange();
        }

        public void Setup()
        {
            checkAndChange();
        }
    }
}
