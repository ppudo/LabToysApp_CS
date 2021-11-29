using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabToys.CTS;

namespace CTS.ASCII_Proto_ETH
{
    public partial class HomePanel : UserControl
    {
        public HomePanel( LabToys.CTS.ASCII_Proto_ETH device, string lang="" )
        {
            InitializeComponent();

            //set properties for panel and some of elements
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //save variables
            this.device = device;

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);

            //set some variables

            //add memories to panel
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private LabToys.CTS.ASCII_Proto_ETH device = null;

        #region FUNCTIONS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Set text elements in panel based on selected language
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

            //change label in panel
        }

        //-----------------------------------------------------------------------------------------
        public void ChangeLanguage(string lang)
        {
            SetLanguage(lang);
        }

        //-----------------------------------------------------------------------------------------
        public void DisplayDeviceStatus()
        {
            
        }

        #endregion


        #region ACTION_ITEMS
        //-------------------------------------------------------------------------------------------------------------------------------------------

        #endregion

        #region DELEGATES
        //-------------------------------------------------------------------------------------------------------------------------------------------
        //  DDDD  EEEEE L     EEEEE  GGG    A   TTTTT EEEEE  SSS
        //  D   D E     L     E     G      A A    T   E     S
        //  D   D EEE   L     EEE   G  GG A   A   T   EEE    SSS
        //  D   D E     L     E     G   G AAAAA   T   E         S
        //  DDDD  EEEEE LLLLL EEEEE  GGG  A   A   T   EEEEE  SSS
        //

        #endregion
    }
}
