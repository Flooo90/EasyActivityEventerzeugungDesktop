using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EasyActivityEventerzeugungDesktop {

    public class Token {

        /// <summary> Speichert einen Token zur Authentifizierung des Nutzers bei Anfragen an die API </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary> Speichert den Typ des Tokens </summary>
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        /// <summary> Identifiziert ob der Nutzer zu dem Token ein Eventveranstallter ist </summary>

        [JsonPropertyName("IstEventveranstalter")]
        public bool IstEventveranstalter { get; set; }
    }
}
