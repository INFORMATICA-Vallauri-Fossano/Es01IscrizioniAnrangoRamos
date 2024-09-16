using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es01AnrangoRamos
{
    public class clsPersona
    {
        //dichiarazione delle caratteristiche   /attributi  /campi della classe
        //li dichiareremo tutti privati --> data hiding, incapsulamento

        private string cognome;
        private string nome;
        private DateTime dataNascita;

        //Per ogni campo privato dichiariamo le property pubbliche per gli accessi in lettura e scrittura

        public string Cognome
        {
            get { return cognome; }     //per accesso in lettura
            set {
                if (controllaNominativo(value))
                    cognome = value;
                else
                    throw new Exception("Cognome non valido, deve contenere almeno 2 lettere");
            }    
        }
        public string Nome
        {
            get { return nome; }     //per accesso in lettura
            set
            {
                if (controllaNominativo(value))
                    nome = value;
                else
                    throw new Exception("Nome non valido, deve contenere almeno 2 lettere");
            }
        }

        public string DataNascita
        {
            get { return dataNascita.ToString(); }
            set
            {
                try
                {
                    dataNascita = Convert.ToDateTime(value);
                }
                catch (Exception ex)
                {
                    throw new Exception("Data di nascita non valida, "+ex.Message);
                }
            }
        }

        //metodi pubblici   ==> richiamabili e visibili anche dall'esterno della classe
        public int VisEta()
        {
            //il metodo non ha parametri perchè usa il campo della classe
            int anni = 0;
            //compito:calcolare l'età della persona
            try
            {
            anni = DateTime.Now.Year - dataNascita.Year;
            }
            catch (Exception ex)
            {
                throw new Exception("errore:"+ex.Message);
            }

            return anni;
        }

        //metodi privati ==> richiamabili e visibili solo all'interno della classe
        private bool controllaNominativo(string s)
        {
            bool esito = true;
            //compito: controllare che s contenga almeno due caratteri, solo lettere dell'alfabeto, spazio,'
            if (s.Length >= 2)
            {
                int i = 0;
                while (((s[i] <= 'Z' && s[i] >= 'A') || (s[i] <= 'z' && s[i] >= 'a') || s[i] == ' ' || s[i] == '\'') && i < s.Length - 1) i++;
                if (!((s[i] <= 'Z' && s[i] >= 'A') || (s[i] <= 'z' && s[i] >= 'a') || s[i] == ' ' || s[i] == '\'')) esito = false;
            }
            else esito = false;

            return esito;
        }
    }
}
