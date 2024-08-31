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
using System.Xml.Linq;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
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


            profileIdLabel.Text = ProfileJsonData?.profileId;
            accountIdTextBox.Text = ProfileJsonData?.accountId;

        }


        private void LoadProfileData()
        {

            
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ProfileJsonData == null)
            {
                MessageBox.Show("Data is unable to be saved.");
                return;
            }

            //ProfileJsonData.profileId = profileIdLabel.Text;
            ProfileJsonData.accountId = accountIdTextBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*",
                Title = "Save JSON File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Set up the JsonSerializerOptions for indentation
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                // Serialize the MyData object to JSON
                string jsonData = JsonSerializer.Serialize(ProfileJsonData);

                // Write the JSON data to the file
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show("File saved successfully.");
            }
        }
    }


}
       
