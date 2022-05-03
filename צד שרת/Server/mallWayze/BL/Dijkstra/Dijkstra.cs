using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dijkstra
{
    class Dijkstra
    {
        static string graphFilePath = @"C:\Users\student\Desktop\routes.txt";
        static List<Route> mallGraph = null;
        public static List<DTOStor> MapSelectedStores(List<DTOStor> stores)
        {
            //יצירת גרף של כל הקניון - קריאת הקשתות מקובץ  
            mallGraph = createMallRoutes(graphFilePath);
            //יצירת גרף חדש של הקשתות בין החנויות הנבחרות  -  הפעלת הדיאקסטרה לכל חנות ברשימה ( שאר החנויות כיעד)

            //הפעלת הדיאקסטרה על הגרף החדש.


            return null;
        }

        //יוצרת גרף של כל החנויות בקניון
        public static List<Route> createMallRoutes(string path)
        {
            List<Route> routes = new List<Route>();
            using (var reader = new StreamReader(graphFilePath, Encoding.Default))
            {
                for (int i = 0, countWord = 0; !reader.EndOfStream; i++, countWord = 0)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    routes.Add(new Route(int.Parse(values[2]), int.Parse(values[1]), double.Parse(values[0])));
                }
            }
            return routes;
        }

        public static List<Route> createSelectedStoresRoutes(List<DTOStor> stores)
        {
            //לולאה ראשונה
            for (int i = 0; i < stores.Count(); i++)
            {
                DTOStor from = stores[i];

                for (int j = 0; j < stores.Count(); j++)
                {
                    if (i == j)
                        continue;
                    DTOStor to = stores[j];

                    Node start = new Node(from);
                    Node end = new Node(to);


                }
            }
            //לולאה שנייה
            //משתנה חנות מקור

            //הפעלה של דיאקסטרה


            return null;
        }
    }
}
