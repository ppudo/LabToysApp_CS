using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DS1000Z;

namespace LabToysApp
{
    public partial class AddDeviceForm : Form
    {
        public AddDeviceForm(string lang = "", bool debug = false)
        {
            InitializeComponent();

            //set properties at start
            this.DialogResult = DialogResult.Cancel;
            this.LANGUAGE = lang;
            this.DEBUG = debug;

            //set window language
            SetLanguage(LANGUAGE);

            //load manufacturers
            LoadManufacturers();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private string LANGUAGE = "";
        private bool DEBUG = false;
        private TreeNode deviceNode = null;

        public TreeNode DeviceNode { get => deviceNode; }

        //-------------------------------------------------------------------------------------------------------------------------------------------
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
            this.Text = Lang.AddDeviceForm.AddDeviceForm_Text;
            this.btCancel.Text = Lang.AddDeviceForm.btCancel_Text;
            this.btNext.Text = Lang.AddDeviceForm.btNext_Text;
            this.lbManufacturer.Text = Lang.AddDeviceForm.lbManufacturer_Text;
            this.lbModel.Text = Lang.AddDeviceForm.lbModel_Text;
        }

        //-----------------------------------------------------------------------------------------
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //-----------------------------------------------------------------------------------------
        private void btNext_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Enabled)
            {
                Dictionary<int, Type> models = (Dictionary<int, Type>)cbModel.Tag;
                Type formType = models[cbModel.SelectedIndex];

                Form form = (Form)Activator.CreateInstance(formType, new object[] { LANGUAGE, DEBUG });
                if (form.ShowDialog() == DialogResult.OK)
                {
                    deviceNode = new TreeNode(form.Text, 0, 2);
                    deviceNode.Tag = form.Tag;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void cbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<int, Model[]> dictonary = (Dictionary<int, Model[]>)cbManufacturer.Tag;
            Model[] models = dictonary[cbManufacturer.SelectedIndex];

            Dictionary<int, Type> modelDictionary = new Dictionary<int, Type>();

            for (int i = 0; i < models.Length; i++)
            {
                int idx = cbModel.Items.Add(models[i].Name);
                modelDictionary.Add(idx, models[i].Form);
            }
            cbModel.Tag = modelDictionary;
            cbModel.Enabled = true;
        }

        //-----------------------------------------------------------------------------------------
        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btNext.Enabled = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void LoadManufacturers()
        {
            Dictionary<int, Model[]> dictonary = new Dictionary<int, Model[]>();

            for (int i = 0; i < manufacturers.Length; i++)
            {
                int idx = cbManufacturer.Items.Add(manufacturers[i].Name);
                dictonary.Add(idx, manufacturers[i].Models);
            }
            cbManufacturer.Tag = dictonary;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private class Model
        {
            public Model(string modelName, Type addForm)
            {
                name = modelName;
                form = addForm;
            }

            private string name = "";
            private Type form = null;

            public string Name { get => name; }
            public Type Form { get => form; }
        }

        //-----------------------------------------------------------------------------------------
        private class Manufacturer
        {
            public Manufacturer(string manufacturerName, Model[] modelsTab)
            {
                name = manufacturerName;
                models = modelsTab;
            }

            private string name = "";
            private Model[] models = new Model[0];

            public string Name { get => name; }
            public Model[] Models { get => models; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        // RIGOL
        private readonly static Model[] rigol = new Model[]
        {
            new Model( "DS1000Z", typeof( DS1000Z.AddForm ) )
        };

        //-----------------------------------------------------------------------------------------
        //private readonly static Model[] deltaElektronika = new Model[]
        //{
        //    new Model( "PSC-ETH", typeof( DS1000Z. ) )
        //};

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private Manufacturer[] manufacturers = new Manufacturer[]
        {
            //new Manufacturer( "Delta Elektronika", deltaElektronika ),
            new Manufacturer( "Rigol", rigol )
        };
    }
}
