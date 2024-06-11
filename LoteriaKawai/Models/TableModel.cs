using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaKawai.Models
{
    
    internal class TableModel
    {
        public static TableModel instance { set; get; }
        public static TableModel getInstance()
        {
            if(instance == null)
            {
                instance = new TableModel();
            }
            return instance;
        }

        private string[,] data = new string[4, 4];

        /// <summary>
        /// Create new table card
        /// </summary>
        private void createTable()
        {
            data = new string[4, 4];
            // Crear una lista de números del 1 al 54
            List<int> numeros = Enumerable.Range(1, 54).ToList();

            // Mezclar aleatoriamente la lista de números
            Random random = new Random();
            numeros = numeros.OrderBy(x => random.Next()).ToList();

            // Llenar el arreglo con los números aleatorios
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    data[i, j] = $"c{numeros[index].ToString()}.jpg";
                    index++;
                }
            }
        }
        /// <summary>
        /// Get a new card
        /// </summary>
        /// <returns>card order</returns>
        internal string[,] getTable()
        {
            createTable();
            
            return data;
        }
    }
}
