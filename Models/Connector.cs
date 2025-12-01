namespace Models
{
    public class Connector
    {
        public string? name;
        public string? description;
        public double? curentVoltage;
        public Picture picture;
        public Connector(string? name, string? description, double? voltage, Picture picture)
        {
            this.name = name;
            this.description = description;
            this.curentVoltage = voltage;
            this.picture = picture;
        }
    }
}
