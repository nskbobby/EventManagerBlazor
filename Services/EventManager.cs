using EventEaseApp;

namespace EventEaseApp
{
    public class EventManager
    {
        private static List<EventModel> _events = new()
        {
            new EventModel { Name = "Tech Summit 2025", Date = DateTime.Now.AddDays(10), Location = "New York" },
            new EventModel { Name = "Health Expo", Date = DateTime.Now.AddDays(15), Location = "Chicago" },
            new EventModel { Name = "Startup Pitch", Date = DateTime.Now.AddDays(20), Location = "San Francisco" }
        };

        public List<EventModel> GetAllEvents() => _events;

        public void AddEvent(EventModel model) => _events.Add(model);

        public void UpdateEvent(string name, EventModel updated)
        {
            var evt = _events.FirstOrDefault(e => e.Name == name);
            if (evt != null)
            {
                evt.Date = updated.Date;
                evt.Location = updated.Location;
            }
        }

        public void DeleteEvent(string name)
        {
            var evt = _events.FirstOrDefault(e => e.Name == name);
            if (evt != null)
            {
                _events.Remove(evt);
            }
        }
    }
}
