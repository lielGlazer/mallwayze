/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package serverb;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import static serverb.Serverb.main;

/**
 *
 * @author student
 */
public class Serverb {

    private DataOutputStream toServer;
    private DataInputStream fromServer;
    private ServerSocket server;
    Socket socket;
    static String[] bar = new String[4];//הבר 

    public Serverb() throws IOException {

        server = new ServerSocket(1500);
        while (true) {
            Socket connection = server.accept();//מאזין 

        //  toServer = new DataOutputStream(connection.getOutputStream());//זרם יוצא ללקוח
            // fromServer = new DataInputStream(connection.getInputStream());//זרם נכנס  לסרוור
            //  provideService(connection);
            //   toServer.writeUTF("הייי מה קורה לקוח");
//         socket = main.accept();//׳”׳?׳–׳ ׳” ׳©׳? ׳”׳©׳¨׳× ׳¢׳? ׳”׳₪׳•׳¨׳˜ ׳©׳?׳• ׳¢׳“ ׳©׳?׳§׳•׳— ׳™׳¦׳•׳¨ ׳§׳©׳¨
            //         ClientHandler ch = new ClientHandler(socket);
            ConnectedwithClient cwc = new ConnectedwithClient(connection);

        }

    }

    public static void main(String[] args) throws IOException {
        new Serverb();
    }

}
