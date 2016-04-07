using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using SdlDotNet.Graphics.Sprites;
using SdlDotNet.Input;
using System.Drawing;

namespace RoadFigther
{
    class Game
    {
        Sprite fons;
        Sprite fonsRepe;
        Sprite jugador;

        public Game()
        {
            Video.WindowCaption = "ROAD FIGHTER!";
            Video.SetVideoMode(800, 600);

            fons = new Sprite(new Surface("../../Imatges/fonsBO.jpg"));
            fonsRepe = new Sprite(new Surface("../../Imatges/fonsRepe.jpg"));
            jugador = new Sprite(new Surface("../../Imatges/Jugador.png"));
            fonsRepe.X = 99;
            fonsRepe.Y = 82;
            jugador.X = 430;
            jugador.Y = 450;

            Events.Tick += Events_Tick;

            // Video.Screen.Blit(sLleo);
            // POSAR ELS COTXES AMB:

            Events.Run();
        }

        private void Events_Tick(object sender, TickEventArgs e)
        {
            Video.Screen.Fill(Color.Black);
            // Video.Screen.Blit(fons);
            Video.Screen.Blit(fonsRepe);
            Video.Screen.Blit(jugador);

            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                //fonsRepe.Y += 3;
                jugador.Y -= 3;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                jugador.X -= 3;
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                jugador.X += 3;
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                jugador.Y += 3;
            }

            Video.Screen.Update();
        }
    }
}
