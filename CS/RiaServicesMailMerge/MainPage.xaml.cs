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
using DevExpress.Xpf.RichEdit;
using System.ServiceModel.DomainServices.Client;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Xpf.Collections;

namespace RiaServicesMailMerge
{
    public partial class MainPage : UserControl
    {
        List<RiaServicesMailMerge.Web.vEmployee> employeeList = new List<RiaServicesMailMerge.Web.vEmployee>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void vEmployeeDomainDataSource_LoadedData(object sender, System.Windows.Controls.LoadedDataEventArgs e)
        {

            if (e.HasError) {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }

            foreach (Entity en in e.AllEntities) {
                employeeList.Add((RiaServicesMailMerge.Web.vEmployee)en);
            }

            this.richEditControl1.Options.MailMerge.DataSource = employeeList;
        }

        private void richEditControl1_CustomizeMergeFields(object sender, DevExpress.XtraRichEdit.CustomizeMergeFieldsEventArgs e)
        {

            ArrayList dropDowns = new ArrayList();
            dropDowns.Add("Title");
            dropDowns.Add("FirstName");
            dropDowns.Add("MiddleName");
            dropDowns.Add("LastName");
            dropDowns.Add("PostalCode");
            dropDowns.Add("CountryRegionName");
            dropDowns.Add("City");
            dropDowns.Add("AddressLine1");
            dropDowns.Add("AddressLine2");

            List<MergeFieldName> result = new List<MergeFieldName>();

            for (int i = 0; i < dropDowns.Count; i++) {
                foreach (MergeFieldName fieldName in e.MergeFieldsNames) {
                    string value = dropDowns[i] as string;
                    if (value == fieldName.Name) result.Add(fieldName);
                }                            
            }
            
            e.MergeFieldsNames = result.ToArray();
        }
        
    }
}
