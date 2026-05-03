using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelloWorldCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Hello World Cs";
            this.Width = 400;
            this.Height = 200;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label helloLabel = new Label();
            helloLabel.Text = "Hello World Cs!";
            helloLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            helloLabel.AutoSize = true;
            helloLabel.Location = new Point(100, 50);

            this.Controls.Add(helloLabel);

            Label featureLabel = new Label();
            featureLabel.Text = "new feature";
            featureLabel.Font = new Font("Arial", 18, FontStyle.Regular);
            featureLabel.AutoSize = true;
            featureLabel.Location = new Point(100, 100);

            this.Controls.Add(featureLabel);
        }
    }
}
