<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128606677/11.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3888)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DomainService1.cs](./CS/RiaServicesMailMerge.Web/DomainService1.cs) (VB: [DomainService1.vb](./VB/RiaServicesMailMerge.Web/DomainService1.vb))
* [MainPage.xaml](./CS/RiaServicesMailMerge/MainPage.xaml) (VB: [MainPage.xaml](./VB/RiaServicesMailMerge/MainPage.xaml))
* [MainPage.xaml.cs](./CS/RiaServicesMailMerge/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/RiaServicesMailMerge/MainPage.xaml.vb))
<!-- default file list end -->
# How to perform mail merge using WCF RIA Services with Entity Framework and DomainDataSource


<p>This example illustrates how the <strong>DomainDataSource</strong> control can be utilized to provide data for the mail merge operation of the RichEditControl for Silverlight.<br />
After all data are loaded (in the <a href="http://msdn.microsoft.com/en-us/library/system.windows.controls.domaindatasource.loadeddata(v=vs.91).aspx"><strong><u>DomainDataSource.LoadedData</u></strong></a> event handler) , a new List is created from data objects obtained via the <a href="http://msdn.microsoft.com/en-us/library/system.windows.controls.loadeddataeventargs.allentities(v=vs.91).aspx"><u>LoadedDataEventArgs.AllEntities</u></a> property. This list is specified as a mail merge data source using the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXtraRichEditAPINativeMailMergeOptions_DataSourcetopic"><u>MailMergeOptions.DataSource</u></a> property.</p>

<br/>


