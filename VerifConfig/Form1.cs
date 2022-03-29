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
using VerifConfig;

namespace VerifConfig
{
    public partial class Form1 : Form
    {
        private Verif selection = new Verif();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;


            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog2.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog2.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                selection.Chemain = filePath;
                selection.Contenue = fileContent;
                //Verif selection = new Verif(filePath, fileContent);
                //string[] chaine = fileContent.Split(' ');
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (selection.Chemain != "")
            {
                MessageBox.Show("Fichier bien selectionner");
            }else { MessageBox.Show("Veuillez renseigner un fichier"); }
        }
    }

}
