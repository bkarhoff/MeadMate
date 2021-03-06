using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeadMate.Models {

    public class MeadAction {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int MeadId { get; set; }
        public string ActionName { get; set; } = "Base";
        public DateTime Date { get; set; }
        public string Reicipe { get; set; }

    }
    public class BrewAction : MeadAction {
        public string Note { get; set; }
        public string StartingGravity { get; set; }
        public Container Fermenter { get; set; }
        public BrewAction() {
            ActionName = "Brew";
        }
    }

    public class RackAction : MeadAction {
        public double GravityReading { get; set; }
        public List<Ingredient> IngredientsAdded { get; set; }
        public List<Ingredient> IngredientsRemoved { get; set; }
        public Container Container { get; set; }
        public RackAction() {
            ActionName = "Rack";
        }
    }

    public class BottleAction : MeadAction {
        public double GravityReading { get; set; }
        public List<Bottle> Bottles { get; set; }
        public BottleAction() {
            ActionName = "Bottle";
        }
    }

    public class TasteAction : MeadAction {
        public string Note { get; set; }
        public Bottle Bottle { get; set; }
        public TasteAction() {
            ActionName = "Taste";
        }
    }
}
