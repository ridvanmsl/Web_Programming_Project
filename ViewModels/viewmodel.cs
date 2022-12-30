using WebAssignment.Models;

namespace WebAssignment.ViewModels
{
    public class viewmodel
    {
        public IEnumerable<movies>? popmvs { get; set; }
        public IEnumerable<news>? nws { get; set; }
        public IEnumerable<movies>? mvs { get; set; }
        public IEnumerable<movies>? willoutmovs { get; set; }
    }
}
