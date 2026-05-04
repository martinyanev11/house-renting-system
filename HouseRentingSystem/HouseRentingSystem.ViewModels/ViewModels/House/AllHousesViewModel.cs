namespace HouseRentingSystem.Models.ViewModels.House
{
    public class AllHousesViewModel
    {
        public IEnumerable<HouseDetailsViewModel> Houses { get; set; } = 
            new List<HouseDetailsViewModel>();

        public int Rating { get; set; }
    }
}
