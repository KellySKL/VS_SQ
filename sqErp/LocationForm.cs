using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sqErp
{
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("http://www.baidu.com");
        }
    }
}
