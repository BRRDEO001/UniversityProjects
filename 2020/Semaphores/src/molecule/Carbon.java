 package molecule;

public class Carbon extends Thread {
	
	private static int carbonCounter =0;
	private int id;
	private Propane sharedPropane;
   private boolean finalAtom = false;
	
	public Carbon(Propane propane_obj) {
		Carbon.carbonCounter+=1;
		id=carbonCounter;
		this.sharedPropane = propane_obj;
	}
	
	public void run() {
	    try {	 
	    	 
          // give mutual exclusive access to shared propane
          sharedPropane.mutex.acquire();
          
          //add carbon atom to propane molecule
          sharedPropane.addCarbon();
          
          //check if enough carbon and hydrogen atoms are present to form a propane molecule
          
          if ((sharedPropane.getCarbon() >= 3)&& ( sharedPropane.getHydrogen() >= 8)){
            finalAtom = true;
            System.out.println("---Group ready for bonding---");
             
             for (int i = 0; i < 8; i++){ //release 8 hydrogen semaphores
             
                sharedPropane.hydrogensQ.release();
               
             }
             
          
             sharedPropane.removeHydrogen(8);
             sharedPropane.hydrogensQ.release();
             sharedPropane.removeCarbon(3);
          }
          
    
          else{
                sharedPropane.mutex.release();
          }
        
	     sharedPropane.carbonQ.acquire(); //carbon semaphore holds the "lock" 
        sharedPropane.bond("C"+this.id);
        sharedPropane.barrier.b_wait();
        
        if(finalAtom){
         sharedPropane.mutex.release(); //release mutual exclusive access, i.e. give access to propane molecule to other threads
	     }
	    	   	 
	    }
	    catch (InterruptedException ex) { /* not handling this  */}
	   // System.out.println(" ");
	}

}
