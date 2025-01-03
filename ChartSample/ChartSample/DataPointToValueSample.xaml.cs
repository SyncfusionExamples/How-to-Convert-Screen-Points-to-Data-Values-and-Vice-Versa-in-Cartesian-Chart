using Syncfusion.Maui.Charts;

namespace ChartSample;

public partial class DataPointToValueSample : ContentPage
{
	public DataPointToValueSample()
	{
		InitializeComponent();
	}
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
            {
                Background = Color.FromArgb("#b37700"),
                TextColor = Colors.White,
                FontSize = 15, 
            };

            chart.Annotations.Add(text);
        }
    }
}