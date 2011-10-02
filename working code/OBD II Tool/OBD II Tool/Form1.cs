using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBDIIEngineLibrary;

namespace OBD_II_Tool
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }



        private void btn_live_Click(object sender, EventArgs e)
        {
            rpmbar.Style = ProgressBarStyle.Blocks;
            speedbar.Style = ProgressBarStyle.Blocks;
            loadbar.Style = ProgressBarStyle.Blocks;
            try
            {
                int i = 1;
                while (i < 250)
                {
                    String port = Convert.ToString(comboBox1.SelectedItem);
                    OBDIIEngine eng;
                    
                    eng = new OBDIIEngine(port);
                    eng.OpenPort();
                    tb_rpm.Text = Convert.ToString(eng.GetEngineRpm());
                    tb_speed.Text = Convert.ToString(eng.GetSpeedKmh());
                    loadbar.Value = Convert.ToInt16(eng.GetCalculatedEngineLoadValue());
                    rpmbar.Value = Convert.ToInt16(tb_rpm.Text);
                    speedbar.Value = Convert.ToInt16(tb_speed.Text);                    
                    tb_rpm.Refresh();   
                    tb_speed.Refresh();                 
                    rpmbar.Refresh();  
                    if (rpmbar.Value > 6000) { label1.Text = "Engine rpm HIGH"; } else { label1.Text = "OK"; }
                    label1.Refresh();
                    if (speedbar.Value > 130) { label2.Text = "Overspeed"; } else { label2.Text = "OK"; }
                    label2.Refresh();                    
                    loadbar.Refresh();                    
                    eng.ClosePort();
                    
                    i++;
                    
                }
                rpmbar.Style = ProgressBarStyle.Marquee; rpmbar.MarqueeAnimationSpeed = 100;
                speedbar.Style = ProgressBarStyle.Marquee; speedbar.MarqueeAnimationSpeed = 100;
                loadbar.Style = ProgressBarStyle.Marquee; loadbar.MarqueeAnimationSpeed = 100;
                tb_speed.Text = "Standby";
                tb_rpm.Text = "Standby";

            }
            catch (Exception)
                {
                    
                    MessageBox.Show("Fehler beim initialisieren des COM Ports.\nBitte Einstellungen prüfen.", "ERROR c001", MessageBoxButtons.OK);
                    rpmbar.Style = ProgressBarStyle.Marquee; rpmbar.MarqueeAnimationSpeed = 100;
                    speedbar.Style = ProgressBarStyle.Marquee; speedbar.MarqueeAnimationSpeed = 100;
                    loadbar.Style = ProgressBarStyle.Marquee; loadbar.MarqueeAnimationSpeed = 100;
                }
        }

        private void rpmworker_DoWork(object sender, DoWorkEventArgs e)
        {
            OBDIIEngine eng;
            eng = new OBDIIEngine("COM6");
            eng.OpenPort();
            tb_rpm.Text = Convert.ToString(eng.GetEngineRpm());
            eng.ClosePort();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rpmbar.Style = ProgressBarStyle.Marquee; rpmbar.MarqueeAnimationSpeed = 100;
            speedbar.Style = ProgressBarStyle.Marquee; speedbar.MarqueeAnimationSpeed = 100;
            loadbar.Style = ProgressBarStyle.Marquee; loadbar.MarqueeAnimationSpeed = 100;
            tb_speed.Text = "Standby";
            tb_rpm.Text="Standby";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //classtest
            //reader read = new reader;
            lies = new reader

            
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            new about().Show();
        }

        }
    }
