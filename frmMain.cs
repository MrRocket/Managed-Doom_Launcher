using Managed_Doom_Launcher.Properties;
using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Managed_Doom_Launcher
{


    //------------------------------------------------------------------------------//
    //                                                                              //
    //    [Managed Doom Launcher] Created by: Mr.Rocket ~ AKA ~ Ron Goode 2024      //
    //    All Doom likeness and logos are a registered trademarks by id Software    //
    //                                                                              //
    //                       This software is free to use!                          //                       
    //                                                                              //
    //------------------------------------------------------------------------------//


    public partial class frmMain : Form
    {
        #region//Engine and IWAD string values:
        private string Location_VAL;
        public string Engine_Location
        {
            get { return Location_VAL; }
            set { Location_VAL = value; }
        }

        private string IWAD_VAL;
        public string IWAD_Select
        {
            get { return IWAD_VAL; }
            set { IWAD_VAL = value; }
        }

        private string IWAD_Path_VAL;
        public string IWAD_Path
        {
            get { return IWAD_Path_VAL; }
            set { IWAD_Path_VAL = value; }
        }


        private string Auto_IWAD_VAL;
        public string Auto_IWAD_Select
        {
            get { return Auto_IWAD_VAL; }
            set { Auto_IWAD_VAL = value; }
        }

        private string AutoLoadEngine_VAL;
        public string AutoLoadEngine_Select
        {
            get { return AutoLoadEngine_VAL; }
            set { AutoLoadEngine_VAL = value; }
        }

        // For Pwad info tab
        //  PWAD_FILENAME_Select

        private string PWAD_FILENAME_VAL;
        public string PWAD_FILENAME_Select
        {
            get { return PWAD_FILENAME_VAL; }
            set { PWAD_FILENAME_VAL = value; }
        }


        #endregion

        #region//Map ## string values:
        private string Map1_VAL;
        public string Map1_Select
        {
            get { return Map1_VAL; }
            set { Map1_VAL = value; }
        }

        private string Map2_VAL;
        public string Map2_Select
        {
            get { return Map2_VAL; }
            set { Map2_VAL = value; }
        }

        private string Map3_VAL;
        public string Map3_Select
        {
            get { return Map3_VAL; }
            set { Map3_VAL = value; }
        }

        private string Map4_VAL;
        public string Map4_Select
        {
            get { return Map4_VAL; }
            set { Map4_VAL = value; }
        }

        private string Map5_VAL;
        public string Map5_Select
        {
            get { return Map5_VAL; }
            set { Map5_VAL = value; }
        }

        private string Map6_VAL;
        public string Map6_Select
        {
            get { return Map6_VAL; }
            set { Map6_VAL = value; }
        }
        private string Map7_VAL;
        public string Map7_Select
        {
            get { return Map7_VAL; }
            set { Map7_VAL = value; }
        }


        #endregion

        #region //Skill Monsters and GameMode string values:
        //Skill
        private string Skill_VAL;
        public string Skill_Select
        {
            get { return Skill_VAL; }
            set { Skill_VAL = value; }
        }

        //Monsters
        private string Monsters_VAL;
        public string Monsters_Select
        {
            get { return Monsters_VAL; }
            set { Monsters_VAL = value; }
        }

        //Game Mode
        private string GameMods_VAL;
        public string GameMods_Select
        {
            get { return GameMods_VAL; }
            set { GameMods_VAL = value; }
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        #region //Form Load.. Load any saved settings..
        private void frmMain_Load(object sender, EventArgs e)
        {

            //Load Engine and Iwad Paths
            Engine_Location = Properties.Settings.Default.Engine_Location;
            IWAD_Path = Properties.Settings.Default.IWAD_Path;
            current_iwad.Text = Properties.Settings.Default.current_iwad;


            //If the IWAD path has already been added, change the IWAD Location text on its button..
            if (!String.IsNullOrWhiteSpace(IWAD_Path))
            {
                btnIWADSLocation.Text = "Add New IWADs Location";
            }


            //Load Pwads and Deh
            LoadPwads.Text = Properties.Settings.Default.LoadPwads;
            txtRecent_Pwads.Text = Properties.Settings.Default.txtRecent_Pwads;
            current_pwad.Text = Properties.Settings.Default.current_pwad;

            //Just a visual element 
            //To sort of let the user know that these are the fields to focus on
            //when adding or selecting a Pwad.
            if (String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(192, 255, 192); //lightgreen
            }


            //Only load these settings if the LoadPwads.Text/TextBox has something in it!
            //eg a path to a given Pwad..
            if (!String.IsNullOrWhiteSpace(this.current_pwad.Text))
            {
                this.lstRecent_Pwads.Items.AddRange(Properties.Settings.Default.PWADItems.ToArray());
            }

            LoadDeh.Text = Properties.Settings.Default.LoadDeh;
            txtRecent_Deh.Text = Properties.Settings.Default.txtRecent_Deh;
            current_deh.Text = Properties.Settings.Default.current_deh;

            //Just a visual element 
            //To sort of let the user know that these are the fields to focus on
            //when adding or selecting a Deh.
            if (String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(192, 255, 192); //lightgreen
            }

            //Only load these settings if the LoadDeh.Text/TextBox has something in it!
            //eg a path to a given Deh..
            if (!String.IsNullOrWhiteSpace(this.current_deh.Text))
            {
                this.lstRecent_Deh.Items.AddRange(Properties.Settings.Default.DEHItems.ToArray());
            }

            //Tab Control ~ last selected
            tabControl1.SelectedIndex = Properties.Settings.Default.tabControl1;

            //Load cmbMaps and parameters
            cmbMaps.Text = Properties.Settings.Default.cmbMaps;
            Map1_Select = Properties.Settings.Default.Map1_Select;
            cmbMaps2.Text = Properties.Settings.Default.cmbMaps2;
            Map2_Select = Properties.Settings.Default.Map2_Select;
            cmbMaps3.Text = Properties.Settings.Default.cmbMaps3;
            Map3_Select = Properties.Settings.Default.Map3_Select;
            cmbMaps4.Text = Properties.Settings.Default.cmbMaps4;
            Map4_Select = Properties.Settings.Default.Map4_Select;
            cmbMaps5.Text = Properties.Settings.Default.cmbMaps5;
            Map5_Select = Properties.Settings.Default.Map5_Select;
            cmbMaps6.Text = Properties.Settings.Default.cmbMaps6;
            Map6_Select = Properties.Settings.Default.Map6_Select;
            cmbMaps7.Text = Properties.Settings.Default.cmbMaps7;
            Map7_Select = Properties.Settings.Default.Map7_Select;

            //Load the rest of the Game Settings, skill, monsters, etc.
            cmbSkills.Text = Properties.Settings.Default.cmbSkills;
            Skill_Select = Properties.Settings.Default.Skill_Select;
            cmbMonsters.Text = Properties.Settings.Default.cmbMonsters;
            Monsters_Select = Properties.Settings.Default.Monsters_Select;
            cmbGameMods.Text = Properties.Settings.Default.cmbGameMods;
            GameMods_Select = Properties.Settings.Default.GameMods_Select;

            //Ensure listbox focus on form load ~ last selected Iwad
            this.lstIWADS.Focus();
            if (lstIWADS.Items.Count > 0)
            {
                StatusInfo.Text = "";
            }

            //Load saved Listbox Game Selection
            IWAD_SelectedItem.Text = Properties.Settings.Default.IWAD_SelectedItem;
            IWAD_Index.Text = Properties.Settings.Default.IWAD_Index;

            //Save load AdditionalCMDs chkbox
            chkSaveAdditional.Checked = Properties.Settings.Default.chkSaveAdditional;
            if (chkSaveAdditional.Checked == true)
            {
                AdditionalCmds.Text = Properties.Settings.Default.AdditionalCmds;
            }
            if (chkSaveAdditional.Checked == false)
            {
                AdditionalCmds.Text = "";
            }

            #endregion

        #region//Auto detect the Game Engine.. If it's not there, make its location button visible..
            if (File.Exists(@"" + Engine_Location))
            {
                Engine_Location = Properties.Settings.Default.Engine_Location;
                BtnEngineLocation.Visible = false;
                btnLaunch.Visible = true;
                Logo_Box.Visible = false;

                try
                {
                    this.BtnEngineLocation.Visible = false;

                    // If the engine file exists, get its full path for execution.
                    string EngineFile = Path.GetDirectoryName(Application.ExecutablePath);

                    btnLaunch.Visible = true;

                    Logo_Box.Visible = true;


                }

                catch (Exception ex)
                {
                    if (!File.Exists(@"managed-doom.exe"))
                        // This will likely never see the light of day..
                        // But I guess I'll put this here if somehow the engine exe was renamed or maybe moved?
                        MessageBox.Show("Could not locate Managed-Doom.exe.\n Please add its location.");

                    MessageBox.Show(ex.Message);
                }

            }

            if (File.Exists(@"managed-doom.exe"))
            {

                try
                {
                    this.BtnEngineLocation.Visible = false;

                    // If the engine file exists, get its full path for execution.
                    string EngineFile = Path.GetDirectoryName(Application.ExecutablePath);
                    Engine_Location = EngineFile + "\\managed-doom.exe";
                    btnLaunch.Visible = true;

                }

                catch
                {
                    if (!File.Exists(@"managed-doom.exe"))
                        // This will likely never see the light of day..
                        // But I guess I'll put this here if somehow the engine exe was renamed?
                        MessageBox.Show("Could not locate Managed-Doom.exe.\n Please add its location.");
                }

            }
            else
            {

                if (!File.Exists(@"" + Engine_Location))
                {
                    this.BtnEngineLocation.Visible = true;
                }

            }
        
            #endregion

        #region //If IWAD exists - load them in the listbox.. Load Saved Index
            // This also loads the [Last Selected IWAD] in the listbox.


            IWAD_Select = IWAD_Path;

            if (File.Exists(IWAD_Select + "\\DOOM1.WAD"))
            {
                this.lstIWADS.Items.Add("DOOM1: Shareware Doom");

                if (IWAD_SelectedItem.Text == "DOOM1: Shareware Doom")
                {
                    //Doom1
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..
                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();
                }
                btnLaunch.Visible = true;
                //   this.lstIWADS.SelectedIndex = 0;
            }

            if (File.Exists(IWAD_Select + "\\DOOM.WAD"))
            {
                this.lstIWADS.Items.Add("DOOM: The Ultimate Doom");
                //  btnIWADSLocation.Visible = false;

                if (IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
                {
                    //Doom
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..
                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();
                }
                btnLaunch.Visible = true;

            }

            if (File.Exists(IWAD_Select + "\\DOOM2.WAD"))
            {
                this.lstIWADS.Items.Add("DOOM2: Hell on Earth");
                //  btnIWADSLocation.Visible = false;
                if (IWAD_SelectedItem.Text == "DOOM2: Hell on Earth")
                {
                    //Doom2
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                }


                btnLaunch.Visible = true;
            }

            //PLUTONIA
            if (File.Exists(IWAD_Select + "\\PLUTONIA.WAD"))
            {
                this.lstIWADS.Items.Add("Final Doom: Plutonia Experiment");
                //  btnIWADSLocation.Visible = false;

                if (IWAD_SelectedItem.Text == "Final Doom: Plutonia Experiment")
                {
                    //Plutonia
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();
                }

                btnLaunch.Visible = true;

            }
            //TNT
            if (File.Exists(IWAD_Select + "\\TNT.WAD"))
            {
                this.lstIWADS.Items.Add("Final Doom: TNT Evilution");
                //  btnIWADSLocation.Visible = false;

                if (IWAD_SelectedItem.Text == "Final Doom: TNT Evilution")
                {
                    //TNT
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();
                }

                btnLaunch.Visible = true;

            }
            //FREEDOOM1
            if (File.Exists(IWAD_Select + "\\FREEDOOM1.WAD"))
            {
                this.lstIWADS.Items.Add("FREEDOOM1: Phase 1");
                //  btnIWADSLocation.Visible = false;

                if (IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
                {
                    //Freedoom1
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();
                }

            }
            //FREEDOOM2
            if (File.Exists(IWAD_Select + "\\FREEDOOM2.WAD"))
            {
                this.lstIWADS.Items.Add("FREEDOOM2: Phase 2");
                //  btnIWADSLocation.Visible = false;

                if (IWAD_SelectedItem.Text == "FREEDOOM2: Phase 2")
                {


                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                }


                btnLaunch.Visible = true;


            }
            //// END IWAD EXISTS....
            ///

        }
        #endregion

        #region //Load the Game Engine, if it wasn't detected ~ Load Engine button.

        private void BtnEngineLocation_Click(object sender, EventArgs e)
        {
            // If the Engine is reloaded, Clear the values first!
            //   IWAD_Select = null;
            //   lstIWADS.Items.Clear();
            {
                //Locate the Game Engine 
                OpenFileDialog openDialog = new OpenFileDialog
                {
                    RestoreDirectory = false,
                    Title = "Select your Doom Engine Location",
                    Filter = "Doom Engine|*Managed-Doom.exe"
                };

                //If all is OK, add the location to the string values
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string EngineFile = openDialog.FileName;
                    Engine_Location = EngineFile;
                    // IWAD_Select only grabs the location, not the exe name.
                    IWAD_Select = Path.GetDirectoryName(Engine_Location);

                    AutoLoadEngine_Select = EngineFile;

                    // Remove the Engine Location botton if the Engine was found:
                    if (File.Exists(AutoLoadEngine_Select))
                    {
                        Engine_Location = AutoLoadEngine_Select;

                        BtnEngineLocation.Visible = false;
                        Properties.Settings.Default.Engine_Location = Engine_Location;
                        Properties.Settings.Default.Save();
                    }

                }
            }
        }
        #endregion
       
        #region //Load Iwad Location - if the IWAD exists Add it to the Listbox
        private void btnIWADSLocation_Click(object sender, EventArgs e)
        {
            //Clear any previouly loadded IWAD location first!
             this.lstIWADS.Items.Clear();
            
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "Select your IWAD Location.."
            };
            if (fbd.ShowDialog() == DialogResult.OK && fbd.SelectedPath.Length > 0)
            {
                IWAD_Path = String.Join(" ", fbd.SelectedPath);
                IWAD_Select = IWAD_Path;

                btnIWADSLocation.Text = "Add New IWAD Location";

                lstIWADS.Visible = true;
                this.lstIWADS.Items.Clear();

            }

            IWAD_Select = IWAD_Path;

            // Based on the current location
            // If the file exists, Add it to the listbox:
            if (File.Exists(IWAD_Select + "\\DOOM1.WAD"))
            {
                this.lstIWADS.Items.Add("DOOM1: Shareware Doom");

                if (IWAD_SelectedItem.Text == "DOOM1: Shareware Doom")
                {
                    //Doom1
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..
                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                    current_iwad.Text = IWAD_Select;

                    Properties.Settings.Default.IWAD_Path = IWAD_Path;
                    Properties.Settings.Default.Save();
                }
                btnLaunch.Visible = true; 
            }

            if (File.Exists(IWAD_Select + "\\DOOM.WAD"))
            {
                this.lstIWADS.Items.Add("DOOM: The Ultimate Doom");

                if (IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
                {
                    //Doom
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..
                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                    current_iwad.Text = IWAD_Select;

                    Properties.Settings.Default.IWAD_Path = IWAD_Path;
                    Properties.Settings.Default.Save();
                }
                btnLaunch.Visible = true;
            }

            if (File.Exists(IWAD_Select + "\\DOOM2.WAD"))
            {
                this.lstIWADS.Items.Add("DOOM2: Hell on Earth");

                if (IWAD_SelectedItem.Text == "DOOM2: Hell on Earth")
                {
                    //Doom2
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                    current_iwad.Text = IWAD_Select;

                    Properties.Settings.Default.IWAD_Path = IWAD_Path;
                    Properties.Settings.Default.Save();
                }
                btnLaunch.Visible = true;
            }

            //PLUTONIA
            if (File.Exists(IWAD_Select + "\\PLUTONIA.WAD"))
            {
                this.lstIWADS.Items.Add("Final Doom: Plutonia Experiment");

                if (IWAD_SelectedItem.Text == "Final Doom: Plutonia Experiment")
                {
                    //Plutonia
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                    current_iwad.Text = IWAD_Select;

                    Properties.Settings.Default.IWAD_Path = IWAD_Path;
                    Properties.Settings.Default.Save();
                }
                btnLaunch.Visible = true;
            }
            //TNT
            if (File.Exists(IWAD_Select + "\\TNT.WAD"))
            {
                this.lstIWADS.Items.Add("Final Doom: TNT Evilution");

                if (IWAD_SelectedItem.Text == "Final Doom: TNT Evilution")
                {
                    //TNT
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                    current_iwad.Text = IWAD_Select;

                    Properties.Settings.Default.IWAD_Path = IWAD_Path;
                    Properties.Settings.Default.Save();
                }
                btnLaunch.Visible = true;
            }
            //FREEDOOM1
            if (File.Exists(IWAD_Select + "\\FREEDOOM1.WAD"))
            {
                this.lstIWADS.Items.Add("FREEDOOM1: Phase 1");

                if (IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
                {
                    //Freedoom1
                    //Parse the string to int.
                    //This all has to do with loading the listbox settings
                    //On form load..

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                    current_iwad.Text = IWAD_Select;

                    Properties.Settings.Default.IWAD_Path = IWAD_Path;
                    Properties.Settings.Default.Save();
                }
                btnLaunch.Visible = true;
            }
            //FREEDOOM2
            if (File.Exists(IWAD_Select + "\\FREEDOOM2.WAD"))
            {
                this.lstIWADS.Items.Add("FREEDOOM2: Phase 2");

                if (IWAD_SelectedItem.Text == "FREEDOOM2: Phase 2")
                {

                    int x = 0;
                    Int32.TryParse(IWAD_Index.Text, out x);
                    this.lstIWADS.Focus();
                    this.lstIWADS.SelectedItem = this;
                    this.lstIWADS.SelectedIndex = x;
                    this.lstIWADS.Select();

                    current_iwad.Text = IWAD_Select;

                    Properties.Settings.Default.IWAD_Path = IWAD_Path;
                    Properties.Settings.Default.Save();
                }
                btnLaunch.Visible = true;
            }
            else
            {
                lstIWADS.Visible = true;
            }
        }
        #endregion

        #region //If a different Game IWAD is selected in the List, do this..
        // Get the selected IWAD path,
        // display the Map combobox for it,
        // display the box art image,
        // display the selected Index number. ~ for debugging, hidden by defualt..
        private void lstIWADS_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnLaunch.Visible = true;

            if (lstIWADS.Text == "DOOM1: Shareware Doom")
            {
                picGame.Image = Resources.doom_shareware;

                //Maps
                cmbMaps.Visible = false;
                cmbMaps2.Visible = false;
                cmbMaps3.Visible = true;
                cmbMaps4.Visible = false;
                cmbMaps5.Visible = false;
                cmbMaps6.Visible = false;
                cmbMaps7.Visible = false;

                lblWarp.Text = Map3_Select;
                lblWarp.ForeColor = Color.Black;


                string IWADINFO = lstIWADS.GetItemText(lstIWADS.SelectedIndex);
                IWAD_Index.Text = IWADINFO;

                IWAD_SelectedItem.Text = "DOOM1: Shareware Doom";
                Properties.Settings.Default.IWAD_Index = IWAD_Index.Text;
                Properties.Settings.Default.IWAD_SelectedItem = IWAD_SelectedItem.Text;
                Properties.Settings.Default.Save();

            }



            if (lstIWADS.Text == "DOOM: The Ultimate Doom")
            {
                picGame.Image = Resources.Theultimatedoom;

                //Maps
                cmbMaps.Visible = false;
                cmbMaps2.Visible = true;
                cmbMaps3.Visible = false;
                cmbMaps4.Visible = false;
                cmbMaps5.Visible = false;
                cmbMaps6.Visible = false;
                cmbMaps7.Visible = false;


                lblWarp.Text = Map2_Select;
                lblWarp.ForeColor = Color.Black;

                string IWADINFO = lstIWADS.GetItemText(lstIWADS.SelectedIndex);
                IWAD_Index.Text = IWADINFO;

                IWAD_SelectedItem.Text = "DOOM: The Ultimate Doom";

                if (Path.GetFileName(LoadPwads.Text) == "SIGIL_COMPAT.wad" 
                    && IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
                {
                    picGame.Image = Resources.Theultimatedoom_Sigil;
                }

                Properties.Settings.Default.IWAD_Index = IWAD_Index.Text;
                Properties.Settings.Default.IWAD_SelectedItem = IWAD_SelectedItem.Text;
                Properties.Settings.Default.Save();

            }


            if (lstIWADS.Text == "DOOM2: Hell on Earth")
            {
                picGame.Image = Resources.Doom2_poster;

                //Maps
                cmbMaps.Visible = true;
                cmbMaps2.Visible = false;
                cmbMaps3.Visible = false;
                cmbMaps4.Visible = false;
                cmbMaps5.Visible = false;
                cmbMaps6.Visible = false;
                cmbMaps7.Visible = false;

                lblWarp.Text = Map1_Select;
                lblWarp.ForeColor = Color.Black;

                string IWADINFO = lstIWADS.GetItemText(lstIWADS.SelectedIndex);
                IWAD_Index.Text = IWADINFO;

                IWAD_SelectedItem.Text = "DOOM2: Hell on Earth";
                Properties.Settings.Default.IWAD_Index = IWAD_Index.Text;
                Properties.Settings.Default.IWAD_SelectedItem = IWAD_SelectedItem.Text;
                Properties.Settings.Default.Save();

            }

            if (lstIWADS.Text == "Final Doom: Plutonia Experiment")
            {
                picGame.Image = Resources.Final_Doom;

                //Maps
                cmbMaps.Visible = false;
                cmbMaps2.Visible = false;
                cmbMaps3.Visible = false;
                cmbMaps4.Visible = true;
                cmbMaps5.Visible = false;
                cmbMaps6.Visible = false;
                cmbMaps7.Visible = false;

                lblWarp.Text = Map4_Select;
                lblWarp.ForeColor = Color.Black;

                string IWADINFO = lstIWADS.GetItemText(lstIWADS.SelectedIndex);
                IWAD_Index.Text = IWADINFO;

                IWAD_SelectedItem.Text = "Final Doom: Plutonia";
                Properties.Settings.Default.IWAD_Index = IWAD_Index.Text;
                Properties.Settings.Default.IWAD_SelectedItem = IWAD_SelectedItem.Text;
                Properties.Settings.Default.Save();

            }

            if (lstIWADS.Text == "Final Doom: TNT Evilution")
            {
                picGame.Image = Resources.Final_Doom;

                //Maps
                cmbMaps.Visible = false;
                cmbMaps2.Visible = false;
                cmbMaps3.Visible = false;
                cmbMaps4.Visible = false;
                cmbMaps5.Visible = true;
                cmbMaps6.Visible = false;
                cmbMaps7.Visible = false;

                lblWarp.Text = Map5_Select;
                lblWarp.ForeColor = Color.Black;

                string IWADINFO = lstIWADS.GetItemText(lstIWADS.SelectedIndex);
                IWAD_Index.Text = IWADINFO;

                ///
                IWAD_SelectedItem.Text = "Final Doom: TNT Evilution";
                Properties.Settings.Default.IWAD_Index = IWAD_Index.Text;
                Properties.Settings.Default.IWAD_SelectedItem = IWAD_SelectedItem.Text;
                Properties.Settings.Default.Save();

            }

            if (lstIWADS.Text == "FREEDOOM1: Phase 1")
            {
                picGame.Image = Resources.freedoom1;

                //Maps
                cmbMaps.Visible = false;
                cmbMaps2.Visible = false;
                cmbMaps3.Visible = false;
                cmbMaps4.Visible = false;
                cmbMaps5.Visible = false;
                cmbMaps6.Visible = true;
                cmbMaps7.Visible = false;


                lblWarp.Text = Map6_Select;
                lblWarp.ForeColor = Color.Black;

                string IWADINFO = lstIWADS.GetItemText(lstIWADS.SelectedIndex);
                IWAD_Index.Text = IWADINFO;

                IWAD_SelectedItem.Text = "FREEDOOM1: Phase 1";

                if (Path.GetFileName(LoadPwads.Text) == "SIGIL_COMPAT.wad"
                && IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
                {
                    picGame.Image = Resources.Freedoom1_Sigil;
                }

                Properties.Settings.Default.IWAD_Index = IWAD_Index.Text;
                Properties.Settings.Default.IWAD_SelectedItem = IWAD_SelectedItem.Text;
                Properties.Settings.Default.Save();

            }


            if (lstIWADS.Text == "FREEDOOM2: Phase 2")
            {
                picGame.Image = Resources.freedoom2;

                //Maps
                cmbMaps.Visible = false;
                cmbMaps2.Visible = false;
                cmbMaps3.Visible = false;
                cmbMaps4.Visible = false;
                cmbMaps5.Visible = false;
                cmbMaps6.Visible = false;
                cmbMaps7.Visible = true;


                lblWarp.Text = Map6_Select;
                lblWarp.ForeColor = Color.Black;

                string IWADINFO = lstIWADS.GetItemText(lstIWADS.SelectedIndex);
                IWAD_Index.Text = IWADINFO;

                IWAD_SelectedItem.Text = "FREEDOOM2: Phase 2";
                Properties.Settings.Default.IWAD_Index = IWAD_Index.Text;
                Properties.Settings.Default.IWAD_SelectedItem = IWAD_SelectedItem.Text;
                Properties.Settings.Default.Save();

            }

        }

        #endregion

        #region //Launch the game - depending on which Iwad is selected 
        private void btnLaunch_Click(object sender, EventArgs e)
        {

            if (lstIWADS.SelectedItem == null)
            {
                MessageBox.Show("Please select an IWAD to play!");
            }


            if (lstIWADS.Text == "DOOM1: Shareware Doom")
            {

                string IWADconfig = " -iwad " + IWAD_Path +
                    "\\Doom1.wad " + LoadPwads.Text + LoadDeh.Text +
                    Map3_Select + Skill_Select + Monsters_Select +
                    GameMods_Select + " " + AdditionalCmds.Text;
                string EngineLocation = Engine_Location;



                // Minimize the launcher window then try to run the game:
                this.WindowState = FormWindowState.Minimized;
                try
                {

                    {

                        var process = Process.Start(@"" + EngineLocation, IWADconfig);

                        // Don't allow the Launcher to be seen in the taskbar during the process:
                        // This seems ugly, but it keeps the launcher from being forcefully accessed.
                        // While the process is running..
                        this.Hide();
                        // Wait for the engine process to end before returning the launcher to its normal state.
                        process.WaitForExit(); 

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Add your Managed-Doom Engine Location.");
                }

                // The process has ended, allow the Launcher to be seen again..
                this.Show();
                // Since launch suceeded, and the process has ended, place the launcher back on the desktop..
                this.WindowState = FormWindowState.Normal;
              
            }

            if (lstIWADS.Text == "DOOM: The Ultimate Doom")
            {

                string IWADconfig = " -iwad " + IWAD_Path +
                    "\\Doom.wad " + LoadPwads.Text + LoadDeh.Text +
                    Map2_Select + Skill_Select + Monsters_Select +
                    GameMods_Select + " " + AdditionalCmds.Text;
                string EngineLocation = Engine_Location;


                // Minimize the launcher window then try to run the game:
                this.WindowState = FormWindowState.Minimized;
                try
                {
                    var process = Process.Start(@"" + EngineLocation, IWADconfig);
                    // ShowInTaskbar = false;
                    this.Hide();


                    // Wait for the engine process to end before returning the launcher to its normal state.
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Add your Managed-Doom Engine Location.");
                }
                // Since launch suceeded, place the launcher back on the desktop..
                // ShowInTaskbar = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
               

            }

            if (lstIWADS.Text == "DOOM2: Hell on Earth")
            {

                string IWADconfig = " -iwad " + IWAD_Path +
                    "\\Doom2.wad " + LoadPwads.Text + LoadDeh.Text +
                    Map1_Select + Skill_Select + Monsters_Select +
                    GameMods_Select + " " + AdditionalCmds.Text;
                string EngineLocation = Engine_Location;

                this.WindowState = FormWindowState.Minimized;
                
                try
                {   
  
                    var process = Process.Start(@"" + EngineLocation, IWADconfig);
                  //  ShowInTaskbar = false;
                  this.Hide();
                    // Wait for the engine process to end before returning the launcher to its normal state.
                    process.WaitForExit();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Add your Managed-Doom Engine Location.");
                }
                // Since launch suceeded, place the launcher back on the desktop..
                // ShowInTaskbar = true;
                this.Show();
             
                this.WindowState = FormWindowState.Normal;


            }
            //PLUTONIA
            if (lstIWADS.Text == "Final Doom: Plutonia Experiment")
            {


                string IWADconfig = " -iwad " + IWAD_Path +
                    "\\PLUTONIA.wad " + LoadPwads.Text + LoadDeh.Text +
                    Map4_Select + Skill_Select + Monsters_Select +
                    GameMods_Select + " " + AdditionalCmds.Text;
                string EngineLocation = Engine_Location;
                // Minimize the launcher window then try to run the game:
                this.WindowState = FormWindowState.Minimized;
                try
                {
                    var process = Process.Start(@"" + EngineLocation, IWADconfig);
                    // ShowInTaskbar = false;
                    this.Hide();
                    // Wait for the engine process to end before returning the launcher to its normal state.
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Add your Managed-Doom Engine Location.");
                }
                // Since launch suceeded, place the launcher back on the desktop..
                //  ShowInTaskbar = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                
            }
            //TNT
            if (lstIWADS.Text == "Final Doom: TNT Evilution")
            {
                string IWADconfig = " -iwad " + IWAD_Path +
                    "\\TNT.wad " + LoadPwads.Text + LoadDeh.Text +
                    Map5_Select + Skill_Select + Monsters_Select +
                    GameMods_Select + " " + AdditionalCmds.Text;
                string EngineLocation = Engine_Location;
                // Minimize the launcher window then try to run the game:
                this.WindowState = FormWindowState.Minimized;
                try
                {
                    var process = Process.Start(@"" + EngineLocation, IWADconfig);
                    //  ShowInTaskbar = false;
                    this.Hide();
                    // Wait for the engine process to end before returning the launcher to its normal state.
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Add your Managed-Doom Engine Location.");
                }
                // Since launch suceeded, place the launcher back on the desktop..
                // ShowInTaskbar = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                
            }
            //FREEDOOM1
            if (lstIWADS.Text == "FREEDOOM1: Phase 1")
            {
                string IWADconfig = " -iwad " + IWAD_Path +
                    "\\FREEDOOM1.wad " + LoadPwads.Text + LoadDeh.Text +
                    Map6_Select + Skill_Select + Monsters_Select +
                    GameMods_Select + " " + AdditionalCmds.Text;
                string EngineLocation = Engine_Location;
                // Minimize the launcher window then try to run the game:
                this.WindowState = FormWindowState.Minimized;
                try
                {
                    var process = Process.Start(@"" + EngineLocation, IWADconfig);
                    //  ShowInTaskbar = false;
                    this.Hide();
                    // Wait for the engine process to end before returning the launcher to its normal state.
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Add your Managed-Doom Engine Location.");
                }
                // Since launch suceeded, place the launcher back on the desktop..
                //   ShowInTaskbar = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
               
            }
            //FREEDOOM2
            if (lstIWADS.Text == "FREEDOOM2: Phase 2")
            {
                string IWADconfig = " -iwad " + IWAD_Path +
                    "\\FREEDOOM2.wad " + LoadPwads.Text + LoadDeh.Text +
                    Map7_Select + Skill_Select + Monsters_Select +
                    GameMods_Select + " " + AdditionalCmds.Text;
                string EngineLocation = Engine_Location;
                // Minimize the launcher window then try to run the game:
                this.WindowState = FormWindowState.Minimized;
                try
                {
                    var process = Process.Start(@"" + EngineLocation, IWADconfig);
                    //   ShowInTaskbar = false;
                    this.Hide();
                    // Wait for the engine process to end before returning the launcher to its normal state.
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Add your Managed-Doom Engine Location.");
                }
                // Since launch suceeded, place the launcher back on the desktop..
                //  ShowInTaskbar = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
               
            }

        }
        #endregion

        #region //Load Pwads and Deh files..
        private void btnLoadPwads_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "WAD Files|*.wad",
                InitialDirectory = "",
                Title = "Select a file..",
                Multiselect = true
            };
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileNames.Length > 0)
            {
                {
                    LoadPwads.Text = " -file " + String.Join(" ", ofd.FileNames);

                    txtRecent_Pwads.Text = LoadPwads.Text;
                    current_pwad.Text = LoadPwads.Text; 

                    if (String.IsNullOrWhiteSpace(this.LoadPwads.Text))
                    {
                        LoadPwads.BackColor = Color.FromArgb(255, 222, 222); //lightred
                    }
                    if (!String.IsNullOrWhiteSpace(this.LoadPwads.Text))
                    {
                        LoadPwads.BackColor = Color.FromArgb(192, 255, 192); //lightgreen
                    }

                    // And then also add them to a ListBox.
                    // This Listbox will store the recently loaded Pwads and their location.
                    // It will allow the user to select a file without having to load it again! :)

                    // Set a Maximum amount of Items that the Listbox can hold
                    // 50 entries should be plenty
                    int MaxItems = 50;
                    if (lstRecent_Pwads.Items.Count < MaxItems)
                    {
                        //Store the items in an Array and then save!
                        lstRecent_Pwads.Items.Add(txtRecent_Pwads.Text);
                        var PWADList = new ArrayList();
                        foreach (object item in lstRecent_Pwads.Items)
                        {
                            PWADList.Add(item);
                            Properties.Settings.Default.LoadPwads = LoadPwads.Text;
                            Properties.Settings.Default.PWADItems = PWADList;
                            Properties.Settings.Default.Save();
                        }


                        // If the SIGIL_COMPAT pwad is loaded display its logo with Doom:
                        if (Path.GetFileName(LoadPwads.Text) == "SIGIL_COMPAT.wad"
                            && IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
                        {

                            picGame.Image = Resources.Theultimatedoom_Sigil;
                        }
                        if (Path.GetFileName(LoadPwads.Text) == "SIGIL_COMPAT.wad" 
                            && IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
                        {

                            picGame.Image = Resources.Freedoom1_Sigil;
                        }
                    }
                }
            }
        }

        private void btnLoadDeh_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "DEH Files|*.deh",
                InitialDirectory = "",
                Title = "Select a file..",
                Multiselect = true
            };
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileNames.Length > 0)
            {
                {
                    LoadDeh.Text = " -deh " + String.Join(" ", ofd.FileNames);

                    txtRecent_Deh.Text = LoadDeh.Text;
                    current_deh.Text = LoadDeh.Text;

                    if (String.IsNullOrWhiteSpace(this.LoadDeh.Text))
                    {
                        LoadDeh.BackColor = Color.FromArgb(255, 222, 222); //lightred
                    }
                    if (!String.IsNullOrWhiteSpace(this.LoadDeh.Text))
                    {
                        LoadDeh.BackColor = Color.FromArgb(192, 255, 192); //lightgreen
                    }

                    // And then also add them to a ListBox.
                    // This Listbox will store the recently loaded Dehs and their location.
                    // It will allow the user to select a file without having to load it again! :)

                    // Set a Maximum amount of Items the Listbox can hold
                    // 50 entries should be plenty..
                    int MaxItems = 50;
                    if (lstRecent_Deh.Items.Count < MaxItems)
                    {
                        // Add the items
                        lstRecent_Deh.Items.Add(txtRecent_Deh.Text);
                        var DEHList = new ArrayList();
                        foreach (object item in lstRecent_Deh.Items)
                        {
                            DEHList.Add(item);
                        }
                        Properties.Settings.Default.LoadDeh = LoadDeh.Text;
                        Properties.Settings.Default.DEHItems = DEHList;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        private void btnClearPwads_Click(object sender, EventArgs e)
        {
            LoadPwads.Clear();
            txtRecent_Pwads.Clear();

            if (Path.GetFileName(LoadPwads.Text) == ""
            && IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
            {

                picGame.Image = Resources.Theultimatedoom;
            }

            if (String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(192, 255, 192); //lightgreen
            }

            Properties.Settings.Default.LoadPwads = LoadPwads.Text;
            Properties.Settings.Default.Save();

        }

        private void btnClearDeh_Click(object sender, EventArgs e)
        {
            LoadDeh.Clear();
            txtRecent_Deh.Clear();

            if (String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(192, 255, 192);
            }

            Properties.Settings.Default.LoadDeh = LoadDeh.Text;
            Properties.Settings.Default.Save();

        }

        #endregion

        #region //When the form is Closing, save any other additional settings
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.Engine_Location = Engine_Location;
            Properties.Settings.Default.current_iwad = current_iwad.Text;
            Properties.Settings.Default.tabControl1 = tabControl1.SelectedIndex;
            Properties.Settings.Default.chkSaveAdditional = chkSaveAdditional.Checked;
            Properties.Settings.Default.AdditionalCmds = AdditionalCmds.Text;
            Properties.Settings.Default.IWAD_Path = IWAD_Path;
            Properties.Settings.Default.current_pwad = current_pwad.Text;
            Properties.Settings.Default.current_deh = current_deh.Text;

            Properties.Settings.Default.Save();
        }
        #endregion

        #region //Pwad and Deh Listbox ~ [Record Keeping] saving them, selecting them, and removing them.
        private void lstRecent_Pwads_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPwads.Clear();
            LoadPwads.Text = lstRecent_Pwads.Text;

            // If the SIGIL_COMPAT pwad IS loaded, display its logo with Doom:
            if (Path.GetFileName(LoadPwads.Text) == "SIGIL_COMPAT.wad" 
                && IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
            {
                picGame.Image = Resources.Theultimatedoom_Sigil;
            }
            // Same thing, if Freedoom 1 is loaded instead of Ultimate Doom:
            if (Path.GetFileName(LoadPwads.Text) == "SIGIL_COMPAT.wad"
                && IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
            {
                picGame.Image = Resources.Freedoom1_Sigil;
            }

            // If the SIGIL_COMPAT pwad is NOT! loaded, only display The Ultimate Doom logo:
            if (Path.GetFileName(LoadPwads.Text) != "SIGIL_COMPAT.wad"
                && IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
            {
                picGame.Image = Resources.Theultimatedoom;
            }
            // Same thing, if Freedoom 1 is loaded instead of Ultimate Doom:
            if (Path.GetFileName(LoadPwads.Text) != "SIGIL_COMPAT.wad"
                && IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
            {
                picGame.Image = Resources.freedoom1;
            }

            // If LoadPwads is Empty, no path to a file, display the textbox background as light red.. 
            if (String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(255, 222, 222); //lightred 
            }
            // If LoadPwads has something in it, a file path, display the textbox background as light green.. 
            if (!String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(192, 255, 192); //lightgreen 
            }

            //Save whatever is in the LoadPwads textbox, even is its empty..
            Properties.Settings.Default.LoadPwads = LoadPwads.Text;
            Properties.Settings.Default.Save();
        }

        private void lstRecent_Deh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDeh.Clear();
            LoadDeh.Text = lstRecent_Deh.Text;

            if (String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(192, 255, 192); //lightgreen
            }

            //Save whatever is in the LoadDeh textbox, even is its empty..
            Properties.Settings.Default.LoadDeh = LoadDeh.Text;
            Properties.Settings.Default.Save();

        }

        private void btnClear_RecentPwads_Click(object sender, EventArgs e)
        {
            //Remove selected Items from the listbox
            foreach (string s in lstRecent_Pwads.SelectedItems.OfType<string>().ToList())
                lstRecent_Pwads.Items.Remove(s);

            //Update the list of remaining items and Save:
            var newList = new ArrayList();
            foreach (object item in lstRecent_Pwads.Items)
            {
                newList.Add(item);
            }

            //if the Sigil_Comp pwad was removed: only display the Ultimate Doom logo
            if (Path.GetFileName(LoadPwads.Text) == ""
            && IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
            {
                picGame.Image = Resources.Theultimatedoom;
            }
            if (Path.GetFileName(LoadPwads.Text) == ""
            && IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
            {
                picGame.Image = Resources.freedoom1;
            }

            if (String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(192, 255, 192);
            }

            Properties.Settings.Default.PWADItems = newList;
            Properties.Settings.Default.Save();
        }

        private void btnClear_RecentDeh_Click(object sender, EventArgs e)
        {
            foreach (string s in lstRecent_Deh.SelectedItems.OfType<string>().ToList())
                lstRecent_Deh.Items.Remove(s);

            //Update the list of remaining items and Save:
            var newList = new ArrayList();
            foreach (object item in lstRecent_Deh.Items)
            {
                newList.Add(item);
            }

            if (String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(192, 255, 192);
            }

            Properties.Settings.Default.DEHItems = newList;
            Properties.Settings.Default.Save();
        }


        private void btnClearAll_RecentPwads_Click(object sender, EventArgs e)
        {
            lstRecent_Pwads.Items.Clear();
            //Update the list of remaining items and Save:
            var newList = new ArrayList();
            foreach (object item in lstRecent_Pwads.Items)
            {
                newList.Add(item);
            }

            //if the Sigil_Comp pwad was removed: only display the Ultimate Doom logo.
            if (Path.GetFileName(LoadPwads.Text) == ""
            && IWAD_SelectedItem.Text == "DOOM: The Ultimate Doom")
            {

                picGame.Image = Resources.Theultimatedoom;
            }

            if (Path.GetFileName(LoadPwads.Text) == ""
            && IWAD_SelectedItem.Text == "FREEDOOM1: Phase 1")
            {
                picGame.Image = Resources.freedoom1;
            }

            if (String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadPwads.Text))
            {
                LoadPwads.BackColor = Color.FromArgb(192, 255, 192);
            }

            Properties.Settings.Default.PWADItems = newList;
            Properties.Settings.Default.Save();
        }

        private void btnClearAll_RecentDeh_Click(object sender, EventArgs e)
        {
            //Clear all items from the list:
            lstRecent_Deh.Items.Clear();
            //Update the list of remaining items and Save:
            var newList = new ArrayList();
            foreach (object item in lstRecent_Deh.Items)
            {
                newList.Add(item);
            }

            if (String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(255, 222, 222); //lightred
            }
            if (!String.IsNullOrWhiteSpace(this.LoadDeh.Text))
            {
                LoadDeh.BackColor = Color.FromArgb(192, 255, 192);
            }

            Properties.Settings.Default.DEHItems = newList;
            Properties.Settings.Default.Save();
        }

        private void chkEnableRemoveAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableRemoveAll.Checked == true)
            {
                btnClearAll_RecentDeh.Enabled = true;
                btnClearAll_RecentPwads.Enabled = true;
            }
            else
            {
                btnClearAll_RecentDeh.Enabled = false;
                btnClearAll_RecentPwads.Enabled = false;
            }
        }


        private void chkSaveAdditional_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveAdditional.Checked == false)
            {
                AdditionalCmds.Text = "";
            }
        }
        #endregion

        #region//Drag n' Drop Pwad and Deh files
        private void LoadPwads_DragDrop(object sender, DragEventArgs e)
        {
            string[] wadfile = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string pwad in wadfile)

            {
                if (Path.GetExtension(pwad) == @".WAD")
                {
                    pwad.ToLower();
                    LoadPwads.Text = @" -file " + "\"" + (pwad) + "\"";

                    txtRecent_Pwads.Text = LoadPwads.Text;

                    // And then also add them to a ListBox.
                    // This Listbox will store the recently loaded Pwads and their location.
                    // It will allow the user to select a file without having to load it again! :)

                    // Set a Maximum amount of Items that the Listbox can hold
                    // 50 entries should be plenty
                    int MaxItems = 50;
                    if (lstRecent_Pwads.Items.Count < MaxItems)
                    {
                        //Store the items in an Array and then save!
                        lstRecent_Pwads.Items.Add(txtRecent_Pwads.Text);
                        var PWADList = new ArrayList();
                        foreach (object item in lstRecent_Pwads.Items)
                        {
                            PWADList.Add(item);
                            Properties.Settings.Default.LoadPwads = LoadPwads.Text;
                            Properties.Settings.Default.PWADItems = PWADList;
                            Properties.Settings.Default.Save();
                        }
                    }
                }

                if (Path.GetExtension(pwad) == @".wad")
                {
                    LoadPwads.Text = @" -file " + "\"" + (pwad) + "\"";

                    txtRecent_Pwads.Text = LoadPwads.Text;

                    // And then also add them to a ListBox.
                    // This Listbox will store the recently loaded Pwads and their location.
                    // It will allow the user to select a file without having to load it again! :)

                    // Set a Maximum amount of Items that the Listbox can hold
                    // 50 entries should be plenty
                    int MaxItems = 50;
                    if (lstRecent_Pwads.Items.Count < MaxItems)
                    {
                        //Store the items in an Array and then save!
                        lstRecent_Pwads.Items.Add(txtRecent_Pwads.Text);
                        var PWADList = new ArrayList();
                        foreach (object item in lstRecent_Pwads.Items)
                        {
                            PWADList.Add(item);
                            Properties.Settings.Default.LoadPwads = LoadPwads.Text;
                            Properties.Settings.Default.PWADItems = PWADList;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
            }
        }

        private void LoadPwads_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void LoadDeh_DragDrop(object sender, DragEventArgs e)
        {
            string[] dehfile = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string dehacked in dehfile)
            {
                if (Path.GetExtension(dehacked) == @".DEH")
                {
                    dehacked.ToLower();
                    LoadDeh.Text = @" -deh " + "\"" + (dehacked) + "\"";

                    txtRecent_Deh.Text = LoadDeh.Text;

                    // And then also add them to a ListBox.
                    // This Listbox will store the recently loaded Dehs and their location.
                    // It will allow the user to select a file without having to load it again! :)

                    // Set a Maximum amount of Items the Listbox can hold
                    // 50 entries should be plenty..
                    int MaxItems = 50;
                    if (lstRecent_Deh.Items.Count < MaxItems)
                    {
                        // Add the items
                        lstRecent_Deh.Items.Add(txtRecent_Deh.Text);
                        var DEHList = new ArrayList();
                        foreach (object item in lstRecent_Deh.Items)
                        {
                            DEHList.Add(item);
                        }
                        Properties.Settings.Default.LoadDeh = LoadDeh.Text;
                        Properties.Settings.Default.DEHItems = DEHList;
                        Properties.Settings.Default.Save();
                    }

                }

                if (Path.GetExtension(dehacked) == @".deh")
                {
                    dehacked.ToLower();
                    LoadDeh.Text = @" -deh " + "\"" + (dehacked) + "\"";

                    txtRecent_Deh.Text = LoadDeh.Text;

                    // And then also add them to a ListBox.
                    // This Listbox will store the recently loaded Dehs and their location.
                    // It will allow the user to select a file without having to load it again! :)

                    // Set a Maximum amount of Items the Listbox can hold
                    // 50 entries should be plenty..
                    int MaxItems = 50;
                    if (lstRecent_Deh.Items.Count < MaxItems)
                    {
                        // Add the items
                        lstRecent_Deh.Items.Add(txtRecent_Deh.Text);
                        var DEHList = new ArrayList();
                        foreach (object item in lstRecent_Deh.Items)
                        {
                            DEHList.Add(item);
                        }
                        Properties.Settings.Default.LoadDeh = LoadDeh.Text;
                        Properties.Settings.Default.DEHItems = DEHList;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        private void LoadDeh_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        #endregion

        #region //Map# or Episode/Levels..
        // These Map Combo Boxes are stack on top of one another in the form..
        // Depending on which IWAD is selected, the appropriate one will be displayed.. 

        // Maps ComboBox based on Doom2 and its variants - cmbMaps
        private void cmbMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIWADS.Text == "DOOM2: Hell on Earth")
            {
                // combobox selection, depends on the selected iwad.
                //these iwads all use the same name convention, eg -warp XX:
                if (cmbMaps.Text == "MAP01")
                {
                    Map1_Select = " -warp 01 ";
                }

                if (cmbMaps.Text == "MAP02")
                {
                    Map1_Select = " -warp 02 ";
                }

                if (cmbMaps.Text == "MAP03")
                {
                    Map1_Select = " -warp 03 ";
                }

                if (cmbMaps.Text == "MAP04")
                {
                    Map1_Select = " -warp 04 ";
                }

                if (cmbMaps.Text == "MAP05")
                {
                    Map1_Select = " -warp 05 ";
                }

                if (cmbMaps.Text == "MAP06")
                {
                    Map1_Select = " -warp 06 ";
                }

                if (cmbMaps.Text == "MAP07")
                {
                    Map1_Select = " -warp 07 ";
                }

                if (cmbMaps.Text == "MAP08")
                {
                    Map1_Select = " -warp 08 ";
                }

                if (cmbMaps.Text == "MAP09")
                {
                    Map1_Select = " -warp 09 ";
                }

                if (cmbMaps.Text == "MAP10")
                {
                    Map1_Select = " -warp 10 ";
                }

                if (cmbMaps.Text == "MAP11")
                {
                    Map1_Select = " -warp 11 ";
                }

                if (cmbMaps.Text == "MAP12")
                {
                    Map1_Select = " -warp 12 ";
                }

                if (cmbMaps.Text == "MAP13")
                {
                    Map1_Select = " -warp 13 ";
                }

                if (cmbMaps.Text == "MAP14")
                {
                    Map1_Select = " -warp 14 ";
                }

                if (cmbMaps.Text == "MAP15")
                {
                    Map1_Select = " -warp 15 ";
                }

                if (cmbMaps.Text == "MAP16")
                {
                    Map1_Select = " -warp 16 ";
                }

                if (cmbMaps.Text == "MAP17")
                {
                    Map1_Select = " -warp 17 ";
                }

                if (cmbMaps.Text == "MAP18")
                {
                    Map1_Select = " -warp 18 ";
                }

                if (cmbMaps.Text == "MAP19")
                {
                    Map1_Select = " -warp 19 ";
                }

                if (cmbMaps.Text == "MAP20")
                {
                    Map1_Select = " -warp 20 ";
                }

                if (cmbMaps.Text == "MAP21")
                {
                    Map1_Select = " -warp 21 ";
                }

                if (cmbMaps.Text == "MAP22")
                {
                    Map1_Select = " -warp 22 ";
                }

                if (cmbMaps.Text == "MAP23")
                {
                    Map1_Select = " -warp 23 ";
                }

                if (cmbMaps.Text == "MAP24")
                {
                    Map1_Select = " -warp 24 ";
                }

                if (cmbMaps.Text == "MAP25")
                {
                    Map1_Select = " -warp 25 ";
                }

                if (cmbMaps.Text == "MAP26")
                {
                    Map1_Select = " -warp 26 ";
                }

                if (cmbMaps.Text == "MAP27")
                {
                    Map1_Select = " -warp 27 ";
                }

                if (cmbMaps.Text == "MAP28")
                {
                    Map1_Select = " -warp 28 ";
                }

                if (cmbMaps.Text == "MAP29")
                {
                    Map1_Select = " -warp 29 ";
                }

                if (cmbMaps.Text == "MAP30")
                {
                    Map1_Select = " -warp 30 ";
                }

                if (cmbMaps.Text == "MAP31")
                {
                    Map1_Select = " -warp 31 ";
                }

                if (cmbMaps.Text == "MAP32")
                {
                    Map1_Select = " -warp 32 ";
                }
                lblWarp.Text = Map1_Select;

                Properties.Settings.Default.cmbMaps = cmbMaps.Text;
                Properties.Settings.Default.Map1_Select = Map1_Select;
                Properties.Settings.Default.Save();
            }
        }

        private void cmbMaps2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIWADS.Text == "DOOM: The Ultimate Doom")
            {

                // combobox selection, depends on the selected iwad.
                //these iwads all use the same name convention, eg -warp X X:
                if (cmbMaps2.Text == "E1M1")
                {
                    Map2_Select = " -warp 1 1 ";
                }
                if (cmbMaps2.Text == "E1M2")
                {
                    Map2_Select = " -warp 1 2 ";
                }
                if (cmbMaps2.Text == "E1M3")
                {
                    Map2_Select = " -warp 1 3 ";
                }
                if (cmbMaps2.Text == "E1M4")
                {
                    Map2_Select = " -warp 1 4 ";
                }
                if (cmbMaps2.Text == "E1M5")
                {
                    Map2_Select = " -warp 1 5 ";
                }
                if (cmbMaps2.Text == "E1M6")
                {
                    Map2_Select = " -warp 1 6 ";
                }
                if (cmbMaps2.Text == "E1M7")
                {
                    Map2_Select = " -warp 1 7 ";
                }
                if (cmbMaps2.Text == "E1M8")
                {
                    Map2_Select = " -warp 1 8 ";
                }
                if (cmbMaps2.Text == "E1M9")
                {
                    Map2_Select = " -warp 1 9 ";
                }
                if (cmbMaps2.Text == "E2M1")
                {
                    Map2_Select = " -warp 2 1 ";
                }
                if (cmbMaps2.Text == "E2M2")
                {
                    Map2_Select = " -warp 2 2 ";
                }
                if (cmbMaps2.Text == "E2M3")
                {
                    Map2_Select = " -warp 2 3 ";
                }
                if (cmbMaps2.Text == "E2M4")
                {
                    Map2_Select = " -warp 2 4 ";
                }
                if (cmbMaps2.Text == "E2M5")
                {
                    Map2_Select = " -warp 2 5 ";
                }
                if (cmbMaps2.Text == "E2M6")
                {
                    Map2_Select = " -warp 2 6 ";
                }
                if (cmbMaps2.Text == "E2M7")
                {
                    Map2_Select = " -warp 2 7 ";
                }
                if (cmbMaps2.Text == "E2M8")
                {
                    Map2_Select = " -warp 2 8 ";
                }
                if (cmbMaps2.Text == "E2M9")
                {
                    Map2_Select = " -warp 2 9 ";
                }
                if (cmbMaps2.Text == "E3M1")
                {
                    Map2_Select = " -warp 3 1 ";
                }
                if (cmbMaps2.Text == "E3M2")
                {
                    Map2_Select = " -warp 3 2 ";
                }
                if (cmbMaps2.Text == "E3M3")
                {
                    Map2_Select = " -warp 3 3 ";
                }
                if (cmbMaps2.Text == "E3M4")
                {
                    Map2_Select = " -warp 3 4 ";
                }
                if (cmbMaps2.Text == "E3M5")
                {
                    Map2_Select = " -warp 3 5 ";
                }
                if (cmbMaps2.Text == "E3M6")
                {
                    Map2_Select = " -warp 3 6 ";
                }
                if (cmbMaps2.Text == "E3M7")
                {
                    Map2_Select = " -warp 3 7 ";
                }
                if (cmbMaps2.Text == "E3M8")
                {
                    Map2_Select = " -warp 3 8 ";
                }
                if (cmbMaps2.Text == "E3M9")
                {
                    Map2_Select = " -warp 3 9 ";
                }
                if (cmbMaps2.Text == "E4M1")
                {
                    Map2_Select = " -warp 4 1 ";
                }
                if (cmbMaps2.Text == "E4M2")
                {
                    Map2_Select = " -warp 4 2 ";
                }
                if (cmbMaps2.Text == "E4M3")
                {
                    Map2_Select = " -warp 4 3 ";
                }
                if (cmbMaps2.Text == "E4M4")
                {
                    Map2_Select = " -warp 4 4 ";
                }
                if (cmbMaps2.Text == "E4M5")
                {
                    Map2_Select = " -warp 4 5 ";
                }
                if (cmbMaps2.Text == "E4M6")
                {
                    Map2_Select = " -warp 4 6 ";
                }
                if (cmbMaps2.Text == "E4M7")
                {
                    Map2_Select = " -warp 4 7 ";
                }
                if (cmbMaps2.Text == "E4M8")
                {
                    Map2_Select = " -warp 4 8 ";
                }
                if (cmbMaps2.Text == "E4M9")
                {
                    Map2_Select = " -warp 4 9 ";
                }
                lblWarp.Text = Map2_Select;

                Properties.Settings.Default.cmbMaps2 = cmbMaps2.Text;
                Properties.Settings.Default.Map2_Select = Map2_Select;
                Properties.Settings.Default.Save();

            }
        }

        private void cmbMaps3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIWADS.Text == "DOOM1: Shareware Doom")
            {
                if (cmbMaps3.Text == "E1M1")
                {
                    Map3_Select = " -warp 1 1 ";
                }
                if (cmbMaps3.Text == "E1M2")
                {
                    Map3_Select = " -warp 1 2 ";
                }
                if (cmbMaps3.Text == "E1M3")
                {
                    Map3_Select = " -warp 1 3 ";
                }
                if (cmbMaps3.Text == "E1M4")
                {
                    Map3_Select = " -warp 1 4 ";
                }
                if (cmbMaps3.Text == "E1M5")
                {
                    Map3_Select = " -warp 1 5 ";
                }
                if (cmbMaps3.Text == "E1M6")
                {
                    Map3_Select = " -warp 1 6 ";
                }
                if (cmbMaps3.Text == "E1M7")
                {
                    Map3_Select = " -warp 1 7 ";
                }
                if (cmbMaps3.Text == "E1M8")
                {
                    Map3_Select = " -warp 1 8 ";
                }
                if (cmbMaps3.Text == "E1M9")
                {
                    Map3_Select = " -warp 1 9 ";
                }

                lblWarp.Text = Map3_Select;

                Properties.Settings.Default.cmbMaps3 = cmbMaps3.Text;
                Properties.Settings.Default.Map3_Select = Map3_Select;
                Properties.Settings.Default.Save();
            }

        }

        private void cmbMaps4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIWADS.Text == "Final Doom: Plutonia Experiment")
            {
                // combobox selection, depends on the selected iwad.
                //these iwads all use the same name convention, eg -warp XX:
                if (cmbMaps4.Text == "MAP01")
                {
                    Map4_Select = " -warp 01 ";
                }

                if (cmbMaps4.Text == "MAP02")
                {
                    Map4_Select = " -warp 02 ";
                }

                if (cmbMaps4.Text == "MAP03")
                {
                    Map4_Select = " -warp 03 ";
                }

                if (cmbMaps4.Text == "MAP04")
                {
                    Map4_Select = " -warp 04 ";
                }

                if (cmbMaps4.Text == "MAP05")
                {
                    Map4_Select = " -warp 05 ";
                }

                if (cmbMaps4.Text == "MAP06")
                {
                    Map4_Select = " -warp 06 ";
                }

                if (cmbMaps4.Text == "MAP07")
                {
                    Map4_Select = " -warp 07 ";
                }

                if (cmbMaps4.Text == "MAP08")
                {
                    Map4_Select = " -warp 08 ";
                }

                if (cmbMaps4.Text == "MAP09")
                {
                    Map4_Select = " -warp 09 ";
                }

                if (cmbMaps4.Text == "MAP10")
                {
                    Map4_Select = " -warp 10 ";
                }

                if (cmbMaps4.Text == "MAP11")
                {
                    Map4_Select = " -warp 11 ";
                }

                if (cmbMaps4.Text == "MAP12")
                {
                    Map4_Select = " -warp 12 ";
                }

                if (cmbMaps4.Text == "MAP13")
                {
                    Map4_Select = " -warp 13 ";
                }

                if (cmbMaps4.Text == "MAP14")
                {
                    Map4_Select = " -warp 14 ";
                }

                if (cmbMaps4.Text == "MAP15")
                {
                    Map4_Select = " -warp 15 ";
                }

                if (cmbMaps4.Text == "MAP16")
                {
                    Map4_Select = " -warp 16 ";
                }

                if (cmbMaps4.Text == "MAP17")
                {
                    Map4_Select = " -warp 17 ";
                }

                if (cmbMaps4.Text == "MAP18")
                {
                    Map4_Select = " -warp 18 ";
                }

                if (cmbMaps4.Text == "MAP19")
                {
                    Map4_Select = " -warp 19 ";
                }

                if (cmbMaps4.Text == "MAP20")
                {
                    Map4_Select = " -warp 20 ";
                }

                if (cmbMaps4.Text == "MAP21")
                {
                    Map4_Select = " -warp 21 ";
                }

                if (cmbMaps4.Text == "MAP22")
                {
                    Map4_Select = " -warp 22 ";
                }

                if (cmbMaps4.Text == "MAP23")
                {
                    Map4_Select = " -warp 23 ";
                }

                if (cmbMaps4.Text == "MAP24")
                {
                    Map4_Select = " -warp 24 ";
                }

                if (cmbMaps4.Text == "MAP25")
                {
                    Map4_Select = " -warp 25 ";
                }

                if (cmbMaps4.Text == "MAP26")
                {
                    Map4_Select = " -warp 26 ";
                }

                if (cmbMaps4.Text == "MAP27")
                {
                    Map4_Select = " -warp 27 ";
                }

                if (cmbMaps4.Text == "MAP28")
                {
                    Map4_Select = " -warp 28 ";
                }

                if (cmbMaps4.Text == "MAP29")
                {
                    Map4_Select = " -warp 29 ";
                }

                if (cmbMaps4.Text == "MAP30")
                {
                    Map4_Select = " -warp 30 ";
                }

                if (cmbMaps4.Text == "MAP31")
                {
                    Map4_Select = " -warp 31 ";
                }

                if (cmbMaps4.Text == "MAP32")
                {
                    Map4_Select = " -warp 32 ";
                }
                lblWarp.Text = Map4_Select;

                Properties.Settings.Default.cmbMaps4 = cmbMaps4.Text;
                Properties.Settings.Default.Map4_Select = Map4_Select;
                Properties.Settings.Default.Save();
            }
        }

        private void cmbMaps5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIWADS.Text == "Final Doom: TNT Evilution")
            {
                // combobox selection, depends on the selected iwad.
                //these iwads all use the same name convention, eg -warp XX:
                if (cmbMaps5.Text == "MAP01")
                {
                    Map5_Select = " -warp 01 ";
                }

                if (cmbMaps5.Text == "MAP02")
                {
                    Map5_Select = " -warp 02 ";
                }

                if (cmbMaps5.Text == "MAP03")
                {
                    Map5_Select = " -warp 03 ";
                }

                if (cmbMaps5.Text == "MAP04")
                {
                    Map5_Select = " -warp 04 ";
                }

                if (cmbMaps5.Text == "MAP05")
                {
                    Map5_Select = " -warp 05 ";
                }

                if (cmbMaps5.Text == "MAP06")
                {
                    Map5_Select = " -warp 06 ";
                }

                if (cmbMaps5.Text == "MAP07")
                {
                    Map5_Select = " -warp 07 ";
                }

                if (cmbMaps5.Text == "MAP08")
                {
                    Map5_Select = " -warp 08 ";
                }

                if (cmbMaps5.Text == "MAP09")
                {
                    Map5_Select = " -warp 09 ";
                }

                if (cmbMaps5.Text == "MAP10")
                {
                    Map5_Select = " -warp 10 ";
                }

                if (cmbMaps5.Text == "MAP11")
                {
                    Map5_Select = " -warp 11 ";
                }

                if (cmbMaps5.Text == "MAP12")
                {
                    Map5_Select = " -warp 12 ";
                }

                if (cmbMaps5.Text == "MAP13")
                {
                    Map5_Select = " -warp 13 ";
                }

                if (cmbMaps5.Text == "MAP14")
                {
                    Map5_Select = " -warp 14 ";
                }

                if (cmbMaps5.Text == "MAP15")
                {
                    Map5_Select = " -warp 15 ";
                }

                if (cmbMaps5.Text == "MAP16")
                {
                    Map5_Select = " -warp 16 ";
                }

                if (cmbMaps5.Text == "MAP17")
                {
                    Map5_Select = " -warp 17 ";
                }

                if (cmbMaps5.Text == "MAP18")
                {
                    Map5_Select = " -warp 18 ";
                }

                if (cmbMaps5.Text == "MAP19")
                {
                    Map5_Select = " -warp 19 ";
                }

                if (cmbMaps5.Text == "MAP20")
                {
                    Map5_Select = " -warp 20 ";
                }

                if (cmbMaps5.Text == "MAP21")
                {
                    Map5_Select = " -warp 21 ";
                }

                if (cmbMaps5.Text == "MAP22")
                {
                    Map5_Select = " -warp 22 ";
                }

                if (cmbMaps5.Text == "MAP23")
                {
                    Map5_Select = " -warp 23 ";
                }

                if (cmbMaps5.Text == "MAP24")
                {
                    Map5_Select = " -warp 24 ";
                }

                if (cmbMaps5.Text == "MAP25")
                {
                    Map5_Select = " -warp 25 ";
                }

                if (cmbMaps5.Text == "MAP26")
                {
                    Map5_Select = " -warp 26 ";
                }

                if (cmbMaps5.Text == "MAP27")
                {
                    Map5_Select = " -warp 27 ";
                }

                if (cmbMaps5.Text == "MAP28")
                {
                    Map5_Select = " -warp 28 ";
                }

                if (cmbMaps5.Text == "MAP29")
                {
                    Map5_Select = " -warp 29 ";
                }

                if (cmbMaps5.Text == "MAP30")
                {
                    Map5_Select = " -warp 30 ";
                }

                if (cmbMaps5.Text == "MAP31")
                {
                    Map5_Select = " -warp 31 ";
                }

                if (cmbMaps5.Text == "MAP32")
                {
                    Map5_Select = " -warp 32 ";
                }
                lblWarp.Text = Map5_Select;

                Properties.Settings.Default.cmbMaps5 = cmbMaps5.Text;
                Properties.Settings.Default.Map5_Select = Map5_Select;
                Properties.Settings.Default.Save();

            }
        }
        private void cmbMaps6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIWADS.Text == "FREEDOOM1: Phase 1")
            {
                // combobox selection, depends on the selected iwad.
                //these iwads all use the same name convention, eg -warp X X:
                if (cmbMaps6.Text == "E1M1")
                {
                    Map6_Select = " -warp 1 1 ";
                }
                if (cmbMaps6.Text == "E1M2")
                {
                    Map6_Select = " -warp 1 2 ";
                }
                if (cmbMaps6.Text == "E1M3")
                {
                    Map6_Select = " -warp 1 3 ";
                }
                if (cmbMaps6.Text == "E1M4")
                {
                    Map6_Select = " -warp 1 4 ";
                }
                if (cmbMaps6.Text == "E1M5")
                {
                    Map6_Select = " -warp 1 5 ";
                }
                if (cmbMaps6.Text == "E1M6")
                {
                    Map6_Select = " -warp 1 6 ";
                }
                if (cmbMaps6.Text == "E1M7")
                {
                    Map6_Select = " -warp 1 7 ";
                }
                if (cmbMaps6.Text == "E1M8")
                {
                    Map6_Select = " -warp 1 8 ";
                }
                if (cmbMaps6.Text == "E1M9")
                {
                    Map6_Select = " -warp 1 9 ";
                }
                if (cmbMaps6.Text == "E2M1")
                {
                    Map6_Select = " -warp 2 1 ";
                }
                if (cmbMaps6.Text == "E2M2")
                {
                    Map6_Select = " -warp 2 2 ";
                }
                if (cmbMaps6.Text == "E2M3")
                {
                    Map6_Select = " -warp 2 3 ";
                }
                if (cmbMaps6.Text == "E2M4")
                {
                    Map6_Select = " -warp 2 4 ";
                }
                if (cmbMaps6.Text == "E2M5")
                {
                    Map6_Select = " -warp 2 5 ";
                }
                if (cmbMaps6.Text == "E2M6")
                {
                    Map6_Select = " -warp 2 6 ";
                }
                if (cmbMaps6.Text == "E2M7")
                {
                    Map6_Select = " -warp 2 7 ";
                }
                if (cmbMaps6.Text == "E2M8")
                {
                    Map6_Select = " -warp 2 8 ";
                }
                if (cmbMaps6.Text == "E2M9")
                {
                    Map6_Select = " -warp 2 9 ";
                }
                if (cmbMaps6.Text == "E3M1")
                {
                    Map6_Select = " -warp 3 1 ";
                }
                if (cmbMaps6.Text == "E3M2")
                {
                    Map6_Select = " -warp 3 2 ";
                }
                if (cmbMaps6.Text == "E3M3")
                {
                    Map6_Select = " -warp 3 3 ";
                }
                if (cmbMaps6.Text == "E3M4")
                {
                    Map6_Select = " -warp 3 4 ";
                }
                if (cmbMaps6.Text == "E3M5")
                {
                    Map6_Select = " -warp 3 5 ";
                }
                if (cmbMaps6.Text == "E3M6")
                {
                    Map6_Select = " -warp 3 6 ";
                }
                if (cmbMaps6.Text == "E3M7")
                {
                    Map6_Select = " -warp 3 7 ";
                }
                if (cmbMaps6.Text == "E3M8")
                {
                    Map6_Select = " -warp 3 8 ";
                }
                if (cmbMaps6.Text == "E3M9")
                {
                    Map6_Select = " -warp 3 9 ";
                }
                if (cmbMaps6.Text == "E4M1")
                {
                    Map6_Select = " -warp 4 1 ";
                }
                if (cmbMaps6.Text == "E4M2")
                {
                    Map6_Select = " -warp 4 2 ";
                }
                if (cmbMaps6.Text == "E4M3")
                {
                    Map6_Select = " -warp 4 3 ";
                }
                if (cmbMaps6.Text == "E4M4")
                {
                    Map6_Select = " -warp 4 4 ";
                }
                if (cmbMaps6.Text == "E4M5")
                {
                    Map6_Select = " -warp 4 5 ";
                }
                if (cmbMaps6.Text == "E4M6")
                {
                    Map6_Select = " -warp 4 6 ";
                }
                if (cmbMaps6.Text == "E4M7")
                {
                    Map6_Select = " -warp 4 7 ";
                }
                if (cmbMaps6.Text == "E4M8")
                {
                    Map6_Select = " -warp 4 8 ";
                }
                if (cmbMaps6.Text == "E4M9")
                {
                    Map6_Select = " -warp 4 9 ";
                }
                lblWarp.Text = Map6_Select;

                Properties.Settings.Default.cmbMaps6 = cmbMaps6.Text;
                Properties.Settings.Default.Map6_Select = Map6_Select;
                Properties.Settings.Default.Save();
            }
        }

        private void cmbMaps7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIWADS.Text == "FREEDOOM2: Phase 2")
            {
                // combobox selection, depends on the selected iwad.
                //these iwads all use the same name convention, eg -warp XX:
                if (cmbMaps7.Text == "MAP01")
                {
                    Map7_Select = " -warp 01 ";
                }

                if (cmbMaps7.Text == "MAP02")
                {
                    Map7_Select = " -warp 02 ";
                }

                if (cmbMaps7.Text == "MAP03")
                {
                    Map7_Select = " -warp 03 ";
                }

                if (cmbMaps7.Text == "MAP04")
                {
                    Map7_Select = " -warp 04 ";
                }

                if (cmbMaps7.Text == "MAP05")
                {
                    Map7_Select = " -warp 05 ";
                }

                if (cmbMaps7.Text == "MAP06")
                {
                    Map7_Select = " -warp 06 ";
                }

                if (cmbMaps7.Text == "MAP07")
                {
                    Map7_Select = " -warp 07 ";
                }

                if (cmbMaps7.Text == "MAP08")
                {
                    Map7_Select = " -warp 08 ";
                }

                if (cmbMaps7.Text == "MAP09")
                {
                    Map7_Select = " -warp 09 ";
                }

                if (cmbMaps7.Text == "MAP10")
                {
                    Map7_Select = " -warp 10 ";
                }

                if (cmbMaps7.Text == "MAP11")
                {
                    Map7_Select = " -warp 11 ";
                }

                if (cmbMaps7.Text == "MAP12")
                {
                    Map7_Select = " -warp 12 ";
                }

                if (cmbMaps7.Text == "MAP13")
                {
                    Map7_Select = " -warp 13 ";
                }

                if (cmbMaps7.Text == "MAP14")
                {
                    Map7_Select = " -warp 14 ";
                }

                if (cmbMaps7.Text == "MAP15")
                {
                    Map7_Select = " -warp 15 ";
                }

                if (cmbMaps7.Text == "MAP16")
                {
                    Map7_Select = " -warp 16 ";
                }

                if (cmbMaps7.Text == "MAP17")
                {
                    Map7_Select = " -warp 17 ";
                }

                if (cmbMaps7.Text == "MAP18")
                {
                    Map7_Select = " -warp 18 ";
                }

                if (cmbMaps7.Text == "MAP19")
                {
                    Map7_Select = " -warp 19 ";
                }

                if (cmbMaps7.Text == "MAP20")
                {
                    Map7_Select = " -warp 20 ";
                }

                if (cmbMaps7.Text == "MAP21")
                {
                    Map7_Select = " -warp 21 ";
                }

                if (cmbMaps7.Text == "MAP22")
                {
                    Map7_Select = " -warp 22 ";
                }

                if (cmbMaps7.Text == "MAP23")
                {
                    Map7_Select = " -warp 23 ";
                }

                if (cmbMaps7.Text == "MAP24")
                {
                    Map7_Select = " -warp 24 ";
                }

                if (cmbMaps7.Text == "MAP25")
                {
                    Map7_Select = " -warp 25 ";
                }

                if (cmbMaps7.Text == "MAP26")
                {
                    Map7_Select = " -warp 26 ";
                }

                if (cmbMaps7.Text == "MAP27")
                {
                    Map7_Select = " -warp 27 ";
                }

                if (cmbMaps7.Text == "MAP28")
                {
                    Map7_Select = " -warp 28 ";
                }

                if (cmbMaps7.Text == "MAP29")
                {
                    Map7_Select = " -warp 29 ";
                }

                if (cmbMaps7.Text == "MAP30")
                {
                    Map7_Select = " -warp 30 ";
                }

                if (cmbMaps7.Text == "MAP31")
                {
                    Map7_Select = " -warp 31 ";
                }

                if (cmbMaps7.Text == "MAP32")
                {
                    Map7_Select = " -warp 32 ";
                }
                lblWarp.Text = Map7_Select;

                Properties.Settings.Default.cmbMaps7 = cmbMaps7.Text;
                Properties.Settings.Default.Map7_Select = Map7_Select;
                Properties.Settings.Default.Save();
            }
        }


        #endregion

        #region //Skill Monsters and GameMode Select 
        private void cmbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSkills.Text == "Skill 1")
            {
                Skill_Select = " -skill 1 ";
            }
            if (cmbSkills.Text == "Skill 2")
            {
                Skill_Select = " -skill 2 ";
            }
            if (cmbSkills.Text == "Skill 3")
            {
                Skill_Select = " -skill 3 ";
            }
            if (cmbSkills.Text == "Skill 4")
            {
                Skill_Select = " -skill 4 ";
            }
            if (cmbSkills.Text == "Skill 5")
            {
                Skill_Select = " -skill 5 ";
            }
            lblSkill.Text = Skill_Select;
            lblSkill.ForeColor = Color.Black;

            Properties.Settings.Default.cmbSkills = cmbSkills.Text;
            Properties.Settings.Default.Skill_Select = Skill_Select;
        }

        private void cmbMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMonsters.Text == "Normal")
            {
                Monsters_Select = "";
                lblMonsters.ForeColor = Color.DarkSlateGray;
                lblMonsters.Text = " Normal Monsters ";
            }
            if (cmbMonsters.Text == "Respawn")
            {
                Monsters_Select = " -respawn ";
                lblMonsters.ForeColor = Color.Black;
                lblMonsters.Text = " -respawn ";
            }
            if (cmbMonsters.Text == "No Monsters")
            {
                Monsters_Select = " -nomonsters ";
                lblMonsters.ForeColor = Color.Black;
                lblMonsters.Text = " -nomonsters ";
            }

            Properties.Settings.Default.cmbMonsters = cmbMonsters.Text;
            Properties.Settings.Default.Monsters_Select = Monsters_Select;

        }

        private void cmbGameMods_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGameMods.Text == "Single Player")
            {
                GameMods_Select = "";
                lblGameMode.ForeColor = Color.DarkSlateGray;
                lblGameMode.Text = " Single Player";
            }
            if (cmbGameMods.Text == "Deathmatch")
            {
                GameMods_Select = " -deathmatch ";
                lblGameMode.ForeColor = Color.Black;
                lblGameMode.Text = " -deathmatch ";
            }
            if (cmbGameMods.Text == "Alt-Death")
            {
                GameMods_Select = " -altdeath ";
                lblGameMode.ForeColor = Color.Black;
                lblGameMode.Text = " -altdeath ";
            }
            if (cmbGameMods.Text == "Solo-Net Single Player")
            {
                GameMods_Select = " -solo-net ";
                lblGameMode.ForeColor = Color.Black;
                lblGameMode.Text = " -solo-net ";
            }
            if (cmbGameMods.Text == "Solo-Net Deathmatch")
            {
                GameMods_Select = " -solo-net -deathmatch";
                lblGameMode.ForeColor = Color.Black;
                lblGameMode.Text = " -solo-net -deathmatch";
            }
            if (cmbGameMods.Text == "Solo-Net Alt-Death")
            {
                GameMods_Select = " -solo-net -altdeath";
                lblGameMode.ForeColor = Color.Black;
                lblGameMode.Text = " -solo-net -altdeath";
            }

            Properties.Settings.Default.cmbGameMods = cmbGameMods.Text;
            Properties.Settings.Default.GameMods_Select = GameMods_Select;

        }
        #endregion

        #region //Set Mouse Over [Info in the Status Strip] for most controls..
        private void btnLoadPwads_MouseEnter(object sender, EventArgs e)
        {
           StatusInfo.Text = "Click to Load Pwad files..";
        }

        private void btnLoadPwads_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void btnLoadDeh_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Click to Load Deh files..";
        }

        private void btnLoadDeh_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void chkEnableRemoveAll_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Disables the [Remove All] buttons as a safe gaurd. ~ Disabled by Default..";
        }

        private void chkEnableRemoveAll_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }


        private void LoadPwads_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Currently Loaded Pwads Path ~ Also supports Drag n' Drop..";
        }

        private void LoadPwads_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void LoadDeh_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Currently Loaded Deh Path ~ Also supports Drag n' Drop..";
        }

        private void LoadDeh_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void lstRecent_Pwads_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Loaded Pwad Files [Record Keeping] ~ Stores up to 50 entries Max..";
        }

        private void lstRecent_Pwads_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void lstRecent_Deh_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Loaded Deh Files [Record Keeping] ~ Stores up to 50 entries Max..";
        }

        private void lstRecent_Deh_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            StatusInfo.Text = "Recently Loaded Files ~ Select Files without having to load them again...";
        }

        private void lstIWADS_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Detected IWADs: [Select an IWAD] to Play!";
        }

        private void lstIWADS_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void btnIWADSLocation_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "IWAD Location: Add the Location where you keep your IWADs!";
        }

        private void btnIWADSLocation_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void BtnEngineLocation_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "The Engine Location has not yet been detected.. Click to Load its Location.";
        }

        private void BtnEngineLocation_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void Logo_Box_MouseEnter(object sender, EventArgs e)
        {
            StatusInfo.Text = "Your Managed Doom Engine has been located.. Click to check for Updates!";
        }

        private void Logo_Box_MouseLeave(object sender, EventArgs e)
        {
            StatusInfo.Text = "";
        }

        private void Logo_Box_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/sinshu/managed-doom/releases/tag/v2.1a");
        }



        #endregion



    }
}
