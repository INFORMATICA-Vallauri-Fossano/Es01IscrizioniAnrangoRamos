using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es01AnrangoRamos
{
    public class clsFile
    {
        private string path;

        public clsFile(string pt) {

            if (!checkPath(pt)) throw new Exception("Path non valido");
            else
            if(!File.Exists(pt))
            {
                using (FileStream fs = File.Create(pt)) { };
            }
                path = pt;
        }

        //il mio check controlla solo path relativi al progetto
        private bool checkPath(string s)
        {
            bool esito = true;
            if (s.Length <= 260&&s.Length>2)
            {
                
                int i = 0;
                bool AllowedCharacter;
                while ((AllowedCharacter=s[i] != '/' && s[i] != ':' && s[i] != '*' && s[i] != '?' && s[i] != '"' && s[i] != '<' && s[i] != '>' && s[i] != '|') && i < s.Length-1)
                    i++;


                if (!AllowedCharacter) esito = false;
                else if (s[s.Length - 4] != '.' || s[s.Length - 3] != 't' || s[s.Length - 2] != 'x' || s[s.Length - 1] != 't') esito = false;

            }else esito =false;

            return esito;
        }
        public string[] GetLinesFile()
        {
            string[] fildata=File.ReadAllLines(path);

            return fildata;
        }

        public void UpdateFile(string[] newFileData)
        {
            File.WriteAllLines(path, newFileData);
        }
        public void CreateLinesFile(string[] newFileData)
        {
            File.AppendAllLines(path, newFileData);
        }
        public void CreateLinesFile(string newFileData)
        {
            MessageBox.Show(path);
            File.AppendAllText(path, newFileData+"\n");
        }
    }
}
