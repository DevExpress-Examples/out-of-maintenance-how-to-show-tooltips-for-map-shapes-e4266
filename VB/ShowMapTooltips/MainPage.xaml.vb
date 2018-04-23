Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports System.Windows.Input
Imports DevExpress.Xpf.Map

Namespace ShowMapTooltips
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub mapControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim mapControl As MapControl = TryCast(sender, MapControl)
'			#Region "#MapControl_CalcHitInfo"
			Dim shape As MapShape = TryCast(mapControl.CalcHitInfo(e.GetPosition(mapControl)).MapPath, MapShape)
'			#End Region ' #MapControl_CalcHitInfo
			If shape IsNot Nothing Then
'				#Region "#MapItem_Attributes"
				Dim name As String = CStr(shape.Attributes("NAME").Value)
				name &= String.Format(": {0:n2}M", CDbl(shape.Attributes("POP_EST").Value) / 1000000)
'				#End Region ' #MapItem_Attributes
				shapeTooltip.Show(mapControl, e.GetPosition(mapControl), name)
			Else
				shapeTooltip.Hide()
			End If

		End Sub
		Private Sub mapControl1_MouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
			shapeTooltip.Hide()
		End Sub

	End Class
End Namespace
