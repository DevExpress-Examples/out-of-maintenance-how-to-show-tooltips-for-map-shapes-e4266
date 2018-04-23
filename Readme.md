# How to show tooltips for map shapes 


<p>This example illustrates how to display tooltips for shapes loaded from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).  <br />
</p><p>Note that a tooltip displays information (a country name, population) for each map shape from Shapefiles.</p><p></p>


<h3>Description</h3>

<p>To extract this information from Shapefiles, use the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Nametopic"><u>MapItemAttribute.Name</u></a>,  <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Typetopic"><u>MapItemAttribute.Type</u></a> and <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Valuetopic"><u>MapItemAttribute.Value</u></a> properties. </p><p><br />
It is also necessary to use the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapMapControl_CalcHitInfotopic"><u>MapControl.CalcHitInfo</u></a> method in the <strong>MapControl.MouseMove</strong> event to determine which map shape is under  the mouse pointer.</p><p><br />
</p>

<br/>


