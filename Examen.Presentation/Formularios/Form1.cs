﻿using Examen.AppCore.IServices;
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
    public partial class Form1 : Form
    {
        IForeCastServices objetoServices;
        public Form1(IForeCastServices objetoServices)
        {
            this.objetoServices = objetoServices;
            InitializeComponent();
        }
    }
}
