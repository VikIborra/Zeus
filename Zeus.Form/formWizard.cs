﻿using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Zeus
{
    public partial class formWizard : MaterialForm
    {
        public formWizard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnIniciar_Click(object sender, System.EventArgs e)
        {
            new formPrincipal().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            tab.SelectTab(2);
        }

        private void formWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExemplo_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Form fc = Application.OpenForms["formConnectionString"];
            if (fc == null)
                new formConnectionString()
                {
                    ConnectionString = txtConnectionString,
                    Oracle = radioSGBD1,
                    Sql = radioSGBD2,
                    Mysql = radioSGBD3,
                    Firebird = radioSGBD4,
                    Postgre = radioSGBD5
                }.ShowDialog();
            else
            {
                fc.Close();
                new formConnectionString()
                {
                    ConnectionString = txtConnectionString,
                    Oracle = radioSGBD1,
                    Sql = radioSGBD2,
                    Mysql = radioSGBD3,
                    Firebird = radioSGBD4,
                    Postgre = radioSGBD5
                }.ShowDialog();
            }
        }

        private void materialRaisedButton2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
