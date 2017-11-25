using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;


namespace vspGL
{
    class Program
    {
        public static RenderWindow wind;
        static void Main(string[] args)
        {
            wind = new RenderWindow(new VideoMode(1280, 680), "sfml game");

            wind.Closed += onClose;

            while (wind.IsOpen)
            {
                wind.DispatchEvents();

                wind.Clear(Color.White);

                // draving

                wind.Display();
            }
        }

        private static void onClose(object sender, EventArgs e)
        {
            wind.Close();
        }
    }
}
