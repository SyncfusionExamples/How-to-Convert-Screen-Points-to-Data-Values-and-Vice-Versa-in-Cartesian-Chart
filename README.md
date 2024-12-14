# How to Convert Screen Points to Data Values and Vice Versa in .NET MAUI Cartesian Chart
The [.NET MAUI SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) offers powerful methods for converting between data values and screen points, enabling dynamic data interaction within charts. This article guides you through using these methods.

* [Value to DataPoint :](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_) Convert a data value from the chart’s data model into a screen coordinate.
* [DataPoint to Value:](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PointToValue_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_) Convert a screen coordinate (pixel position) into a data model value.

This example demonstrates handling button clicks to display text annotations on the chart’s highest and lowest values using the converted value/data points.

### Initialize SfCartesianChart:
Set up the **SfCartesianChart** following the [guidelines in documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started).

### Value To DataPoint in Category Axis:
In the XAML, define the **SfCartesianChart** with [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) and include two buttons to trigger the actions for converting values:

**[XAML]**
 
 ```xml
<chart:SfCartesianChart x:Name="chart">

<chart:SfCartesianChart.XAxes>
    <chart:CategoryAxis x:Name="xAxis"/>
</chart:SfCartesianChart.XAxes>
  ...

 </chart:SfCartesianChart>
<Button Text="Value To DataPoint"  Clicked="Button_Clicked"/>
<Button Text="DataPoint To Value" Clicked="Button_Clicked_1"/> 
 ```

 **[C#]**

In this example, we convert a data value to a screen point, then display a [TextAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TextAnnotation.html) at that point on the chart:
 
 ```csharp
private void Button_Clicked(object sender, EventArgs e)
 {
     if (chart is SfCartesianChart cartesianChart)
     {
         //Convert chart point to screen point.
         var xPoint = cartesianChart.ValueToPoint(cartesianChart.XAxes[0], 1.8);
         var yPoint = cartesianChart.ValueToPoint(cartesianChart.YAxes[0], 40);

         var text = new TextAnnotation()
         {
             X1 = xPoint,
             Y1 = yPoint,
             Text = "Lowest Sales Month",
             CoordinateUnit = ChartCoordinateUnit.Pixel
         };
         ...
        chart.Annotations.Add(text);
     }
 }
 ```

### Value to DataPoint in DateTimeAxis:
In the XAML, define the **SfCartesianChart** with [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#properties) :

**[XAML]**
 
 ```xml
<chart:SfCartesianChart x:Name="chart">
<chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis x:Name="xAxis" IntervalType="Years" Interval="1">
            <chart:DateTimeAxis.LabelStyle>
                <chart:ChartAxisLabelStyle LabelFormat="yyyy-MMM" />
            </chart:DateTimeAxis.LabelStyle>
        </chart:DateTimeAxis>
 </chart:SfCartesianChart.XAxes>

...
 ```
**[C#]**

Using the **ToOADate()** built-in method, convert the DateTime value to a double.
 
 ```csharp
private void Button_Clicked(object sender, EventArgs e)
 {
     if (chart is SfCartesianChart cartesianChart)
     {
         //Convert chart point to screen point.
         var xPoint = cartesianChart.ValueToPoint(cartesianChart.XAxes[0], new DateTime(2011,10,10).ToOADate());
         var yPoint = cartesianChart.ValueToPoint(cartesianChart.YAxes[0], 40);

         var text = new TextAnnotation()
         {
             X1 = xPoint,
             Y1 = yPoint,
             Text = "Lowest Sales Year",
             CoordinateUnit = ChartCoordinateUnit.Pixel
         };
        ...
         chart.Annotations.Add(text);
     }
 } 
 ```

### DataPoint to Value:
In this example, we convert a screen coordinate (pixel position) to the corresponding data value and display a [TextAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TextAnnotation.html) at that point:

 
 ```csharp
private void Button_Clicked_1(object sender, EventArgs e)
 {
     if (chart is SfCartesianChart cartesianChart)
     {
         //Convert screen point to chart point.
         var xValue = cartesianChart.PointToValue(cartesianChart.XAxes[0], 660, 100);
         var yValue = cartesianChart.PointToValue(cartesianChart.YAxes[0], 660, 100);

         var text = new TextAnnotation()
         {
             X1 = xValue,
             Y1 = yValue,
             Text = "Highest Sales Month",
             CoordinateUnit = ChartCoordinateUnit.Axis
         };
        ...
        chart.Annotations.Add(text);
     }
 } 
 ```

**[Output]**
 
 ![ValueToDatapoint.gif](https://support.syncfusion.com/kb/agent/attachment/article/18515/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0MDM2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.11AHIh90dmWHbghHndwh9EC80-mBuMclmwSTAWMcg-Y)
 
### Github
For more details, refer to the [Value to data point vice versa conversion sample](https://github.com/SyncfusionExamples/How-to-Convert-Screen-Points-to-Data-Values-and-Vice-Versa-in-Cartesian-Chart).

