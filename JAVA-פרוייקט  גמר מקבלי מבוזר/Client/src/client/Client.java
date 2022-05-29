/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package client;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author student
 */
public class Client {
    

    private DataOutputStream toServer;
    private ObjectInputStream fromServer;
    private Socket socket;

    public Client() {

        try {
            // Create a socket to connect to the server
            socket = new Socket("localhost", 1500);
            System.out.println("הצלחתי להתחבר!!");

            // Create an output stream to send data 
            // to the server
            //מה יצא מהלקוח
            toServer = new DataOutputStream(socket.getOutputStream());
            

            // Create an input stream to receive data
            // from the server
            //מה יוצא מהשרת
            fromServer = new ObjectInputStream(socket.getInputStream());
            //System.out.println(fromServer.readUTF());

        } 
        catch (IOException ex) {
        }
    }

    public void writeToServer(String s) {
        try 
        {
            //תכניס למה שיוצא מהלקוח את מה שהלקוח כתב
            toServer.writeUTF(s);
            toServer.flush();
            
        } 
        catch (IOException e) 
        {
            e.printStackTrace();
        }
    }

    public String readFromServer() {

        try 
        {
            return (String) fromServer.readUTF();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }
      public String[] readBarFromServer()  {

//        try {
//            return (String) fromServer.readUTF();
//        } catch (ClassNotFoundException e) {
//            e.printStackTrace();
//        }
//
//    }
        try 
        {
            try {
                return (String[]) fromServer.readObject();
            } catch (ClassNotFoundException ex) {
                Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }
    
         public static void main(String[] args) throws IOException {
        new Client();
    }

}
