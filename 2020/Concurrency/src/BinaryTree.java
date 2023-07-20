class Node {
   String value;
   Node leftC;
   Node rightC;
   
   public Node(String val){
      value = val;
      leftC = null;
     rightC = null;
   }
   
   
   
   public String getValue() { return this.value; }
   
   public String getLeftC() { 
      try{
      return this.leftC.getValue(); }
      catch ( NullPointerException ex) { return null; }
   }

   
   public void printNode() { System.out.println("Value:" + getValue() + "  Right Child:"+ getRightC()+"  Left child:"+ getLeftC()); }
   
   public String getRightC() { 
      try {
      return this.rightC.getValue();}
      
       catch ( NullPointerException ex) { return null; }
   }
      
   public void setLeftC(String val){  leftC =  new Node(val); }
   
   public void setRightC(String val){  rightC = new Node(val); }
   
   
    
   
}

public class BinaryTree  {
Node root;
int S_OpCounter = 0;
int I_OpCounter= 0;

public BinaryTree () { root = null; }

public BinaryTree (String val){ 
   Node node = new Node (val);
   root = node;
}

public void incSearchCount(){ S_OpCounter++; }
public void resetSearchCount(){ S_OpCounter = 0; }
public void incInsertCount() { I_OpCounter++; }

public int getSCounterVal(){ return this.S_OpCounter; }
public int getICounterVal(){ return this.I_OpCounter; }

public void addNode (String val){
    if (root == null) root = new Node (val); 
    else addNode(root, val);
}


public void addNode( Node node, String val){
     incInsertCount();
     if (val.compareTo(node.value) < 0) {
         if (node.getLeftC() == null){ node.setLeftC(val) ;}
         else
             addNode(node.leftC, val);
          
      }
     incInsertCount();    
     if (val.compareTo(node.value) > 0){
         if (node.getRightC() == null) { node.setRightC(val); }
         else {
            addNode(node.rightC, val);         
         }
     }
}


public boolean findNode(String val){
	resetSearchCount();
         return findNode(root, val);
   }

   public boolean findNode( Node node, String val){
        if (node == null) { 
            return false; 
        }
        incSearchCount(); 
    	 if ((val).equals(getDetails(node)) == true ) { 
            return true; 
        }
        incSearchCount();
        if (val.compareTo(getDetails(node)) < 0) { 
            return  findNode(node.leftC, val); 
        }
        incSearchCount();     
        if (val.compareTo(getDetails(node)) > 0){
          return findNode(node.rightC, val);         
       }  
        return false;
   }

   public String findNodeVal(String val){
      return findNodeVal(root, val);
   }

   public String findNodeVal( Node node, String val){

     if ((val).equals(getDetails(node)) == true ) {
          return getAreas(node); 
     }
      
     else if (val.compareTo(getDetails(node)) < 0) {
        return  findNodeVal(node.leftC, val); 
     }
          
     else if (val.compareTo(getDetails(node)) > 0){
        return findNodeVal(node.rightC, val);         
      }
     return "Not found";
   }

   public String getAreas(Node node){
         String line = node.getValue();
         int space = line.indexOf(" ")+1;
         String areas = line.substring(space);
         return areas;
   }

   public String getDetails(Node node){

      String line = node.getValue();
      int space;
      
      try {
         space = line.indexOf(" ");
          String details = line.substring(0,space);
         return details;  
      }
      catch (NullPointerException ex) { 
         System.out.println("Not found");  
      }
      return "Not found";
   
   }

   public void printAreas(String stage, String dom, String s_time){
      String details = stage + "_"+dom+"_"+s_time;
      
      if (findNode(details) == true){
	    
            System.out.println(findNodeVal(details));
	    System.out.println("Search operation counter value:  "+getSCounterVal());
      }
      else 
            System.out.println("No areas found");
	    System.out.println("Search operation counter value:  "+getSCounterVal());
   }

   public void printAllAreas(){
      printAllAreas(root);
   }


   public void printAllAreas(Node node){
   
      if (node != null) { 
      			System.out.println(node.value);
      			printAllAreas(node.leftC); 
      			printAllAreas(node.rightC); 
      } 
   
   }
}
   

