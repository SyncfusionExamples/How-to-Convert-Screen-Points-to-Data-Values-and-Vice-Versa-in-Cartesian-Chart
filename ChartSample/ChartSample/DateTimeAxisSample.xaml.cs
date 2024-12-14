using Syncfusion.Maui.Charts;

namespace ChartSample;

public partial class DateTimeAxisSample : ContentPage
{
	public DateTimeAxisSample()
	{
		InitializeComponent();
	}
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
            text.LabelStyle = new ChartAnnotationLabelStyle()
            {
                Background = Color.FromArgb("#D76C82"),
                FontSize = 15
            };

            chart.Annotations.Add(text);
        }
    }

    private void Button_Clicked1(object sender, EventArgs e)
    {
        if (chart is SfCartesianChart cartesianChart)
        {
            //Convert screen point to chart point.
            var xValue = cartesianChart.PointToValue(cartesianChart.XAxes[0], 640, 100);
            var yValue = cartesianChart.PointToValue(cartesianChart.YAxes[0], 640, 100);

            var text = new TextAnnotation()
            {
                X1 = xValue,
                Y1 = yValue,
                Text = "Highest Sales Year",
                CoordinateUnit = ChartCoordinateUnit.Axis
            };
            text.LabelStyle = new ChartAnnotationLabelStyle()
            {
                Background = Color.FromArgb("#D76C82"),
                FontSize = 15
            };

            chart.Annotations.Add(text);
        }
    }
}