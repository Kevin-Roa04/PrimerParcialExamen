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
        public DetailsHistory(string Detail, String Value, string Value1)
        {
            InitializeComponent();
            lbldetail.Text = Detail;
            lblDetailValue.Text = Value;
            lblDetailValue2.Text = Value1;
        }
        public DetailsHistory(string City, string NameCity)
        {
            InitializeComponent();
            lbldetail.Text = City;
            lblDetailValue2.Visible = false;
            lblDetailValue.Text = NameCity;
        }
    }
}
