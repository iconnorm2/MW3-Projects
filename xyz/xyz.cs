using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinityScript;

namespace xyz
{
    public class xyz : BaseScript
    {
        public xyz() : base()
        {
            PlayerConnected += new Action<Entity>(player =>
            {
                Call("setdvar", "cg_LaserForceOn", 1);
                Call("setdvar", "cg_laserlight", 1);

                HudElem PlayerPos = HudElem.CreateFontString(player, "hudbig", 0.8f);
                PlayerPos.SetPoint("top left", "top left", 10, 140);
                PlayerPos.HideWhenInMenu = true;

                OnInterval(3500, () =>
                {
                    float X = (player.Origin.X);
                    float Y = (player.Origin.Y);
                    float Z = (player.Origin.Z);
                    int PlayerX = (int)X;
                    int PlayerY = (int)Y;
                    int PlayerZ = (int)Z;

                    PlayerPos.SetText("Position: X: " + PlayerX + " Y: " + PlayerY + " Z: " + PlayerZ);

                    return true;
                });
            });
        }
    }
}