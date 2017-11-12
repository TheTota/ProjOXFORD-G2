using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ProjOXFORD_G2
{
    public class ReconnaissanceFaciale
    {

        //Lien de la clef Oxford
        const string clefOxford = "bade90def1b947a7ae96c103847db05c";

        //Url de POST de demande 
        const string uriBaseDetect = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";
        const string uriBaseVerify = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/verify";
        const string uriFaceAdd = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/facelists/oxford/persistedFaces";
        const string uriFaceCompare = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/findsimilars";

        public static void Main()
        {
            // Récupération du path de l'image
            //Console.WriteLine("chemin de l'image svp : \n");
            //string imageFilePath = Console.ReadLine();

            //Task<string> faceAdd = FaceAddAsync(imageFilePath);
            //faceAdd.Wait();
            //Console.WriteLine(faceAdd.Result);

            //Task<string> tempFaceAdd = FaceRecCreateFaceIdTempAsync(imageFilePath);
            //tempFaceAdd.Wait();
            //Console.WriteLine(tempFaceAdd.Result);

            //Task<int> compareFace = FaceRecCompareFaceAsync(imageFilePath);
            //compareFace.Wait();
            //Console.WriteLine(compareFace.Result);



            //Console.ReadLine();

        }

        /// <summary>
        ///  Envoie une image sur les serveurs microsoft l'ajoute dans la facelist
        ///  Oxford et retourne un faceId persistant
        /// </summary>
        /// <param name="imageFilePath">Chemin de l'image à upload</param>
        /// <returns>Peristant id de l'image</returns>
        public static async Task<string> FaceRecFaceAddListAsync(string imageFilePath)
        {
            HttpClient client = new HttpClient();
            JObject data;

            // Entête de la demande.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", clefOxford);

            // Assemblage de la requete URL.
            string uri = uriFaceAdd;

            HttpResponseMessage response;

            // Mise en cache sous format binaire.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // Header content type de la requete
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                // Execute la demande de POST
                response = await client.PostAsync(uri, content);

                // Téléchargement du JSON de réponse.
                string contentString = await response.Content.ReadAsStringAsync();
                contentString = contentString.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });

                // Création du fichier Json.
                data = JObject.Parse(JsonPrettyPrint(contentString));
            }
            //Console.WriteLine(JsonPrettyPrint(contentString));
            return Convert.ToString(data.GetValue("persistedFaceId"));
        }

        /// <summary>
        /// Compare un visage à la liste des faceId
        /// </summary>
        /// <param name="imageFilePath">Chemin de l'image à comparer.</param>
        async public static Task<int> FaceRecCompareFaceAsync(string faceId)
        {
            HttpClient client = new HttpClient();
            JObject data;


            // Entête de la demande.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", clefOxford);

            // Assemblage de la requete URL.
            string uri = uriFaceCompare;

            HttpResponseMessage response;

            //Génère une image temporaire pour la reconnaissance ICI PROBELEME
            //JObject tempFaceAdd = await FaceRecCreateFaceIdTempAsync(imageFilePath);
            //string faceId = Convert.ToString(tempFaceAdd.GetValue("faceId"));

            // Body de la requete
            string contentBefore = "{\"faceId\":\"" + faceId + "\",\"faceListId\":\"" + "oxford" + "\", \"maxNumOfCandidatesReturned\":1, \"mode\": \"matchPerson\"}";
            StringContent content = new StringContent(contentBefore);

            // Header content type de la requete
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            // Execute the REST API call.
            response = await client.PostAsync(uri, content);

            // Téléchargement du JSON de réponse.
            string contentString = await response.Content.ReadAsStringAsync();
            contentString = contentString.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });
            if (contentString != "")
            {
                data = JObject.Parse(JsonPrettyPrint(contentString));
            }
            else
            {
                return 0;
            }

            // Converti en objet java 
            //data = JObject.Parse(JsonPrettyPrint(contentString));

            return Convert.ToInt16(data.GetValue("confidence"));
        }


        /// <summary>
        /// Créer un faceId temporaire avec le chemin d'une image
        /// </summary>
        /// <param name="imageFilePath">Chemin de l'image.</param>
        public static async Task<JObject> FaceRecCreateFaceIdTempAsync(string imageFilePath)
        {
            HttpClient client = new HttpClient();
            JObject data;

            // Entête de la demande.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", clefOxford);

            // Paramètre de la requete.
            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";

            // Assemblage de la requete URL.
            string uri = uriBaseDetect + "?" + requestParameters;

            HttpResponseMessage response;

            // Mise en cache sous format binaire.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // Header content type de la requete
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                // Execute la demande de POST
                response = await client.PostAsync(uri, content);

                // Téléchargement du JSON de réponse.
                string contentString = await response.Content.ReadAsStringAsync();
                contentString = contentString.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });

                if (contentString == "")
                {
                    throw new Exception("Aucun visage détécté ! ");
                }
                else
                {
                    data = JObject.Parse(JsonPrettyPrint(contentString));
                }

                return data;
            }
        }


        /// <summary>
        /// Converti l'image en tableau binaire
        /// </summary>
        /// <param name="imageFilePath">Le fichier de l'image.</param>
        /// <returns>Un tableau de bite en fonction de l'image.</returns>
        private static byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }


        /// <summary>
        /// Formate le fichier JSON.
        /// </summary>
        /// <param name="json">Un fichier JSON en bordel.</param>
        /// <returns>Un fichier JSON reformaté.</returns>
        private static string JsonPrettyPrint(string json)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;

            json = json.Replace(Environment.NewLine, "").Replace("\t", "");

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
                        if (!ignore) quote = !quote;
                        break;
                    case '\'':
                        if (quote) ignore = !ignore;
                        break;
                }

                if (quote)
                    sb.Append(ch);
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
                            if (ch != ' ') sb.Append(ch);
                            break;
                    }
                }
            }

            return sb.ToString().Trim();
        }

        /// <summary>
        /// envois un Mail d'erreur au RSSI quand une personne tente de s'authentifier sans que ce sois vraiment elle.
        /// </summary>
        /// <param name="Image"> chemin de l'image</param>
        /// <exception cref="Exception"></exception>
        public static void MailErreur(string Image)
        {
            //Addresse Expediteur/receveur
            MailAddress From = new MailAddress("Expediteur@mail.com", "Nom Prénom"); /* mail de l'expéditeur (a renseigner)*/
            MailAddress To = new MailAddress("receveur@mail.com", "Nom Prénom"); /* Mail du receveur (a renseigner)*/

            //Contenant du message
            MailMessage message = new MailMessage(From, To)
            {
                Subject = "Erreur d'authentification",
                Body = "Cette personne à tenté de s'authentifier sans succès"
            };

            //Renseignement de la pièce jointe
            Attachment data = new Attachment(Image);
            message.Attachments.Add(data);

            //serveur SMTP
            SmtpClient client = new SmtpClient("Leserveur"); /* renseinger le serveur smtp */

            try
            {
                //Envois du message
                client.Send(message);
            }
            catch
            {
                throw new Exception();
            }

        }
    }
}
