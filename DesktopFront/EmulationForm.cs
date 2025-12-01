using Models;

namespace DesktopFront
{
    public partial class EmulationForm : Form
    {
        private Device _mainDevice;
        public EmulationForm()
        {
            _mainDevice = new Device();
            InitializeComponent();
        }
    }
}
