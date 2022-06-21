using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BL
{
    public class Dijkstra
    {
        //הדאטה ביס של כל המערכת 
        static DBConection db = new DBConection();
        //הניתוב של הגרף
        static string graphFilePath =
        //@"C:\Users\user\Documents\GitHub\mallwayze\אפליקציה וויז בקניון\צד שרת\Server\mallWayze\BL\Dijkstra\routes.txt";
        //@"..\..\BL\Dijkstra\routes.txt";
        @"C:\Users\student\Desktop\liel\אפליקציה וויז בקניון\צד שרת\Server\mallWayze\BL\Dijkstra\routes.txt";// @"..\..\BL\Dijkstra\routes.txt";
        //אתחול רשימת הקשתות של הקומהה הראשונה בקניון 
        static List<Route> mallGraphRoutes = null;
        //אתחול המילון שמורכב משם צומת וצומת
        static Dictionary<string, Node> mallGraphNodes = new Dictionary<string, Node>();
        // אתחול רשימת הצמים בגרף החדש שניצור יהנו המסלול 
        static List<Route> selectedStoresGraphRoutes = new List<Route>();
        //אתחול המילון הצמתים של הגרף החדש
        static Dictionary<string, Node> selectedStoresGraphNodes = new Dictionary<string, Node>();
        //מילון צמתים שיוצרים קשת
        static Dictionary<string, List<DTOStor>> realNodesOfSelectedStoresRoute = new Dictionary<string, List<DTOStor>>();
        //מקבלת רשימה של חניות למעבר ומחזירה את הרשימה הטובה =היעילה ביותר 





        public static List<StoreWithLocation> MapSelectedStores(List<DTOStor> stores)
        {
            //1 - יצירת הצמתים שנמצאים בכל הקניון-עובד
            mallGraphNodes = createMallNodes();
            //2 - יצירת גרף של כל הקניון - קריאת הקשתות מקובץ  -עובד
            mallGraphRoutes = createMallRoutes(graphFilePath);
            //3 - יצירת גרף חדש של הקשתות בין החנויות הנבחרות  -  הפעלת הדיאקסטרה לכל חנות ברשימה ( שאר החנויות כיעד)עובד
            //יצית הגרף החדש  - אתחול רשימה חדשה של קשתות וצמתים
            createSelectedStoresGraph(stores);
            //4 - חישוב מסלול בגרף החדש  - דיאקסטרה שני-עובד
            DTOStor s = new DTOStor();
            List<DTOStor> selectedStores = createShortestPathForSelectedStores();
            //5 - מציאת הצמתים במסלול ע''י חזרה אחורה - 
            List<DTOStor> finalNodes = FindNodesOfShortestPath(selectedStores);
            List<StoreWithLocation> storesWithLocation = new List<StoreWithLocation>();
            List<DTOStor> strSale = new List<DTOStor>();
            foreach (var n in finalNodes)
            {
                strSale.Add(n);
                storesWithLocation.Add(new StoreWithLocation(n.NameStor, n.Locations.AxisX, n.Locations.AxisY));
            }
            List<DTOStor> Sale=   strSale.Where(r => r.Sale).ToList();
            List<DTOStor> NoSale= strSale.Where(r => r.Sale=false).ToList();
            List<DTOStor> NewPathSale=new List<DTOStor>();
            foreach (var n in Sale)
            {
                NewPathSale.Add(n);
            }
            foreach (var n in NoSale)
            {
                NewPathSale.Add(n);
            }
            
            createSalePATH(NewPathSale);
            return storesWithLocation;
        }
        //המרחקים הקשתות יוצרת גרף של כל המרחקים בקניון
        public static List<Route> createMallRoutes(string path)//
        {
            List<Route> routes = new List<Route>();//
            using (var reader = new StreamReader(graphFilePath, Encoding.Default))
            {
                for (int i = 0, countWord = 0; !reader.EndOfStream; i++, countWord = 0)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Stor s1 = db.GetDbSet<Stor>().ToList().FirstOrDefault(s => s.Locations.LocationCode == long.Parse(values[2]));
                    Stor s2 = db.GetDbSet<Stor>().ToList().FirstOrDefault(s => s.Locations.LocationCode == long.Parse(values[1]));
                    routes.Add(new Route(mallGraphNodes.FirstOrDefault(a => a.Value.Store.CodeStor == s1.CodeStor).Value,
                        mallGraphNodes.FirstOrDefault(a => a.Value.Store.CodeStor == s2.CodeStor).Value,
                       double.Parse(values[0])));
                }
            }
            return routes;
        }

        //הצמתים יוצרת גרף של כל החנויות בקניון
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

        //יצירת הגרף החדש =המסלול 
        public static void createSelectedStoresGraph(List<DTOStor> stores)//יצירת הגרף החדש
        {
            Stor entrance = db.GetDbSet<Stor>().FirstOrDefault(s => s.NameStor.Equals("כניסה "));
            stores.Add(new DTOStor(entrance));
            //לכל חנות ברשימה הנבחרת
            for (int i = 0; i < stores.Count(); i++)
            {   //מאיפה להגיע מאיזה מקור
                DTOStor from = stores[i];
                //מוסיפה אותו לרשימת הצמתים בגרף החדש
                selectedStoresGraphNodes.Add(from.NameStor, new Node(from));
                //ניצור קשתות לשאר החנויות ברשימה
                for (int j = 0; j < stores.Count(); j++)
                {
                    //כדי למנוע כפילויות - נדלג על החנות הנוכחית
                    if (i == j)
                        continue;
                    //לאיפה אני מגיעה
                    DTOStor to = stores[j];
                    //נגדיר חנות נוכחית בתור התחלה
                    Node start = new Node(from);
                    //נגדיר חנות אחרת ברשימה בתור יעד
                    Node end = new Node(to);
                    //ניצור קשת - אבל - נאתחל את המרחק ב-0 כי עדיין לא ברור מה המרחק הכי קצר - צריך חישוב
                    Route newRoute = new Route(start, end, 0);
                    //חישוב המרחק הקצר ע''י דייקסטרה
                    //השמת ערך 0 על הנקודה שבה אנחנו מתחילים 
                    mallGraphNodes[start.Store.NameStor].Value = 0;
                    //בונה תור עדיפות למרחקים קצרים
                    PrioQueue queue = new PrioQueue();
                    //מוסיפה לתור את הצומת התחלה 
                    queue.AddNodeWithPriority(mallGraphNodes[start.Store.NameStor]);
                    //מגדירה רשימת צמתים שלא בקרתי בהם 
                    List<Node> unvisited = new List<Node>();
                    //מעבר בלולאה כל הצמתים בקומה  
                    foreach (var n in mallGraphNodes.Values)
                    {//מוסיפה לרשימה את כל החניות בקומה 
                        unvisited.Add(n);
                    }
                    Node lastNode = null;
                    //מקבלת  את המרחק הקצר שחוזר  - פב מתחילה הריקורסיה של הדיאקסטרה
                    double finalDistance = 0;
                    CheckNode(mallGraphRoutes, mallGraphNodes, queue, unvisited, end, ref lastNode, ref finalDistance);
                    double shortestDistance = lastNode.Value;
                    //אתחול משקל הקשת למרחק הקצר שחזר
                    newRoute.Distance = shortestDistance;
                    //הוספה לרשימת הקשתות של הגרף החדש  את הקשת שחשבנו
                    selectedStoresGraphRoutes.Add(newRoute);
                    //שמירת החנויות שיצרו את הקשת המדומה-----------------------------------------------------------------------------**********************
                    realNodesOfSelectedStoresRoute.Add(from.NameStor + to.NameStor, new List<DTOStor>());
                    List<DTOStor> tempList = new List<DTOStor>();
                    while (lastNode != null)
                    {
                        DTOStor s = lastNode.Store;
                        tempList.Add(s);
                        lastNode = lastNode.PreviousNode;
                    }
                    //הכנסת הרשימה מחנות ההתחלה לחנות הסיום לתוך המילון-----------------------------------------------------------------------------**********************
                    for (int k = tempList.Count() - 1; k >= 0; k--)
                    {
                        realNodesOfSelectedStoresRoute[from.NameStor + to.NameStor].Add(tempList[k]);
                    }
                    //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    System.Diagnostics.Debug.WriteLine("Creating route between {0} and {1}. Distance is:  {2}", from.NameStor, to.NameStor, newRoute.Distance);
                    foreach (var item in realNodesOfSelectedStoresRoute[from.NameStor + to.NameStor])
                    {
                        System.Diagnostics.Debug.Write(item.NameStor + " -> ");
                    }
                    System.Diagnostics.Debug.WriteLine("");
                    //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    //הכנת הצמתים בקניון למסלול הקצר הבא-----------------------------------------------------------------------------**********************
                    foreach (var n in mallGraphNodes.Values)
                    {
                        n.Value = int.MaxValue;
                        n.PreviousNode = null;
                    }
                }
            }
        }

        //המציאת המשלול הקצר והחזרת הצומת האחרונה במסלול - לצורך שחזור המסלול     
        //החישוב של המסלול הקצר עמצו על ידי מעבר על כל אופציה קצרה ובדיקה מה הכי טוב עד לסוף הרשימה 
        public static List<DTOStor> createShortestPathForSelectedStores()
        {
            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            System.Diagnostics.Debug.WriteLine("\n%%%%Graph before Dijxtra%%%%%");
            foreach (Node item in selectedStoresGraphNodes.Values)
            {
                System.Diagnostics.Debug.WriteLine("{0} .  PreviousNode: {1}.   Value: {2}", item.Store.NameStor, item.PreviousNode == null ? "null" : item.PreviousNode.Store.NameStor, item.Value);
            }
            System.Diagnostics.Debug.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\n");
            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            List<DTOStor> stores = new List<DTOStor>();
            Node node = selectedStoresGraphNodes["כניסה "];
            stores.Add(selectedStoresGraphNodes["כניסה "].Store);
            while (selectedStoresGraphRoutes.Count>0)
            {
                var routes = selectedStoresGraphRoutes.Where(r => r.From.Store.NameStor.Equals(node.Store.NameStor)).ToList();
                double min = int.MaxValue;
                DTOStor minS = null;
                foreach (var route in routes)
                {
                    if (route.Distance < min)
                    {
                        min = route.Distance;
                        minS = route.To.Store;
                    }
                }
                stores.Add(minS);
                //מחיקת החנות והקשתות
                selectedStoresGraphNodes.Remove(node.Store.NameStor);
                selectedStoresGraphRoutes.RemoveAll(r => r.From.Store.NameStor.Equals(node.Store.NameStor) || r.To.Store.NameStor.Equals(node.Store.NameStor));
                //עדכון לקראת הלולאה הבאה
                node = selectedStoresGraphNodes[minS.NameStor];
            }
            return stores;
        }

        //שחזור בעצמו 
        public static List<DTOStor> FindNodesOfShortestPath(List<DTOStor> stores)
        {
            List<DTOStor> fullStoresPath = new List<DTOStor>();
            fullStoresPath.Add(mallGraphNodes["כניסה "].Store);

            //עובר על כל החניות הרצויות 

            for (int i = 1; i < stores.Count; i++)
            {
                //חנות נוכחית
                string from = stores[i - 1].NameStor;
                //חנות יעד קרובה
                string to = stores[i].NameStor;
                //  ועל ידי הכנסת שני החניות מתקבלת רשימה של כל הצמתים שיוצרים את הקשת הנוכחית (מילוי הרשימה - קיים מילון שבו יש שם של שני צמתים (חניות  
                List<DTOStor> realStores = realNodesOfSelectedStoresRoute[from + to];
                realStores.RemoveAt(0);
                //מעבר על כל הרשימה של הצמתים שיוצרים את הקשת  -וממלאת את הרשימה של כל המתים 
                foreach (var s in realStores)
                {
                    fullStoresPath.Add(s);
                }
            }
            //מחזיר את המסלול המלא הקצר 
            return fullStoresPath;
        }

        //מחזירה את המרחק הקצר ביותר
        //מעבר על הגרף הגדול-ממשקל אותו מסדר אותו 
        private static void CheckNode(List<Route> routes, Dictionary<string, Node> nodes, PrioQueue queue, List<Node> unvisited, Node destinationNode, ref Node lastNode, ref double dist)
        {
            ///פה אני צריכה לעשות נקודת עצירה 
            //תנאי עצירה בחיפוש מסלול קצר בין כל הנקודות בגרף
            if (queue.Count == 0)
            {
                return;
            }
            //תנאי עצירה בחיפוש מסלול קצר בין מקור ליעד
            if (lastNode != null && destinationNode != null && lastNode.Store.NameStor.Equals(destinationNode.Store.NameStor))
            {
                return;
            }
            //רשימת קשתות של צומת 
            List<Route> neighborRoutes = routes.Where(s => s.From.Equals(queue.First.Value)).ToList();
            foreach (var r in neighborRoutes)
            {
                //אם קוד היעד לא נמצא ברשימה שצריך לבקר בה סימן שביקרו בו - נדלג עליו
                if (!unvisited.Contains(r.To))
                {
                    continue;
                }
                //מעדכנת מה המרחק עד לצומת הנוכחית - מה היה המרחק עד הגעה לצומת הנוחכית 
                double travelDistance = nodes[queue.First.Value.Store.NameStor].Value + r.Distance;
                //בדיקה האם מה שחישבתי עכשיו יותר קצר ממה שקיים בצומת היעד עד עכשיו 
                if (travelDistance < nodes[r.To.Store.NameStor].Value)
                {
                    //אם כן -תעדכן 
                    nodes[r.To.Store.NameStor].Value = travelDistance;
                    //הקודם 
                    nodes[r.To.Store.NameStor].PreviousNode = r.From;
                  
                }
                if (!queue.HasLetter(r.To))
                {
                    queue.AddNodeWithPriority(r.To);
                }
            }
            unvisited.Remove(queue.First.Value);
            lastNode = nodes[queue.First.Value.Store.NameStor];
            queue.RemoveFirst();
            CheckNode(routes, nodes, queue, unvisited, destinationNode, ref lastNode, ref dist);
            return;
        }

      public static List<StoreWithLocation> createSalePATH(List<DTOStor> SALE)
        {
            List<StoreWithLocation> ss = new List<StoreWithLocation>();

            return ss;
        }


    }


}
