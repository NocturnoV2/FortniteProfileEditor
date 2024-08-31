using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace TheaterEditor
{
    public partial class ProfileInformationForm : Form
    {

        //Form1 jsonForm = new Form1();
        //public List<SvcCodeReport> Report { get; set; }

        //public Form1.ProfileData ProfileFromJson { get; }
        //Battleship fredBattleship;

        public Form1.Profile ProfileJsonData { set; get; }
        //public string ProfileJsonData { get; set; }

        //private Form1.Profile profileFromJson;

        public ProfileInformationForm()
        {
            InitializeComponent();

            this.Load += profileInformationForm_Load;
        }

        public ProfileInformationForm(Form1.Profile ProfileData)
        {
            
        }

        private void profileInformationForm_Load(object sender, EventArgs e)
        {
            textBox2.Text = ProfileJsonData.accountId;



        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        public Form1 JsonDataClass { get; set; }
        public Form1.Profile ProfileAttributes { get; }

        public Form1.Profile profileData { get; }
    }


}
       
