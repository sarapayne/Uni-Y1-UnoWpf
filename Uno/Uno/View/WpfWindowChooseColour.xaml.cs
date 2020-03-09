﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Uno.View
{
    /// <summary>
    /// Interaction logic for WpfWindowChooseColour.xaml
    /// </summary>
    public partial class WpfWindowChooseColour : Window
    {
        public WpfWindowChooseColour()
        {
            InitializeComponent();
        }

        private void buttonRed_Click(object sender, RoutedEventArgs e)
        {
            Suit suit = Suit.Red;
            EventPublisher.ColourPick(suit);
        }

        private void buttonGren_Click(object sender, RoutedEventArgs e)
        {
            Suit suit = Suit.Green;
            EventPublisher.ColourPick(suit);
        }

        private void buttonBlue_Click(object sender, RoutedEventArgs e)
        {
            Suit suit = Suit.Blue;
            EventPublisher.ColourPick(suit);
        }

        private void buttonYellow_Click(object sender, RoutedEventArgs e)
        {
            Suit suit = Suit.Yellow;
            EventPublisher.ColourPick(suit);
        }
    }
}
