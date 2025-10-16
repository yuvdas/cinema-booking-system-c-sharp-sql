using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingSystem
{
    public partial class FilmDetails : Form
    {
        public FilmDetails()
        {
            InitializeComponent();
            if (GlobalVariables._globalFilmID == "1")//sets global variables to FilmID
            {
                pictureBoxDune.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "2")//sets global variables to FilmID
            {
                pictureBoxBob.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "3")//sets global variables to FilmID
            {
                pictureBoxDrive.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "4")//sets global variables to FilmID
            {
                pictureBoxGhostbusters.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "5")//sets global variables to FilmID
            {
                pictureBoxGodzilla.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "6")//sets global variables to FilmID
            {
                pictureBoxImaginary.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "7")//sets global variables to FilmID
            {
                pictureBoxKraven.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "8")//sets global variables to FilmID
            {
                pictureBoxMigration.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "9")//sets global variables to FilmID
            {
                pictureBoxWonka.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
            if (GlobalVariables._globalFilmID == "10")//sets global variables to FilmID
            {
                pictureBoxKung.Visible = true;//make selected film visible
                label1.Text = Db.GetDetailsFilmTitle(GlobalVariables._globalFilmID);//displays corresponding film title to filmID from database
                textBoxFilmDescription.Text = Db.GetDetailsFilmDescription(GlobalVariables._globalFilmID);//displays corresponding film description to filmID from database
            }
        }

        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxEmail.Text.Length > 0)//if details are entered
            {
                Db.ADDDetailsCustomers(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text);//adds customer details to database
                Db.ADDDetailsOrders(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, GlobalVariables._globalFilmID);//adds customer order to database
                textBoxFirstName.Text = "";//resets textbox
                textBoxLastName.Text = "";//resets textbox
                textBoxEmail.Text = "";//resets textbox
            }
            else
            {
                MessageBox.Show("Invalid Input");//outputs error
                textBoxFirstName.Text = "";//resets textbox
                textBoxLastName.Text = "";//resets textbox
                textBoxEmail.Text = "";//resets textbox
            }
        }




    }
}
