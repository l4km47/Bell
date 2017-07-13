using System.IO;

namespace RcisSchoolBell.lib
{
   public class Player
    {
       public static string[] Playlist(string path)
       {
           var f = Directory.Exists(path) ? Directory.GetFiles(path,"*.mp3") : null;
        
           return f;
       }


    }
}
