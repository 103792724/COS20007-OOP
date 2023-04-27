using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using passtask3;
using SplashKitSDK;

namespace passtask3
{
    internal class Drawing
    {
        private readonly List<Shape> _shapes;

        private Color _background;

        public Color Background { get => _background; set => _background = value; }

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
        }
        public Drawing() : this(Color.White)
        {
            // other steps could go here…
        }
        public int ShapeCount
        {
            get { return _shapes.Count; }
        }
        public void AddShape(Shape z)
        {
            _shapes.Add(z);
        }
        public void RemoveShape(Shape z)
        {
            _shapes.Remove(z);
        }
        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape z in _shapes)
            {
                z.Draw();
            }
        }
        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape z in _shapes)
                {
                    if (z.Selected)
                    {
                        result.Add(z);
                    }
                }
                return result;
            }
        }
        public void SelectedShapesAt(Point2D pt)
            {
                foreach (Shape z in _shapes)
                {
                    if (z.IsAt(pt))
                    {
                        z.Selected = true;
                    }
                }    
            }
        }

    }
