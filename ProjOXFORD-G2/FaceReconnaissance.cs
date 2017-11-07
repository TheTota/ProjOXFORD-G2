////-----------------------------------------------------------------------
//// <copyright file="FaceReconnaissance.cs" company="SIO">
////     Copyright (c) SIO. All rights reserved.
//// </copyright>
//// <author>Loic DELAUNAY</author>
////-----------------------------------------------------------------------

//using Microsoft.ProjectOxford.Face;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using Newtonsoft.Json.Linq;

//namespace ProjOXFORD_G2
//{
//    static public class FaceReconnaissance
//    {
//        // Lien de la clef Oxford
//        const string clefOxford = "bade90def1b947a7ae96c103847db05c";

//        // Url de POST de demande 
//        const string uriBaseDetect = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";
//        const string uriBaseVerify = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/verify";

//        static public void Main()
//        {
//            try
//            {
//                // Reconnaissance faciale qui retourne true or false en fonction du résultat de la reco
//                Task<bool> taskRecoFaciale = ReconnaissanceFacialeAsync();

//                // Demande de l'API.
//                FaceAnalyse(imageFilePath);
//                //FaceCompare("51cb5321-1ca1-4618-a296-68cfe9699f69", "3edfa0ce-9a96-4004-99e9-d867f0dcc7dd");

//                // On attend que la reconnaissance faciale soit finie 
//                taskRecoFaciale.Wait();

//                // Affichage du résultat du test de correspondance (succès ou échec)
//                if (taskRecoFaciale.Result)
//                {
//                    Console.WriteLine("La personne a été reconnue.");
//                }
//                else
//                {
//                    Console.WriteLine("La personne n'a pas été reconnue");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            // On garde la console ouverte
//            Console.ReadLine();
//        }

//        /// <summary>
//        /// Méthode regroupant les étapes de la reconnaissance faciale pour obtenir
//        /// un simple oui ou non concernant le succès de la reconnaissance faciale.
//        /// </summary>
//        /// <returns>Le résultat de la reco sous forme booléenne.</returns>
//        private static async Task<bool> ReconnaissanceFacialeAsync()
//        {
//            bool personneReconnue = false;

//            // Récupération des faceID en base
//            List<string> lesFaceIdEnBase = RecupIdentifiants.RecupListFaceId();

//            // Si la table de la BDD n'est pas vide..
//            if (lesFaceIdEnBase.Count != 0)
//            {
//                // Récupération du path de l'image
//                Console.WriteLine("Détection des visages :");
//                Console.Write("Chemin de l'image: ");
//                string imageFilePath = Console.ReadLine();

//                // Récupération du FaceId de l'image à analyser (sera sauvegarder dans la variable faceIdDeLaPhotoPrise)
//                string faceIdDeLaPhotoPrise = await GetImageFaceIDAsync(imageFilePath);

//                // Comparaison du faceId local avec ceux de la BDD            
//                foreach (string faceId in lesFaceIdEnBase)
//                {
//                    // Comparaison des visages
//                    Task<bool> taskFaceCompare = FaceCompareAsync(faceIdDeLaPhotoPrise, faceId);
//                    taskFaceCompare.Wait();

//                    // Si la personne est reconnue
//                    if (taskFaceCompare.Result)
//                    {
//                        personneReconnue = true;
//                        break;
//                    }
//                }
//            }

//            // On retourne le résultat de la comparaison
//            return personneReconnue;
//        }

//        /*      METHODE REMPLACEE PAR GetImageFaceID
//        */
//        /// <summary>
//        /// Envoie une demande d'analyse au service de MICROSOFT
//        /// </summary>
//        /// <param name="imageFilePath">Chemin de l'image.</param>
//        static async void FaceAnalyse(string imageFilePath)
//        {
//            HttpClient client = new HttpClient();

//            // Entête de la demande.
//            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", clefOxford);

//            // Paramètre de la requete.
//            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";

//            // Assemblage de la requete URL.
//            string uri = uriBaseDetect + "?" + requestParameters;

//            HttpResponseMessage response;

//            // Mise en cache sous format binaire.
//            byte[] byteData = GetImageAsByteArray(imageFilePath);

//            using (ByteArrayContent content = new ByteArrayContent(byteData))
//            {
//                // Header content type de la requete
//                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

//                // Execute la demande de POST
//                response = await client.PostAsync(uri, content);

//                // Téléchargement du JSON de réponse.
//                string contentString = await response.Content.ReadAsStringAsync();

//                // Affichage de la réponse en JSON.
//                //Console.WriteLine("\nResponse:\n");
//                //Console.WriteLine(JsonPrettyPrint(contentString));
//            }
//        }


//        /// <summary>
//        /// Méthode permettant de détecter les visage et ainsi de récupérer le FaceID de la photo se 
//        /// trouvant au path donné en paramètres.
//        /// </summary>
//        /// <param name="imageFilePath">Chemin vers la photo à traiter.</param>
//        static async Task<string> GetImageFaceIDAsync(string imageFilePath)
//        {
//            // Autorisation de l'utilisation de l'API
//            FaceServiceClient faceServiceClient = new FaceServiceClient(clefOxford, "https://westcentralus.api.cognitive.microsoft.com/face/v1.0");

//            // Traitement de la photo se trouvant au path donné
//            using (Stream s = File.OpenRead(imageFilePath))
//            {
//                // On détecte les visages présents sur la photo

//                var faces = await faceServiceClient.DetectAsync(s);

//                // On vérifie qu'on a bien qu'1 seul visage sur la photo
//                if (faces.Length > 1)
//                {
//                    throw new Exception("Erreur: plus de 1 visage ont été détectés sur la photo.");
//                }

//                // On sauvegarde dans une variable le faceId de la photo prise
//                return faces[0].FaceId.ToString();
//            }
//        }

//        /// <summary>
//        /// Compare deux faceId et retourne la correspondance
//        /// </summary>
//        /// <param name="faceId1">string FaceId1</param>
//        /// <param name="faceId2">string FaceId2</param>
//        static async Task<bool> FaceCompareAsync(string faceId1, string faceId2)
//        {
//            HttpClient client = new HttpClient();

//            // Entête de la demande.
//            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", clefOxford);

//            // Url de la requete.
//            string uri = uriBaseVerify;

//            HttpResponseMessage response;

//            // Body de la requete
//            string contentBefore = "{\"faceId1\":\"" + faceId1 + "\",\"faceId2\":\"" + faceId2 + "\"}";
//            StringContent content = new StringContent(contentBefore);

//            // Header content type de la requete
//            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

//            // Execute the REST API call.
//            response = await client.PostAsync(uri, content);

//            // Téléchargement du JSON de réponse.
//            string contentString = await response.Content.ReadAsStringAsync();
//            JObject data = JObject.Parse(JsonPrettyPrint(contentString));

//            // Affichage de la réponse en JSON.
//            return Convert.ToBoolean(data.GetValue("isIdentical"));
//        }

//        #region Méthodes supplémentaires pour traitements
//        /// <summary>
//        /// Converti l'image en bits
//        /// </summary>
//        /// <param name="imageFilePath">Le fichier de l'image.</param>
//        /// <returns>Un tableau de bite en fonction de l'image.</returns>
//        static byte[] GetImageAsByteArray(string imageFilePath)
//        {
//            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
//            BinaryReader binaryReader = new BinaryReader(fileStream);
//            return binaryReader.ReadBytes((int)fileStream.Length);
//        }


//        /// <summary>
//        /// Formate le fichier JSON.
//        /// </summary>
//        /// <param name="json">Un fichier JSON en bordel.</param>
//        /// <returns>Un fichier JSON reformaté.</returns>
//        static string JsonPrettyPrint(string json)
//        {
//            if (string.IsNullOrEmpty(json))
//                return string.Empty;

//            json = json.Replace(Environment.NewLine, "").Replace("\t", "");

//            StringBuilder sb = new StringBuilder();
//            bool quote = false;
//            bool ignore = false;
//            int offset = 0;
//            int indentLength = 3;

//            foreach (char ch in json)
//            {
//                switch (ch)
//                {
//                    case '"':
//                        if (!ignore) quote = !quote;
//                        break;
//                    case '\'':
//                        if (quote) ignore = !ignore;
//                        break;
//                }

//                if (quote)
//                    sb.Append(ch);
//                else
//                {
//                    switch (ch)
//                    {
//                        case '{':
//                        case '[':
//                            sb.Append(ch);
//                            sb.Append(Environment.NewLine);
//                            sb.Append(new string(' ', ++offset * indentLength));
//                            break;
//                        case '}':
//                        case ']':
//                            sb.Append(Environment.NewLine);
//                            sb.Append(new string(' ', --offset * indentLength));
//                            sb.Append(ch);
//                            break;
//                        case ',':
//                            sb.Append(ch);
//                            sb.Append(Environment.NewLine);
//                            sb.Append(new string(' ', offset * indentLength));
//                            break;
//                        case ':':
//                            sb.Append(ch);
//                            sb.Append(' ');
//                            break;
//                        default:
//                            if (ch != ' ') sb.Append(ch);
//                            break;
//                    }
//                }
//            }

//            return sb.ToString().Trim();
//        }
//        #endregion
//    }
//}
