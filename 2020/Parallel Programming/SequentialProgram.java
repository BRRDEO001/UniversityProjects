import java.util.*;
import java.io.*;
import java.text.*;

public class SequentialProgram{
static long startTime = 0;
static float endTime;
static float NOISE_VAL = 0.01f;
   
   private static void tick(){
      startTime = System.currentTimeMillis();               
   }

   private static float tock(){
      return (System.currentTimeMillis() - startTime)/ 1000.0f ;
   }
   
   
   public static void main (String [] args){
  
      //Get input and output filenames from command-line parameters
      String fileName = args[0];
      String outputFN = args[1];
      
      //Creating variables that stores number of rows and number of columns, as well as 2D array to store all the data 
      int numCol =0;
      int numRows = 0;
      float [][] data = new float [numRows][numCol];

      //Storing data in 2D array
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
     
     /*Finding basins 
      A basin is determined for a given grid position by checking the ring of neighbouring height values. 
      If all of the neighbours are at least 0.01m higher than the grid point then it is classified as a basin.
      There is no need to classify points on the outer edge of the grid as they are automatically considered non-basins. 
      I.e if number of rows passed is x, and number of columns passed is y, then non-basins would be at:
      (x,y) such that x = 0 or y = 0 or x or y = number of rows or columns
      Also keep track of number of basins
      */
      int basinCounter = 0;
      ArrayList<String> basins = new ArrayList<String> () ;
      
      //start timer to see time of execution
      tick();
      
      for (int x = 1; x < numRows-1; x++){
         for (int y = 1; y < numCol-1; y++)
         {
            float currentPoint = data [x][y] + NOISE_VAL;
               if (  ( currentPoint <= (data[x-1][y] ))
                  && (currentPoint <= (data[x+1][y] ))
                  && (currentPoint <= (data[x][y-1] ))
                  && (currentPoint <= (data[x][y+1] ))
                  && (currentPoint <= (data[x-1][y-1] ))
                  && (currentPoint <= (data[x-1][y+1] ))
                  && (currentPoint <= (data[x+1][y-1] ))
                  && (currentPoint <= (data[x+1][y+1] )))
                  { String pos =  x+" "+y;
                    basinCounter++;
                    basins.add(pos); 
                  }
         }
      
      }
      //end timer
      endTime = tock();
      
      
      try{
         PrintWriter writer = new PrintWriter(outputFN);
 	 writer.println(basinCounter);
         for (int i = 0; i < basinCounter; i++){
            writer.println(basins.get(i));
         }
	writer.close();
      
      }
      catch (IOException e) { System.out.println("Output file not found"); }
     
   //   System.out.println(endTime); // - for research purposes

   }
}
