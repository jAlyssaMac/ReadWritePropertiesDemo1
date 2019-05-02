﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {

        Balloon myFirstBalloon;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                //I must instantiate my object
                myFirstBalloon = new Balloon() {

                    Colour = txtColor.Text.Trim(),
                    Height = Convert.ToDecimal(txtHeight.Text),
                    Diameter = Convert.ToDecimal(txtDiameter.Text)

                };

                //myFirstBalloon.Colour = txtColor.Text.Trim();.Text);
                //myFirstBalloon.Height = Convert.ToDecimal(txtHeight.Text);
                //myFirstBalloon.Diameter = Convert.ToDecimal(txtDiameter.Text);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lblOutput.Text = $"Colour: {myFirstBalloon.Colour}\n" +
                $"Height: {myFirstBalloon.Height.ToString()}\n" +
                $"Diameter: {myFirstBalloon.Diameter.ToString()}";
        }
    }
}
