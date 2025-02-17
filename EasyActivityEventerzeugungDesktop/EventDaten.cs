using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EasyActivityEventerzeugungDesktop
{
    public class EventDaten {
        public EventDaten(
            Dictionary<string, object> eventDaten)
        {
            foreach (KeyValuePair<string, object> eventData in eventDaten)
            {
                switch (eventData.Key)
                {
                    case "Titel":
                        Titel = JsonSerializer.Deserialize <string>((JsonElement)eventData.Value);
                        break;
                    case "Beschreibung":
                        Beschreibung = JsonSerializer.Deserialize<string>((JsonElement)eventData.Value);
                        break;
                    case "Ort":
                        Ort = JsonSerializer.Deserialize<string>((JsonElement)eventData.Value);
                        break;
                    case "Staat":
                        Staat = JsonSerializer.Deserialize<string>((JsonElement)eventData.Value);
                        break;
                    case "Straße":
                        Straße = JsonSerializer.Deserialize<string>((JsonElement)eventData.Value);
                        break;
                    case "Hausnummer":
                        Hausnummer = JsonSerializer.Deserialize<string>((JsonElement)eventData.Value);
                        break;
                    case "Postleitzahl":
                        Postleitzahl = JsonSerializer.Deserialize<string>((JsonElement)eventData.Value);
                        break;
                    case "Startzeitpunkt":
                        Startzeitpunkt = JsonSerializer.Deserialize<DateTime>((JsonElement)eventData.Value);
                        break;
                    case "Endzeitpunkt":
                        Endzeitpunkt = JsonSerializer.Deserialize<DateTime>((JsonElement)eventData.Value);
                        break;
                    case "AktivitätID":
                        AktivitätID = JsonSerializer.Deserialize<long>((JsonElement)eventData.Value);
                        break;
                    default:
                        break;

                }
            }
        }

        public long AktivitätID { get; set; }
        public string Titel { get; set; }
        public string Beschreibung { get; set; }
        public string Ort { get; set; }
        public string Staat { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string Postleitzahl { get; set; }
        public DateTime Startzeitpunkt { get; set; }
        public DateTime Endzeitpunkt { get; set; }
    }
}
