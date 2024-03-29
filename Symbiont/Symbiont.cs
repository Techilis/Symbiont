﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Symbiont
{
    public partial class Symbiont : Form
    {
        //Creates place to store Player object, underscore to signify private variable
        private Player _player;
        public Symbiont() //Constructor
        {
            InitializeComponent();

            // Custom constructor located in Location.cs
            Location location = new Location(1, "Home", "This is your house.");

            //Creates new player object and assigns obect to the _player variable created earlier
            _player = new Player(10, 10, 20, 0, 1);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

    }
}
