package molecule;

public class Hydrogen extends Thread {

	private static int hydrogenCounter =0;
	private int id;
	private Propane sharedPropane;
	private boolean finalAtom = false;
	
	public Hydrogen(Propane propane_obj) {
		Hydrogen.hydrogenCounter+=1;
		id=hydrogenCounter;
		this.sharedPropane = propane_obj;
		
	}
	
	public void run() {

	    try {
       
	    	 // you will need to fix below
          
         
         sharedPropane.mutex.acquire();// gives mutual exclusive access to shared propane
         sharedPropane.addHydrogen(); //add hydrogen atom to propane molecule
         
       
        
         //check if enough carbon and hydrogen atoms are present to form a propane molecule
         if ((sharedPropane.getCarbon() >= 3)&& (sharedPropane.getHydrogen()>=8)){
            finalAtom = true;
            System.out.println("---Group ready for bonding---");			 
	    	   
            for(int i = 0; i < 8; i++){ //release 8 hydrogen semaphores
            
               sharedPropane.hydrogensQ.release();
            
            }
            
            sharedPropane.removeHydrogen(8);
            
            for(int i = 0; i < 3; i++){ //release 3 carbon semaphores
               sharedPropane.carbonQ.release();
               
            }
        
            sharedPropane.removeCarbon(3);
         
         
         } 
         else {
           
             sharedPropane.mutex.release();  //give other threads access to propane molecule (no longer mutually exclusive)
            
         }
         
          
         sharedPropane.hydrogensQ.acquire();
         
         sharedPropane.bond("H"+this.id);
         sharedPropane.barrier.b_wait(); 
         
         if (finalAtom){
          sharedPropane.mutex.release();
         }
         
	       
	    }
	   catch (InterruptedException ex) { /* not handling this  */}
	    //System.out.println(" ");
	}

}
