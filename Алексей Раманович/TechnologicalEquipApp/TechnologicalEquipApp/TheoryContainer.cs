using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnologicalEquipApp
{
    class TheoryContainer
    {
        public List<Theory> TheoryList { get; }

        public TheoryContainer()
        {
            TheoryList = new List<Theory>
            {
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory1.pdf", "Chapter1_1"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory2.pdf", "Chapter1_2"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory3.pdf", "Chapter1_3"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory4.pdf", "Chapter1_4"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory5.pdf", "Chapter1_5"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory6.pdf", "Chapter2_1"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory7.pdf", "Chapter2_2"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory8.pdf", "Chapter3_1"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory9.pdf", "Chapter3_2"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory10.pdf", "Chapter3_3"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory11.pdf", "Chapter3_4"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory12.pdf", "Chapter3_5"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory13.pdf", "Chapter3_6"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory14.pdf", "Chapter4_1"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory15.pdf", "Chapter4_2"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory16.pdf", "Chapter4_3"),
                new Theory(Application.StartupPath + "\\Content\\Theory\\theory17.pdf", "Chapter4_4"),
            };
        }
    }
}
