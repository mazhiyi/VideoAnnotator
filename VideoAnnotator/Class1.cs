using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VideoAnnotator
{
    class gl
    {
        public static string filename = @"C:\Users\Zoe Ma\Downloads\Videolist.txt", txtEx = ".csv";
        //filename: The path of Video.List; txtEx = the extension of output text files;
        public static string[] Clips; //Clip[0] = userID, Clip[1]~Clip[3] = name of segments; Clip[4] = TaskMode(A or B);
        public static string clipPath = @"C:\Users\Zoe Ma\Downloads", movEx = ".mp4"; //path: path of clip; movEx: extension of clips; 
        public static string currentClip, currentMode;// Clip: the current segment name; Path: the current directory of clips playing;
        // Name: the name of output file; Path: the path of output file
        public static string writeName;
        public static string writePath = @"C:\Users\Zoe Ma\Desktop";
        // The following variables can only be changed here
        public static string example, exampleA = @"C:\Users\Zoe Ma\Documents\VideoAnnotator_v3\Happy-Bothered.mp4", exampleB = @"C:\Users\Zoe Ma\Documents\VideoAnnotator_v3\Concentrated-Confused.mp4";
        public static string[] A = { "Happy", "Bothered" }, B = { "Concentrated", "Confused" }; // Task mode labels (5,4)
        public static string video = @"C:\Users\Zoe Ma\Downloads\Videos.csv";
    }
}
