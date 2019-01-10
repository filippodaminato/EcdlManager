using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace EcdlManager
{
    class Esaminando
    {
        string nome, cognome, data_nascita, luogo_nascita;
        char sesso, studente;
        public Esaminando(DataRow data)
        {
            nome =  Convert.ToString(data["Nome"]);
            cognome = Convert.ToString(data["Cognome"]);
            data_nascita = Convert.ToString(data["DataNascita"]);
            luogo_nascita = Convert.ToString(data["LuogoNascita"]);
            sesso = Convert.ToChar(data["Sesso"]);
            studente = Convert.ToChar(data["BoolStudente"]);
        }



    }
}
