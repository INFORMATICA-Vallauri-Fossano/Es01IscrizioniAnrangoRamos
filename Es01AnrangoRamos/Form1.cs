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
        public clsPersona persona=new clsPersona();
        public clsElenco elenco;
        public clsFile fileController = new clsFile(".\\Iscrizioni.txt");
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
                MessageBox.Show("Inserito il nuovo iscritto: " + iscritto.visDati());

                elenco.aggiungi(iscritto);
                salvasufile();
                elenco.visualizza(dgv);
            }
            
        }


        //aggiunge un nuovo iscritto al file
        private void salvasufile()
        {
            string[] line = { persona.Cognome, persona.Nome, persona.DataNascita };
            fileController.CreateLinesFile(string.Join(";", line));
        }

        private void frmIscrizione_Load(object sender, EventArgs e)
        {
            elenco=new clsElenco();
            caricaIscrittiFile();
            elenco.visualizza(dgv);
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

                elenco.aggiungi(iscritto);
            }
        }

        private void btnInserire2_Click(object sender, EventArgs e)
        {
            bool esito = true;
            try
            {
               persona=new clsPersona( txtCognome.Text,
                txtNome.Text,
                txtData.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reinserire i dati. " + ex.Message);
                esito = false;
            }
            if (esito)
            {
                clsPersona iscritto = new clsPersona(
                persona.Cognome,
                persona.Nome,
                persona.DataNascita);
                MessageBox.Show("Inserito il nuovo iscritto: " + iscritto.visDati());

                elenco.aggiungi(iscritto);
                salvasufile();
                elenco.visualizza(dgv);
                
            }
        }

        private void btnRicercaXanno_Click(object sender, EventArgs e)
        {

        }

        private void btnRicercaXcognome_Click(object sender, EventArgs e)
        {

        }
    }
}
