using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losowanieAleWWinForms {
    public partial class oMnie : Form {
        public oMnie() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://github.com/konmedy/losowanie");
        }
    }
}
