using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Es01AnrangoRamos
{
    public partial class frmIscrizione : Form
    {
        clsPersona persona=new clsPersona();
        List<clsPersona> iscritti=new List<clsPersona>();
        clsFile fileController = new clsFile(".\\Iscrizioni.txt");
        public frmIscrizione()
        {
            InitializeComponent();
        }

        private void btnInserire_Click(object sender, EventArgs e)
        {
            bool esito = true;
            try
            {
                persona.Cognome=txtCognome.Text;
                persona.Nome=txtNome.Text;
                persona.DataNascita = txtData.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reinserire i dati. "+ex.Message);
                esito=false;
            }
            if (esito)
            {
                clsPersona iscritto= new clsPersona();
                iscritto.Nome = persona.Nome;
                iscritto.Cognome= persona.Cognome;
                iscritto.DataNascita= persona.DataNascita;
                
                iscritti.Add(iscritto);
                salvasufile();
                aggiornadgv();
            }
            
        }

        private void aggiornadgv()
        {
            dgv.Rows.Clear();

            dgv.ColumnCount = 3;
            dgv.RowCount= iscritti.Count;
            dgv.Columns[0].HeaderCell.Value = "Cognome";
            dgv.Columns[1].HeaderCell.Value = "Nome";
            dgv.Columns[2].HeaderCell.Value = "Data di Nascita";

            for (int i = 0; i < iscritti.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value=iscritti[i].Cognome;
                dgv.Rows[i].Cells[1].Value=iscritti[i].Nome;
                dgv.Rows[i].Cells[2].Value=iscritti[i].DataNascita;
            }

            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }

        //aggiunge un nuovo iscritto al file
        private void salvasufile()
        {
            string[] line = { persona.Cognome, persona.Nome, persona.DataNascita };
            fileController.CreateLinesFile(string.Join(";", line));
        }

        private void frmIscrizione_Load(object sender, EventArgs e)
        {
            caricaIscrittiFile();
            aggiornadgv();
        }

        private void caricaIscrittiFile()
        {
            string[] fileIscritti = fileController.GetLinesFile();
            string[] record;
            for (int i = 0; i < fileIscritti.Length; i++)
            {
                record = fileIscritti[i].Split(';');
                clsPersona iscritto= new clsPersona();
                iscritto.Cognome = record[0];
                iscritto.Nome = record[1];
                iscritto.DataNascita = record[2];

                iscritti.Add(iscritto);
            }
        }
    }
}
