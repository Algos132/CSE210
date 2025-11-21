using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        // creates the first video
        video1.setVideo("Crazy Video!", "John Doe", 123);

        // Comments for the first video
        video1.addComment("Jane Doe", "This video is crazy!");
        video1.addComment("Jason Doe", "This video is SO crazy!");
        video1.addComment("John Downer", "It's not that crazy.");

        // Displays the first video and the comments on it
        video1.displayVideo();
        video1.displayComments();
        Console.WriteLine();


        // creates the second video
        video2.setVideo("Did you know?", "Martha Doe", 550);
        
        // Comments for the second video
        video2.addComment("Steve", "First");
        video2.addComment("Alison Doe", "I DID know!");
        video2.addComment("John Boe", "I DIDN'T know about that!");

        // Displays the second video and the comments on it
        video2.displayVideo();
        video2.displayComments();
        Console.WriteLine();


        // creates the third video
        video3.setVideo("Funny Cat", "Cat Lady", 120);
        
        // Comments for the third video
        video3.addComment("AirforcePilot", "These cats are soo cute they melt my heart!");
        video3.addComment("Bark", "These cats are so overrated.");
        video3.addComment("ThatGuy34", "I'm that guy.");

        // Displays the third video and the comments on it
        video3.displayVideo();
        video3.displayComments();
    }
}