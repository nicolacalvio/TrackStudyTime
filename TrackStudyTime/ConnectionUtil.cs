﻿using System;
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
        static async Task<string> getRequestAsync(string url, string values)
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
            string result = getRequestAsync("https://www.nicolacalvio.com/api/utenteRegistrato.php?nome=", nome).Result;
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
            if (getRequestAsync("https://www.nicolacalvio.com/api/registraUtente.php?nome=", nome + "&password=" + password + "&mail="+mail).Result.Equals("registrato"))
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
            if (getRequestAsync("https://www.nicolacalvio.com/api/mandaTempo.php?tempo=", Convert.ToString(tempo) + "&nome=" + nome + "&password="+password).Result.Equals("mandato"))
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
            return getRequestAsync("https://www.nicolacalvio.com/api/getTimeAmico.php?nome=", utente).Result;

        }
        public static bool aggiungiAmico(string nome, string nomeAmico)
        {
           if (getRequestAsync("https://www.nicolacalvio.com/api/aggiungiAmico.php?nome=", nome + "&nomeAmico=" + nomeAmico).Result.Equals("aggiunto"))
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
            return getRequestAsync("https://www.nicolacalvio.com/api/getTime.php?nome=", nome).Result;
        }
        public static bool mandaMail(string nome, string email, string massimaPausa)
        {
            if (getRequestAsync("https://www.nicolacalvio.com/api/mandaEmail.php?nome=", nome + "&email=" + email + "&pausa=" + massimaPausa).Result.Equals("mandato"))
                return true;
            else
                return false;
        }
        public static Tuple<string, double>[] prendiInfoGrafico(string nomeUtente, string partenza, string finale)
        {
           
            //01/02/2021;3960-02/02/2021;5000
            string result = getRequestAsync("https://www.nicolacalvio.com/api/prendiGrafico.php?nome=", nomeUtente + "&partenza=" + partenza + "&finale="+ finale).Result;
            string[] dati = result.Split('*');
            Tuple<string, double>[] tuplaArray = new Tuple<string, double>[dati.Length - 1];
            for (int i = 0; i < dati.Length-1; i++)
            {
                string[] temp = dati[i].Split(';');
                tuplaArray[i] = new Tuple<string, double>(DateUtil.convertiInFormatoIta(temp[0]), (Convert.ToDouble(temp[1])/60)/60);
            }
            return tuplaArray;
        }
        public static string[] returnStats(string nomeUtente, string partenza, string finale)
        {
            string result = getRequestAsync("https://www.nicolacalvio.com/api/returnStats.php?nome=", nomeUtente + "&partenza=" + partenza + "&finale=" + finale).Result;
            string[] dati = result.Split(';');
            //[0]sum [1]avg
            return dati;
        }
    }
}
