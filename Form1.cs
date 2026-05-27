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
            this.Height = 250;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label helloLabel = new Label();
            helloLabel.Text = "Hello World nf2 Cs!";
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

            Label agentLabel = new Label();
            agentLabel.Text = "this is created by agent";
            agentLabel.Font = new Font("Arial", 14, FontStyle.Italic);
            agentLabel.AutoSize = true;
            agentLabel.Location = new Point(100, 140);

            this.Controls.Add(agentLabel);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Font = new Font("Arial", 12, FontStyle.Bold);
            okButton.Size = new Size(100, 35);
            okButton.Location = new Point(150, 180);
            okButton.Click += (sender, e) => this.Close();

            this.Controls.Add(okButton);
        }
    }
}
