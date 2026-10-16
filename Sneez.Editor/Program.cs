using System;
using Sneez.Core;
using Raylib_cs;
using System.Numerics;

namespace Sneez.Editor
{
    class EditorApp : Application
    {
        private Camera3D _camera;
        private Vector3 _cubePosition;

        public EditorApp() : base(1280, 720, "Sneez Editor - Milestone 1")
        {
        }

        protected override void Initialize()
        {
            _camera = new Camera3D
            {
                Position = new Vector3(4.0f, 4.0f, 4.0f),
                Target = new Vector3(0.0f, 0.0f, 0.0f),
                Up = new Vector3(0.0f, 1.0f, 0.0f),
                FovY = 45.0f,
                Projection = CameraProjection.Perspective
            };

            _cubePosition = new Vector3(0.0f, 0.0f, 0.0f);
        }

        protected override void Update()
        {
            // Simple camera movement could be added here later
        }

        protected override void Draw()
        {
            Raylib.BeginMode3D(_camera);

            Raylib.DrawCube(_cubePosition, 2.0f, 2.0f, 2.0f, Color.Red);
            Raylib.DrawCubeWires(_cubePosition, 2.0f, 2.0f, 2.0f, Color.Maroon);
            Raylib.DrawGrid(10, 1.0f);

            Raylib.EndMode3D();

            Raylib.DrawText("Sneez Editor - Milestone 1 Foundation", 10, 10, 20, Color.DarkGray);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var app = new EditorApp();
            app.Run();
        }
    }
}
