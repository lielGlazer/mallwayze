using DAL;
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

        static DBConection db = new DBConection();//הדאטה ביס של כל המערכת 
        static string graphFilePath = @"C:\Users\student\Desktop\routes.txt";//הניתוב של הגרף
        static List<Route> mallGraphRoutes = null;//אתחול רשימת הקשתות של הקומהה הראשונה בקניון 
        static Dictionary<string, Node> mallGraphNodes = new Dictionary<string, Node>();//אתחול המילון שמורכב משם צומת וצומת
        static List<Route> selectedStoresGraphRoutes = new List<Route>();// אתחול רשימת הצמים בגרף החדש שניצור יהנו המסלול 
        static Dictionary<string, Node> selectedStoresGraphNodes = new Dictionary<string, Node>();//אתחול המילון הצמתים של הגרף החדש

        public static List<DTOStor> MapSelectedStores(List<DTOStor> stores)//מיפוי 
        {
            //יצירת גרף של כל הקניון - קריאת הקשתות מקובץ  
            mallGraphRoutes = createMallRoutes(graphFilePath);
            mallGraphNodes = createMallNodes();
            //יצירת גרף חדש של הקשתות בין החנויות הנבחרות  -  הפעלת הדיאקסטרה לכל חנות ברשימה ( שאר החנויות כיעד)

            //הפעלת הדיאקסטרה על הגרף החדש.


            return null;
        }

        //יוצרת גרף של כל החנויות בקניון
        public static List<Route> createMallRoutes(string path)//
        {
            List<Route> routes = new List<Route>();//
            using (var reader = new StreamReader(graphFilePath, Encoding.Default))
            {
                for (int i = 0, countWord = 0; !reader.EndOfStream; i++, countWord = 0)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Stor s1 = db.GetDbSet<Stor>().FirstOrDefault(s => s.Locations.LocationCode == long.Parse(values[2]));
                    Stor s2 = db.GetDbSet<Stor>().FirstOrDefault(s => s.Locations.LocationCode == long.Parse(values[1]));

                    routes.Add(new Route(new Node(new DTOStor(s1)), new Node(new DTOStor(s2)), double.Parse(values[0])));
                }
            }
            return routes;
        }
        public static Dictionary<string, Node> createMallNodes()
        {
            Dictionary<string, Node> nodes = new Dictionary<string, Node>();
            List<Stor> stores = db.GetDbSet<Stor>();
            foreach (var s in stores)
            {
                DTOStor dtos = new DTOStor(s);
                nodes.Add(dtos.NameStor, new Node(dtos));
            }
            return nodes;
        }

        public static void createSelectedStoresGraph(List<DTOStor> stores)
        {


            for (int i = 0; i < stores.Count(); i++)//לכל חנות ברשימה הנבחרת
            {
                DTOStor from = stores[i];

                selectedStoresGraphNodes.Add(from.NameStor, new Node(from));

                for (int j = 0; j < stores.Count(); j++)//ניצור קשתות לשאר החנויות ברשימה
                {
                    if (i == j)//כדי למנוע כפילויות - נדלג על החנות הנוכחית
                        continue;
                    DTOStor to = stores[j];

                    Node start = new Node(from); //נגדיר חנות נוכחית בתור התחלה
                    Node end = new Node(to);//נגדיר חנות אחרת ברשימה בתור יעד
                    //ניצור קשת - אבל - נאתחל את המרחק ב-0 כי עדיין לא ברור מה המרחק הכי קצר - צריך חישוב
                    Route newRoute = new Route(start, end, 0);

                    //חישוב המרחק הקצר ע''י דייקסטרה
                    //השמת ערך 0 על הנקודה שבה אנחנו מתחילים 
                    mallGraphNodes[start.Store.NameStor].Value = 0;

                    PrioQueue queue = new PrioQueue();
                    queue.AddNodeWithPriority(mallGraphNodes[start.Store.NameStor]);

                    List<Node> unvisited = new List<Node>();
                    foreach (var n in mallGraphNodes.Values)
                    {
                        unvisited.Add(n);
                    }

                    double shortestDistance = CheckNode(mallGraphRoutes, mallGraphNodes, queue, unvisited, end);
                    newRoute.Distance = shortestDistance;
                    selectedStoresGraphRoutes.Add(newRoute);

                }
            }

        }


        public static void createShortestPathForSelectedStores()
        {

            DTOStor entrance = new DTOStor();
            entrance.NameStor = "כניסה";
           
            Node start = new Node( entrance); //נגדיר כניסה בתור התחלה
            Node end = null;//אין יעד - רוצים לעבור בין כל החנויות שנבחרו
                              
            //חישוב המרחק הקצר ע''י דייקסטרה
            //השמת ערך 0 על הנקודה שבה אנחנו מתחילים 
            mallGraphNodes[start.Store.NameStor].Value = 0;

            PrioQueue queue = new PrioQueue();
            queue.AddNodeWithPriority(selectedStoresGraphNodes[start.Store.NameStor]);

            List<Node> unvisited = new List<Node>();
            foreach (var n in selectedStoresGraphNodes.Values)
            {
                unvisited.Add(n);
            }

            double shortestDistance = CheckNode(selectedStoresGraphRoutes, selectedStoresGraphNodes, queue, unvisited, end);
        }



        private static double CheckNode(List<Route> routes, Dictionary<string, Node> nodes, PrioQueue queue, List<Node> unvisited, Node destinationNode)
        {
            if (queue.Count == 0)  //תנאי עצירה בחיפוש מסלול קצר בין כל הנקודות בגרף
            {
                return 0;
            }
            if (queue.First.Value == destinationNode)//תנאי עצירה בחיפוש מסלול קצר בין מקור ליעד
            {
                return destinationNode.Value;
            }
            List<Route> neighborRoutes = routes.Where(s => s.From == queue.First.Value).ToList();
            foreach (var r in neighborRoutes)
            {
                if (!unvisited.Contains(r.To))//אם קוד היעד לא נמצא ברשימה שצריך לבקר בה סימן שביקרו בו - נדלג עליו
                {
                    continue;
                }

                double travelDistance = nodes[queue.First.Value.Store.NameStor].Value + r.Distance;

                if (travelDistance < nodes[r.To.Store.NameStor].Value)
                {
                    nodes[r.To.Store.NameStor].Value = travelDistance;
                    nodes[r.To.Store.NameStor].PreviousNode = r.From;
                }

                if (!queue.HasLetter(r.To))
                {
                    queue.AddNodeWithPriority(r.To);
                }

            }
            unvisited.Remove(queue.First.Value);
            queue.RemoveFirst();
            CheckNode(routes, nodes, queue, unvisited, destinationNode);
            return 0;

        }


    }
}
