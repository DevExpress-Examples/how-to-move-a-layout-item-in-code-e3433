Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Layout.Core

Namespace DockLayoutManager_MoveItem
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonMove_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'			#Region "#1"
			dockLayoutManager1.LayoutController.Move(layoutItemEditor1, layoutItemButton1, MoveType.Left)
'			#End Region ' #1
		End Sub
	End Class
End Namespace
