using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Media;

namespace dip2
{
    class music
    {
        public SoundPlayer sp = new SoundPlayer(@"1.wav");
        public MediaPlayer sp1 = new MediaPlayer();
        public void musicplay()
        {
            sp.PlayLooping();
        }
        public void sound()
        {
            sp1.Open(new Uri("2.wav", UriKind.Relative));
            sp1.Play();
        }
        public void musicstop()
        {
            sp.Stop();
        }
    }
}
