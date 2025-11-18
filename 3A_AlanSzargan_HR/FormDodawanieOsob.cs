using _3A_AlanSzargan_HR.LogowanieOsoby;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A_AlanSzargan_HR
{
    public partial class FormDodawanieOsob : Form
    {
        public FormDodawanieOsob()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Role.Rola));

        }
    }
}
