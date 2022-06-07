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


         @"C:\Users\user\Documents\GitHub\mallwayze\אפליקציה וויז בקניון\צד שרת\Server\mallWayze\BL\Dijkstra\routes.txt";
        //@"..\..\BL\Dijkstra\routes.txt";
        //@"C:\Users\student\Desktop\liel\אפליקציה וויז בקניון\צד שרת\Server\mallWayze\BL\Dijkstra\routes.txt";// @"..\..\BL\Dijkstra\routes.txt";
        //אתחול רשימת הקשתות של הקומהה הראשונה בקניון 
        static List<Route> mallGraphRoutes = null;
        //אתחול המילון שמורכב משם צומת וצומת
        static Dictionary<string, Node> mallGraphNodes = new Dictionary<string, Node>();
        // אתחול רשימת הצמים בגרף החדש שניצור יהנו המסלול 
        static List<Route> selectedStoresGraphRoutes = new List<Route>();
        //אתחול המילון הצמתים של הגרף החדש
        static Dictionary<string, Node> selectedStoresGraphNodes = new Dictionary<string, Node>();
        //מקבלת רשימה של חניות למעבר ומחזירה את הרשימה הטובה =היעילה ביותר 
        public static List<DTOStor> MapSelectedStores(List<DTOStor> stores)
        {
            List<DTOStor> GETlist = new List<DTOStor>();

            //2 - יצירת הצמתים שנמצאים בכל הקניון-עובד
            mallGraphNodes = createMallNodes();
            //1 - יצירת גרף של כל הקניון - קריאת הקשתות מקובץ  -עובד
            mallGraphRoutes = createMallRoutes(graphFilePath);
         
            //3 - יצירת גרף חדש של הקשתות בין החנויות הנבחרות  -  הפעלת הדיאקסטרה לכל חנות ברשימה ( שאר החנויות כיעד)עובד
            //יצית הגרף החדש  - אתחול רשימה חדשה של קשתות וצמתים
            createSelectedStoresGraph(stores);
            //4 - חישוב מסלול בגרף החדש  - דיאקסטרה שני-עובד
            DTOStor s = new DTOStor();
            Node end = createShortestPathForSelectedStores();
            //5 - מציאת הצמתים במסלול ע''י חזרה אחורה - נתקע בגלל הPREV
            List<Node> finalNodes = FindNodesOfShortestPath(end);
            //החזרת הרשימה ללקוח על ידי המרה מNODEלDTOStor 
            foreach (var g in finalNodes)
            {
                GETlist.Add(g.Store);
            }
            return GETlist;
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
                { //כדי למנוע כפילויות - נדלג על החנות הנוכחית
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
                    CheckNode(mallGraphRoutes, mallGraphNodes, queue, unvisited, end, ref lastNode);
                    double shortestDistance = lastNode.Value;
                    //אתחול משקל הקשת למרחק הקצר שחזר
                    newRoute.Distance = shortestDistance;
                    //הוספה לרשימת הקשתות של הגרף החדש  את הקשת שחשבנו
                    selectedStoresGraphRoutes.Add(newRoute);
                }
            }
        }
        // המציאת המשלול הקצר והחזרת הצומת האחרונה במסלול - לצורך שחזור המסלול
        public static Node createShortestPathForSelectedStores()
        {
            //יוצרים מידע שכאילו כבר קיים
           

            Node lastNode = null;
            //נגדיר את הכניסה כנקודת המוצא
            Node start = selectedStoresGraphNodes["כניסה "];
            //אין יעד - הדחאקסטרה צריך ליצור מסלול בין כל הצמתים
            Node end = null;
            //חישוב המרחק הקצר ע''י דייקסטרה
            //השמת ערך 0 על הכניסה 
            selectedStoresGraphNodes[start.Store.NameStor].Value = 0;
            //בונה תור עדיפות למרחקים קצרים
            PrioQueue queue = new PrioQueue();
            //מוסיפה לתור את הצומת התחלה 
            queue.AddNodeWithPriority(selectedStoresGraphNodes[start.Store.NameStor]);
            //מגדירה רשימת צמתים שלא בקרתי בהם 
            List<Node> unvisited = new List<Node>();
            //מעבר בלולאה כל הצמתים בקומה  
            foreach (var n in selectedStoresGraphNodes.Values)
            {//מוסיפה לרשימה את כל החניות בקומה 
                unvisited.Add(n);
            }
            CheckNode(selectedStoresGraphRoutes, selectedStoresGraphNodes, queue, unvisited, end, ref lastNode);

            return lastNode;
        }
        //שחזור בעצמו 
        public static List<Node> FindNodesOfShortestPath(Node end)
        {
            List<Node> nodes = new List<Node>();
            Node current = end;
            Node prev = end.PreviousNode;
            while (end.PreviousNode != null)
            {
                Node mallCurrent = end;
                while (true)
                {
                    if (mallCurrent == prev)
                        break;
                    nodes.Add(mallCurrent);
                    mallCurrent = mallCurrent.PreviousNode;

                }
                current = prev;
                prev = current.PreviousNode;
            }
            return nodes;
        }
        //מחזירה את המרחק הקצר ביותר
        private static void CheckNode(List<Route> routes, Dictionary<string, Node> nodes, PrioQueue queue, List<Node> unvisited, Node destinationNode, ref Node lastNode)
        {
            ///פה אני צריכה לעשות נקודת עצירה 
            //תנאי עצירה בחיפוש מסלול קצר בין כל הנקודות בגרף
            if (queue.Count == 0)
            {
                return;
            }
            //תנאי עצירה בחיפוש מסלול קצר בין מקור ליעד
            if (queue.First.Value == destinationNode)
            {
                lastNode = queue.First.Value;
                return;
            }
            //רשימת קשתות של צומת 
            List<Route> neighborRoutes = routes.Where(s => s.From.Equals( queue.First.Value)).ToList();
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
                {//אם כן -תעדכן 
                    nodes[r.To.Store.NameStor].Value = travelDistance;
                    //הקודם 
                    nodes[r.To.Store.NameStor].PreviousNode = r.From;
                    //  travelDistance צריך פה גם לעדכן שוב את ה
                }

                if (!queue.HasLetter(r.To))
                {
                    queue.AddNodeWithPriority(r.To);
                }
            }
            unvisited.Remove(queue.First.Value);
            lastNode = queue.First.Value;
            queue.RemoveFirst();
            CheckNode(routes, nodes, queue, unvisited, destinationNode, ref lastNode);
            return;
        }
    }
}
