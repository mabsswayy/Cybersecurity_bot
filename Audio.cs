namespace Cybersecurity_bot
{
    //importing system media
    using System.Media;
    using System;
    using System.IO;

    public class Audio
    {
        public Audio()
        {
            //get project
            string project_location = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(project_location);
            //replacing the file bin\debug\to get audio
            string updated_path = project_location.Replace("bin\\Debug\\", "");
            //combine wav
            string full_fpath = Path.Combine(updated_path, "recording.wav");
            Play_wav(full_fpath);
        }//end of constructor
        //method to play sound
        private void Play_wav(string full_path)

        {
            try
            {
                //play sound
                using (SoundPlayer player = new SoundPlayer(full_path))
                {
                    //
                    player.PlaySync();
                }//end of using
            }
            catch (Exception error)
            {
//displaying error msge
Console.WriteLine(error.Message);
            }//end of catch
        }
    }//end of class
}//end of namespace