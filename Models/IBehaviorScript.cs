namespace Models
{
    public interface IBehaviorScript
    {
        public bool IsRunning { get; set; }
        public Device? Device { get; set; }
        public void Setup();
        public void Loop();
        
    }
}