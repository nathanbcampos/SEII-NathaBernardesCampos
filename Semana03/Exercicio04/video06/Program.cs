using AlgorithmsDataStructure.LinkedList;

/*Node nodeA = new Node();*/
/*nodeA.Data = 3;*/
/**/
/*Node nodeB = new Node();*/
/*nodeB.Data = 344;*/
/**/
/*Node nodeC = new Node();*/
/*nodeC.Data = 2397;*/
/**/
/*Node nodeD = new Node();*/
/*nodeD.Data = 321;*/
/**/
/*nodeA.Next = nodeB;*/
/*nodeB.Next = nodeC;*/
/*nodeC.Next = nodeD;*/

LinkedList linkedlist = new LinkedList();
linkedlist.InsertFirst(1);
linkedlist.InsertFirst(2);
linkedlist.InsertFirst(3);
linkedlist.InsertFirst(4);

linkedlist.DeleteFirst();
linkedlist.DeleteFirst();

linkedlist.InsertLast(546);
linkedlist.InsertLast(3434);

linkedlist.DisplayList();
