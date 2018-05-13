using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СarServiceApplication
{
    public static class TheoryContainer

    {
        public static List<string> ChaptersList { get; } = new List<string>
        {
            Application.StartupPath + "\\Content\\Theory\\theory1.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory2.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory3.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory4.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory5.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory6.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory7.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory8.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory9.pdf"
        };

        public static List<string> VideoList { get; } = new List<string>
        {
            Application.StartupPath + "\\Content\\Video\\1.mp4",
            Application.StartupPath + "\\Content\\Video\\2.mp4",
            Application.StartupPath + "\\Content\\Video\\3.mp4",
            Application.StartupPath + "\\Content\\Video\\4.mp4",
            Application.StartupPath + "\\Content\\Video\\5.mp4",
            Application.StartupPath + "\\Content\\Video\\6.mp4",
            Application.StartupPath + "\\Content\\Video\\7.mp4",
            Application.StartupPath + "\\Content\\Video\\8.mp4",
        };


        public static string[][] Pictures { get; } =
        {
            new [] {Application.StartupPath + "\\Content\\Pic\\1.jpg"},
            new []
            {
                Application.StartupPath + "\\Content\\Pic\\2-1.jpg",
                Application.StartupPath + "\\Content\\Pic\\2-2.jpg"
            },
            new []
            {
                Application.StartupPath + "\\Content\\Pic\\3-1.jpg",
                Application.StartupPath + "\\Content\\Pic\\3-2.jpg",
                Application.StartupPath + "\\Content\\Pic\\3-3.jpg",
                Application.StartupPath + "\\Content\\Pic\\3-4.jpg",
                Application.StartupPath + "\\Content\\Pic\\3-5.jpg",
                Application.StartupPath + "\\Content\\Pic\\3-6.jpg",
                Application.StartupPath + "\\Content\\Pic\\3-7.jpg",
            },
            new [] {Application.StartupPath + "\\Content\\Pic\\3-1.jpg"},
            new []
            {
                Application.StartupPath + "\\Content\\Pic\\5-1.jpg",
                Application.StartupPath + "\\Content\\Pic\\5-2.jpg",
            },
            new []
            {
                Application.StartupPath + "\\Content\\Pic\\6-1.jpg",
                Application.StartupPath + "\\Content\\Pic\\6-2.jpg",
                Application.StartupPath + "\\Content\\Pic\\6-3.jpg"
            },
            new []
            {
                Application.StartupPath + "\\Content\\Pic\\7-1.jpg",
                Application.StartupPath + "\\Content\\Pic\\7-2.jpg"
            },
            new []
            {
                Application.StartupPath + "\\Content\\Pic\\8-1.jpg",
                Application.StartupPath + "\\Content\\Pic\\8-1.jpg"
            },
            new []
            {
                Application.StartupPath + "\\Content\\Pic\\9-1.jpg",
                Application.StartupPath + "\\Content\\Pic\\9-2.jpg",
                Application.StartupPath + "\\Content\\Pic\\9-3.jpg",
            }
        };
    }
}
