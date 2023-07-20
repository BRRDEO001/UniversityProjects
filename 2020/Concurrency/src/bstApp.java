import java.util.Scanner;
import java.io.File;
import java.io.FileNotFoundException;

public class bstApp{ 
public static void main (String [] args){

String fn = "loadshedding.txt";
File file = new File (fn);
BinaryTree bst = new BinaryTree();

try {
   Scanner tfile = new Scanner (file);
   int i = 0;
   String line;
   
   while (tfile.hasNext()){
   line = tfile.nextLine();
   bst.addNode(line);
   }
   
   tfile.close();
   }

catch  (FileNotFoundException e) { System.out.println ("File not found");}

if (args.length == 3){
      String stage = args[0];
      String dom = args[1];
      String s_time = args[2];
      bst.printAreas(stage, dom, s_time);
   }

else { bst.printAllAreas();}

System.out.println("Insert operation counter value: "+ bst.getICounterVal());

}

}


