using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxAndWhiskerSeries
{
    internal class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model() { Subjects = "Tamil", Marks = new List<double> { 22, 22, 23, 25, 25, 25, 26, 27, 27, 28, 28, 29, 30, 32, 34, 32, 34, 36, 35, 38 },Total=200 });
            Data.Add(new Model() { Subjects = "English", Marks = new List<double> { 22, 33, 23, 25, 26, 28, 29, 30, 34, 33, 32, 31, 50 },Total=180 });
            Data.Add(new Model() { Subjects = "Maths", Marks = new List<double> { 22, 24, 25, 30, 32, 34, 36, 38, 39, 41, 35, 36, 40, 56 },Total=150 });
            Data.Add(new Model() { Subjects = "Science", Marks = new List<double> { 26, 27, 28, 30, 32, 34, 35, 37, 35, 37, 45 }, Total = 210 });
        }
    }
}
