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
using VerifConfig.Fonction;

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
            string contenue = string.Empty;
            string chemain = string.Empty;


            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                chemain = openFileDialog2.FileName;

                var fileStream = openFileDialog2.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    contenue = reader.ReadToEnd();
                }
                selection.Chemain = chemain;
                selection.Contenue = contenue;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (selection.Chemain != "")
            {
                MessageBox.Show("Fichier bien selectionner");
                GeneralVerif.Exec_fichier(selection);
            }else { MessageBox.Show("Veuillez renseigner un fichier"); }
        }
    }

}
