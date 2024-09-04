/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/4/2024
 * Time: 7:48 AM
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
	/// Description of AddStudent.
	/// </summary>
	public partial class AddStudent : Form
	{
		public AddStudent()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public MainForm mf;
		
			public void  setForm( MainForm f)
			{
				//try{
					this.mf = f;
				//}
				//catch{};
			}
			
		void AddStudentLoad(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
				student x = new student();
			    x.setForm(mf);
			    x.createstudent(this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,this.textBox4.Text,this.textBox5.Text,this.textBox6.Text,this.textBox7.Text,
			                   this.textBox8.Text,this.textBox9.Text,this.textBox10.Text,this.textBox11.Text,this.textBox12.Text,this.textBox13.Text,this.textBox14.Text);
			 mf.studentilista.Add(x);
			x.printCard(mf);
		}
	}
}
