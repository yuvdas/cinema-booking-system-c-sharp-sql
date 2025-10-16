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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxBob_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "2";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxWonka_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "9";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxDrive_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "3";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxDune_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "1";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxGhostbusters_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "4";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxImaginary_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "6";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxGodzilla_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "5";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxKraven_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "7";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxMigration_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "8";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }

        private void pictureBoxKung_Click(object sender, EventArgs e)
        {
            GlobalVariables._globalFilmID = "10";//sets variable to corresponding filmID in films database
            Form FilmDetails = new FilmDetails();//creates film details form
            FilmDetails.ShowDialog();//displays form
        }
    }
}
