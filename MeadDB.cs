using MeadMate.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeadMate {
    public class MeadDB {


        public List<Mead> GetActiveBrews() {
            return MockMeadList();
        }

        private static List<Mead> MockMeadList() {
            return new List<Mead>() {
                new Mead(){
                    Id= 0,
                    Name=$"Trad",
                    ABV=8.2,
                    Actions=new List<MeadAction>(){
                        new BrewAction(){
                            Date= new DateTime(2021, 1, 1)
                        },
                        new RackAction(){
                            Date= new DateTime(2021, 2, 1)
                        }
                    },
                    LastAction= new RackAction()
                },
                new Mead(){
                    Id=1,
                    Name=$"Hibiscus",
                    ABV=12.6,
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
                    },
                    LastAction = new BottleAction()
                },
                new Mead() {
                    Id=1,
                    Name=$"S'Mores",
                    ABV=13.3,
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
                    },
                    LastAction = new TasteAction()
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
