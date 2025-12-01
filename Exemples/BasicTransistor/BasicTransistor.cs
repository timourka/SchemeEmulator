using Models;
using System.Drawing;

namespace Exemples.BasicTransistor
{
    public class BasicTransistor : Device
    {
        
        public BasicTransistor(Point position) : base(new List<Picture>(), new TransistorBehavior(), new List<Connector>())
        {
            connectors.AddRange(new List<Connector>(){
                new Connector(
                    "base",
                    "base",
                    0,
                    new Picture(
                        new Image("./baseImage.png"),
                        new Point(position.X + 50, position.Y)
                    )
                ),
                new Connector(
                    "collector",
                    "collector",
                    0,
                    new Picture(
                        new Image("./collectorImage.png"),
                        new Point(position.X, position.Y)
                    )
                ),
                new Connector(
                    "emitor",
                    "emitor",
                    0,
                    new Picture(
                        new Image("./emitorImage.png"),
                        new Point(position.X, position.Y + 50)
                    )
                )
            });
            presentation.Add(new Picture(new Image("./transistorImage.png"), position));
        }
    }
}
