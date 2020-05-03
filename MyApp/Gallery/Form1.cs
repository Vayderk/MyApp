using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace MyApp
{
	public partial class Form1 : Form
	{

		int cont = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		public void chargePhotos()
		{

			var images = new List<string>() { @"C:\Users\Vayderk\source\repos\MyApp\MyApp\Gallery\Photos\a.jpg",
				@"C:\Users\Vayderk\source\repos\MyApp\MyApp\Gallery\Photos\b.jpg"};


			if (cont > images.Count - 1) { cont = 0; }

			pictureBox1.Image = Image.FromFile(images[cont]);
			pictureBox1.Width = 400;
			pictureBox1.Height = 299;





		}

		private void button1_Click(object sender, EventArgs e)
		{
			cont++;
			chargePhotos();
		}
	}
}
