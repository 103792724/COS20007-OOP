using SplashKitSDK;


namespace passtask3
{
    public class Program
    {
        public static void Main()

        {
            
            Drawing mydrawing = new Drawing();

            new Window("Shape Drawer- Nguyen Manh Duc ", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myshape = new Shape();
                    myshape.X = SplashKit.MouseX();
                    myshape.Y = SplashKit.MouseY();
                    myshape.Colour = SplashKit.ColorBrown();
                    mydrawing.AddShape(myshape);
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    mydrawing.SelectedShapesAt(SplashKit.MousePosition());
                }


                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    mydrawing.Background = SplashKit.RandomColor();
                }
                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    foreach (Shape z in mydrawing.SelectedShapes)
                    {
                        mydrawing.RemoveShape(z);
                    }
                }


                mydrawing.Draw();
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer- Nguyen Manh Duc "));


        }
    }
}