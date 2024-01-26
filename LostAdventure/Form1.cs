using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        SoundPlayer sp;

        public Form1()
        {
            InitializeComponent();

            outputLabel.Text = "This is a story of a man named Stanley. Stanley worked for a company in a big building where he was D-class #427";
            option1Label.Text = "go forward";
            option2Label.Text = "go backward";

            imageBox.Image = Properties.Resources.scp_door2;

            sp = new SoundPlayer(Properties.Resources.alarm);
            sp.Play();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            
            if (page == 1) 
            { 
                page = 2;
            }
            else if (page == 2) 
            {
                page = 4;
            }
            else if (page == 3) 
            {
                page = 1;
            }
            else if (page == 4) 
            {
                page = 6;
            }
            else if (page == 5) 
            {
                page = 2;
            }
            else if (page == 6) 
            {
                page = 7;
            }
            else if (page == 7) 
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 1;
            }

            else if (page == 9)
            {
                page = 1;

            }
            else if (page == 10)
            {
                page = 1;
            }
             else if (page == 11)

            {

                page = 1;
            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "This is a story of a man named Stanley. Stanley worked for a company in a big building where he was D-class #427";
                    option1Label.Text = "go forward";
                    option2Label.Text = "go backward";

                    imageBox.Image = Properties.Resources.scp_door2;

                    sp = new SoundPlayer(Properties.Resources.alarm);
                    sp.Play();
                    break;
                case 2:
                    outputLabel.Text = "Stanley started to walk around he then entered a room with two doors one is just a broom closet but the other seems to be locked";
                    option1Label.Text = "brooms door";
                    option2Label.Text = "locked door";
                    imageBox.Image = Properties.Resources.doors;


                    sp = new SoundPlayer(Properties.Resources.alarm);
                    sp.Play();

                    break;
                case 3:
                 //   outputLabel.Text = "You fall in a pit and die. Play again?";
                 //   option1Label.Text = "Yes";
                 //   option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "Stanley stepped into the broom closet, but there was nothing here, so he turned around and got back on track ";
                    option2Label.Text = "fine";
                    option1Label.Text = "No i didnt";

                    imageBox.Image = Properties.Resources.broom;
                    sp = new SoundPlayer(Properties.Resources.The_Stanley_Parable);
                    sp.Play();

                    break;
                case 5:
                    outputLabel.Text = "the door is locked?";
                    option1Label.Text = "go to closet";
                    option2Label.Text = "";
                    break;
                case 6:

                    outputLabel.Text = "you hear screaming and a loud cash outside the door you wait a minute then leave?";
                    option2Label.Text = "...";
                    option1Label.Text = "leave";
                    imageBox.Image = Properties.Resources.broom;
                    break;
                case 7:
                 outputLabel.Text = "whatever it was its gone now you see it opened the other door";
                    option1Label.Text = "closet";
                    option2Label.Text = "go through";
              
                    imageBox.Image = Properties.Resources.OIGy;
                    break;
                case 8:
                    outputLabel.Text = " you hear screaming and a loud cash outside the door you wait a minute the leave?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "heck no";
                    break;
                case 9:
                 outputLabel.Text = "no Stanley the closet is a bad influents on you. think about it then restart";
                 option1Label.Text = "";
                 option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(4000);
                    this.Close();
                    break;
                case 11:
                    break;
                    outputLabel.Text = "you step towards the door it opens and guards come rushing out before you could say anything the opened fire they said there sorry";
                    option1Label.Text = "thanks";
                    option2Label.Text = "for playing";
                    Refresh();
                    Thread.Sleep(4000);
                    this.Close();

                    //      break;
                    //  case 10:

                    //       break;
                    //   case 11:

                    //       break;
                    //  case 12:
                    //       break;
                    //  case 99:
                    //      break;
                    //  case 99:


                    Refresh();
                    Thread.Sleep(4000);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {

                page = 3;

            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 2; //check this
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 1;
            }

            else if (page == 9)
            {
                page = 1;

            }
            else if (page == 10)
            {
                page = 9;
            }
             else if (page == 11)
            {
                page = 1;

            }
                /// Display text and game options to screen based on the 
                /// current page

                switch (page)
            {
                case 1:
                    outputLabel.Text = "This is a story of a man named Stanley. Stanley worked for a company in a big building where he was D-class #427";
                    option1Label.Text = "go forward";
                    option2Label.Text = "go backward";

                    imageBox.Image = Properties.Resources.scp_door2;

                    sp = new SoundPlayer(Properties.Resources.alarm);
                    sp.Play();
                    break;
                case 2:
                    outputLabel.Text = "Stanley started to walk around he then entered a room with two doors one is just a broom closet but the other seems tp be locked up tight ";
                    option1Label.Text = "brooms door";
                    option2Label.Text = "try locked door";
                    imageBox.Image = Properties.Resources.doors;


                    sp = new SoundPlayer(Properties.Resources.alarm);
                    sp.Play();

                    break;
                case 3:
                    outputLabel.Text = "you didn't hear it crying but once you did you accepted what was going to happen to you. im sorry";
                    option1Label.Text = "restart";
                    option2Label.Text = "restart";
                    imageBox.Image = Properties.Resources.ohno;


                    sp = new SoundPlayer(Properties.Resources.Shy_guy);
                    sp.Play();

                    break;
                case 4:
                    outputLabel.Text = "Stanley stepped into the broom closet, but there was nothing here, so he turned around and got back on track ";
                    option2Label.Text = "fine";
                    option1Label.Text = "No i didnt";

                    imageBox.Image = Properties.Resources.broom;
                    sp = new SoundPlayer(Properties.Resources.The_Stanley_Parable);
                    sp.Play();

                    break;
                case 5:
                    outputLabel.Text = "the door is locked";
                    option1Label.Text = "go to closet";
                    option2Label.Text = "<---";
                    break;
                case 6:

                    outputLabel.Text = "you hear screaming and a loud cash outside the door you wait a minute then leave?";
                    option2Label.Text = " ... ";
                    option1Label.Text = "leave";
                    imageBox.Image = Properties.Resources.broom;
                    break;
                case 7:
                    outputLabel.Text = "whatever it was its gone now you see it opened the other door";
                    option1Label.Text = "closet";
                    option2Label.Text = "go through";

                    imageBox.Image = Properties.Resources.OIGy;
                    break;
                case 8:
                    outputLabel.Text = "Well, I've come to a very definite conclusion about what's happening right now. You're dead";
                    option1Label.Text = "restart";
                    option2Label.Text = "restart";
                    break;
                case 9:
                    outputLabel.Text = "no Stanley the closet is a bad influents on you. think about it then restart";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                case 10:
                    outputLabel.Text = "Stanley went through the now unlocked door it lead to a big open room with a huge door. my word look at the size of that thing stanley. ";
                    option1Label.Text = "go to door";
                    option2Label.Text = "i miss closet";
                    imageBox.Image = Properties.Resources.door_big;
                        break;
                case 11:
                 break;
                  outputLabel.Text = "you step towards the door it opens and guards come rushing out before you could say anything the opened fire they said there sorry";
                  option1Label.Text = "thanks";
                  option2Label.Text = "for playing";
                  Refresh();
                  Thread.Sleep(2000);
                 this.Close();
                }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void option2Label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageBox_Click(object sender, EventArgs e)
        {

        }

        private void option1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
