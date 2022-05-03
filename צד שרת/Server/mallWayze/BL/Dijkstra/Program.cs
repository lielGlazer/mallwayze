using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BL;

namespace BL.Dijkstra
{
    class Program
    {

        DBConection db = new DBConection();

        string graphFilePath = "../../../../routes.txt";

        //רשימת קשתות של כל מיקום לחנויות בקומה 1
        List<Route> Routes = new List<Route>();
        //רשימת חניות שבהם הלקוח רוצה לבקר
        List<DTOStor> StoresWanted = new List<DTOStor>();
        //רשימת צמתים
        List<Node> nodes = new List<Node>();

        static void Main(string[] args)
        {
            //try
            //{
            //    initGraph();
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return;
            //}

            //Console.Clear();
            //PrintOverview();

            //var (startNode, destNode) = GetStartAndEnd();

            //// Set our start node. The start node has to have a value
            //// of 0 because we're already there.
            //nodeDict[startNode].Value = 0;

            //var queue = new PrioQueue();
            //queue.AddNodeWithPriority(nodeDict[startNode]);

            //// Do the calculations to find the shortest path to every node
            //// in the graph starting from our starting node.
            //CheckNode(queue, destNode);

            //// Print out the result
            //PrintShortestPath(startNode, destNode);
        }

        //הפונקציה יוצרת רשימת קשתות
        public void FillRoutes()
        {
            string graphFilePath = "../../../../routes.txt";
            using (var reader = new StreamReader(graphFilePath, Encoding.Default))
            {
                List<Route> routes = new List<Route>();
                for (int i = 0, countWord = 0; !reader.EndOfStream; i++, countWord = 0)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    routes.Add(new Route(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2])));
                }
            }
        }

        //ליצור רשימת צמתים
        public void createNodesList()
        {
            foreach (var s in db.GetDbSet<Stor>().ToList())
            {
                DTOStor store = new DTOStor(s);
                nodes.Add(new Node(store));
            }
        }





        private static void initGraph()
        {
            if (!File.Exists(graphFilePath))
            {
                throw new FileNotFoundException("File not found");
            }

            using (var fileStream = File.OpenRead(graphFilePath))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var values = line.Split(",");
                        var (from, to, distance) = (values[0], values[1], double.Parse(values[2]));
                        if (!nodeDict.ContainsKey(from)) { nodeDict.Add(from, new Node(from)); }
                        if (!nodeDict.ContainsKey(to)) { nodeDict.Add(to, new Node(to)); }
                        unvisited.Add(from);
                        unvisited.Add(to);

                        routes.Add(new Route(from, to, distance));
                    }
                }
            }
        }

        private static void PrintOverview()
        {
            Console.WriteLine("Nodes:");
            foreach (Node node in nodeDict.Values)
            {
                Console.WriteLine("\t" + node.Name);
            }

            Console.WriteLine("\nRoutes:");
            foreach (Route route in routes)
            {
                Console.WriteLine("\t" + route.From + " -> " + route.To + " Distance: " + route.Distance);
            }
        }

        // קבל קלט משתמש עבור צמתי ההתחלה והיעד.
        private static int GetStartAndEnd()
        {
            Console.WriteLine("\nEnter the start node: ");
            string startNode = Console.ReadLine();
            Console.WriteLine("Enter the destination node: ");
            string destNode = Console.ReadLine();
            return (startNode, destNode);
        }


        private static void CheckNode(PrioQueue queue, string destinationNode)
        {
            // If there are no nodes left to check in our queue, we're done.
            if (queue.Count == 0)
            {
                return;
            }

            foreach (var route in routes.FindAll(r => r.From == queue.First.Value.Name))
            {
                // Skip routes to nodes that have already been visited.
                if (!unvisited.Contains(route.To))
                {
                    continue;
                }

                double travelledDistance = nodeDict[queue.First.Value.Name].Value + route.Distance;

                // We only look at nodes we haven't visited yet and we only
                // update the node's values if the distance of the path we're
                // currently checking is shorter than the one we found before.
                if (travelledDistance < nodeDict[route.To].Value)
                {
                    nodeDict[route.To].Value = travelledDistance;
                    nodeDict[route.To].PreviousNode = nodeDict[queue.First.Value.Name];
                }

                // We don't add the 'to' node to the queue if it has already been
                // visited and we don't allow duplicates.
                if (!queue.HasLetter(route.To))
                {
                    queue.AddNodeWithPriority(nodeDict[route.To]);
                }
            }
            unvisited.Remove(queue.First.Value.Name);
            queue.RemoveFirst();

            CheckNode(queue, destinationNode);
        }


        private static void PrintShortestPath(string startNode, string destNode)
        {
            var pathList = new List<String> { destNode };

            Node currentNode = nodeDict[destNode];
            while (currentNode != nodeDict[startNode])
            {
                pathList.Add(currentNode.PreviousNode.Name);
                currentNode = currentNode.PreviousNode;
            }

            pathList.Reverse();
            for (int i = 0; i < pathList.Count; i++)
            {
                Console.Write(pathList[i] + (i < pathList.Count - 1 ? " -> " : "\n"));
            }
            Console.WriteLine("Overall distance: " + nodeDict[destNode].Value);
        }
    }

}