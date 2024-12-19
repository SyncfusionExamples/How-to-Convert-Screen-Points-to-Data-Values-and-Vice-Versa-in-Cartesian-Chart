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
                new Model { EmployeeName = "John", Year = new DateTime(2010, 01, 01), SalesRate = 170 },
                new Model { EmployeeName = "Emily", Year = new DateTime(2011, 01, 01), SalesRate = 96 },
                new Model { EmployeeName = "Michael", Year = new DateTime(2012, 01, 01), SalesRate = 65 },
                new Model { EmployeeName = "Sophia", Year = new DateTime(2013, 01, 01), SalesRate = 182 },
                new Model { EmployeeName = "David", Year = new DateTime(2014, 01, 01), SalesRate = 144 },
                new Model { EmployeeName = "Olivia", Year = new DateTime(2015, 01, 01), SalesRate = 124 },
                new Model { EmployeeName = "Daniel", Year = new DateTime(2016, 01, 01), SalesRate = 154 },
            };
        }
    }
}
