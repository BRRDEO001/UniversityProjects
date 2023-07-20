import java.util.*;
import java.io.File;
import java.io.FileNotFoundException;
public class Testing {
   
   public static void main (String [] args){
    
for (int datasize = 297; datasize < 2976; datasize +=297 ){

   Random rand = new Random();
   int s_val = rand.nextInt(2976-datasize);
   
  // System.out.println(s_val);
   String [] dataset = new String [datasize];
   BinaryTree bst = new BinaryTree();
   avltree avl = new avltree();
   
   File file = new File ("loadshedding.txt");
    int i = 0;
   int  counter = 1;
   String line;
   
try {
   Scanner tfile = new Scanner (file);
  
   
   while (tfile.hasNext()){
      line = tfile.nextLine();   
      if ((counter >= s_val)&&(counter < s_val + datasize)){
         
         dataset[i] = line;
         bst.addNode(line);
         avl.addavlnode(line);
         i++;
         counter++;
      }
      else counter++;
   }
   
   tfile.close();
  }
catch  (FileNotFoundException e) { System.out.println ("File not found");}
String stage, DOM, time;
System.out.println("Data set size: "+ datasize);
for (i = 0; i < datasize; i++){
   line = dataset[i];
   int us = line.indexOf("_");
         stage = line.substring(0,us);
         line = line.substring(us+1);
         us = line.indexOf("_");
         DOM = line.substring(0,us);
         line = line.substring(us+1); 
         us = line.indexOf(" ");
         time = line.substring(0,us);
         
	 System.out.println("Key: "+ stage+"_"+DOM+"_"+time);
         bst.printAreas(stage, DOM,time);
	 avl.printAreas(stage, DOM, time);
}

   

}
   }
}
