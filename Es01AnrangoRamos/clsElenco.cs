using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es01AnrangoRamos
{
    public class clsElenco
    {
        //una lista in cui inserire gli oggetti di tipo clsPersona
        private List<clsPersona> listaPersona;

        //costruttore
        public clsElenco() {
        listaPersona = new List<clsPersona>();
        }

        //metodi pubblici
        public void aggiungi(clsPersona persona)
        {
            listaPersona.Add(persona);
        }
        public void visualizza(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaPersona;
            dgv.AutoResizeRows();
            dgv.AutoResizeColumns();
        }
        public string ricerca(string cognome)
        {
            string s = "";

            if (listaPersona.Count == 0)
                s = "Lista vuota";
            else
            {

                foreach (var persona in listaPersona)
                {
                    if (cognome.ToUpper() == persona.Cognome.ToUpper())
                        s += persona.visDati() + "\n";
                }

                if (s == "") s = "Nessuna persona con il cognome richiesto";
            }
            return s;
        }
        public string ricerca(int anno)
        {
            string s = "";
            DateTime dt;

            if (listaPersona.Count == 0)
                s = "Lista vuota";
            else
            {

                foreach (var persona in listaPersona)
                {
                    dt = Convert.ToDateTime(persona.DataNascita);
                    if (dt.Year==anno)
                        s += persona.visDati() + "\n";
                }

                if (s == "") s = "Nessuna persona nata nell'anno richiesto";
            }
            return s;
        }

    }
}
