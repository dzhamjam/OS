using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length-1; i++)
            {
                label1.Text = $"Наличие диска: {drives[i].IsReady}\nНазвание: {drives[i].Name}\n\n" +
                    $"Наличие диска: {drives[i+1].IsReady}\nНазвание: {drives[i+1].Name}";
     
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                for (int i = 0; i < drives.Length - 1; i++)
                {
                    if (drives[i].IsReady)
                    {
                        label2.Text = $"Кол-во свободного места: {drives[i].AvailableFreeSpace} байт\nОбъём памяти: {drives[i].TotalSize} байт\n\n" +
                            $"Кол-во свободного места: {drives[i + 1].AvailableFreeSpace} байт\nОбъём памяти: {drives[i + 1].TotalSize} байт";
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
