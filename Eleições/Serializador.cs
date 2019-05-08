using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;


namespace Eleições
{
    class Serializador
    {
        public void Serialize(String strPath, List<Candidatos> mArquivo)
        {
            FileStream fs = new FileStream(strPath, FileMode.OpenOrCreate);
            BinaryFormatter formatador = new BinaryFormatter();
            try
            {
                formatador.Serialize(fs, mArquivo);
                fs.Close();
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Candidatos> Deserialize(String strPath)
        {
            FileStream fs = new FileStream(strPath, FileMode.Open);
            List<Candidatos> mArquivo = new List<Candidatos>();
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                mArquivo = (List<Candidatos>)formatter.Deserialize(fs);
                fs.Close();
                return mArquivo;
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return mArquivo;
            }
        }
    }
}
