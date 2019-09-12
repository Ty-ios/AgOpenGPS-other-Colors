﻿using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormMakeBndCon : Form
    {
        //access to the main GPS form and all its variables
        private readonly FormGPS mf;

        public FormMakeBndCon(Form _mf)
        {
            mf = _mf as FormGPS;
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            mf.ct.BuildBoundaryContours((int)nudPass.Value, (int)nudSpacing.Value);
            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}