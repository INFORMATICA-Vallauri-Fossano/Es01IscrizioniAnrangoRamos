using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es01AnrangoRamos
{
    public class clsPersona
    {
        /***
         * Una classe rappresenta un tipo di dati associati ad un gruppo 
         * di oggetti che hannno:
         * stesse caratteristiche e stesso funzionamento ma
         * stato differente
         * definendo una classe si definisce un 
         * 
         * 
         */

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
            get { return nome; }
            set                         //per accesso in scrittura
            {
                if (controllaNominativo(value))
                    nome = value;
                else
                    throw new Exception("Nome non valido, deve contenere almeno 2 lettere");
            }
        }

        public string DataNascita
        {
            get { return dataNascita.ToString("d"); }
            set
            {
                try
                {
                    dataNascita = Convert.ToDateTime(value);
                    //almeno 10 annni compiuti
                }
                catch (Exception ex)
                {
                    throw new Exception("Data di nascita non valida, "+ex.Message);
                }
            }
        }
        //costruttori
        //ha stesso nome della classe
        public clsPersona() { }
        public clsPersona(string _cognome,string _nome, string _datanascita) {
            Cognome=_cognome;
            Nome=_nome;
            DataNascita = _datanascita;
            
        }


        //metodi pubblici   ==> richiamabili e visibili anche dall'esterno della classe
        public int VisEta()
        {
            //il metodo non ha parametri perchè usa il campo della classe
            int anni;
            //compito:calcolare l'età della persona
            
            anni = DateTime.Now.Year - dataNascita.Year;
            if (DateTime.Now.DayOfYear < dataNascita.DayOfYear) anni--;

            return anni;
        }

        public string visDati()
        {

            string s=cognome+" "+nome+" data nascita: "+dataNascita.ToString("d");
            return s;
        }
        //metodi privati ==> richiamabili e visibili solo all'interno della classe
        private bool controllaNominativo(string s)
        {
            bool esito = true;
            s = s.Trim();
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
