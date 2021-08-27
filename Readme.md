<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571035/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4266)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/ShowMapTooltips/MainPage.xaml) (VB: [MainPage.xaml](./VB/ShowMapTooltips/MainPage.xaml))
* [MainPage.xaml.cs](./CS/ShowMapTooltips/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/ShowMapTooltips/MainPage.xaml.vb))
* [MapShapeTooltip.cs](./CS/ShowMapTooltips/MapShapeTooltip.cs) (VB: [MapShapeTooltip.vb](./VB/ShowMapTooltips/MapShapeTooltip.vb))
<!-- default file list end -->
# How to show tooltips for map shapes 


<p>This example illustrates how to display tooltips for shapes loaded from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).  <br />
</p><p>Note that a tooltip displays information (a country name, population) for each map shape from Shapefiles.</p><p></p>


<h3>Description</h3>

<p>To extract this information from Shapefiles, use the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Nametopic"><u>MapItemAttribute.Name</u></a>,  <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Typetopic"><u>MapItemAttribute.Type</u></a> and <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Valuetopic"><u>MapItemAttribute.Value</u></a> properties. </p><p><br />
It is also necessary to use the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapControl_CalcHitInfotopic"><u>MapControl.CalcHitInfo</u></a> method in the <strong>MapControl.MouseMove</strong> event to determine which map shape is under  the mouse pointer.</p><p><br />
</p>

<br/>


