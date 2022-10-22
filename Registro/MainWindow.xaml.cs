﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Registro
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<alunno> classe;
        public MainWindow()
        {
            InitializeComponent();

             classe = new List<alunno>();
        }
        
        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            alunno a = new alunno(txtNome.Text, txtCognome.Text);
            classe.Add(a);

        }
    }

    class alunno
    {
        string nome, cognome;

        public alunno (string n, string c)
        {
            nome = n;
            cognome = c;
        }
    }
}
