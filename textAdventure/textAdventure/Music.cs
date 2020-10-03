using NAudio.Wave;
using System;
using System.Runtime.Serialization;
using System.Threading;
using WMPLib;
using System.Media;

namespace TextAdventure
{
    public class Music//class Music
    {
        public static void Mus()//method Mus
        {

            SoundPlayer player = new SoundPlayer();//creates SoundPlayer
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "0740.wav";//puts location of .wav file in variable player
            player.Play();//plays variable player


            
                



        }
      

            
        

    }

}
        
            


           



