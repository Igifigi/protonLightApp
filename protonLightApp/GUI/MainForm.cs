using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using protonLightApp.GUI;
using protonLightApp.Model;
using protonLightApp.Utils;

namespace protonLightApp
{
    public partial class MainForm : Form
    {
        private Cache cache;
        public MainForm()
        {
            InitializeComponent();
            GetData();
        }
        
        private void GetData()
        {
            LoadingForm loadingForm = new LoadingForm();
            var result = loadingForm.ShowDialog();
            if (result != DialogResult.OK)
                Close();
            cache = loadingForm.cache;
        }


    }
}
