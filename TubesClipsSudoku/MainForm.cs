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
		private Mommosoft.ExpertSystem.Environment theEnv = new Mommosoft.ExpertSystem.Environment();
		private sudokuX scene = new sudokuX();

		public MainForm() {
			InitializeComponent();
			theEnv.Load(@"CLIPS\sudoku - mod.clp");
			theEnv.Load(@"CLIPS\solve.clp");
			theEnv.Load(@"CLIPS\output-frills.clp");
		}

		private void buttLoad_Click(object sender, EventArgs e) {
			int size = -1;
			DialogResult result = loadScene.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK) // Test result.
			{
				scene.readText(loadScene.FileName);
				scene.clpConversion(loadScene.FileName);
				c11.Text = scene.getValue(1, 1).ToString();
				c21.Text = scene.getValue(1, 2).ToString();
				c31.Text = scene.getValue(1, 3).ToString();
				c41.Text = scene.getValue(1, 4).ToString();
				c51.Text = scene.getValue(1, 5).ToString();
				c61.Text = scene.getValue(1, 6).ToString();
				c12.Text = scene.getValue(2, 1).ToString();
				c22.Text = scene.getValue(2, 2).ToString();
				c32.Text = scene.getValue(2, 3).ToString();
				c42.Text = scene.getValue(2, 4).ToString();
				c52.Text = scene.getValue(2, 5).ToString();
				c62.Text = scene.getValue(2, 6).ToString();
				c13.Text = scene.getValue(3, 1).ToString();
				c23.Text = scene.getValue(3, 2).ToString();
				c33.Text = scene.getValue(3, 3).ToString();
				c43.Text = scene.getValue(3, 4).ToString();
				c53.Text = scene.getValue(3, 5).ToString();
				c63.Text = scene.getValue(3, 6).ToString();
				c14.Text = scene.getValue(4, 1).ToString();
				c24.Text = scene.getValue(4, 2).ToString();
				c34.Text = scene.getValue(4, 3).ToString();
				c44.Text = scene.getValue(4, 4).ToString();
				c54.Text = scene.getValue(4, 5).ToString();
				c64.Text = scene.getValue(4, 6).ToString();
				c15.Text = scene.getValue(5, 1).ToString();
				c25.Text = scene.getValue(5, 2).ToString();
				c35.Text = scene.getValue(5, 3).ToString();
				c45.Text = scene.getValue(5, 4).ToString();
				c55.Text = scene.getValue(5, 5).ToString();
				c65.Text = scene.getValue(5, 6).ToString();
				c16.Text = scene.getValue(6, 1).ToString();
				c26.Text = scene.getValue(6, 2).ToString();
				c36.Text = scene.getValue(6, 3).ToString();
				c46.Text = scene.getValue(6, 4).ToString();
				c56.Text = scene.getValue(6, 5).ToString();
				c66.Text = scene.getValue(6, 6).ToString();
			}
		}

		private void buttSolve_Click(object sender, EventArgs e) {
			string filepath = loadScene.FileName + ".clp";
			theEnv.Load(@filepath);
			theEnv.Reset();
			string a = Console.ReadLine();
			theEnv.Run();

			Console.WriteLine(a);
		}

	}
}
