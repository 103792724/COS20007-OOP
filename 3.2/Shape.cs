using SplashKitSDK;

namespace passtask3
{
    public class Shape
    {
        private Color _colour;
        private float _x, _y;
        private int _width, _height;
        private bool _selected;

        public Shape()
        {
            _colour = Color.Green;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
        }

        public Color Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public bool Selected { get => _selected; set => _selected = value; }

        public void Draw()
        {
            SplashKit.FillRectangle(_colour, _x, _y,
                                   _width, _height);
            if (_selected)
            {
                this.DrawOutline();
            }
        }

        public bool IsAt(Point2D pt)
        {
            if ((((pt.X >= _x) && (pt.X <= (_x + _width))) && (pt.Y >= _y) && (pt.Y <= (_y + _height))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Yellow, X - 2, Y - 2, Width + 4, Height + 4);
        }
    }
}
