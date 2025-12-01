using System.Drawing;

namespace Models
{
    public class Picture
    {
        public Image image;
        public Point location;
        public Picture(Image image, Point position)
        {
            this.image = image;
            this.location = position;
        }
    }
}
