using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeadMate.Models {
    public class Mead {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MeadAction> Actions { get; set; }
        public int QuantityML => GetQuantity();
        public double ABV { get; set; }
        public MeadAction LastAction { get; set; }

        private int GetQuantity() {
            foreach(MeadAction action in Actions) {

            }
            return 0;
        }
    }
}
