using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;


namespace Standalone_PET.UI
{
    public class Button
    {
        private Rectangle hitbox;
        public int Width;
        public int Height;
        public int X;
        public int Y;
        public Color color;
        public string Text;

        public Button()
        {
            Width = 0;
            Height = 0;
            Text = "";
            hitbox = new Rectangle();
        }

        public Button(int width, int height, string text, int x, int y, Color color)
        {
            Width = width;
            Height = height;
            Text = text;
            X = x;
            Y = y;
            this.color = color;

            hitbox = new Rectangle(x, y, width, height);
        }

        public void Update()
        {
            DrawRectangle(X, Y, Width, Height, color);
            if (CheckHover())
            {
                DrawRectangle(X, Y, Width, Height, ColorAlpha(Color.BLACK, 0.25f));
                if (IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    OnClick();
                }
            }
        }

        public bool CheckHover()
        {
            int MouseX = GetMouseX();
            int MouseY = GetMouseY();
            Vector2 MousePos = new Vector2(MouseX, MouseY);

            return CheckCollisionPointRec(MousePos, hitbox);
        }

        public virtual void OnClick(){}
    }
}
