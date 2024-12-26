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
            var xPoint = cartesianChart.ValueToPoint(cartesianChart.XAxes[0], new DateTime(2010,04,30).ToOADate());
            var yPoint = cartesianChart.ValueToPoint(cartesianChart.YAxes[0], 182);

            trackball.Show(xPoint, yPoint);
        }
    }
}