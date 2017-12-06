//-----------------------------------------------------------------------
// <copyright file="ReconnaissanceFaciale.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc Delaunay</author>
// <author>Thomas LAURE</author>
//-----------------------------------------------------------------------

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjOXFORD_G2
{
    /// <summary> Classe principale de la reconnaissance faciale. </summary>
    /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
    public class ReconnaissanceFaciale
    {
        /// <summary> Lien de la clef Oxford. </summary>
        private const string CLE_OXFORD = "c68422f56ead4a0b998fd07811bf0b05";
        
        //// URL de POST de demande.
        
        /// <summary> The URI base detect. </summary>
        private const string URI_BASE_DETECT = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";

        /// <summary> The URI base verify. </summary>
        private const string URI_BASE_VERIFY = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/verify";

        /// <summary> The URI face add. </summary>
        private const string URI_FACE_ADD = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/facelists/oxford/persistedFaces";

        /// <summary> The URI face compare. </summary>
        private const string URI_FACE_COMPARE = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/findsimilars";

        /// <summary> Main entry-point for this application. </summary>
        /// <remarks> Thomas LAURE, 06/12/2017. </remarks>
        public static void Main()
        {
        }

        /// <summary>
        ///  Envoie une image sur les serveurs Microsoft et l'ajoute dans la facelist
        ///  Oxford et retourne un Face ID persistant.
        /// </summary>
        /// <param name="imageFilePath">Chemin de l'image à upload.</param>
        /// <returns>Peristant ID de l'image.</returns>
        public static async Task<string> FaceRecFaceAddListAsync(string imageFilePath)
        {
            HttpClient client = new HttpClient();
            JObject data;

            //// Entête de la demande.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", CLE_OXFORD);

            //// Assemblage de la requête URL.
            string uri = URI_FACE_ADD;

            HttpResponseMessage response;

            //// Mise en cache sous format binaire.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                //// Header content type de la requête.
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                //// Exécute la demande de POST.
                response = await client.PostAsync(uri, content);

                //// Téléchargement du JSON de réponse.
                string contentString = await response.Content.ReadAsStringAsync();
                contentString = contentString.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });

                //// Création du fichier JSON.
                data = JObject.Parse(JsonPrettyPrint(contentString));
            }

            return Convert.ToString(data.GetValue("persistedFaceId"));
        }

        /// <summary> Compare un visage à la liste des faceId. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="faceId"> Face ID à comparer. </param>
        /// <returns> Data. </returns>
        public static async Task<JObject> FaceRecCompareFaceAsync(string faceId)
        {
            HttpClient client = new HttpClient();
            JObject data;
            //// Entête de la demande.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", CLE_OXFORD);
            //// Assemblage de la requete URL.
            string uri = URI_FACE_COMPARE;
            HttpResponseMessage response;
            //// Body de la requête.
            string contentBefore = "{\"faceId\":\"" + faceId + "\",\"faceListId\":\"" + "oxford" + "\", \"maxNumOfCandidatesReturned\":1, \"mode\": \"matchPerson\"}";
            StringContent content = new StringContent(contentBefore);
            //// Header content type de la requête.
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //// Exécute the REST API call.
            response = await client.PostAsync(uri, content);
            //// Téléchargement du JSON de réponse.
            string contentString = await response.Content.ReadAsStringAsync();
            contentString = contentString.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });
            if (contentString != string.Empty)
            {
                data = JObject.Parse(JsonPrettyPrint(contentString));
            }
            else
            {
                return null;
            }

            return data;
        }

        /// <summary>
        /// Créer un faceId temporaire avec le chemin d'une image.
        /// </summary>
        /// <param name="imageFilePath">Chemin de l'image.</param>
        /// <returns> Data. </returns>
        public static async Task<JObject> FaceRecCreateFaceIdTempAsync(string imageFilePath)
        {
            HttpClient client = new HttpClient();
            JObject data;
            //// Entête de la demande.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", CLE_OXFORD);
            //// Paramètre de la requête.
            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";
            //// Assemblage de la requête URL.
            string uri = URI_BASE_DETECT + "?" + requestParameters;
            HttpResponseMessage response;
            //// Mise en cache sous format binaire.
            byte[] byteData = GetImageAsByteArray(imageFilePath);
            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                //// Header content type de la requete
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                //// Execute la demande de POST
                response = await client.PostAsync(uri, content);
                //// Téléchargement du JSON de réponse.
                string contentString = await response.Content.ReadAsStringAsync();
                contentString = contentString.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });

                if (contentString == string.Empty)
                {
                    throw new Exception("Aucun visage détecté ! ");
                }
                else
                {
                    data = JObject.Parse(JsonPrettyPrint(contentString));
                }

                return data;
            }
        }

        /// <summary>
        /// Envoie un Mail d'erreur au RSSI quand une personne tente de s'authentifier sans que ce soit vraiment elle.
        /// </summary>
        /// <param name="photoPath"> Chemin de l'image. </param>
        /// <exception cref="Exception">An Exception.</exception>
        public static void MailErreur(string photoPath)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("sio.bonaparte@gmail.com");
                message.To.Add(new MailAddress("bts-sio@lyc-bonaparte.fr"));
                message.Subject = "Inscription";
                Attachment photo = new Attachment(photoPath);
                message.Body = "Bonjour " +
                    "\n Bonjours," +
                    "\n Cette personne a tenté  de pénétrer dans l'enceinte de l'entreprise sans l'autorisation." +
                    "\n Merci de prendre les mesures adaptées.";
                message.Attachments.Add(photo);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("sio.bonaparte@gmail.com", "sCAtenTU");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary> Méthode permettant d'écrire coorectement le prénom pour l'afficher plus tard. </summary>
        /// <remarks> Thomas LAURE, 29/11/2017. </remarks>
        /// <param name="prenom"> Prénom du visiteur. </param>
        /// <returns> Le prénom de la personne souhaitant s'identifier en respectant les règles d'écriture du nom et du prénom. </returns>
        public static string PrenomToUpperFirstCase(string prenom)
        {
            string prenomUpper = string.Empty;
            char[] lettresPrenom = prenom.ToCharArray();
            string premiereLettrePrenom = Convert.ToString(lettresPrenom[0]).ToUpper();
            for (int i = 1; i < lettresPrenom.Count(); i++)
            {
                prenomUpper += Convert.ToString(lettresPrenom[i]).ToLower();
            }

            return premiereLettrePrenom + prenomUpper;
        }

        /// <summary>
        /// Converti l'image en tableau binaire.
        /// </summary>
        /// <param name="imageFilePath">Le fichier de l'image.</param>
        /// <returns>Un tableau de bits en fonction de l'image.</returns>
        private static byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }

        /// <summary>
        /// Formate le fichier JSON.
        /// </summary>
        /// <param name="json">Un fichier JSON en désordre.</param>
        /// <returns>Un fichier JSON reformaté.</returns>
        private static string JsonPrettyPrint(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return string.Empty;
            }
                
            json = json.Replace(Environment.NewLine, string.Empty).Replace("\t", string.Empty);
            StringBuilder sb = new StringBuilder();
            bool quote = false;
            bool ignore = false;
            int offset = 0;
            int indentLength = 3;
            foreach (char ch in json)
            {
                switch (ch)
                {
                    case '"':
                        if (!ignore)
                        {
                            quote = !quote;
                        }

                        break;
                    case '\'':
                        if (quote)
                        {
                            ignore = !ignore;
                        }

                        break;
                }

                if (quote)
                {
                    sb.Append(ch);
                }
                else
                {
                    switch (ch)
                    {
                        case '{':
                        case '[':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', ++offset * indentLength));
                            break;
                        case '}':
                        case ']':
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', --offset * indentLength));
                            sb.Append(ch);
                            break;
                        case ',':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', offset * indentLength));
                            break;
                        case ':':
                            sb.Append(ch);
                            sb.Append(' ');
                            break;
                        default:
                            if (ch != ' ') 
                            {
                                sb.Append(ch);
                            }

                            break;
                    }
                }
            }

            return sb.ToString().Trim();
        }
    }
}
