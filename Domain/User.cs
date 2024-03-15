namespace Domain
{
    public class User : Person
    {
        private List<TravelPlan> travelPlans = new List<TravelPlan>();

        public List<TravelPlan> GetTravelPlans()
        {
            return travelPlans;
        }

        public IReadOnlyList<TravelPlan> TravelPlans => GetTravelPlans().AsReadOnly();

        public void AddTravelPlan(TravelPlan plan)
        {
            travelPlans.Add(plan);
            
        }

    }
}