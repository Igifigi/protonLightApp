using protonLightApp.Model;
using protonLightApp.Utils;
using System;
using System.Windows.Forms;

namespace protonLightApp.GUI
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        //jeśli będą problemy zmień na public
        internal Cache cache { get; set; }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            Log("Wczytywanie okna.");
            LoadChache();
            Submit();
        }

        private void LoadChache()
        {
            try
            {
                Log("Ładowanie pamięci podręcznej...");
                cache = Cache.LoadCache();
                Log("Pomyślnie załadowano pamięć podręczną.");
            }
            catch (Exception e)
            {
                string message = "Nie udało się załadować pamięci podręcznej. Więcej szczegółów: " + e.Message;
                Log(message);
                MessageBoxes.ShowErrorBox(message);
                Close();
            }
        }

        private void Submit()
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Log(string message)
        {
            LogTextBox.AppendText(message);
            LogTextBox.AppendText(Environment.NewLine);
        }
    }
}
