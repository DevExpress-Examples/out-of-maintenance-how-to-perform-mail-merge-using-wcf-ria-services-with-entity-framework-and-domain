
namespace RiaServicesMailMerge.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies vEmployeeMetadata as the class
    // that carries additional metadata for the vEmployee class.
    [MetadataTypeAttribute(typeof(vEmployee.vEmployeeMetadata))]
    public partial class vEmployee
    {

        // This class allows you to attach custom attributes to properties
        // of the vEmployee class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class vEmployeeMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private vEmployeeMetadata()
            {
            }

            public string AdditionalContactInfo { get; set; }

            public string AddressLine1 { get; set; }

            public string AddressLine2 { get; set; }

            public string City { get; set; }

            public string CountryRegionName { get; set; }

            public string EmailAddress { get; set; }

            public int EmailPromotion { get; set; }

            public int EmployeeID { get; set; }

            public string FirstName { get; set; }

            public string JobTitle { get; set; }

            public string LastName { get; set; }

            public string MiddleName { get; set; }

            public string Phone { get; set; }

            public string PostalCode { get; set; }

            public string StateProvinceName { get; set; }

            public string Suffix { get; set; }

            public string Title { get; set; }
        }
    }
}
