using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaneOsobowe.Baza_danych.Context;

namespace DaneOsobowe
{
    public partial class OknoGlowne : Form
    {
        private MojaBazaContext bazaDanychContext;

        public OknoGlowne()
        {
            InitializeComponent();
            bazaDanychContext = new MojaBazaContext();
        }

    }
}
