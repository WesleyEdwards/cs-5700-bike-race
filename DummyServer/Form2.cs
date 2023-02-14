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
            
                // var modalDialogForm = new ObserverCreationForm
                // {
                    // Text = @"New Observer",
                    // ObserverTitle = $"Observer #{_knownDisplays.Count + 1}"
                // };
                // 
                // if (modalDialogForm.ShowDialog() != DialogResult.OK) return;
                // 
                // var observer = (modalDialogForm.ObserverType == "L") ? (BallObserver)new ListDisplay() : new GraphicalDisplay();
                // observer.Title = modalDialogForm.ObserverTitle;
                // _knownDisplays.Add(observer);
                // observer.Show();
                // 
                // _selectedObserver = null;
                // observersListView.SelectedIndices.Clear();
                // RefreshObversersListView();
                // RefreshBallLists();
            
        }

        private void Load_Listview()
        {
            foreach (var racer in this.racerInfo.racers)
            {
                string[] row = { racer.RaceBibNumber.ToString(), $"{racer.FirstName} {racer.LastName}" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
