namespace Models
{
    public class Device
    {
        public List<Picture>? presentation;
        public IBehaviorScript? behaviorScript;
        public List<Connector> connectors;
        public List<Device>? childrenDevices;
        public Device(List<Picture> presentation, IBehaviorScript behaviorScript, List<Connector> connectors)
        {
            this.presentation = presentation;
            this.behaviorScript = behaviorScript;
            this.connectors = connectors;
            this.behaviorScript.Device = this;
        }
        public void Setup()
        {
            if (childrenDevices != null)
                foreach (var device in childrenDevices)
                {
                    device.Setup();
                }
            if (behaviorScript != null)
            {
                behaviorScript.IsRunning = true;
                behaviorScript.Setup();
            }
        }
        public void Loop()
        {
            if (childrenDevices != null)
                foreach (var device in childrenDevices)
                {
                    device.Loop();
                }
            behaviorScript?.Loop();
        }
    }
}
