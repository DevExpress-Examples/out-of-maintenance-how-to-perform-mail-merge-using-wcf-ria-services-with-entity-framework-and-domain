# How to perform mail merge using WCF RIA Services with Entity Framework and DomainDataSource


<p>This example illustrates how the <strong>DomainDataSource</strong> control can be utilized to provide data for the mail merge operation of the RichEditControl for Silverlight.<br />
After all data are loaded (in the <a href="http://msdn.microsoft.com/en-us/library/system.windows.controls.domaindatasource.loadeddata(v=vs.91).aspx"><strong><u>DomainDataSource.LoadedData</u></strong></a> event handler) , a new List is created from data objects obtained via the <a href="http://msdn.microsoft.com/en-us/library/system.windows.controls.loadeddataeventargs.allentities(v=vs.91).aspx"><u>LoadedDataEventArgs.AllEntities</u></a> property. This list is specified as a mail merge data source using the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXtraRichEditAPINativeMailMergeOptions_DataSourcetopic"><u>MailMergeOptions.DataSource</u></a> property.</p>

<br/>


