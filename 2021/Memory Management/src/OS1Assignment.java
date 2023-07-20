import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Arrays;
import java.util.Scanner;
import java.io.*;

public class OS1Assignment {


    public static void getAddress(int input){

        int [] pageTable = new int [] {2,4,1,7,3,5,6};

        String binaryVal = formatBinary(decToBinary(input));

        String pageTblRef = binaryVal.substring(0,5);

        int index =  pageTable[binaryToDec(pageTblRef)];

        String offset = binaryVal.substring(5);

        String indexBin = decToBinary(index);

        String address = indexBin + offset;

        address = formatBinary(address);

        String btx = binaryToHex(address);

        String temp = "0x";
        for (int i = 0; i < 10 - btx.length(); i++){
            temp += "0";
        }
        btx = temp + btx;
        System.out.println(btx);
    }

    /*
        Function that takes in a String value in hex format, and converts it to a binary format.

    public static String hexToBinary(String val){

        if(val.length() == 2){
            val+= "0";
        }
        else if(val.length() == 1){
            val+= "00";
        }
        String input = val.substring(val.length() - 3);
        String binary = "";
     for (int i = 0; i < 3; i++){
         binary += binValue(input.charAt(i));
     }

       return binary;
    }
    */

    public static String formatBinary(String input ){
        String binary = "";

        for (int i = 0; i < 12 - input.length() ; i++){
            binary += "0";
        }
        binary += input;
        return binary;
    }
    /*
        Reverses a string and returns a string
     */
    public static String reverse(String input){

        String result = "";

        for (int i = input.length()-1; i > -1; i--){
            result += input.charAt(i);
        }

        return result;
    }


    public static String binValue(char input){

        String binary = "";
        String hex = "";

            if (input == '0') {
                binary = "0000";
            } else if (input == '1') {
                binary = "0001";
            } else if (input == '2') {
                binary = "0010";
            } else if (input == '3') {
                binary = "0011";
            } else if (input == '4') {
                binary = "0100";
            } else if (input == '5') {
                binary = "0101";
            } else if (input == '6') {
                binary = "0110";
            } else if (input == '7') {
                binary = "0111";
            } else if (input == '8') {
                binary = "1000";
            } else if (input == '9') {
                binary = "1001";
            } else if (input == 'A') {
                binary = "1010";
            } else if (input == 'B') {
                binary = "1011";
            } else if (input == 'C') {
                binary = "1100";
            } else if (input == 'D') {
                binary = "1101";
            } else if (input == 'E') {
                binary = "1110";
            } else if (input == 'F') {
                binary = "1111";
            }

        return binary;
    }

    public static String hexValue(String  input){
        String hex = "";

        if (input.equals("0000")) {
            hex = "0";
        }
        if (input.equals( "0001") ){
            hex = "1";
        }
        if (input.equals("0010") ){
            hex = "2";
        }
        if (input.equals("0011") ){
            hex = "3";
        }
        if (input.equals("0100")) {
            hex = "4";
        }
        if (input .equals( "0101") ){
            hex = "5";
        }
        if (input.equals("0110") ){
            hex = "6";
        }
        if (input.equals("0111")){
            hex = "7";
        }
        else if(input.equals("1010")){
            hex = "A";
        }
        else if(input.equals("1011")){
            hex = "B";
        }
        else if(input.equals("1100")){
            hex = "C";
        }
        else if(input.equals("1101")){
            hex = "D";
        }
        else if(input.equals("1110")){
            hex = "E";
        }
        else if(input.equals("1111")){
            hex = "F";
        }

        return hex;
    }

    public static int binaryToDec(String input ){
        int dec = 0;
        int c = 0;


        for (int i = input.length()-1; i >= 0 ; i--){
            int iVal =Character.getNumericValue (input.charAt(c));
            dec += iVal * Math.pow(2, i);
            c++;
        }
        return dec;
    }

    public static String  decToBinary(int input){
        String binary = "";
        int quotient = input;

        while (quotient > 0){

            if(quotient % 2 == 0){
                binary += 0;
            }
            else {
                binary += 1;
            }
            quotient /= 2;
        }

        binary = (reverse(binary));


        return binary;

    }

    public static String binaryToHex(String binary){

        String nibble;

        String hexval = "";
        for (int i = 0; i < 12; i+=4){
            nibble = binary.substring(i, i + 4);
            hexval += hexValue(nibble);

        }

        return hexval;
    }

    public static void main (String [] args) throws IOException {

        //Process binary input file

        Path path = Paths.get(args[0]);
        byte [] arr = Files.readAllBytes(path);
        long [] byteArr = new long[8];
        int count = 0;
        String strByte = "";

        for (int i = 0; i < arr.length; i++){
            byte j = arr[i];
            byteArr[count] = j & 0xff;
            count++;

            if (count == 8){
                for (int k  = 7; k >= 0; k--){
                    strByte += byteArr [k];
                }
                try{
                    getAddress(Integer.parseInt(strByte));
                }
                catch (ArrayIndexOutOfBoundsException ex){
                    System.out.println("ERROR");
                }


                count = 0;
                strByte = "";

            }

        }

        /*
            Steps to doing the conversion:

             Convert input to binary
             Make length 12
             Split into offset (last 7 characters) and page table reference (first 5 characters)
             Convert page ref. binary portion to decimal
             Check 3's answer with ref table -> index
             Convert index to binary
             Concatenate binary format of input and offset in binary format
         */

     //   getAddress("BC");

    }
}

