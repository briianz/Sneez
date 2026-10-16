using Raylib_cs;

namespace Sneez.Core
{
    public class Application
    {
        public int WindowWidth { get; private set; }
        public int WindowHeight { get; private set; }
        public string Title { get; private set; }

        public Application(int width = 800, int height = 600, string title = "Sneez Engine")
        {
            WindowWidth = width;
            WindowHeight = height;
            Title = title;
        }

        public void Run()
        {
            Raylib.InitWindow(WindowWidth, WindowHeight, Title);
            Raylib.SetTargetFPS(60);

            Initialize();

            while (!Raylib.WindowShouldClose())
            {
                Update();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RayWhite);

                Draw();

                Raylib.EndDrawing();
            }

            Shutdown();

            Raylib.CloseWindow();
        }

        protected virtual void Initialize()
        {
        }

        protected virtual void Update()
        {
        }

        protected virtual void Draw()
        {
        }

        protected virtual void Shutdown()
        {
        }
    }
}
