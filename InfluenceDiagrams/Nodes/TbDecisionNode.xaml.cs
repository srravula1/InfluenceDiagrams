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

namespace InfluenceDiagrams.Nodes
{
    /// <summary>
    /// Interaction logic for TbDecisionNode.xaml
    /// </summary>
    public partial class TbDecisionNode : UserControl
    {
        public TbDecisionNode()
        {
            InitializeComponent();
        }

        public void MouseLeftDown(object sender, MouseEventArgs e)
        {
            MainWindow.GetMCanvas.DragSelection = "DecisionNode";
            DragDrop.DoDragDrop(this, MainWindow.GetCanvas, DragDropEffects.Move);
        }

    }
}
