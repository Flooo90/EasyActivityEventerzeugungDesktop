using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                        Titel = (string)eventData.Value;
                        break;
                    case "Beschreibung":
                        Beschreibung = (string)eventData.Value;
                        break;
                    case "Ort":
                        Ort = (string)eventData.Value;
                        break;
                    case "Staat":
                        Staat = (string)eventData.Value;
                        break;
                    case "Straße":
                        Straße = (string)eventData.Value;
                        break;
                    case "Hausnummer":
                        Hausnummer = (string)eventData.Value;
                        break;
                    case "Postleitzahl":
                        Postleitzahl = (string)eventData.Value;
                        break;
                    case "Startzeitpunkt":
                        Startzeitpunkt = (DateTime)eventData.Value;
                        break;
                    case "Endzeitpunkt":
                        Endzeitpunkt = (DateTime)eventData.Value;
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
