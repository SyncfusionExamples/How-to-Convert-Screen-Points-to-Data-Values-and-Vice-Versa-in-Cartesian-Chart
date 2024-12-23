The [.NET MAUI SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) offers powerful methods for converting between data values and screen points, enabling dynamic data interaction within charts. This article guides you through using these methods.

* [Value to DataPoint :](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_) Convert a data value from the chart’s data model into a screen coordinate.
* [DataPoint to Value:](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PointToValue_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_) Convert a screen coordinate (pixel position) into a data model value.

This example demonstrates handling button clicks to display [tooltip](https://help.syncfusion.com/maui/cartesian-charts/tooltip), [trackball](https://help.syncfusion.com/maui/cartesian-charts/trackball), [text annotations](https://help.syncfusion.com/maui/cartesian-charts/annotation#text-annotation) on the chart’s using the converted value/data points.

## Step 1: Initialize SfCartesianChart
Set up the **SfCartesianChart** following the [guidelines in documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started).

## Step 2: Value To DataPoint

### Value To DataPoint in Category Axis:
Define the **SfCartesianChart** with [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html).  Initialize the [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) with a name and set the [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) property to `true` for the series.

**[XAML]**
 
 ```xml
<Grid RowDefinitions="*,100">
<chart:SfCartesianChart x:Name="chart">

<chart:SfCartesianChart.XAxes>
    <chart:CategoryAxis/>
</chart:SfCartesianChart.XAxes>
  ...

 <chart:SfCartesianChart.TooltipBehavior>
     <chart:ChartTooltipBehavior x:Name="tooltip"/>
 </chart:SfCartesianChart.TooltipBehavior>

 <chart:ColumnSeries EnableTooltip="True"/>
 </chart:SfCartesianChart>
 
<Button Grid.Row="1" Text="Value To DataPoint"  Clicked="Button_Clicked"/>
</Grid>
 ```
Each X-axis value is treated as an index (e.g., 0, 1, 2). The [ValueToPoint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_) method converts data values to screen coordinates, and the [Show](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html#Syncfusion_Maui_Charts_ChartTooltipBehavior_Show_System_Single_System_Single_System_Boolean_) method displays the `tooltip` at the nearest data point for the given X and Y values. 

**[C#]**
 
 ```csharp
private void Button_Clicked(object sender, EventArgs e)
 {
     if (chart is SfCartesianChart cartesianChart)
    {
     //Convert chart point to screen point.
     var xPoint = cartesianChart.ValueToPoint(cartesianChart.XAxes[0], 2);
     var yPoint = cartesianChart.ValueToPoint(cartesianChart.YAxes[0], 65);

     tooltip.Show(xPoint, yPoint, true);
    }
 }
 ```
 ![Category-axis.gif](https://support.syncfusion.com/kb/agent/attachment/article/18515/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0MzExIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.mex4oQnuEc98ZrTNtHPRfyVyzbEd-bkhCGITffsjxgM) 

### Value to DataPoint in DateTimeAxis:
Define the **SfCartesianChart** with [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#properties). Initialize the [ChartTrackballBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html) with a name.

**[XAML]**
 
 ```xml
<Grid RowDefinitions="*,100">
<chart:SfCartesianChart x:Name="chart">
<chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis x:Name="xAxis" Interval="1" IntervalType="Months">
            <chart:DateTimeAxis.LabelStyle>
                <chart:ChartAxisLabelStyle LabelFormat="MMM-dd"/>
            </chart:DateTimeAxis.LabelStyle>
        </chart:DateTimeAxis>
 </chart:SfCartesianChart.XAxes>
 
  <chart:SfCartesianChart.TrackballBehavior>
      <chart:ChartTrackballBehavior x:Name="trackball"/>
  </chart:SfCartesianChart.TrackballBehavior>
 </chart:SfCartesianChart>
<Button Grid.Row="1" Text="Value To DataPoint"  Clicked="Button_Clicked"/>
</Grid>
 ```
Using the **ToOADate()** built-in method, convert the DateTime value to a double.The [ValueToPoint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_) method is convert the data value into screen coordinates, and the `trackball` is displayed at the converted point using the [Show](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html#Syncfusion_Maui_Charts_ChartTrackballBehavior_Show_System_Single_System_Single_) method.

**[C#]**
 
 ```csharp
private void Button_Clicked(object sender, EventArgs e)
 {
   if (chart is SfCartesianChart cartesianChart)
  {
     //Convert chart point to screen point.
     var xPoint = cartesianChart.ValueToPoint(cartesianChart.XAxes[0], new DateTime(2010,04,30).ToOADate());
     var yPoint = cartesianChart.ValueToPoint(cartesianChart.YAxes[0], 182);

     trackball.Show(xPoint, yPoint);
  }
 } 
 ```
 
 ![DateTimeAxis.gif](https://support.syncfusion.com/kb/agent/attachment/article/18515/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0MzM1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.pt6ktasbXCmrJhVSciD4g8wXXkI5wx3Js7Nofivpsro)
 

## Step 3: DataPoint to Value
In this example, we convert a screen coordinate (pixel position) to the corresponding data value and display a [TextAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TextAnnotation.html) at that point:

 
 ```csharp
 private void Button_Clicked1(object sender, EventArgs e)
 {
     if (chart is SfCartesianChart cartesianChart)
     {
         //Convert screen point to chart point.
         var xValue = cartesianChart.PointToValue(cartesianChart.XAxes[0], 630, 100);
         var yValue = cartesianChart.PointToValue(cartesianChart.YAxes[0], 630, 100);

         var text = new TextAnnotation()
         {
             X1 = xValue,
             Y1 = yValue,
             Text = "Highest Sales Month",
             CoordinateUnit = ChartCoordinateUnit.Axis
         };
         text.LabelStyle = new ChartAnnotationLabelStyle()
        ...
         chart.Annotations.Add(text);
     }
 }
 ```
 ![DateTimeValue.gif](https://support.syncfusion.com/kb/agent/attachment/article/18515/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0MzM2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.kTJIs32GTSBfyRT6smujuOZYgbWqFZ7qz7S9QqT4yng)
## Github
For more details, refer to the [Value to data point vice versa conversion sample](https://github.com/SyncfusionExamples/How-to-Convert-Screen-Points-to-Data-Values-and-Vice-Versa-in-Cartesian-Chart).