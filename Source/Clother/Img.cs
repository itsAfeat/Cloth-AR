using System.Drawing;

namespace Clother
{
    class Img
    {
        public string filepath;
        public Bitmap image;

        public Img(string filepath, Bitmap image)
        {
            this.filepath = filepath;
            this.image = image;
        }

        public void Update(string filepath)
        {
            image = new Bitmap(filepath);
            this.filepath = filepath;
        }
    }
}
