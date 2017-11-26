using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Web;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;

namespace WorkshopPublisherForm
{
    public partial class Form1 : Form
    {
        string GmodLocation;
        string GmadLocation;
        string GmpublishLocation;
        string picturePath;
        DataTable ActionQueue = new DataTable();
        DataTable WSAddons = new DataTable();

        int AddonID;

        public void RefreshAddonsList()
        {
            Process Gmpublish = new Process();
            try
            {
                Gmpublish.StartInfo.UseShellExecute = false;
                Gmpublish.StartInfo.CreateNoWindow = true;
                Gmpublish.StartInfo.FileName = GmpublishLocation;
                Gmpublish.StartInfo.RedirectStandardOutput = true;
                Gmpublish.StartInfo.Arguments = "list";
                Gmpublish.Start();

                string raw_addonslist = Gmpublish.StandardOutput.ReadToEnd();
                string addonslist = raw_addonslist.Substring(96);
                addonslist = addonslist.Remove(addonslist.Length - 7, 5);

                string[] addons = addonslist.Split('\n');

                foreach (var line in addons)
                {
                    if (line.Length > 5)
                    {
                        string[] split = line.Split('\t');

                        DataRow row = WSAddons.NewRow();

                        row.SetField(WSAddons.Columns[0], int.Parse(split[1]));
                        row.SetField(WSAddons.Columns[1], split[2]);
                        split[3] = split[3].Replace("\"", ""); // Quickly removing the quotations cause they annoyed the shit out of me
                        row.SetField(WSAddons.Columns[2], split[3]);

                        WSAddons.Rows.Add(row);
                    }
                }
                Gmpublish.WaitForExit();
                Gmpublish.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Failed to use gmpublish.exe! Is Steam running?");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Turning stuff specific to Create Mode off on load
            texbGMAOutput.Enabled = !rdbtnCreate.Checked;
            texbFileExtract.Enabled = !rdbtnCreate.Checked;
            texbExtractOutput.Enabled = !rdbtnCreate.Checked;
            texbChanges.Enabled = !rdbtnCreate.Checked;

            lblChanges.Enabled = !rdbtnCreate.Checked;
            lblGMAOutput.Enabled = !rdbtnCreate.Checked;

            btnSelectGMAOutput.Enabled = !rdbtnCreate.Checked;

            grpboxAddonList.Enabled = !rdbtnCreate.Checked;
            grpboxExtract.Enabled = !rdbtnCreate.Checked;

            // Getting the install location folder for GMod.
            try
            {
                RegistryKey localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
                localKey = localKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 4000");
                if (localKey != null)
                {
                    GmodLocation = localKey.GetValue("InstallLocation").ToString();
                    GmadLocation = GmodLocation + "\\bin\\gmad.exe";
                    GmpublishLocation = GmodLocation + "\\bin\\gmpublish.exe";
                }
                else
                {
                    localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.CurrentUser, RegistryView.Registry64);
                    localKey = localKey.OpenSubKey(@"Software\Shadow2hel\ShadowsPublisher\version");
                    if (localKey == null)
                    {
                        FolderBrowserDialog fbdGmodLocation = new FolderBrowserDialog();
                        fbdGmodLocation.RootFolder = Environment.SpecialFolder.MyComputer;
                        fbdGmodLocation.Description = "Couldn't find your GMod installation, please select it.";
                        fbdGmodLocation.ShowNewFolderButton = false;

                        if (fbdGmodLocation.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {

                            //Check if gmad or gmpublish exists in the bin folder
                            GmodLocation = fbdGmodLocation.SelectedPath;
                            GmadLocation = GmodLocation + "\\bin\\gmad.exe";
                            GmpublishLocation = GmodLocation + "\\bin\\gmpublish.exe";

                            if (File.Exists(GmpublishLocation) == false || File.Exists(GmadLocation) == false)
                            {
                                MessageBox.Show("You're missing gmad.exe or gmpublish.exe in your bin folder!");
                            }

                            RegistryKey regKeyAppRoot = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
                            regKeyAppRoot = Registry.CurrentUser.CreateSubKey(@"Software\Shadow2hel\ShadowsPublisher\version");
                            regKeyAppRoot.SetValue("GmodLocation", GmodLocation);
                            regKeyAppRoot.Close();

                        }
                    }
                    else
                    {
                        GmodLocation = localKey.GetValue("GmodLocation").ToString();
                        GmadLocation = GmodLocation + "\\bin\\gmad.exe";
                        GmpublishLocation = GmodLocation + "\\bin\\gmpublish.exe";

                        if (File.Exists(GmadLocation) == false || File.Exists(GmpublishLocation) == false)
                        {
                            MessageBox.Show("You're missing gmad.exe or gmpublish.exe in your bin folder!");
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            //Loading addons list
            
            DataColumn colID = WSAddons.Columns.Add("ID", typeof(int));
            DataColumn colSize = WSAddons.Columns.Add("Size", typeof(string));
            DataColumn colName = WSAddons.Columns.Add("Name", typeof(string));

            Process Gmpublish = new Process();

            try {
                Gmpublish.StartInfo.UseShellExecute = false;
                Gmpublish.StartInfo.CreateNoWindow = true;
                Gmpublish.StartInfo.FileName = GmpublishLocation;
                Gmpublish.StartInfo.RedirectStandardOutput = true;
                Gmpublish.StartInfo.Arguments = "list";
                Gmpublish.Start();

                string raw_addonslist = Gmpublish.StandardOutput.ReadToEnd();
                string addonslist = raw_addonslist.Substring(96);
                addonslist = addonslist.Remove(addonslist.Length - 7, 5);
                


                string[] addons = addonslist.Split('\n');

                foreach (var line in addons)
                {
                    if (line.Length > 5)
                        {
                            string[] split = line.Split('\t');
                
                            DataRow row = WSAddons.NewRow();
                
                            row.SetField(colID, int.Parse(split[1]));
                            row.SetField(colSize, split[2]);
                            split[3] = split[3].Replace("\"", ""); // Quickly removing the quotations cause they annoyed the shit out of me
                            row.SetField(colName, split[3]);
                
                            WSAddons.Rows.Add(row);
                        }
                }

                


                Gmpublish.WaitForExit();
                Gmpublish.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show("Failed to use gmpublish.exe! Is Steam running?");
            }

            dgvAddonsList.DataSource = WSAddons;

            
            DataColumn colAction = ActionQueue.Columns.Add("Action", typeof(string));
            DataColumn colJob = ActionQueue.Columns.Add("Job", typeof(string));
            DataColumn colStatus = ActionQueue.Columns.Add("Status", typeof(string));
            DataColumn colCommand = ActionQueue.Columns.Add("Command", typeof(string));
            DataColumn colJSON = ActionQueue.Columns.Add("JSON", typeof(string));
            DataColumn colLocation = ActionQueue.Columns.Add("Location", typeof(string));
            DataColumn colImage = ActionQueue.Columns.Add("Image", typeof(string));

            dgvQueue.DataSource = ActionQueue;
            dgvQueue.Columns[3].Visible = true;
            dgvQueue.Columns[4].Visible = true;
            dgvQueue.Columns[5].Visible = true;
            dgvQueue.Columns[6].Visible = true;
        }

        public dynamic ReturnCheckedTypeRadiobutton(){
            foreach(Control button in grpboxType.Controls)
            {
                if (button is RadioButton) {
                    if (((RadioButton)button).Checked == true) {
                        return (RadioButton)button;
                    }
                }
            }
            return null;
        }
        
        public string UseFolderDialog(string Key) {
            var fbdFolderLocation = new CommonOpenFileDialog();
            fbdFolderLocation.IsFolderPicker = true;
            fbdFolderLocation.Multiselect = false;
            fbdFolderLocation.EnsurePathExists = true;

            RegistryKey localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.CurrentUser, RegistryView.Registry64);
            localKey = Registry.CurrentUser.OpenSubKey(@"Software\Shadow2hel\ShadowsPublisher\lastbrowsed");

            if (localKey == null)
            {
                fbdFolderLocation.InitialDirectory = "c:\\";
            }
            else
            {
                fbdFolderLocation.InitialDirectory = (string)localKey.GetValue(Key);
            }



            if (fbdFolderLocation.ShowDialog() == CommonFileDialogResult.Ok)
            {
                localKey = Registry.CurrentUser.CreateSubKey(@"Software\Shadow2hel\ShadowsPublisher\lastbrowsed");
                localKey.SetValue(Key, fbdFolderLocation.FileName);
                return fbdFolderLocation.FileName;
            }
            else {
                return "";
            }

        }

        public string UseFileDialog(string Key, string Filter) {
            OpenFileDialog fldAddonFile = new OpenFileDialog();

            RegistryKey localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.CurrentUser, RegistryView.Registry64);
            localKey = Registry.CurrentUser.OpenSubKey(@"Software\Shadow2hel\ShadowsPublisher\lastbrowsed");

            if (localKey == null)
            {
                fldAddonFile.InitialDirectory = "c:\\";
            }
            else
            {
                fldAddonFile.InitialDirectory = (string)localKey.GetValue(Key);
            }


            fldAddonFile.Filter = Filter;

            if (fldAddonFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    localKey = Registry.CurrentUser.CreateSubKey(@"Software\Shadow2hel\ShadowsPublisher\lastbrowsed");
                    string path = Path.GetDirectoryName(fldAddonFile.FileName);
                    localKey.SetValue(Key, path);
                    return fldAddonFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbllayoutAddonList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgAddonsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strAddonname = dgvAddonsList.SelectedRows[0].Cells["Name"].Value.ToString();
            AddonID = (int)dgvAddonsList.SelectedRows[0].Cells["ID"].Value;

            texbTitle.Text = strAddonname;

            var doc = Supremes.Dcsoup.Parse(new Uri("http://steamcommunity.com/sharedfiles/filedetails/?id=" + AddonID), 5000);
            var WSStuff = doc.Select("div[class=workshopTags]");
            string Tags = WSStuff.Text;
            Tags = Tags.Replace("Addon", "");
            Tags = Tags.Replace(" ", "");
            Tags = Tags.Replace(HttpUtility.HtmlDecode("&nbsp;"), "");
            Tags = Tags.Replace("Type:", "");
            if (Tags.Contains("Tags:") == true)
            {
                Tags = Tags.Replace("Tags:", "");

                string[] ALTags = Tags.Split(',');

                foreach (Control button in grpboxType.Controls)
                {
                    if (button is RadioButton)
                    {
                        if (((RadioButton)button).Text == ALTags[0])
                        {
                            ((RadioButton)button).Checked = true;
                        }
                    }
                }

                foreach (Control button in grpboxTags.Controls)
                {
                    if (button is CheckBox)
                    {
                        for (int i = 1; i < ALTags.Length; i++)
                        {
                            if (((CheckBox)button).Text == ALTags[i])
                            {
                                ((CheckBox)button).Checked = true;
                                i++;

                            }
                        }
                    }
                }
            }
            else {
                Tags = Tags.Replace(",", "");

                foreach (Control button in grpboxType.Controls)
                {
                    if (button is RadioButton)
                    {
                        if (((RadioButton)button).Text == Tags)
                        {
                            ((RadioButton)button).Checked = true;
                        }
                    }
                }
            }
            

        }

        private void rdbtnCreate_CheckedChanged(object sender, EventArgs e)
        {
            texbGMAOutput.Enabled = !rdbtnCreate.Checked;
            texbFileExtract.Enabled = !rdbtnCreate.Checked;
            texbExtractOutput.Enabled = !rdbtnCreate.Checked;
            texbChanges.Enabled = !rdbtnCreate.Checked;

            btnSelectGMAOutput.Enabled = !rdbtnCreate.Checked;

            lblChanges.Enabled = !rdbtnCreate.Checked;
            lblGMAOutput.Enabled = !rdbtnCreate.Checked;

            grpboxAddonList.Enabled = !rdbtnCreate.Checked;
            grpboxExtract.Enabled = !rdbtnCreate.Checked;

        }

        private void rdbtnGMA_CheckedChanged(object sender, EventArgs e)
        {
            texbGMAOutput.Enabled = rdbtnGMA.Checked;
            grpboxAddonList.Enabled = !rdbtnGMA.Checked;
            grpboxExtract.Enabled = !rdbtnGMA.Checked;

            lblIcon.Enabled = !rdbtnGMA.Checked;
            btnUploadIcon.Enabled = !rdbtnGMA.Checked;
            grpboxIconPreview.Enabled = !rdbtnGMA.Checked;

            picBoxIconPreview.ImageLocation = "";

        }

        private void rdbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            texbGMAOutput.Enabled = !rdbtnUpdate.Checked;
            btnSelectGMAOutput.Enabled = !rdbtnUpdate.Checked;
            grpboxExtract.Enabled = !rdbtnUpdate.Checked;

            lblIcon.Enabled = !rdbtnUpdate.Checked;
            btnUploadIcon.Enabled = !rdbtnUpdate.Checked;
            grpboxIconPreview.Enabled = !rdbtnUpdate.Checked;

            picBoxIconPreview.ImageLocation = "";
        }

        private void rdbtnExtract_CheckedChanged(object sender, EventArgs e)
        {
            grpboxAddonjson.Enabled = !rdbtnExtract.Checked;
            texbGMAOutput.Enabled = !rdbtnExtract.Checked;
            texbChanges.Enabled = !rdbtnExtract.Checked;

            texbFileorFolder.Enabled = !rdbtnExtract.Checked;
            
            btnFile.Enabled = !rdbtnExtract.Checked;
            btnFolder.Enabled = !rdbtnExtract.Checked;

            btnUploadIcon.Enabled = !rdbtnExtract.Checked;
            lblIcon.Enabled = !rdbtnExtract.Checked;
            grpboxIconPreview.Enabled = !rdbtnExtract.Checked;

            lblChanges.Enabled = !rdbtnExtract.Checked;
            lblGMAOutput.Enabled = !rdbtnExtract.Checked;
            lblFileorFolder.Enabled = !rdbtnExtract.Checked;

            btnSelectGMAOutput.Enabled = !rdbtnExtract.Checked;

            grpboxAddonList.Enabled = !rdbtnExtract.Checked;

            picBoxIconPreview.ImageLocation = "";

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            texbFileorFolder.Text = UseFileDialog("lastFile", "All files (*.*)|*.*");

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            string output = UseFolderDialog("lastFolder");
            texbFileorFolder.Text = output;
        }

        private void btnUploadIcon_Click(object sender, EventArgs e)
        {   
            string output = UseFileDialog("lastUpload", "Image Files(*.JPG)|*.JPG");
            if (output != null) { 
                Image img = System.Drawing.Image.FromFile(output);
                int width = img.Width;
                int height = img.Height;
                if (width == 512 && height == 512)
                {
                    picBoxIconPreview.ImageLocation = output;
                    picturePath = output;
                }
                else {
                    MessageBox.Show("The uploaded image is not 512x512!");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRow row = ActionQueue.NewRow();

            row.SetField("Action", "testing123");
            row.SetField("Job", "testing123");
            row.SetField("Status", "testing123");
            row.SetField("Command", "tests galore");
            ActionQueue.Rows.Add(row);
        }

        public struct AddonJSON
        {
            public string title;
            public string type;
            public ArrayList tags;
            public ArrayList ignore;
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            AddonJSON addon = new AddonJSON();
            addon.title = texbTitle.Text;
            if (ReturnCheckedTypeRadiobutton() != null) {
                addon.type = (string)ReturnCheckedTypeRadiobutton().Tag;

                //Adding the tags
                ArrayList ALTags = new ArrayList();
                int i = 0;
                foreach (Control button in grpboxTags.Controls)
                {
                    if (button is CheckBox)
                    {
                        if (((CheckBox)button).Checked == true)
                        {
                            ALTags.Insert(i, (string)((CheckBox)button).Tag);
                            i++;
                        }
                    }
                }

                addon.tags = ALTags;

                ArrayList ALIgnoreExt = new ArrayList();
                string[] ArrIgnoreExt = texbIgnore.Text.Split(',');
                ALIgnoreExt.AddRange(ArrIgnoreExt);
                ALIgnoreExt.Remove("\\\"");

                addon.ignore = ALIgnoreExt;

                // Here's some code for later
                string output = JsonConvert.SerializeObject(addon);
                output = output.Replace("\\\"", "");

                string SelectedRdButton;

                foreach (Control button in grpboxMode.Controls)
                {
                    if (button is RadioButton)
                    {
                        if (((RadioButton)button).Checked == true)
                        {
                            SelectedRdButton = ((RadioButton)button).Text;

                            DataRow row = ActionQueue.NewRow();
                            switch (SelectedRdButton) {
                                case "Create":
                                    if (texbTitle.Text != "" && picturePath != null) {
                                        row.SetField("Action", "Create");
                                        row.SetField("Job", "Creating addon from " + texbFileorFolder.Text);
                                        row.SetField("Status", "Waiting..");
                                        row.SetField("Command", "create -addon " + texbFileorFolder + ".gma" + " -icon" + picturePath);
                                        row.SetField("JSON", output);
                                        row.SetField("Location", texbFileorFolder.Text);
                                        row.SetField("Image", picturePath);
                                        ActionQueue.Rows.Add(row);
                                    } else {
                                        MessageBox.Show("You don't have a title or a picture!");
                                    }
                                    break;
                                case "Create GMA":
                                    if (texbTitle.Text != "" && texbGMAOutput.Text != "")
                                    {
                                        row.SetField("Action", "Create GMA");
                                        row.SetField("Job", "Creating .gma from " + texbGMAOutput.Text);
                                        row.SetField("Status", "Waiting..");
                                        row.SetField("Command", "create -folder " + texbFileorFolder.Text + " -out " + texbGMAOutput.Text);
                                        row.SetField("Location", texbFileorFolder.Text);
                                        row.SetField("JSON", output);
                                        ActionQueue.Rows.Add(row);
                                    }
                                    else {
                                        MessageBox.Show("You don't have a title or you didn't select a GMA output!");
                                    }
                                    break;
                                case "Update":
                                    if (texbTitle.Text != "")
                                    {
                                        row.SetField("Action", "Update");
                                        row.SetField("Job", "Updating addon " + texbTitle.Text);
                                        row.SetField("Status", "Waiting..");
                                        row.SetField("Command", "update -addon " + texbFileorFolder.Text + ".gma" + " -id " + AddonID);
                                        row.SetField("JSON", output);
                                        row.SetField("Location", texbFileorFolder.Text);
                                        ActionQueue.Rows.Add(row);
                                    } else
                                    {
                                        MessageBox.Show("You don't have a title!");
                                    }
                                    break;
                                case "Extract":
                                    row.SetField("Action", "Extract");
                                    row.SetField("Job", "Extracting addon " + texbFileorFolder.Text);
                                    row.SetField("Status", "Waiting..");
                                    if (chkboxOutput.Checked == false)
                                    {
                                        row.SetField("Command", "extract -file " + texbFileExtract.Text);
                                    }
                                    else {
                                        row.SetField("Command", "extract -file " + texbFileExtract.Text + " -out " + texbExtractOutput.Text);
                                    }
                                    ActionQueue.Rows.Add(row);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            } else if (rdbtnExtract.Checked == true)
            {
                DataRow row = ActionQueue.NewRow();
                row.SetField("Action", "Extract");
                row.SetField("Job", "Extracting addon " + texbFileExtract.Text);
                row.SetField("Status", "Waiting..");
                if (chkboxOutput.Checked == false)
                {
                    row.SetField("Command", "extract -file " + texbFileExtract.Text);
                }
                else
                {
                    row.SetField("Command", "extract -file " + texbFileExtract.Text + " -out " + texbExtractOutput.Text);
                }
                ActionQueue.Rows.Add(row);
            } else {
                MessageBox.Show("You didn't select a type!");
            }

            // Here's some code for later
            //string output = JsonConvert.SerializeObject(addon);
            //output = output.Replace("\\\"", "");
            //
            //File.WriteAllText(@"D:\Users\antonio\Documents\Addons\addon.json", output);

        }

        private void btnSelectGMAOutput_Click(object sender, EventArgs e)
        {
            texbGMAOutput.Text = UseFolderDialog("lastGMAFolder");
        }

        private void btnFileExtract_Click(object sender, EventArgs e)
        {
            string output = UseFileDialog("lastFileExtract", "GMA *.gma|*.gma");
            texbFileExtract.Text = output;
            
            if (texbExtractOutput.Text == "") {
                texbExtractOutput.Text = output.Replace(".gma","");
                string Extract = Path.GetFullPath(Path.Combine(output, @"..\"));
            }
        }

        private void btnFolderExtract_Click(object sender, EventArgs e)
        {
            texbExtractOutput.Text = UseFolderDialog("lastExtract");
        }

        private void btnQueueExecute_Click(object sender, EventArgs e)
        {
               foreach (DataGridViewRow dr in dgvQueue.Rows)
               {
                        string Action = dr.Cells[0].Value.ToString();
                        string Command = dr.Cells[3].Value.ToString();
                        string JSON = dr.Cells[4].Value.ToString();
                        string Location = dr.Cells[5].Value.ToString();
                        string Status = dr.Cells[2].Value.ToString();
                        string Image = dr.Cells[6].Value.ToString();


                        if (Status == "Waiting..")
                        {
                            switch (Action)
                            {
                                case "Create":
                                    dr.Cells[2].Value = "Busy";

                                    string createoutput = JsonConvert.SerializeObject(JSON);
                                    createoutput = createoutput.Replace("\\", "");
                                    createoutput = createoutput.Remove(0, 1);
                                    createoutput = createoutput.Remove(createoutput.Length - 1, 1);

                                    File.WriteAllText(Location + "\\addon.json", createoutput);

                                    var Gmad = new Process();
                                    Gmad.StartInfo.UseShellExecute = false;
                                    Gmad.StartInfo.CreateNoWindow = true;
                                    Gmad.StartInfo.FileName = GmadLocation;
                                    Gmad.StartInfo.Arguments = "create -folder " + "\"" + Location + "\"";
                                    Gmad.StartInfo.RedirectStandardOutput = true;
                                    Gmad.Start();

                                    texbLog.AppendText(Gmad.StandardOutput.ReadToEnd());

                                    Gmad.WaitForExit();
                                    Gmad.Close();

                                    var Gmpublish = new Process();
                                    Gmpublish.StartInfo.UseShellExecute = false;
                                    Gmpublish.StartInfo.CreateNoWindow = true;
                                    Gmpublish.StartInfo.FileName = GmpublishLocation;
                                    Gmpublish.StartInfo.Arguments = "create -addon " + Location + ".gma -icon " + Image;
                                    Gmpublish.StartInfo.RedirectStandardOutput = true;
                                    Gmpublish.Start();

                                    texbLog.AppendText(Gmpublish.StandardOutput.ReadToEnd());

                                    Gmpublish.WaitForExit();
                                    Gmpublish.Close();

                                    File.Delete(Location + "\\addon.json");
                                    File.Delete(Location + ".gma");
                                    RefreshAddonsList();
                                    dr.Cells[2].Value = "Done";
                                    break;
                                case "Create GMA":
                                    dr.Cells[2].Value = "Busy";

                                    string gmaoutput = JsonConvert.SerializeObject(JSON);
                                    gmaoutput = gmaoutput.Replace("\\", "");
                                    gmaoutput = gmaoutput.Remove(0, 1);
                                    gmaoutput = gmaoutput.Remove(gmaoutput.Length - 1, 1);

                                    File.WriteAllText(Location + "\\addon.json", gmaoutput);

                                    Gmad = new Process();
                                    Gmad.StartInfo.UseShellExecute = false;
                                    Gmad.StartInfo.CreateNoWindow = true;
                                    Gmad.StartInfo.FileName = GmadLocation;
                                    Gmad.StartInfo.Arguments = Command;
                                    Gmad.StartInfo.RedirectStandardOutput = true;
                                    Gmad.Start();

                                    texbLog.AppendText(Gmad.StandardOutput.ReadToEnd());

                                    Gmad.WaitForExit();
                                    Gmad.Close();

                                    dr.Cells[2].Value = "Done";
                                    break;
                                case "Update":
                                    dr.Cells[2].Value = "Busy";

                                    string updateoutput = JsonConvert.SerializeObject(JSON);
                                    updateoutput = updateoutput.Replace("\\", "");
                                    updateoutput = updateoutput.Remove(0, 1);
                                    updateoutput = updateoutput.Remove(updateoutput.Length - 1, 1);

                                    File.WriteAllText(Location + "\\addon.json", updateoutput);

                                    Gmad = new Process();
                                    Gmad.StartInfo.UseShellExecute = false;
                                    Gmad.StartInfo.CreateNoWindow = true;
                                    Gmad.StartInfo.FileName = GmadLocation;
                                    Gmad.StartInfo.Arguments = "create -folder " + "\"" + Location + "\"";
                                    Gmad.StartInfo.RedirectStandardOutput = true;
                                    Gmad.Start();

                                    texbLog.AppendText(Gmad.StandardOutput.ReadToEnd());

                                    Gmad.WaitForExit();
                                    Gmad.Close();

                                    Gmpublish = new Process();
                                    Gmpublish.StartInfo.UseShellExecute = false;
                                    Gmpublish.StartInfo.CreateNoWindow = true;
                                    Gmpublish.StartInfo.FileName = GmpublishLocation;
                                    Gmpublish.StartInfo.Arguments = Command;
                                    Gmpublish.StartInfo.RedirectStandardOutput = true;
                                    Gmpublish.Start();

                                    texbLog.AppendText(Gmpublish.StandardOutput.ReadToEnd());

                                    Gmpublish.WaitForExit();
                                    Gmpublish.Close();

                                    File.Delete(Location + "\\addon.json");
                                    File.Delete(Location + ".gma");
                                    RefreshAddonsList();
                                    dr.Cells[2].Value = "Done";
                                    break;
                                case "Extract":
                                    Gmad = new Process();
                                    Gmad.StartInfo.UseShellExecute = false;
                                    Gmad.StartInfo.CreateNoWindow = true;
                                    Gmad.StartInfo.FileName = GmadLocation;
                                    Gmad.StartInfo.Arguments = Command;
                                    Gmad.StartInfo.RedirectStandardOutput = true;
                                    Gmad.Start();

                                    texbLog.AppendText(Gmad.StandardOutput.ReadToEnd());

                                    Gmad.WaitForExit();
                                    Gmad.Close();

                                    dr.Cells[2].Value = "Done";
                                    break;
                            }
                             Thread.Sleep(500);
                        }
                
            }
            

        }

        private void btnQueueClear_Click(object sender, EventArgs e)
        {
            ActionQueue.Clear();
        }

        private int checkCounter;
        public void LimitCheckboxes(object sender) {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;
            else
                checkCounter--;

            // prevent checking
            if (checkCounter > 2)
            {
                MessageBox.Show("You may only select 2 tags!");
                box.Checked = false;
            }
        }

        private void chkboxFun_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxRoleplay_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxScenic_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxMovie_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxRealism_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxCartoon_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxWater_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxComic_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }

        private void chkboxBuild_CheckedChanged(object sender, EventArgs e)
        {
            LimitCheckboxes(sender);
        }
    }
}

