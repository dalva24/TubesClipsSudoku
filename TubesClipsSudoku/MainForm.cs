using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TubesClipsSudoku {
	public partial class MainForm : Form {

		private sudokuX scene = new sudokuX();

		public MainForm() {
			InitializeComponent();
		}

		private void buttLoad_Click(object sender, EventArgs e) {
			int size = -1;
			DialogResult result = loadScene.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK) // Test result.
			{
				scene.readText(loadScene.FileName);
				//What's sudokuX's coordinate system?
				c11.Text = scene.getValue(1, 1).ToString();
				c21.Text = "5";
				c31.Text = "5";
				c41.Text = "5";
				c51.Text = "5";
				c61.Text = "5";
				c11.Text = "5";
				c22.Text = "5";
				c32.Text = "5";
				c42.Text = "5";
				c52.Text = "5";
				c62.Text = "5";
				c13.Text = "5";
				c23.Text = "5";
				c33.Text = "5";
				c43.Text = "5";
				c53.Text = "5";
				c63.Text = "5";
				c14.Text = "5";
				c24.Text = "5";
				c34.Text = "5";
				c44.Text = "5";
				c54.Text = "5";
				c64.Text = "5";
				c15.Text = "5";
				c25.Text = "5";
				c35.Text = "5";
				c45.Text = "5";
				c55.Text = "5";
				c65.Text = "5";
				c16.Text = "5";
				c26.Text = "5";
				c36.Text = "5";
				c46.Text = "5";
				c56.Text = "5";
				c66.Text = "5";
			}
		}

		private void buttSolve_Click(object sender, EventArgs e) {
			//TODO
		}
	}
}
