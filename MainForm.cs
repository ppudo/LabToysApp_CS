using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using DebugDevice;

namespace LabToysApp
{
    public partial class MainForm : Form
    {
        public MainForm( string[] args )
        {
            InitializeComponent();

            //check for arguments
            CheckArguments(args);

            //set program aspect acording to arguments and options
            SetLanguage(LANGUAGE);
            SetAspect();
        }

        //*****************************************************************************************
        /// <summary>
        /// Language in app, empty string is used as default
        /// </summary>
        private string LANGUAGE = "";

        /// <summary>
        /// Indicator for debug options. Can be changed by argument during run application
        /// </summary>
        private bool DEBUG = false;

        #region ACTIONS_ITEM
        //*******************************************************************************************************************************************
        //   A    CCC  TTTTT III  OOO  N   N       III TTTTT EEEEE M   M  SSS
        //  A A  C   C   T    I  O   O NN  N        I    T   E     MM MM S
        // A   A C       T    I  O   O N N N        I    T   EEE   M M M  SSS
        // AAAAA C   C   T    I  O   O N  NN        I    T   E     M   M     S
        // A   A  CCC    T   III  OOO  N   N       III   T   EEEEE M   M  SSS
        //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm(LANGUAGE);
            form.ShowDialog();
        }

        //-----------------------------------------------------------------------------------------
        private void tsmiGit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            System.Diagnostics.Process.Start((string)item.Tag);
        }

        //-----------------------------------------------------------------------------------------
        //LANGUAGE OPTIONS
        //-----------------------------------------------------------------------------------------
        private void tsmiLangDefault_Click(object sender, EventArgs e)
        {
            LANGUAGE = "";
            SetLanguage(LANGUAGE);
        }

        //---------------------------------------
        private void tsmiLangEnglish_Click(object sender, EventArgs e)
        {
            LANGUAGE = "en-EN";
            SetLanguage(LANGUAGE);
        }

        //---------------------------------------
        private void tsmiLangPoland_Click(object sender, EventArgs e)
        {
            LANGUAGE = "pl-PL";
            SetLanguage(LANGUAGE);
        }

        //-----------------------------------------------------------------------------------------
        //DEVICES
        //-----------------------------------------------------------------------------------------
        private void btAddDevice_Click(object sender, EventArgs e)
        {
            AddDeviceForm form = new AddDeviceForm(LANGUAGE, DEBUG);
            if( form.ShowDialog() == DialogResult.OK )
            {
                if( form.DeviceNode != null )
                {
                    tvDevices.Nodes.Add(form.DeviceNode);
                    tvDevices.SelectedNode = form.DeviceNode;
                }
            }
        }

        //---------------------------------------
        private void btDeleteDevice_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------
        private void btSeparateWindow_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------
        private void tvDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if( e.Node.Parent == null )
            {
                scMain.Panel2.Controls.Clear();
                scMain.Panel2.Controls.Add((Control)e.Node.Tag);
            }
        }

        #endregion

        #region FUNCTIONS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        // FFFFF U   U N   N  CCC  TTTTT III  OOO  N   N  SSS
        // F     U   U NN  N C   C   T    I  O   O NN  N S
        // FFF   U   U N N N C       T    I  O   O N N N  SSS
        // F     U   U N  NN C   C   T    I  O   O N  NN     S
        // F      UUU  N   N  CCC    T   III  OOO  N   N  SSS
        //

        /// <summary>
        /// Check arguments list and set variables in program
        /// </summary>
        /// <param name="args">List of arguments given by user</param>
        private void CheckArguments(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    //***** DEBUG
                    case "-d":
                        DEBUG = true;
                        break;
                    //***** LANGUAGE
                    case "-l":
                        if ((args.Length > (i + 1)) && (args[i + 1][0] != '-'))        //check for second part of this arguments, if there is another arguments then leave this command
                        {
                            i++;
                            switch (args[i])
                            {
                                case "PL":
                                    LANGUAGE = "pl-PL";
                                    break;
                                case "EN":
                                    LANGUAGE = "en-EN";
                                    break;
                            }
                        }
                        break;
                    //*****
                    default:
                        break;
                }
            }
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Set text elements in app based on selected language
        /// </summary>
        /// <param name="lang">Selected language</param>
        private void SetLanguage(string lang)
        {
            if (lang == "")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.InstalledUICulture.Name);
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            }

            //-----------------------------------
            //change label in app
            this.Text = Lang.MainForm.MainForm_Text;

            //msMain
            this.tsmiFile.Text = Lang.MainForm.tsmiFile_Text;
            this.tsmiAbout.Text = Lang.MainForm.tsmiAbout_Text;
            this.tsmiLanguage.Text = Lang.MainForm.tsmiLanguage_Text;
            this.tsmiLangDefault.Text = Lang.MainForm.tsmiLangDefault_Text;
            this.tsmiLangEnglish.Text = Lang.MainForm.tsmiLangEnglish_Text;
            this.tsmiLangPoland.Text = Lang.MainForm.tsmiLangPoland_Text;

            //buttons
            this.ttTipMain.SetToolTip(btAddDevice, Lang.MainForm.btAddDevice_ToolTip);
            this.ttTipMain.SetToolTip(btDeleteDevice, Lang.MainForm.btDeleteDevice_ToolTip);
            this.ttTipMain.SetToolTip(btSeparateWindow, Lang.MainForm.btSeparateWindow_ToolTip);

            //-----------------------------------
            //clear all checked for langage options
            tsmiLangDefault.Checked = false;
            tsmiLangEnglish.Checked = false;
            tsmiLangPoland.Checked = false;

            //set checked for language options
            switch (lang)
            {
                case "en-EN":
                    tsmiLangEnglish.Checked = true;
                    break;
                case "pl-PL":
                    tsmiLangPoland.Checked = true;
                    break;
                default:
                    tsmiLangDefault.Checked = true;
                    break;
            }
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Set displayed layout for program depend on set variables in program
        /// </summary>
        private void SetAspect()
        {
            if (!DEBUG)
            {
                //Debug mode disabled
            }
            else
            {
                //Debug mode enabled
                this.Text = this.Text + " - v" + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
                                                Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." +
                                                Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() + "." +
                                                Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();

                //Add debug device
                TreeNode debugNode = new TreeNode("Debug", 1, 0);
                debugNode.Tag = new DebugDevice.DevicePanel(LANGUAGE);
                tvDevices.Nodes.Add(debugNode);
                tvDevices.SelectedNode = debugNode;
            }
        }

        #endregion

        
    }
}
