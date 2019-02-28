using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Eletronicos
{
    public partial class Caixa : UserControl
    {
        private static Caixa _instance;
        public static Caixa Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Caixa();
                return _instance;
            }
        }
        public Caixa()
        {
            InitializeComponent();
        }
    }
}
