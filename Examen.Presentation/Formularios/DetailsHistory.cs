using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Presentation.Formularios
{
    public partial class DetailsHistory : UserControl
    {
        public DetailsHistory(string Detail, String Value)
        {
            InitializeComponent();
            lbldetail.Text = Detail;
            lblDetailValue.Text = Value;
        }
    }
}
