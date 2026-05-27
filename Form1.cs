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
            this.Height = 380;
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

            Label resultLabel = new Label();
            resultLabel.Text = "";
            resultLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            resultLabel.ForeColor = Color.Blue;
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(100, 175);

            this.Controls.Add(resultLabel);

            TextBox inputTextBox = new TextBox();
            inputTextBox.Font = new Font("Arial", 12, FontStyle.Regular);
            inputTextBox.Location = new Point(100, 210);
            inputTextBox.Width = 200;

            this.Controls.Add(inputTextBox);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Font = new Font("Arial", 12, FontStyle.Bold);
            okButton.Size = new Size(100, 35);
            okButton.Location = new Point(90, 260);
            okButton.Click += (sender, e) => {
                Form newWindow = new Form();
                newWindow.Text = "Madhuri";
                newWindow.Width = 300;
                newWindow.Height = 150;
                newWindow.StartPosition = FormStartPosition.CenterParent;

                Label contentLabel = new Label();
                contentLabel.Text = inputTextBox.Text;
                contentLabel.Font = new Font("Arial", 14, FontStyle.Regular);
                contentLabel.AutoSize = true;
                contentLabel.Location = new Point(30, 40);

                newWindow.Controls.Add(contentLabel);
                newWindow.Show();
            };

            this.Controls.Add(okButton);

            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Font = new Font("Arial", 12, FontStyle.Bold);
            closeButton.Size = new Size(100, 35);
            closeButton.Location = new Point(210, 260);
            closeButton.Click += (sender, e) => this.Close();

            this.Controls.Add(closeButton);
        }
    }
}
