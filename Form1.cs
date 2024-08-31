using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheaterEditor.Form1;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

namespace TheaterEditor
{
    public partial class Form1 : Form
    {

        private OpenFileDialog ofd;
        public Profile profileData;

        public ProfileInformationForm profileInfoForm = new ProfileInformationForm();
        //public  Profile profileFromJson;

        //public Dictionary<string, Profile> Files { set; get; }

        public string ProfileDataForm1 { get; set; }

        public string JsonDataForm1;

        private readonly string _path = $"d:\\FortniteServer\\LawinServer\\profiles\\profile0.json";

        

        string profile0 = @"{
         '_id': 'testing',
         'created': '0001-01-01T00:00:00.000Z',
         'updated': '0001-01-01T00:00:00.000Z',
         'rvn': 1,
         'wipeNumber': 1,
         'accountId': 'insertAccountIdHere',
         'profileId': 'profile0',
         'version': 'no_version',





        }";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       // public Profile profileFromJson { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //string filePath = "";
            Stream st;
            //string jsonFromFile;
            //string sFileName;
            //string sFilePath;
            string profileFilePath;
            string jsonData;

            //var incoming = new List<Profile2>();

            OpenFileDialog openfiledialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*",
                Title = "Select a JSON File"

            };

            // Show the dialog and check if the user selected a file
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                profileFilePath = openfiledialog.FileName;

                // Read the JSON file
                jsonData = File.ReadAllText(profileFilePath);
                profileData = new Profile();

                profileData = JsonSerializer.Deserialize<Profile>(jsonData);
                profileInfoForm.ProfileJsonData = profileData;

                richTextBox1.Text = jsonData;

                profileInfoForm.Show();
            }

            

            

            /* try
            {
                Stream st;
                string jsonFromFile;
                //string profile0fileName = "profile0.json";
                //string profile0data;
               
                OpenFileDialog d1 = new OpenFileDialog();
                
                

                if (d1.ShowDialog() == DialogResult.OK)
                {
                    if ((st = d1.OpenFile()) != null)
                    {
                        using (var reader = new StreamReader(_path))
                        {
                            jsonFromFile = reader.ReadToEnd();
                            string jsonDat2a = File.ReadAllText(_path);

                            
                            //var profileAttributes = JsonConvert.DeserializeObject<Profile>(jsonFromFile);
                            // string accountIdStr = profileAttributes.accountId.ToString();
                            //profileAttributes.

                            //ProfileInformationForm profileMomento = new ProfileInformationForm(profileAttributes);
                            // profileMomento.ProfileJsonData = accountIdStr;

                            //string accountIdStr = profileAttributes.accountId.FirstOrDefault().description;
                            //profileMomento.ProfileJsonData = profileAttributes;
                            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(profileInformationForm);
                            //Form1 fn = new Form1();
                            // fn.ProfileJson = json;
                            // string json = Newtonsoft.Json.JsonConvert.SerializeObject(profileFromJson);


                            //profileInformationForm = new ProfileInformationForm(json);

                            //newTest.ProfileFromJson = json;
                        }

                        //string FilePath = Path.GetFullPath(jsonFromFile);
                        //Profile profileAttributes = new Profile();
                       // label4.Text = FilePath;
                        richTextBox1.Text = jsonFromFile;
                        //string jsonString = reader

                        //ProfileInformationForm f2 = new ProfileInformationForm();
                        profileInformationForm.Show();

                       

                        
                        //return profileFromJson;
                    }
                }

               


            }
            catch (Exception ex)
            {
                //ignored.
            } */

            /* Stream st;
            OpenFileDialog d1 = new OpenFileDialog();
            if (d1.ShowDialog() == DialogResult.OK)
            {
                if ((st = d1.OpenFile()) != null)
                {
                    string file = d1.FileName;
                    String str = File.ReadAllText(file);
                    //textBox1.text = str;
                }
            } */

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void recieveJsonData(string text)
        {
            //ProfileDataForm1.
        }

        public static class JsonData
        {
            public static string profile0information { get; set; }
        }

        string getProfile(Profile b)
        {
            if (b == null)
                return "Unknown";
            return b.accountId;
        }

        /* private Profile GetProfile()
        {
            var profile = new Profile
            {
                _id = "1",
                created = "Bob",
                updated = "Smith"

            };
        } */

        public record struct Profile2 
        (
            string _id,
            string created,
            string updated,
            int rvn,
            int wipenumber,
            string accountId,
            string profileId,
            string version
            
            
        );

        public class Profile
        {
            public string _id { get; set; }
            public string created { get; set; }
            public string updated { get; set; }
            public int rvn { get; set; }
            public int wipeNumber { get; set; }
            public string accountId { get; set; }
            public string profileId { get; set; }
            public string version { get; set; }
            //public List<McpItems> Items { get; set; }
        }

        public class McpItems
        {
            public string templateId { get; set; }
            public List<McpAttributes> attributes { get; set; }
            public string quantity { get; set; }
        }

        public class McpAttributes
        {
            public int max_level_bonus { get; set; }
            public int level { get; set; }
            public bool item_seen { get; set; }
            public bool favorite { get; set; }
        }


        public class Order
        {
           // public int Id { get; set; }
            ///public List<Item> Items { get; set; }
        }
    }
}
