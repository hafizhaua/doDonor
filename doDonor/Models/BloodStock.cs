using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class BloodStock
    {
        private string? id;
        private string? region;
        private int wbA;
        private int wbB;
        private int wbAb;
        private int wbO;

        private int tcA;
        private int tcB;
        private int tcAb;
        private int tcO;

        private int prcA;
        private int prcB;
        private int prcAb;
        private int prcO;

        private DateTime dateStock;

        public BloodStock(string region, int wbA, int wbB, int wbAB, int wbO, int tcA, int tcB, int tcAB, int tcO, int prcA, int prcB, int prcAB, int prcO, DateTime dateStock)
        {
            this.Region = region;
            this.WbA = wbA;
            this.WbB = wbB;
            this.WbAb = wbAB;
            this.WbO = wbO;
            this.TcA = tcA;
            this.TcB = tcB;
            this.TcAb = tcAB;
            this.TcO = tcO;
            this.PrcA = prcA;
            this.PrcB = prcB;
            this.PrcAb = prcAB;
            this.PrcO = prcO;
            this.DateStock = dateStock;
        }

        public string Id { get => id; set => id = value; }
        public string Region { get => region; set => region = value; }
        public int WbA { get => wbA; set => wbA = value; }
        public int WbB { get => wbB; set => wbB = value; }
        public int WbAb { get => wbAb; set => wbAb = value; }
        public int WbO { get => wbO; set => wbO = value; }
        public int TcA { get => tcA; set => tcA = value; }
        public int TcB { get => tcB; set => tcB = value; }
        public int TcAb { get => tcAb; set => tcAb = value; }
        public int TcO { get => tcO; set => tcO = value; }
        public int PrcA { get => prcA; set => prcA = value; }
        public int PrcB { get => prcB; set => prcB = value; }
        public int PrcAb { get => prcAb; set => prcAb = value; }
        public int PrcO { get => prcO; set => prcO = value; }
        public DateTime DateStock { get => dateStock; set => dateStock = value; }
    }
}
