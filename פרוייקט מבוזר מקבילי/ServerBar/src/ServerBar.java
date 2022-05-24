
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

public class ServerBar 

{
    private DataOutputStream toServer;
   private DataInputStream fromServer;
   private ServerSocket server;

    public ServerBar() throws IOException {
        server = new ServerSocket(1500);
        while (true) 
        { 
        Socket connection = server.accept(); 
          toServer = new DataOutputStream(socket.());
         fromServer = new DataInputStream(socket.getInputStream());
      // provideService(connection);

        }
        
    }









}