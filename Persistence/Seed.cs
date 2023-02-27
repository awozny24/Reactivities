using Domain;

namespace Persistence 
{
  public class Seed
  {
    public static async Task SeedData(DataContext context)
    {
      if (context.Activities.Any()) return;

      var activities = new List<Activity>
      {
        new Activity
        {
          Title = "Past Activity 1",
          Date = DateTime.UtcNow.AddMonths(-2),
          Description = "Activity 2 months ago",
          Category = "drinks",
          City = "London",
          Venu = "Pub",
        },
        new Activity
        {
          Title = "Past Activity 2",
          Date = DateTime.UtcNow.AddMonths(-1),
          Description = "Activity 1 months ago",
          Category = "culture",
          City = "Paris",
          Venu = "Louvre",
        },
        new Activity
        {
          Title = "Future Activity 1",
          Date = DateTime.UtcNow.AddMonths(1),
          Description = "Activity 1 months in future",
          Category = "culture",
          City = "London",
          Venu = "Natural History Museum",
        },
        new Activity
        {
          Title = "Future Activity 2",
          Date = DateTime.UtcNow.AddMonths(2),
          Description = "Activity 2 months in future",
          Category = "music",
          City = "London",
          Venu = "02 Arena",
        },
        new Activity
        {
          Title = "Future Activity 3",
          Date = DateTime.UtcNow.AddMonths(3),
          Description = "Activity 3 months in future",
          Category = "drinks",
          City = "London",
          Venu = "Another pub",
        },
        new Activity
        {
          Title = "Future Activity 4",
          Date = DateTime.UtcNow.AddMonths(4),
          Description = "Activity 4 months in future",
          Category = "soccer",
          City = "London",
          Venu = "Chelsea stadium",
        },
        new Activity
        {
          Title = "Future Activity 5",
          Date = DateTime.UtcNow.AddMonths(5),
          Description = "Activity 5 months in future",
          Category = "dinner",
          City = "New Smyrna",
          Venu = "Breakers",
        },
        new Activity
        {
          Title = "Future Activity 6",
          Date = DateTime.UtcNow.AddMonths(6),
          Description = "Activity 6 months in future",
          Category = "Party",
          City = "New York",
          Venu = "Night Club",
        },
        new Activity
        {
          Title = "Future Activity 7",
          Date = DateTime.UtcNow.AddMonths(7),
          Description = "Activity 7 months in future",
          Category = "Sports Day",
          City = "London",
          Venu = "Park",
        },
        new Activity
        {
          Title = "Future Activity 8",
          Date = DateTime.UtcNow.AddMonths(8),
          Description = "Activity 8 months in future",
          Category = "film",
          City = "London",
          Venu = "Cinema",
        }
      };

      await context.Activities.AddRangeAsync(activities);
      await context.SaveChangesAsync();
    }
  }
}