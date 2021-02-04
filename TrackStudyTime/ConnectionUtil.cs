using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text.Json;

namespace TrackStudyTime
{
    class ConnectionUtil
    {
        private static readonly HttpClient client = new HttpClient();
        static string getRequestAsync(string url, string values)
        {
            /*
            string postData = "This is a test that posts this string to a Web server.";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            */
            WebRequest request = WebRequest.Create(url+values);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            /*
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            */
            WebResponse response = request.GetResponse();
            string responseFromServer;
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }
            response.Close();
            return responseFromServer;
            //var responseString = await client.GetStringAsync(url+values);
            //return responseString;
        }
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static bool utenteRegistrato(string nome)
        {
            string result = getRequestAsync("https://www.nicolacalvio.com/api/utenteRegistrato.php?nome=", nome);
            if (result.Equals("registrato"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool registraUtente(string nome, string password, string mail)
        {
            password = ComputeSha256Hash(password);
            if (getRequestAsync("https://www.nicolacalvio.com/api/registraUtente.php?nome=", nome + "&password=" + password + "&mail="+mail).Equals("registrato"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool mandaTempo(string nome, int tempo, string password)
        {
            password = ComputeSha256Hash(password);
            if (getRequestAsync("https://www.nicolacalvio.com/api/mandaTempo.php?tempo=", Convert.ToString(tempo) + "&nome=" + nome + "&password="+password).Equals("mandato"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string prendiTempoAmici(string utente)
        {
            return getRequestAsync("https://www.nicolacalvio.com/api/getTimeAmico.php?nome=", utente);

        }
        public static bool aggiungiAmico(string nome, string nomeAmico)
        {
           if (getRequestAsync("https://www.nicolacalvio.com/api/aggiungiAmico.php?nome=", nome + "&nomeAmico=" + nomeAmico).Equals("aggiunto"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string getTempoSeStessoGiorno(string nome)
        {
            //TODO: implementare
            //ritorna secondi minuti ore in questo ordine con un ; in mezzo
            return null;
        }
        public static bool mandaMail(string nome, string email, string massimaPausa)
        {
            //TODO: da implementare
            return true;
        }
    }
}
