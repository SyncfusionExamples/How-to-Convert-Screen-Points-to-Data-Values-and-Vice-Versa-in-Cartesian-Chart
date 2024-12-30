using System.Collections.ObjectModel;

namespace ChartSample
{
    public class Model
    {
        public string EmployeeName { get; set; }
        public DateTime Year { get; set; }
        public double SalesRate { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model { EmployeeName = "John", Year = new DateTime(2010,01 , 31), SalesRate = 170 },
                new Model { EmployeeName = "Emily", Year = new DateTime(2010, 02, 28), SalesRate = 96 },
                new Model { EmployeeName = "Michael", Year = new DateTime(2010, 03, 31), SalesRate = 65 },
                new Model { EmployeeName = "Sophia", Year = new DateTime(2010, 04, 30), SalesRate = 182 },
                new Model { EmployeeName = "David", Year = new DateTime(2010, 05, 31), SalesRate = 144 },
                new Model { EmployeeName = "Olivia", Year = new DateTime(2010, 06, 30), SalesRate = 124 },
                new Model { EmployeeName = "Daniel", Year = new DateTime(2010, 07, 31), SalesRate = 154 },
            };
        }
    }
}
