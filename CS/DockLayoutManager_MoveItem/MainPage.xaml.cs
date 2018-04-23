using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Layout.Core;

namespace DockLayoutManager_MoveItem {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void buttonMove_Click(object sender, RoutedEventArgs e) {
            #region #1
            dockLayoutManager1.LayoutController.Move(layoutItemEditor1, layoutItemButton1, MoveType.Left);
            #endregion #1
        }
    }
}
