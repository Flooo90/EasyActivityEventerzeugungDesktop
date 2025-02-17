using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EasyActivityEventerzeugungDesktop
{
    public class EventDaten {

        /// <summary> Konstruktor der anhand eines Dictonarys mit Stings als Keys und Objekten als Werten die EventDaten ermittelt </summary>
        /// <param name="eventDaten"></param>
        public EventDaten (
            Dictionary<string,object> eventDaten) {
            foreach (KeyValuePair<string,object> eventData in eventDaten) {
                switch (eventData.Key) {
                    case "Titel":
                        Titel = JsonSerializer.Deserialize<string>((JsonElement)eventData.Value);
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

        /// <summary> Einndutiger Identifikator der Aktivität </summary>
        public long AktivitätID { get; set; }

        /// <summary> Titel der Aktivität </summary>
        public string Titel { get; set; }

        /// <summary> Beschreibung der Aktivität </summary>
        public string Beschreibung { get; set; }

        /// <summary> Staat der zur Aktivität zugeordneten Adresse </summary>
        public string Staat { get; set; }

        /// <summary> Ort der zur Aktivität zugeordneten Adresse </summary>
        public string Ort { get; set; }

        /// <summary> Postleitzahl der zur Aktivität zugeordneten Adresse </summary>
        public string Postleitzahl { get; set; }

        /// <summary> Straße der zur Aktivität zugeordneten Adresse </summary>
        public string Straße { get; set; }

        /// <summary> Hausnummer der zur Aktivität zugeordneten Adresse </summary>
        public string Hausnummer { get; set; }

        /// <summary> Startzeitpunkt der Aktivität </summary>
        public DateTime Startzeitpunkt { get; set; }

        /// <summary> Endzeitpunkt der Aktivität </summary>
        public DateTime Endzeitpunkt { get; set; }
    }
}
