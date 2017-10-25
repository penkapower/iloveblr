using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using WMPLib;
using System.Media;
using System.Windows.Controls;

namespace dip2
{
    static class Program
    {
        public static Form2 Form2
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static int pic14 = 0;
        public static int pic13 = 0;
        public static int pic15 = 0;
        public static int pic16 = 0;
        public static int score1 = 0;
        public static int score2 = 0;
        public static int vib = 0;
        public static string team1;
        public static string team2;
        public static string logo1;
        public static string logo2;
        public static SoundPlayer backsound = new SoundPlayer(@"files/sound/bcgr.wav");
        public static int backsoundpl = 1;
        public static MediaPlayer butclic = new MediaPlayer();
        public static int bbutclicpl = 1;
        public static int back = 0;
    }
}
