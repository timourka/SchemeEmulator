using Models;
using System.Drawing;

namespace Exemples.BasicLED
{
    public class BasicLED : Device
    {
        public BasicLED(Point position) : base(
            new List<Picture> { new Picture( new Image("./LEDImage.png"), position) },
            new LEDBehavior(),
            new List<Connector>
            {
                new Connector(
                    "anod", "anod", 0,
                    new Picture(new Image("./anodImage.png"), new Point(position.X, position.Y))
                ),
                new Connector(
                    "catod", "catod", 0,
                    new Picture(new Image("./catodImage.png"), new Point(position.X + 50, position.Y))
                ),
            }
            )
        {
            // DONOTHING
        }
    }
}
