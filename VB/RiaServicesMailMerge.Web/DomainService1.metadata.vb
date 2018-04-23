Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace RiaServicesMailMerge.Web


	' The MetadataTypeAttribute identifies vEmployeeMetadata as the class
	' that carries additional metadata for the vEmployee class.
	<MetadataTypeAttribute(GetType(vEmployee.vEmployeeMetadata))> _
	Partial Public Class vEmployee

		' This class allows you to attach custom attributes to properties
		' of the vEmployee class.
		'
		' For example, the following marks the Xyz property as a
		' required property and specifies the format for valid values:
		'    [Required]
		'    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		'    [StringLength(32)]
		'    public string Xyz { get; set; }
		Friend NotInheritable Class vEmployeeMetadata

			' Metadata classes are not meant to be instantiated.
			Private Sub New()
			End Sub

			Private privateAdditionalContactInfo As String
			Public Property AdditionalContactInfo() As String
				Get
					Return privateAdditionalContactInfo
				End Get
				Set(ByVal value As String)
					privateAdditionalContactInfo = value
				End Set
			End Property

			Private privateAddressLine1 As String
			Public Property AddressLine1() As String
				Get
					Return privateAddressLine1
				End Get
				Set(ByVal value As String)
					privateAddressLine1 = value
				End Set
			End Property

			Private privateAddressLine2 As String
			Public Property AddressLine2() As String
				Get
					Return privateAddressLine2
				End Get
				Set(ByVal value As String)
					privateAddressLine2 = value
				End Set
			End Property

			Private privateCity As String
			Public Property City() As String
				Get
					Return privateCity
				End Get
				Set(ByVal value As String)
					privateCity = value
				End Set
			End Property

			Private privateCountryRegionName As String
			Public Property CountryRegionName() As String
				Get
					Return privateCountryRegionName
				End Get
				Set(ByVal value As String)
					privateCountryRegionName = value
				End Set
			End Property

			Private privateEmailAddress As String
			Public Property EmailAddress() As String
				Get
					Return privateEmailAddress
				End Get
				Set(ByVal value As String)
					privateEmailAddress = value
				End Set
			End Property

			Private privateEmailPromotion As Integer
			Public Property EmailPromotion() As Integer
				Get
					Return privateEmailPromotion
				End Get
				Set(ByVal value As Integer)
					privateEmailPromotion = value
				End Set
			End Property

			Private privateEmployeeID As Integer
			Public Property EmployeeID() As Integer
				Get
					Return privateEmployeeID
				End Get
				Set(ByVal value As Integer)
					privateEmployeeID = value
				End Set
			End Property

			Private privateFirstName As String
			Public Property FirstName() As String
				Get
					Return privateFirstName
				End Get
				Set(ByVal value As String)
					privateFirstName = value
				End Set
			End Property

			Private privateJobTitle As String
			Public Property JobTitle() As String
				Get
					Return privateJobTitle
				End Get
				Set(ByVal value As String)
					privateJobTitle = value
				End Set
			End Property

			Private privateLastName As String
			Public Property LastName() As String
				Get
					Return privateLastName
				End Get
				Set(ByVal value As String)
					privateLastName = value
				End Set
			End Property

			Private privateMiddleName As String
			Public Property MiddleName() As String
				Get
					Return privateMiddleName
				End Get
				Set(ByVal value As String)
					privateMiddleName = value
				End Set
			End Property

			Private privatePhone As String
			Public Property Phone() As String
				Get
					Return privatePhone
				End Get
				Set(ByVal value As String)
					privatePhone = value
				End Set
			End Property

			Private privatePostalCode As String
			Public Property PostalCode() As String
				Get
					Return privatePostalCode
				End Get
				Set(ByVal value As String)
					privatePostalCode = value
				End Set
			End Property

			Private privateStateProvinceName As String
			Public Property StateProvinceName() As String
				Get
					Return privateStateProvinceName
				End Get
				Set(ByVal value As String)
					privateStateProvinceName = value
				End Set
			End Property

			Private privateSuffix As String
			Public Property Suffix() As String
				Get
					Return privateSuffix
				End Get
				Set(ByVal value As String)
					privateSuffix = value
				End Set
			End Property

			Private privateTitle As String
			Public Property Title() As String
				Get
					Return privateTitle
				End Get
				Set(ByVal value As String)
					privateTitle = value
				End Set
			End Property
		End Class
	End Class
End Namespace
