using Raylib_cs;
using static Raylib_cs.Raylib;
using Standalone_PET.UI;

namespace Standalone_PET
{
    public static class Program
    {
        public static void Main()
        {
            Button testButton = new Button(65, 25, "Button", 400, 300, Color.GRAY);
            InitWindow(800, 600, "Standalone Particle Editor Tool");

            while(!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(Color.WHITE);

                testButton.Update();

                DrawText("Hello World!", 350, 150, 10, Color.BLACK);

                EndDrawing();
            }
        }
    }
}