using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using Newtonsoft.Json;
using System.Net;
using System.Threading;
using System.Timers;


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
                Console.SetWindowSize(30, 20);

                i++;
                string google;
                int attempt;
                google = i.ToString();
                gen();
                gen2();
                gen3();
                gen4();
                gen5();
                gen6();
                gen7();
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



        private static void gen() //Geersgatan
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
