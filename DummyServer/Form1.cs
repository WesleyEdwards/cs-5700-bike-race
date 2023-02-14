using Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DummyServer
{
    public partial class Form1 : Form
    {

        public string enteredGroupPath { get; set; }
        public string enteredRacersPath { get; set; }

        public event Action<string[]> SubmitRacerPaths;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Pressed.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            enteredGroupPath = groupsTextBox.Text;
            enteredRacersPath = racersTextBox.Text;

            this.SubmitRacerPaths(new string[] { enteredGroupPath, enteredRacersPath });
        }

        private void guessSubmit_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupsTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
