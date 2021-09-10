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
        private SpeechSynthesizer _speechHandler;
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            _speechHandler = new SpeechSynthesizer();
            btn_Resume.Enabled = false;
            btn_Pause.Enabled = false;
            btn_Quit.Enabled = false;
        }

        private void btn_Talk_Click(object sender, EventArgs e)
        {
            _speechHandler.Dispose();
            if (inputTextBox.Text != "")
            {
                _speechHandler = new SpeechSynthesizer();
                _speechHandler.SpeakAsync(inputTextBox.Text);
                btn_Pause.Enabled = true;
                btn_Quit.Enabled = true;
            }
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (_speechHandler != null)
            {
                if (_speechHandler.State == SynthesizerState.Speaking)
                {
                    _speechHandler.Pause();
                    btn_Resume.Enabled = true;
                    btn_Talk.Enabled = false;
                }
            }
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            if (_speechHandler != null)
            {
                if (_speechHandler.State == SynthesizerState.Paused)
                {
                    _speechHandler.Resume();
                    btn_Resume.Enabled = false;
                    btn_Talk.Enabled = true;
                }
            }
        }
    }
}
