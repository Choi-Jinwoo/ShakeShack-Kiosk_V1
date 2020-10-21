using SheckSheck_Kiosk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.ViewModel
{
    class TableViewModel
    {
        private static TableViewModel instance;
        private TableViewModel() { }

        public static TableViewModel Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableViewModel();
                }
                return instance;
            }
        }

        public List<Table> tables = new List<Table>( new Table[]
        {
            new Table() {Number=1},
            new Table() {Number=2},
            new Table() {Number=3},
            new Table() {Number=4},
            new Table() {Number=5},
            new Table() {Number=6},
            new Table() {Number=7},
            new Table() {Number=8},
            new Table() {Number=9},
        });
        
    }
}
