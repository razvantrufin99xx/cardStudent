/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/3/2024
 * Time: 9:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace stundentCard
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			student x = new student();
			x.setForm(this);
			 x.createstudent("maria","alexandru","25 iulie 1999","sb 01161","sb 3281","szzllaacccccc","m","str nume nr n bl n sc n et n ap n","romania","s","s","codpostal","0040+telefon","nume@compania.com");
			 studentilista.Add(x);
			x.printCard(this);
		}
		public List<student> studentilista = new List<student>();
		public void setLabel(Label l, string s)
		{
			l.Text = s;
		}
		void Button2Click(object sender, EventArgs e)
		{
			AddStudent ast = new AddStudent();
			ast.setForm(this);
			ast.Show();
		}
	
	}
}
