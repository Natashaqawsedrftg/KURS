﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KURS
{
    public partial class Dobavit_ : Form
    {
        public Dobavit_()
        {
            InitializeComponent();
        }

        private void Dobavit__Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.Klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.allDataSet.Klient);
          
           

        }

        private void Dobavit__FormClosing(object sender, FormClosingEventArgs e)
        {
            //если пользователь нажал на первую кнопку:
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                //сохранить изменения:
                klientBindingSource.EndEdit();
            else
                //не сохранять изменения:
               klientBindingSource.CancelEdit();

        }

        
    }
}
