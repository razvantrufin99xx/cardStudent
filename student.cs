/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/4/2024
 * Time: 7:59 AM
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
	/// Description of student.
	/// </summary>
	public class student
		{
			public MainForm mf;
			public string nume;
			public string prenume;
			public string datanasterii;
			public string nrmatricol;
			public string seriesinrci;
			public string cnp;
			public string sex;
			public string adresa;
			public string tara;
			public string judet;
			public string oras;
			public string codpostal;
			public string nrtelefon;
			public string email;
			
			public student(){}
			public void  setForm( MainForm f)
			{
				//try{
					this.mf = f;
				//}
				//catch{};
			}
			public void addStudentInLista(ref List<student> ls, ref student ns)
			{
				ls.Add(ns);
			}
			public void createstudent(string pnume, string pprenume , string pdatanasterii, string pnrmatricol, string pseriesinrci, string pcnp, 
			               string psex, string padresa, string ptara, string pjudet,string poras, string pcodpostal, string pnrtelefon, string pemail){
				this.nume = pnume;
				this.prenume= pprenume;
				this.datanasterii = pdatanasterii;
				this.nrmatricol = pnrmatricol;
				this.seriesinrci = pseriesinrci;
				this.cnp = pcnp;
				this.sex = psex; 
				this.adresa = padresa;
				this.tara = ptara;
				this.judet = pjudet;
				this.oras = poras;
				this.codpostal = pcodpostal;
				this.nrtelefon = pnrtelefon;
				this.email = pemail;
				
			}
			public bool printCard(MainForm mf)
			{
				mf.setLabel( mf.label1,this.nume);
				mf.setLabel( mf.label2,this.prenume);
				mf.setLabel( mf.label3,this.datanasterii);
				mf.setLabel( mf.label4,this.nrmatricol);
				mf.setLabel( mf.label5,this.seriesinrci);
				
				mf.setLabel( mf.label6,this.cnp);
				mf.setLabel( mf.label7,this.sex);
				mf.setLabel( mf.label8,this.adresa);
				mf.setLabel( mf.label9,this.tara);
				mf.setLabel( mf.label10,this.judet);
				
				mf.setLabel( mf.label11,this.oras);
				mf.setLabel( mf.label12,this.codpostal);
				mf.setLabel( mf.label13,this.nrtelefon);
				mf.setLabel( mf.label14,this.email);
				
				return true;
			}
			
		}
		
}
