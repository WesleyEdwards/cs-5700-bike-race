using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyServer
{
    public partial class Form2 : Form
    {
        private readonly List<Racer> _knownRacers = new List<Racer>();
        private readonly List<RaceGroup> _knownGroups = new List<RaceGroup>();
        private RaceGroupInfo racerInfo;
        private CheatObserver _selectedObserver;
        private string groupsPath { get; set; }
        private string racersPath { get; set; }


        public Form2(RaceGroupInfo info)
        {
            InitializeComponent();
            this.racerInfo = info;
            Load_Listview();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void create_Observer(object sender, EventArgs e)
        {
            Console.WriteLine(racerInfo.racers[0].FirstName);
        }

        private void Load_Listview()
        {
            foreach (var racer in this.racerInfo.racers)
            {
                string[] row = { racer.FirstName, racer.RaceBibNumber.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }


            

        }

    }
}
