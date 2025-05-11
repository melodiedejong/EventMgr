using Blazored.LocalStorage;
using EventMgr.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMgr.Services
{
    public class EventService
    {
        private readonly ILocalStorageService _localStorage;
        private const string EventKey = "eventlist";

        public EventService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        // Fetch all events
        public async Task<List<EventItem>> GetEventAsync()
        {
            var eventList = await _localStorage.GetItemAsync<List<EventItem>>(EventKey);
            return eventList ?? new List<EventItem>();
        }

        // Fetch an event by name
        public async Task<EventItem?> GetEventByNameAsync(string eventName)
        {
            var eventList = await GetEventAsync();
            return eventList.FirstOrDefault(e => e.Name.Equals(eventName, System.StringComparison.OrdinalIgnoreCase));
        }

        // Update an event by name
        public async Task UpdateEventByNameAsync(EventItem updatedEvent)
        {
            var eventList = await GetEventAsync();
            var index = eventList.FindIndex(e => e.Name.Equals(updatedEvent.Name, System.StringComparison.OrdinalIgnoreCase));
            if (index != -1)
            {
                eventList[index] = updatedEvent;
                await _localStorage.SetItemAsync(EventKey, eventList);
            }
        }

        // Add a new event
        public async Task AddEventAsync(EventItem newEvent)
        {
            var eventList = await GetEventAsync();
            eventList.Add(newEvent);
            await _localStorage.SetItemAsync(EventKey, eventList);
        }
    }
}