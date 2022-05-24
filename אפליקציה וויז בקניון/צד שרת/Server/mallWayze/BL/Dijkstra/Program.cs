//using system;
//using system.collections.generic;
//using system.io;
//using system.linq;
//using system.text;
//using system.threading.tasks;
//using dto;
//using dal;
//using bl;

//namespace bl.dijkstra
//{
//    class program
//    {

//        dbconection db = new dbconection();

//        static string graphfilepath = "../../../../routes.txt";

//        רשימת קשתות של כל מיקום לחנויות בקומה 1
//        list<route> routes = new list<route>();
//        רשימת חניות שבהם הלקוח רוצה לבקר
//        list<dtostor> storeswanted = new list<dtostor>();
//        רשימת צמתים
//        list<node> nodes = new list<node>();

//        static void main(string[] args)
//        {
//            try
//            {
//                initgraph();
//            }
//            catch (filenotfoundexception ex)
//            {
//                console.writeline(ex.message);
//                return;
//            }

//            console.clear();
//            printoverview();

//            var (startnode, destnode) = getstartandend();

//            // set our start node. the start node has to have a value
//            // of 0 because we're already there.
//            nodedict[startnode].value = 0;

//            var queue = new prioqueue();
//            queue.addnodewithpriority(nodedict[startnode]);

//            // do the calculations to find the shortest path to every node
//            // in the graph starting from our starting node.
//            checknode(queue, destnode);

//            // print out the result
//            printshortestpath(startnode, destnode);
//        }

//        הפונקציה יוצרת רשימת קשתות
//        public void fillroutes()
//        {
//            string graphfilepath = "../../../../routes.txt";
//            using (var reader = new streamreader(graphfilepath, encoding.default))
//            {
//                list<route> routes = new list<route>();
//                for (int i = 0, countword = 0; !reader.endofstream; i++, countword = 0)
//                {
//                    var line = reader.readline();
//                    var values = line.split(',');
//                    routes.add(new route(int.parse(values[0]), int.parse(values[1]), int.parse(values[2])));
//                }
//            }
//        }

//        ליצור רשימת צמתים
//        public void createnodeslist()
//        {
//            foreach (var s in db.getdbset<stor>().tolist())
//            {
//                dtostor store = new dtostor(s);
//                nodes.add(new node(store));
//            }
//        }





//        private static void initgraph()
//        {
//            if (!file.exists(graphfilepath))
//            {
//                throw new filenotfoundexception("file not found");
//            }

//            using (var filestream = file.openread(graphfilepath))
//            {
//                using (var streamreader = new streamreader(filestream, encoding.utf8, true, 128))
//                {
//                    string line;
//                    while ((line = streamreader.readline()) != null)
//                    {
//                        var values = line.split(",");
//                        var (from, to, distance) = (values[0], values[1], double.parse(values[2]));
//                        if (!nodedict.containskey(from)) { nodedict.add(from, new node(from)); }
//                        if (!nodedict.containskey(to)) { nodedict.add(to, new node(to)); }
//                        unvisited.add(from);
//                        unvisited.add(to);

//                        routes.add(new route(from, to, distance));
//                    }
//                }
//            }
//        }

//        private static void printoverview()
//        {
//            console.writeline("nodes:");
//            foreach (node node in nodedict.values)
//            {
//                console.writeline("\t" + node.name);
//            }

//            console.writeline("\nroutes:");
//            foreach (route route in routes)
//            {
//                console.writeline("\t" + route.from + " -> " + route.to + " distance: " + route.distance);
//            }
//        }

//        // קבל קלט משתמש עבור צמתי ההתחלה והיעד.
//        private static int getstartandend()
//        {
//            console.writeline("\nenter the start node: ");
//            string startnode = console.readline();
//            console.writeline("enter the destination node: ");
//            string destnode = console.readline();
//            return (startnode, destnode);
//        }


//        private static void checknode(prioqueue queue, string destinationnode)
//        {
//            // if there are no nodes left to check in our queue, we're done.
//            if (queue.count == 0)
//            {
//                return;
//            }

//            foreach (var route in routes.findall(r => r.from == queue.first.value.name))
//            {
//                //skip routes to nodes that have already been visited.
//                if (!unvisited.contains(route.to))//אם קוד היעד לא נמצא ברשימה שצריך לבקר בה סימן שביקרו בו - נדלג עליו
//                {
//                    continue;
//                }

//                double travelleddistance = nodedict[queue.first.value.name].value + route.distance;

//                //we only look at nodes we haven't visited yet and we only
//                // update the node's values if the distance of the path we're
//                 //currently checking is shorter than the one we found before.
//                if (travelleddistance < nodedict[route.to].value)
//                {
//                    nodedict[route.to].value = travelleddistance;
//                    nodedict[route.to].previousnode = nodedict[queue.first.value.name];
//                }

//                //we don't add the 'to' node to the queue if it has already been
//                // visited and we don't allow duplicates.
//                if (!queue.hasletter(route.to))
//                {
//                    queue.addnodewithpriority(nodedict[route.to]);
//                }
//            }
//            unvisited.remove(queue.first.value.name);
//            queue.removefirst();

//            checknode(queue, destinationnode);
//        }


//        private static void printshortestpath(string startnode, string destnode)
//        {
//            var pathlist = new list<string> { destnode };

//            node currentnode = nodedict[destnode];
//            while (currentnode != nodedict[startnode])
//            {
//                pathlist.add(currentnode.previousnode.name);
//                currentnode = currentnode.previousnode;
//            }

//            pathlist.reverse();
//            for (int i = 0; i < pathlist.count; i++)
//            {
//                console.write(pathlist[i] + (i < pathlist.count - 1 ? " -> " : "\n"));
//            }
//            console.writeline("overall distance: " + nodedict[destnode].value);
//        }
//    }

//}