using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace ShooterGame
{
    public partial class FormCharacterChoice : Form
    {
        private void FormCharacterChoice_Load(object sender, EventArgs e)
        {
            picFairy.Image = Image.FromFile(@"Resources\pp of fairy.png");
            picSoldier.Image = Image.FromFile(@"Resources\pp of soldier.png");
            picOldman.Image = Image.FromFile(@"Resources\pp of oldman.png");
        }

        Player player;
        private string playerName;
        private FormMenu menuForm;
        public FormCharacterChoice(FormMenu menu, string playerName)
        {
            InitializeComponent();
            this.menuForm = menu;
            this.playerName = playerName;
        }
        private void picFairy_Click(object sender, EventArgs e)
        {
            player = new Fairy(playerName, 2, 30);
            this.Hide();
            FormGame gameform = new FormGame(menuForm, playerName, player);
            gameform.Show();
        }
        private void picSoldier_Click(object sender, EventArgs e)
        {
            player = new Soldier(playerName, 2, 30);
            this.Hide();
            FormGame gameform = new FormGame(menuForm, playerName, player);
            gameform.Show();
        }

        private void picOldman_Click(object sender, EventArgs e)
        {
            player = new OldMan(playerName, 2, 30); 
            this.Hide();
            FormGame gameform = new FormGame(menuForm, playerName, player);
            gameform.Show();
        }

        private void picFairy_MouseEnter(object sender, EventArgs e)
        {
            lblFairyHealth.Visible = true;
            lblFairyAttack.Visible = true;
        }

        private void picFairy_MouseLeave(object sender, EventArgs e)
        {
            lblFairyHealth.Visible = false;
            lblFairyAttack.Visible = false;
        }

        private void picSoldier_MouseEnter(object sender, EventArgs e)
        {
            lblSoldierHealth.Visible = true;
            lblSoldierAttack.Visible = true;
        }

        private void picSoldier_MouseLeave(object sender, EventArgs e)
        {
            lblSoldierHealth.Visible = false;
            lblSoldierAttack.Visible = false;
        }

        private void picOldman_MouseEnter(object sender, EventArgs e)
        {
            lblOldmanHealth.Visible = true;
            lblOldmanAttack.Visible = true;
        }

        private void picOldman_MouseLeave(object sender, EventArgs e)
        {
            lblOldmanHealth.Visible = false;
            lblOldmanAttack.Visible = false;
        }
    }
}
