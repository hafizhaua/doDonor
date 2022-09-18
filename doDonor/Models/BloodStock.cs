using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class BloodStock
    {
        private int idBloodStock;
        private int idPMI;
        private List<string>? stockO;
        private List<string>? stockA;
        private List<string>? stockB;
        private List<string>? stockAB;

        public BloodStock(int idBloodStock, int idPMI, List<string>? stockO, List<string>? stockA, List<string>? stockB, List<string>? stockAB)
        {
            this.IdBloodStock = idBloodStock;
            this.IdPMI = idPMI;
            this.StockO = stockO;
            this.StockA = stockA;
            this.StockB = stockB;
            this.StockAB = stockAB;
        }

        public int IdBloodStock { get => idBloodStock; set => idBloodStock = value; }
        public int IdPMI { get => idPMI; set => idPMI = value; }
        public List<string>? StockO { get => stockO; set => stockO = value; }
        public List<string>? StockA { get => stockA; set => stockA = value; }
        public List<string>? StockB { get => stockB; set => stockB = value; }
        public List<string>? StockAB { get => stockAB; set => stockAB = value; }
    }
}
