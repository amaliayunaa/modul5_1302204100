using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204100
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length < 200 && title != null, "Length nama jangan lebih dari 200 dan jangan NULL!");

            this.title = title;
            Random random = new Random();
            id = random.Next(0, 10000);
            PlayCount = 0;
        }

        public void IncreasePlayCount(int playC)
        {


            try
            {
                if (playC > 25000000) throw new Exception("playCount maksimal 25.000.000!");
                PlayCount = playC + PlayCount;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails()
        {

            Console.WriteLine("id: " + id);
            Console.WriteLine("judul: " + title);
            Console.WriteLine("play count: " + PlayCount);
        }
        public int getPlayCount()
        {
            return this.PlayCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
