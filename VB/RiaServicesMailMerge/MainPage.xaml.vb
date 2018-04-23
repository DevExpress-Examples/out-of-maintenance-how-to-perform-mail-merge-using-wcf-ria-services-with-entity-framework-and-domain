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
Imports DevExpress.Xpf.RichEdit
Imports System.ServiceModel.DomainServices.Client
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Xpf.Collections

Namespace RiaServicesMailMerge
	Partial Public Class MainPage
		Inherits UserControl
		Private employeeList As New List(Of RiaServicesMailMerge.Web.vEmployee)()

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub vEmployeeDomainDataSource_LoadedData(ByVal sender As Object, ByVal e As System.Windows.Controls.LoadedDataEventArgs)

			If e.HasError Then
				System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK)
				e.MarkErrorAsHandled()
			End If

			For Each en As Entity In e.AllEntities
				employeeList.Add(CType(en, RiaServicesMailMerge.Web.vEmployee))
			Next en

			Me.richEditControl1.Options.MailMerge.DataSource = employeeList
		End Sub

		Private Sub richEditControl1_CustomizeMergeFields(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.CustomizeMergeFieldsEventArgs)

			Dim dropDowns As New ArrayList()
			dropDowns.Add("Title")
			dropDowns.Add("FirstName")
			dropDowns.Add("MiddleName")
			dropDowns.Add("LastName")
			dropDowns.Add("PostalCode")
			dropDowns.Add("CountryRegionName")
			dropDowns.Add("City")
			dropDowns.Add("AddressLine1")
			dropDowns.Add("AddressLine2")

			Dim result As New List(Of MergeFieldName)()

			For i As Integer = 0 To dropDowns.Count - 1
				For Each fieldName As MergeFieldName In e.MergeFieldsNames
					Dim value As String = TryCast(dropDowns(i), String)
					If value = fieldName.Name Then
						result.Add(fieldName)
					End If
				Next fieldName
			Next i

			e.MergeFieldsNames = result.ToArray()
		End Sub

	End Class
End Namespace
