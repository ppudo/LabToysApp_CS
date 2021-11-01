using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaElektronika.PSC_ETH
{
    public partial class HelpPanel : UserControl
    {
        public HelpPanel( string lang="" )
        {
            InitializeComponent();

            //set properties for panel and some of elements
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;

            //set language version and disable and enable some controls depends on options
            SetLanguage(lang);

            //add items to list
            items = new ItemDesription[]
            {
                new ItemDesription("SM800 outputs", ItemDesription.GetImageControl( Images.Delta_SM800_outputs ) ),
                new ItemDesription("SM800 switches", ItemDesription.GetImageControl( Images.Delta_SM800_switches ) ),
                new ItemDesription("SM800 analog connector", ItemDesription.GetImageControl( Images.Delta_SM800_analog_prog ) ),
                new ItemDesription("PSC-ETH-2 IO pinout", ItemDesription.GetImageControl( Images.PSC_ETH_2_IO_pinout ) )
            };

            for( int i=0; i<items.Length; i++ )
            {
                lbItems.Items.Add(items[i]);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private ItemDesription[] items = null;

        #region FUNCTIONS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Set text elements in panel based on selected language
        /// </summary>
        /// <param name="lang">Selected language</param>
        public void SetLanguage(string lang)
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
        #endregion

        #region ACTION_ITEMS
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            if(list.SelectedItem != null )
            {
                ItemDesription item = (ItemDesription)list.SelectedItem;
                scHelp.Panel2.Controls.Clear();
                scHelp.Panel2.Controls.Add(item.Item);
            }
        }
        #endregion

        #region CLASSES
        //-------------------------------------------------------------------------------------------------------------------------------------------
        private class ItemDesription
        {
            public ItemDesription( string text, Control item=null )
            {
                this.text = text;
                this.item = item;
            }

            //------------------------------------------------------------
            private string text = "";
            private Control item = null;

            //-----------------------------------
            public string Text { get => text; }
            public Control Item { get => item; }

            //------------------------------------------------------------
            public override string ToString()
            {
                return text;
            }

            //-----------------------------------
            public static Control GetImageControl( Bitmap image )
            {
                return new PictureBox()
                {
                    Dock = DockStyle.Fill,
                    BackgroundImage = image,
                    BackgroundImageLayout = ImageLayout.Zoom
                };
            }
        }
        #endregion
    }
}
