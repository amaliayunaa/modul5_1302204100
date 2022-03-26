using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SayaTubeUser user1 = new SayaTubeUser("Yuna");

            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Spider-Man oleh Yuna");
            user1.AddVideo(video1);
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Titanic oleh Yuna");
            user1.AddVideo(video2);
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Upin Ipin The Movie oleh Yuna");
            user1.AddVideo(video3);
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Spongebob oleh Yuna");
            user1.AddVideo(video4);
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Kuntilanak 2 oleh Yuna");
            user1.AddVideo(video5);
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Baby Boss oleh Yuna");
            user1.AddVideo(video6);
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film After The Rain oleh Yuna");
            user1.AddVideo(video7);
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Geez & Ann oleh Yuna");
            user1.AddVideo(video8);
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Ada Apa Dengan Cinta oleh Yuna");
            user1.AddVideo(video9);
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Midnight Sun oleh Yuna");
            user1.AddVideo(video10);

            //video1.IncreasePlayCount(100);

            user1.PrintAllVideoPlaycount();
            Console.WriteLine(user1.GetTotalVideoPlayCount());
            //user1.GetTotalVideoPlayCount();
        }
    }
}
