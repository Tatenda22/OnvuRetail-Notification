using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace NotifyTest1 // Basic GUI code test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier(); // declaring variable
            popup.Image = Properties.Resources.info1; // fetching image from where it has been stored
            popup.TitleText = "OnvuRetail Update Alert !";
            popup.ContentText = "Camera updates required (Now or Later)";
            popup.Popup(); // Allows the notification to appear
        }
    }
}
