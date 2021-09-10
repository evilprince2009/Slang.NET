using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slang.NET
{
    public partial class AppForm : Form
    {
        private SpeechSynthesizer SpeechHandler;
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            SpeechHandler = new SpeechSynthesizer();
            btn_Resume.Enabled = false;
            btn_Pause.Enabled = false;
            btn_Quit.Enabled = false;
        }
    }
}
