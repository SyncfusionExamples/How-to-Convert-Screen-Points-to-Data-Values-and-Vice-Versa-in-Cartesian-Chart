using Syncfusion.Maui.Charts;

namespace ChartSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
        }

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
    }

}
