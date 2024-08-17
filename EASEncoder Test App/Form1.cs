using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Speech.Synthesis;
using EASEncoder;
using EASEncoder.Models;
using EASEncoder.Models.SAME;
using NAudio.Wave;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using System.Configuration;
using Newtonsoft.Json;

namespace EASEncoder_Test_App
{
    public partial class Form1 : Form
    {
        private List<SAMERegion> Regions = new List<SAMERegion>();
        private string _length;
        private SAMEMessageAlertCode _selectedAlertCode;
        private SAMECounty _selectedCounty;
        private SAMEMessageOriginator _selectedOriginator;
        private SAMEState _selectedState;
        private SAMESubdivision _selectedSubdivision;
        private string _senderId;
        private bool _openFileLocation;
        private int _fileType;
        private string _fileName;
        private string _fileNameAndExtension;
        private string _fileLocation;
        private DateTime _start;
        private WaveOutEvent player;
        private int _locationCount;
        private Properties.Settings _settings;
        private bool forceRestart = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Searches for the user's last used voice, then for installed SAPI voices with Tom or Paul in the name.
        /// </summary>
        public void SelectVoice()
        {
            // Ensure the ComboBox is not empty
            if (installedVoicesComboBox.Items.Count == 0)
            {
                MessageBox.Show("No SAPI voices were found on your device. Speech has been disabled.", "EAS Encoder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                enableSpeechCheckBox.Enabled = false;
                enableSpeechCheckBox.Checked = false;
                enableSpeechCheckBox.Text = "Enable Speech (Disabled! No SAPI voices found)";
                speechGroupBox.Enabled = false;
                return;
            }
   
            string[] priorityVoices;

            /* Search for the user's last voice first, then Tom, then Paul.
               Tom and Paul are the most commonly used EAS voices.
               While it may not be accurate, it's a good starting point. */
            if (String.IsNullOrWhiteSpace(_settings.announcementVoice.ToLower()))
                priorityVoices = new string[] { "tom", "paul" };
            else
                priorityVoices = new string[] { _settings.announcementVoice.ToLower(), "tom", "paul" };

            foreach (string voice in priorityVoices)
            {
                for (int i = 0; i < installedVoicesComboBox.Items.Count; i++)
                {
                    string item = installedVoicesComboBox.Items[i].ToString().ToLower();
                    if (item.Contains(voice))
                    {
                        Debug.WriteLine("Voice found: " + item);
                        installedVoicesComboBox.SelectedIndex = i;
                        return;
                    }
                }
            }

            // If neither "paul" nor "david" is found, default to the first in the list
            installedVoicesComboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the program icon
            this.Icon = Properties.Resources.LogoIco;

            // Init UI
            var bindingList = new BindingList<SAMERegion>(Regions);
            var source = new BindingSource(bindingList, null);
            datagridRegions.DataSource = source;

            dateStart.ShowUpDown = true;
            dateStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateStart.Format = DateTimePickerFormat.Custom;

            comboState.Items.AddRange(MessageRegions.States.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
            comboCode.Items.AddRange(MessageTypes.AlertCodes.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
            comboOriginator.Items.AddRange(MessageTypes.Originators.OrderBy(x => x.Name).Select(x => x.Name).ToArray());

            datagridRegions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load settings
            try
            {
                _settings = Properties.Settings.Default;
                comboOriginator.SelectedIndex = _settings.originator;
                comboCode.SelectedIndex = _settings.code;
                txtSender.Text = _settings.senderId;
                numericUpDownHours.Value = _settings.validHours;
                numericUpDownMins.Value = _settings.validMins;
                chkEbsTones.Checked = _settings.useEbs;
                chkNwsTone.Checked = _settings.useNws;
                enableSpeechCheckBox.Checked = _settings.enableSpeech;
                speedTrackBar.Value = _settings.speechSpeed;

                txtAnnouncement.Text = _settings.announcementText;

                if (_settings.dateStart != DateTime.MinValue)
                    dateStart.Value = _settings.dateStart;
                else
                    dateStart.Value = DateTime.Now;

                if (!String.IsNullOrWhiteSpace(_settings.locations))
                {
                    Regions = JsonConvert.DeserializeObject<List<SAMERegion>>(_settings.locations);
                    var _bindingList = new BindingList<SAMERegion>(Regions);
                    var _source = new BindingSource(_bindingList, null);
                    datagridRegions.DataSource = _source;

                    _locationCount = datagridRegions.RowCount;

                    locCountLabel.Text = "Event Locations: " + _locationCount;
                    if (_locationCount != 0)
                        locCountLabel.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                forceRestart = true;
                this.Hide();
                
                DialogResult result = MessageBox.Show("The configuration file detected is incompatible with this version of EAS Encoder and the program cannot continue.\n" +
                                                      "Would you like EAS Encoder to attempt to delete the old configuration files?", "Error loading EAS Encoder", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    string targetDirectory = Path.Combine(localAppData, "Joe_Goldade");

                    if (Directory.Exists(targetDirectory))
                    {
                        string[] directories = Directory.GetDirectories(targetDirectory, "EASEncoder_Test_App*");

                        foreach (string directory in directories)
                        {
                            try
                            {
                                Directory.Delete(directory, true);
                            }
                            catch (Exception eex)
                            {
                                DialogResult result2 = MessageBox.Show("EAS Encoder encountered an error while attempting to delete the incompatible configuration files. They must be deleted manually.\n" +
                                                                       "Would you like to visit the GitHub page for information on how to do this?\nException: " + eex, "Error deleting config files", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (result2 == DialogResult.Yes)
                                {
                                    System.Diagnostics.Process.Start("https://github.com/AntAptive/EAS-Encoder#how-to-fix-configuration-file-error");
                                }
                                Application.Exit();
                                break;
                            }
                        }
                        MessageBox.Show("Successfully deleted incompatible configuration files! EAS Encoder will now restart.", "Successfully deleted config files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                        return;
                    }
                    else
                    {
                        DialogResult result2 = MessageBox.Show("EAS Encoder encountered an error while attempting to delete the incompatible configuration files. They must be deleted manually.\n" +
                                                               "Would you like to visit the GitHub page for information on how to do this?\nException: " + ex, "Error deleting config files", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result2 == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("https://github.com/AntAptive/EAS-Encoder#how-to-fix-configuration-file-error");
                        }
                    }
                }

                forceRestart = true;
                this.Close();
                Application.Exit();
            }
            

            // Check for installed SAPI voices
            SpeechSynthesizer s = new SpeechSynthesizer();
            foreach (InstalledVoice v in s.GetInstalledVoices())
            {
                installedVoicesComboBox.Items.Add(v.VoiceInfo.Name);
            }

            SelectVoice();
        }

        private void comboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Repopulate the counties box corresponding to the selected state
            _selectedState = MessageRegions.States.FirstOrDefault(x => x.Name == comboState.Text);
            if (_selectedState != null)
            {
                comboCounty.Items.Clear();
                comboCounty.Text = "";
                _selectedCounty = null;
                foreach (
                    var thisCounty in
                        MessageRegions.Counties.Where(x => x.state.Id == _selectedState.Id).OrderBy(x => x.Name))
                {
                    comboCounty.Items.Add(thisCounty.Name);
                }

                // Set the index of the county box to the first selection by default
                if (comboCounty.Items.Count != 0) comboCounty.SelectedIndex = 0;
            }
        }

        private void comboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set local variable
            _selectedCounty =
                MessageRegions.Counties.FirstOrDefault(
                    x => x.state.Id == _selectedState.Id && x.Name == comboCounty.Text);
        }

        private void comboCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set local variable
            _selectedAlertCode = MessageTypes.AlertCodes.FirstOrDefault(y => y.Name == comboCode.Text);
        }

        private void comboOriginator_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set local variable
            _selectedOriginator = MessageTypes.Originators.FirstOrDefault(y => y.Name == comboOriginator.Text);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Do not continue if an error was found with the user's input
            if (!ValidateInput()) return;
            
            btnGenerate.Enabled = false;
            btnGenerate.Text = "Generating EAS...";

            // Set local variables
            _start = dateStart.Value.ToUniversalTime();
            _senderId = txtSender.Text;
            _length = ZeroPad(numericUpDownHours.Value.ToString(), 2) + ZeroPad(numericUpDownMins.Value.ToString(), 2);

            // Create a new message and send it to EASEncoder to be encoded.
            var newMessage = new EASMessage(_selectedOriginator.Id, _selectedAlertCode.Id,
                Regions, _length, _start, _senderId);

            // Create the save file dialog
            CommonSaveFileDialog sfd = new CommonSaveFileDialog();
            sfd.DefaultFileName = newMessage.ToSameHeaderStringNoPreamble();

            // Open File Checkbox
            CommonFileDialogCheckBox openFileDialogChkBox = new CommonFileDialogCheckBox();
            openFileDialogChkBox.Text = "Open file location after generating";
            openFileDialogChkBox.IsChecked = Properties.Settings.Default.openFileLocation;
            
            sfd.Controls.Add(openFileDialogChkBox);

            // Wave file filter
            CommonFileDialogFilter wavFilter = new CommonFileDialogFilter();
            wavFilter.DisplayName = "Wave file";
            wavFilter.Extensions.Add("wav");
            sfd.Filters.Add(wavFilter);

            // MP3 file filter
            CommonFileDialogFilter mp3Filter = new CommonFileDialogFilter();
            mp3Filter.DisplayName = "MP3 file";
            mp3Filter.Extensions.Add("mp3");
            sfd.Filters.Add(mp3Filter);

            CommonFileDialogResult sfdResult = sfd.ShowDialog();

            if (sfdResult == CommonFileDialogResult.Ok)
            {
                _openFileLocation = openFileDialogChkBox.IsChecked;
                Properties.Settings.Default.openFileLocation = openFileDialogChkBox.IsChecked;
                _fileType = sfd.SelectedFileTypeIndex;
                _fileLocation = Path.GetDirectoryName(sfd.FileName);
                _fileName = Path.GetFileNameWithoutExtension(sfd.FileName);
                _fileNameAndExtension = Path.GetFileName(sfd.FileName);
            }
            else if (sfdResult == CommonFileDialogResult.Cancel)
            {
                btnGenerate.Enabled = true;
                btnGenerate.Text = "Generate EAS File";
                return;
            }

            EASEncoder.EASEncoder.CreateNewMessage(newMessage, chkEbsTones.Checked, chkNwsTone.Checked,
                formatAnnouncement(txtAnnouncement.Text), _fileName, _openFileLocation,
                                   installedVoicesComboBox.SelectedItem == null ? "" : installedVoicesComboBox.SelectedItem.ToString(),
                                   enableSpeechCheckBox.Checked, _fileType, speedTrackBar.Value, _fileLocation, _fileNameAndExtension);

            btnGenerate.Enabled = true;
            btnGenerate.Text = "Generate EAS File";
        }

        internal string ZeroPad(string String, int Length)
        {
            if (string.IsNullOrEmpty(String))
            {
                String = "0";
            }
            if (String.Length > Length)
            {
                return String;
            }

            while (String.Length < Length)
            {
                String = "0" + String;
            }

            return String;
        }

        private string formatAnnouncement(string announcement)
        {
            return
                announcement.Replace("*", "")
                    .Replace("\r\n", " ")
                    .ToLower()
                    .Replace(" cdt", "central daylight time")
                    .Replace(" cst", "central standard time")
                    .Replace(" edt", "eastern daylight time")
                    .Replace(" est", "eastern standard time")
                    .Replace(" mdt", "mountain daylight time")
                    .Replace(" mst", "moutain standard time")
                    .Replace(" pdt", "pacific daylight time")
                    .Replace(" pst", "pacific standard time")
                    .Replace(" mph", "miles per hour")
                    .Replace(" winds", "whinds")
                    .Replace("  ", " ")
                    .Replace("...", ", ")
                    .Replace("precautionary/preparedness actions", "")
                    .ToLower();

        }

        private bool ValidateInput()
        {
            if (String.IsNullOrEmpty(txtSender.Text) || txtSender.TextLength != 8)
            {
                MessageBox.Show("You must enter a valid Sender ID. Ensure the ID is exactly 8 characters in length.", "Unable to create EAS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in txtSender.Text)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    MessageBox.Show("You must enter a valid Sender ID. Ensure the ID is alphanumeric. Underscores are allowed.", "Unable to create EAS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (String.IsNullOrEmpty(comboOriginator.Text))
            {
                MessageBox.Show("You must select an 'Originator' from the drop down menu.", "Unable to create EAS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(comboCode.Text))
            {
                MessageBox.Show("You must select a 'Code' (event) from the drop down menu.", "Unable to create EAS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numericUpDownHours.Value == 0 && numericUpDownMins.Value == 0)
            {
                MessageBox.Show("You must specify a validity duration.", "Unable to create EAS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Regions.Count < 1)
            {
                MessageBox.Show("You must add at least 1 location (state/county) to the locations list.", "Unable to create EAS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void btnGeneratePlay_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            btnGeneratePlay.Text = "Loading preview...";
            btnGeneratePlay.Enabled = false;

            _start = dateStart.Value.ToUniversalTime();
            _senderId = txtSender.Text;
            _length = ZeroPad(numericUpDownHours.Value.ToString(), 2) + ZeroPad(numericUpDownMins.Value.ToString(), 2);

            var newMessage = new EASMessage(_selectedOriginator.Id, _selectedAlertCode.Id,
                Regions, _length, _start, _senderId);


            var messageStream = EASEncoder.EASEncoder.GetMemoryStreamFromNewMessage(newMessage, chkEbsTones.Checked,
                chkNwsTone.Checked, formatAnnouncement(txtAnnouncement.Text),
                installedVoicesComboBox.SelectedItem == null ? "" : installedVoicesComboBox.SelectedItem.ToString(),
                enableSpeechCheckBox.Checked, speedTrackBar.Value);

            btnGeneratePlay.Enabled = true;
            btnGeneratePlay.Text = "Stop Playing";

            WaveStream mainOutputStream = new RawSourceWaveStream(messageStream, new WaveFormat());
            var volumeStream = new WaveChannel32(mainOutputStream);
            volumeStream.PadWithZeroes = false;

            player = new WaveOutEvent();
            player.PlaybackStopped += (o, args) =>
            {
                player.Dispose();
                player = null;
                btnGeneratePlay.Text = "Preview EAS";
            };

            player.Init(volumeStream);

            player.Play();
        }

        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            if (comboState.SelectedIndex >= 0 && comboCounty.SelectedIndex >= 0 && !Regions.Exists(x => x.County.Id == _selectedCounty.Id && x.State.Id == _selectedState.Id))
            {
                Regions.Add(new SAMERegion(_selectedState, _selectedCounty));
                var bindingList = new BindingList<SAMERegion>(Regions);
                var source = new BindingSource(bindingList, null);
                datagridRegions.DataSource = source;

                comboCounty.SelectedIndex = -1;
                _selectedCounty = null;

                _locationCount += 1;
                locCountLabel.Text = "Event Locations: " + _locationCount;
                locCountLabel.ForeColor = Color.Black;
            }
            else if (comboState.SelectedIndex < 0 || comboCounty.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a state and county from the dropdown menus.", "Unable to add location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regions.Exists(x => x.County.Id == _selectedCounty.Id && x.State.Id == _selectedState.Id))
            {
                MessageBox.Show("This location has already been added.", "Unable to add location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearRegions_Click(object sender, EventArgs e)
        {
            Regions.Clear();
            var bindingList = new BindingList<SAMERegion>(Regions);
            var source = new BindingSource(bindingList, null);
            datagridRegions.DataSource = source;

            _locationCount = 0;
            locCountLabel.Text = "Event Locations: " + _locationCount;
            locCountLabel.ForeColor = Color.Red;
        }

        // Unused
        private void txtAnnouncement_TextChanged(object sender, EventArgs e)
        {
            //parse vtec
            // (\/)(O)(.)(NEW|CON|EXT|EXA|EXB|UPG|CAN|EXP|COR|ROU)(.)([\w]{4})(.)([A-Z][A-Z])(.)([WAYSFON])(.)([0-9]{4})(.)([0-9]{6})(T)([0-9]{4})(Z)([-])([0-9]{6})([T])([0-9]{4})([Z])(\/)?
        }

        private void setTimeToRightNowBtn_Click(object sender, EventArgs e)
        {
            dateStart.Value = DateTime.Now;
        }

        private void DeleteItemFromRegions(SAMERegion regionToDelete)
        {
            Regions.Remove(regionToDelete);
        }

        private bool found = false;
        private SAMERegion itemToRemove;

        private void datagridRegions_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SAMEState tempState = MessageRegions.States.FirstOrDefault(x => x.Name == (string)e.Row.Cells[1].Value);
            SAMECounty tempCounty = MessageRegions.Counties.FirstOrDefault(x => x.Name == (string)e.Row.Cells[0].Value);

            SAMERegion tempRegion = new SAMERegion(tempState, tempCounty);

            if (found == false)
                foreach (SAMERegion _region in Regions)
                {
                    if (_region.StateName == tempState.Name && _region.CountyName == tempCounty.Name)
                    {
                        found = true;
                        itemToRemove = _region;
                    }
                }
        }

        private void datagridRegions_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {   
            if (found)
            {
                DeleteItemFromRegions(itemToRemove);
                _locationCount--;
                locCountLabel.Text = "Event Locations: " + _locationCount;
                if (_locationCount == 0)
                    locCountLabel.ForeColor = Color.Red;
                found = false;
            }
        }

        private void enableSpeechCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            speechGroupBox.Enabled = enableSpeechCheckBox.Checked;
        }

        private void txtSender_TextChanged(object sender, EventArgs e)
        {
            if (txtSender.Text.Length > 8)
            {
                txtSender.Text = txtSender.Text.Substring(0, 8);
                txtSender.SelectionStart = txtSender.Text.Length;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forceRestart)
            {
                e.Cancel = true;
                DialogResult result = MessageBox.Show("Save EAS configuration?", "Closing EAS Encoder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Save the settings
                    _settings.originator = comboOriginator.SelectedIndex;
                    _settings.code = comboCode.SelectedIndex;
                    _settings.dateStart = dateStart.Value;
                    _settings.senderId = txtSender.Text;
                    _settings.validHours = (int)numericUpDownHours.Value;
                    _settings.validMins = (int)numericUpDownMins.Value;
                    _settings.useEbs = chkEbsTones.Checked;
                    _settings.useNws = chkNwsTone.Checked;
                    _settings.locations = JsonConvert.SerializeObject(datagridRegions.DataSource);
                    _settings.announcementText = txtAnnouncement.Text;
                    _settings.announcementVoice = installedVoicesComboBox.Text;
                    _settings.enableSpeech = enableSpeechCheckBox.Checked;
                    _settings.speechSpeed = speedTrackBar.Value;

                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

                // Saving even if the user said no because some background settings still need to be changed.
                Properties.Settings.Default.Save();
                e.Cancel = false;
            }
        }

        private void resetDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("EAS Encoder can save your data from one session to the next. Are you sure you want to reset the program's data?" +
                "\nYou will lose any unsaved data in your current session.", "Reset EAS Encoder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                MessageBox.Show("EAS Encoder has been reset successfully and will now restart.", "Reset successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forceRestart = true;
                Application.Restart();
            }
        }
    }
}
