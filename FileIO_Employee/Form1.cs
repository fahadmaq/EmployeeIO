using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIO_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Employee.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter=new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(txId.Text));
                binaryWriter.Write(txName.Text);
                binaryWriter.Write(Convert.ToDouble(txSalary.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Employee added sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Employee.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txId.Text = binaryReader.ReadInt32().ToString();
                txName.Text = binaryReader.ReadString();
                txSalary.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
