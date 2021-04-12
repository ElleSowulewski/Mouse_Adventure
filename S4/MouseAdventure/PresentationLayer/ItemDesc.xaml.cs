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
using System.Windows.Shapes;
using MouseAdventure.BusinessLayer;
using MouseAdventure.Models;
using MouseAdventure.DataLayer;

namespace MouseAdventure.PresentationLayer
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ItemDesc : Window
    {
        GameSessionViewModel _gameSessionViewModel;
        public ItemDesc(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;

            InitializeComponent();
            setText();

        }

        public void setText()
        {
            text.Content = _gameSessionViewModel.Player.Inventory[0].Description;
            name.Content = _gameSessionViewModel.Player.Inventory[0].Name;
        }

    }
}