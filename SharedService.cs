using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;

namespace AliceBlue
{
    public static class SharedService
    {
        public static void PlaySound(string soundFile)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                SoundPlayer soundPlayer;
                var myAssembly = Assembly.GetExecutingAssembly();
                var stream = (myAssembly.GetManifestResourceStream(soundFile));
                soundPlayer = new SoundPlayer(stream);
                soundPlayer.PlaySync();
            }));
            thread.Start();
        }
    }
}
