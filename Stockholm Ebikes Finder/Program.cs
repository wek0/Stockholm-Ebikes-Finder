using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;


//Gjorde denna i sommras när det fanns så få cyklar

namespace Stockholm_Ebikes_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("STOCKHOLM EBIKES FINDER (ÖSTERMALM EDITION)");
            Console.Title = "ÖSTERMALM";
            int xsleep = 0;
            int tiden = 0;

            Console.WriteLine("hur många attempts? ");
            tiden = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tid att söka? (1000 = 1min): ");
            xsleep = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= tiden; i++) //1241
            {
                Console.SetWindowSize(40, 20);
                i++;
                string google;
                int attempt;
                google = i.ToString();
                generator();
                Console.WriteLine("Attempts: " + google);
                string realtid;
                realtid = DateTime.Now.ToString("HH:mm:ss"); //result 22:11:45
                Console.WriteLine(realtid);//visar klockan
                Thread.Sleep(xsleep); // ändra om den ska gå långsammare eller snabbare 
                Console.SetCursorPosition(0, 0); //gör så inte skärmen blinkar
            }
            Console.Title = "KLAR!";
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Allt är klart");
        }
        public class Location
        {
            public string Area { get; set; }
            public string Url { get; set; }

            public string Name { get; set; }

        }


        static void generator()
        {
            
            Console.WriteLine("Location?");
            string selectedLoc = Convert.ToString(Console.ReadLine());

            //Alla platser
            var Locations = new List<Location>
        {
            new Location{
                Area = "HORNSTULL",
                Url = "https://stockholmebikes.se/map/detail/faed2f51-897e-46f4-af3f-e4ee4b493b46?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Zinkens IP"
            },

            new Location{
                Area = "HORNSTULL",
                Url = "https://stockholmebikes.se/map/detail/8ad34ecd-993a-4142-a8ef-ff663f54bfa0?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Hornsgatan"
            },

            new Location{
                Area = "HORNSTULL",
                Url = "https://stockholmebikes.se/map/detail/c4714522-e691-4aec-98ae-2f7db39655f3?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Ringvägen / Tanto"
            },

            new Location{
                Area = "HORNSTULL",
                Url = "https://stockholmebikes.se/map/detail/5555380e-c81f-4e7f-a303-32d39396e50c?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Hornstullstrand"
            },

            new Location{
                Area = "HORNSTULL",
                Url = "https://stockholmebikes.se/map/detail/907dcd54-cdd9-4521-975e-b60cee9da28c?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Högalidsgatan"
            },

            new Location{
                Area = "Östermalm",
                Url = "https://stockholmebikes.se/map/detail/84b645f4-490c-45ad-8616-de9a4db70dd5?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Stureparken"
            },

            new Location{
                Area = "Östermalm",
                Url = "https://stockholmebikes.se/map/detail/35eded4e-3fff-4bcc-bc6d-86a365f0c288?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Tegeluddsvägen"
            },


            new Location{
                Area = "Slussen",
                Url = "https://stockholmebikes.se/map/detail/e0e79e75-93bd-4398-b3e0-5db2c81c349b?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Slussen"
            },

            //SÖDERMALM
            new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/71e0ac89-db41-4e7b-9404-582767594026?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Medborgarplatsen"
            },

            new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/60120bb7-f90a-48f6-aa3c-6efe92195fd0?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Götgatan/Katarina Bangata"
            },

              new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/d874a261-90c5-4dc6-b120-17fd378a461e?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Götgatan"
            },

                   new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/63253761-1360-40b1-aff1-2d18cd054180?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Ringen"
            },

                        new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/c40527cb-d84c-4704-93d3-2b2ee7eed99f?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Skanstull"
            },

                             new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/8ba3983b-cee2-41cd-a24c-01517af95a47?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Södra station"
            },


                       new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/551ad7c7-a918-4c69-aa7e-6110d567c395?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Ringvägen/Södermannagatan"
            },


                       new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/fa1bf7f5-fa86-45c2-b9a4-9584f909bf34?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Nytorget"
            },


                       new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/4a029af8-7575-49d5-9142-dfc467bd4960?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Vintertullstorget"
            },


                       new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/90beb6ce-1e2b-4586-9514-4cd9ef0aff7c?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Tegelviksgatan"
            },


                       new Location{
                Area = "Södermalm",
                Url = "https://stockholmebikes.se/map/detail/f9033694-e456-4e2d-8f0a-2118934407b5?_data=routes%2Fmap%2Fdetail.%24optionId",
                Name = "Londonviadukten"
            },





            };


            foreach (var l in Locations)
            {
                //Om X innehåller selectedLoc (UserInput) så kör koden. StringComparision gör så den ignorerar upper/lowercase
                if (l.Area.Contains(selectedLoc, StringComparison.InvariantCultureIgnoreCase))
                {
                    WebClient client = new WebClient();
                    string strPageCode = client.DownloadString(l.Url);
                    dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
                    string temp = dobj["mobilityOption"]["station"]["occupancy"];
                    Console.WriteLine(l.Name + ": " + temp + "\r\n");
                }
            }

        }




        static void gen() //Geersgatan
        {

            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://stockholmebikes.se/map/detail/e439da44-4c3f-4324-a718-638dde5626e8?_data=routes%2Fmap%2Fdetail.%24optionId");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = dobj["mobilityOption"]["station"]["occupancy"];
            Console.WriteLine("De Geersgatan: " + temp + "\r\n");
        }

        private static void gen2() //Grevgatan
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://stockholmebikes.se/map/detail/7d608a47-9d34-451e-9ec1-f7868254b2f8?_data=routes%2Fmap%2Fdetail.%24optionId");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = dobj["mobilityOption"]["station"]["occupancy"];
            Console.WriteLine("Storgatan/Grevgatan: " + temp + "\r\n");
        }
        private static void gen3() //Narvavägen
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://stockholmebikes.se/map/detail/b19f3928-7779-4967-857f-1700c9c2ca27?_data=routes%2Fmap%2Fdetail.%24optionId");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = dobj["mobilityOption"]["station"]["occupancy"];
            Console.WriteLine("Strandvägen/Narvavägen: " + temp + "\r\n");
        }
        private static void gen4() //Tegeluddsvägen
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://stockholmebikes.se/map/detail/35eded4e-3fff-4bcc-bc6d-86a365f0c288?_data=routes%2Fmap%2Fdetail.%24optionId");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = dobj["mobilityOption"]["station"]["occupancy"];
            Console.WriteLine("Tegeluddsvägen: " + temp + "\r\n");
        }
        private static void gen5() //Lidingövägen
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://stockholmebikes.se/map/detail/5d5600f3-9ead-4b8f-94a6-167de179d0be?_data=routes%2Fmap%2Fdetail.%24optionId");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = dobj["mobilityOption"]["station"]["occupancy"];
            Console.WriteLine("Lidingövägen: " + temp + "\r\n");
        }
        private static void gen6() //Stureparken
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://stockholmebikes.se/map/detail/84b645f4-490c-45ad-8616-de9a4db70dd5?_data=routes%2Fmap%2Fdetail.%24optionId");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = dobj["mobilityOption"]["station"]["occupancy"];
            Console.WriteLine("Stureparken: " + temp + "\r\n");

        }
        private static void gen7() //Norrmalmstorg
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://stockholmebikes.se/map/detail/ddad0994-42a6-4e6a-bf67-0ff3925d150b?_data=routes%2Fmap%2Fdetail.%24optionId");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = dobj["mobilityOption"]["station"]["occupancy"];
            Console.WriteLine("Norrmalmstorg: " + temp + "\r\n");
        }
    }
}
