class avlnode {
   String value;
   avlnode leftC;
   avlnode rightC;
   int height;
   
   public avlnode(String val){
      value = val;
      leftC = null;
      rightC = null;
      height = -1;;
   }
   
   
   
   public String getValue() { 
      return this.value; }
   
   public String getLeftC() { 
      return this.leftC.getValue(); }

   
   public void printavlnode() { System.out.println("Value:" + getValue() + "  Right Child:"+ getRightC()+"  Left child:"+ getLeftC()); }
   
   public String getRightC() { 
      return this.rightC.getValue();
   }
      
   public void setLeftC(String val){  leftC =  new avlnode(val); }
   public void setLeft(avlnode avlnode){  leftC =  avlnode; }
    
   public void setRightC(String val){  rightC = new avlnode(val); }
   public void setRight(avlnode avlnode){  rightC = avlnode; }
   
   
}

public class avltree{
   avlnode root;
	int S_OpCounter = 0;
	int I_OpCounter= 0;

   public avltree() { root = null; }

   public avltree(String val) { root = new avlnode (val); } 
 
   public void incSearchCount(){ S_OpCounter++; }
   public void resetSearchCount(){ S_OpCounter = 0; }
   public void incInsertCount() { I_OpCounter++; }

   public int getSCounterVal(){ return this.S_OpCounter; }
   public int getICounterVal(){ return this.I_OpCounter; }

   public void rotateRight(avlnode avlnode, avlnode parent){
      //avlnode passed is the unbalanced avlnode
     
      if (avlnode == root) { 
         root = avlnode.leftC;
      }
      
      else {
         parent.rightC = avlnode.leftC;
       }
       
      avlnode temp = avlnode.leftC.rightC;
      avlnode.leftC.rightC = avlnode;
      avlnode.leftC = temp;
   
      fixHeight(root);
      
      return;
   
   }

   public void rotateLeft(avlnode avlnode, avlnode parent){

      if (avlnode == root) { root = avlnode.rightC; }
      else {
         parent.leftC = avlnode.rightC;
      }
      avlnode temp = avlnode.rightC.leftC;
      avlnode.rightC.leftC = avlnode;
      avlnode.rightC = temp;

      fixHeight(root);
      return;
   
   }


   public int balanceF(avlnode avlnode){
   //calculates balance factor of a avlnode passed
         int balance;
         
          if ((avlnode.leftC != null) && (avlnode.rightC != null)){
             return balance =  avlnode.leftC.height - avlnode.rightC.height;
          }
          
          else if ((avlnode.leftC != null)){
             return  balance = avlnode.leftC.height + 2;
          }
          
          else if (avlnode.rightC != null){
             return balance = -2 - avlnode.rightC.height;
          } 
          
          else return 0;
   }  

   public void fixHeight(avlnode avlnode){
     
      if ((avlnode.leftC != null) && (avlnode.rightC != null)){
         fixHeight(avlnode.leftC);
         fixHeight(avlnode.rightC);
         avlnode.height =  Math.max (avlnode.leftC.height, avlnode.rightC.height) + 1;
      }
      
      else if ((avlnode.leftC != null)){
         fixHeight(avlnode.leftC);
         avlnode.height = avlnode.leftC.height + 1;
      }
      
      else if (avlnode.rightC != null){
         fixHeight(avlnode.rightC);
         avlnode.height = avlnode.rightC.height + 1;
      }
   }


   public avlnode balance(avlnode avlnode, avlnode parent){
   // balances entire tree. Starts by checking the balance factor of the root, and then moves down.   
      if (balanceF(avlnode) == 2) {
             if (balanceF(avlnode.leftC) < 0) { 
               rotateLeft(avlnode.leftC, avlnode);
            } 
            rotateRight(avlnode, parent) ;
            return avlnode; 
      }
      
      else if (balanceF(avlnode) == -2){ 
            if (balanceF(avlnode.rightC) > 0) {
                rotateRight(avlnode.rightC, avlnode); 
             }
            rotateLeft(avlnode,parent);         
            return avlnode;
      } 
            
      else if (balanceF(avlnode) > 0) {     
           return balance(avlnode.leftC, avlnode); 
      }
           
      else if (balanceF(avlnode) < 0){  
            return balance(avlnode.rightC, avlnode); 
      }
      else {   
            return avlnode;
      }
   }

   public void addavlnode (String val){
      if (root == null) root = new avlnode (val); 
      else addavlnode(root, val);
   }


   public void addavlnode( avlnode avlnode, String val){

      incInsertCount();
      if (val.compareTo(avlnode.value) < 0) {
      
         if (avlnode.leftC == null) { 
               avlnode.setLeftC(val) ;
               fixHeight(root);
               balance(root, null);
               fixHeight(root);
               return;
         }
         
         else {
            addavlnode(avlnode.leftC, val); }
      }
      incInsertCount();    
      if (val.compareTo(avlnode.value) > 0){
         if (avlnode.rightC == null) { 
                avlnode.setRightC(val);
                fixHeight(root);
                balance(root, null);
               fixHeight(root);
               return;
         }
         else {
            addavlnode(avlnode.rightC, val);         
         }
      }
   }
   
   public boolean findavlnode(String val){
	 resetSearchCount();
         return findavlnode(root, val);
   }

   public boolean findavlnode( avlnode avlnode, String val){
        if (avlnode == null) { 
            return false; 
        }
        incSearchCount(); 
    	 if ((val).equals(getDetails(avlnode)) == true ) { 
            return true; 
        }
        incSearchCount();
        if (val.compareTo(getDetails(avlnode)) < 0) { 
            return  findavlnode(avlnode.leftC, val); 
        }
        incSearchCount();     
        if (val.compareTo(getDetails(avlnode)) > 0){
          return findavlnode(avlnode.rightC, val);         
       }  
        return false;
   }

   public String findavlnodeVal(String val){
      return findavlnodeVal(root, val);
   }

   public String findavlnodeVal( avlnode avlnode, String val){

     if ((val).equals(getDetails(avlnode)) == true ) {
          return getAreas(avlnode); 
     }
      
     else if (val.compareTo(getDetails(avlnode)) < 0) {
        return  findavlnodeVal(avlnode.leftC, val); 
     }
          
     else if (val.compareTo(getDetails(avlnode)) > 0){
        return findavlnodeVal(avlnode.rightC, val);         
      }
     return "Not found";
   }

   public String getAreas(avlnode avlnode){
         String line = avlnode.getValue();
         int space = line.indexOf(" ")+1;
         String areas = line.substring(space);
         return areas;
   }

   public String getDetails(avlnode avlnode){

      String line = avlnode.getValue();
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
      
      if (findavlnode(details) == true){
            System.out.println(findavlnodeVal(details));
	    System.out.println("Search operation counter value: "+ getSCounterVal());
      }
      else 
            System.out.println("No areas found");
	    System.out.println("Search operation counter value: "+ getSCounterVal());
		
   }

   public void printAllAreas(){
      printAllAreas(root);
   }


   public void printAllAreas(avlnode avlnode){
   
      if (avlnode != null) { 
      			System.out.println(avlnode.value);
      			printAllAreas(avlnode.leftC); 
      			printAllAreas(avlnode.rightC); 
      } 

   }
}

