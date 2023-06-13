namespace CodebridgeTest.ViewModels
{
    public class DogTableViewModel
    {
        public List<DogViewModel> DogsList { get; set; }
        public DogTableFilterViewModel Filter { get; set; }
        public int TotalDogsCount { get; set; }
    }
}
