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
        }
    }
}
