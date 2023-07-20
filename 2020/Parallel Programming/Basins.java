import java.util.concurrent.RecursiveTask;
import java.util.*;
import java.io.*;
import java.text.*;

public class Basins extends RecursiveTask <ArrayList<String>> {
    //2D Array attributes
    int numCol ;
    int numRows ;
    float [][] data = new float [numRows][numCol];
    
    //Basins attributes
    ArrayList<String> basins = new ArrayList<String> ();
    static final float NOISE_VAL = 0.01f;
    static int basinCounter = 0;
    static float endTime;
    static long startTime = 0;
    
    //Fields required for parallel programming
    static final int SEQUENTIAL_CUTOFF = 400;
    int lowerB, upperB;
      
     //constructor - takes data from textfile and puts it into a 2D array     
     public Basins(String fileName){
          try { 
               //create file object passed to scanner class in order to receive input from textfile
               File file = new File(fileName);
               Scanner f = new Scanner(file);
               //fields used to extract and store data
               String line;
               int space;
              
               if (f.hasNextLine() == true){
                  line = f.nextLine();
                  space = line.indexOf(" ");
                  int tempRow = Integer.parseInt(line.substring(0,space));
                  int tempCol= Integer.parseInt(line.substring(space+1));
                  if (tempRow >=0 && tempCol>=0) {
                     numRows = tempRow;
                     numCol = tempCol;
                  }
                  data = new float [numRows][numCol];
               }
                   if (f.hasNextLine() == true){
                        line = f.nextLine(); 
                        Scanner scan = new Scanner(line);
                        scan.useDelimiter(" ");
                  
                        //Go through data and store in 2D array
                          for (int j = 0; j < numRows; j++) { //loop through each row
                           for (int i = 0; i <numCol; i++){
                              data[j][i] = Float.parseFloat(scan.next());
                           }   
                          }
                    }
           } 
           catch (FileNotFoundException e) { 
               System.out.println("File not found"); 
           }
          lowerB = 1;
          upperB = numRows-1; 
           
   } // end of constructor
   
   public Basins(float[][] arr, int numC, int lowerBound, int upperBound, int basinC){
             upperB = upperBound;
             lowerB = lowerBound;
             data = arr;
             numCol = numC;
             basinCounter = basinC;
   }
      
      public ArrayList<String> findBasins(float [][] dataArray, int numCol, int lowerB, int upperB, int basinC){
         for (int x = lowerB; x < upperB; x++){
            for (int y = 1; y < numCol-1; y++){
            
               float currentPoint = data [x][y] + NOISE_VAL;
               if (  ( currentPoint <= (data[x-1][y] ))
                  && (currentPoint <= (data[x+1][y] ))
                  && (currentPoint <= (data[x][y-1] ))
                  && (currentPoint <= (data[x][y+1] ))
                  && (currentPoint <= (data[x-1][y-1] ))
                  && (currentPoint <= (data[x-1][y+1] ))
                  && (currentPoint <= (data[x+1][y-1] ))
                  && (currentPoint <= (data[x+1][y+1] )))
                  { 
                    String pos =  x+" "+y;
                    basinCounter++;
                    basins.add(pos);
                    
                  } // conditions for basin
            
            } //loop through columns
         } //loop throug rows
        return basins; 
      }//end of findBasins function
      
    private static void tick(){
      startTime = System.currentTimeMillis();               
   }

   private static float tock(){
      return (System.currentTimeMillis() - startTime)/ 1000.0f ;
   }
   
   protected ArrayList<String> compute(){
   if (this.startTime == 0){
      tick();
   }
      if ((upperB-lowerB) < SEQUENTIAL_CUTOFF){
         basins = (findBasins(data, numCol, lowerB, upperB,basinCounter));   
      }
      else {
           Basins left = new Basins(data, numCol,lowerB,(upperB+lowerB)/2, basinCounter );
           Basins right = new Basins(data, numCol, (upperB+lowerB)/2, upperB,basinCounter);
  
           left.fork();
			  ArrayList<String> rightArr = right.compute();
			  ArrayList<String> leftArr  = left.join();
			  leftArr.addAll(rightArr);
           basins.addAll(leftArr);
           endTime = tock(); 
           return basins; 
      
      }
      return basins;
   }

    public static void main (String [] args){
       Basins fb = new Basins(args[0]);
       String outputFN = args[1];
       tick();
       fb.compute();
       float endTime = tock();
       
         try{
            
		    FileWriter filewriter = new FileWriter(outputFN);
		    PrintWriter writer = new PrintWriter(filewriter);
		    writer.println(fb.basinCounter);
		    for (int i = 0; i < basinCounter; i++){
		     writer.println(fb.basins.get(i));
           }
            writer.close();
      
      }
      catch (IOException e) { System.out.println("Output file not found"); }


 }
 
 }
