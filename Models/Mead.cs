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


        internal static List<Mead> GetActiveBrews() {
            return MockMeadList();
        }

        private static List<Mead> MockMeadList() {
            return new List<Mead>() {
                new Mead(){
                    Id= 0,
                    Name=$"Trad",
                    Actions=new List<MeadAction>(){
                        new BrewAction(){ 
                            Date= new DateTime(2021, 1, 1)
                        },
                        new RackAction(){
                            Date= new DateTime(2021, 2, 1)
                        }
                    },
                },
                new Mead(){
                    Id=1,
                    Name=$"Hibiscus",
                    Actions=new List<MeadAction>(){
                        new BrewAction(){
                            Date= new DateTime(2021, 1, 1)
                        },
                        new RackAction(){
                            Date= new DateTime(2021, 2, 1)
                        },
                        new BottleAction(){
                            Date= new DateTime(2021, 3, 1)
                        }
                    }
                },
                new Mead() {
                    Id=1,
                    Name=$"S'Mores",
                    Actions=new List<MeadAction>(){
                        new BrewAction(){
                            Date= new DateTime(2021, 1, 1)
                        },
                        new RackAction(){
                            Date= new DateTime(2021, 1, 1)
                        },
                        new BottleAction(){
                            Date= new DateTime(2021, 1, 1)
                        },
                        new TasteAction(){
                            Date= new DateTime(2021, 1, 1)
                        }
                    }
                }
            };
        }

        public void AddMead() {
            using (SQLiteConnection connection = new SQLiteConnection(App.DataPath)) {
                connection.CreateTable<Mead>();
                connection.Insert(this);
            }
        }
        public void UpdateMead() {
            using (SQLiteConnection connection = new SQLiteConnection(App.DataPath)) {
                connection.CreateTable<Mead>();
                connection.Update(this);
            }
        }
        public void RemoveMead() {
            using (SQLiteConnection connection = new SQLiteConnection(App.DataPath)) {
                connection.CreateTable<Mead>();
                connection.Delete(this);
            }
        }
    }
}
