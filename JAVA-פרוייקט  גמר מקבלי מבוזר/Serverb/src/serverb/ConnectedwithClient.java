/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package serverb;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import static java.lang.Boolean.FALSE;
import static java.lang.Boolean.TRUE;
import java.lang.String;
import java.lang.reflect.Array;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;
import static serverb.Serverb.bar;
/**
 *
 * @author student
 */
public class ConnectedwithClient extends Thread{
    String take;// לראות מה הלקוח רוצה לקחת מהבר
    String put;//לראות מה העובד רוצה להכניס לבר 
        
   
  
    Socket socket;//הצינור
    DataInputStream din;//נכנס 
    ObjectOutputStream dout;//יוצא

    public ConnectedwithClient(Socket socket) {//פונקציה שמקבלת את הפיה של הצינורכאילו את מי שיצר את הקשר 
        this.socket = socket;//אתחול הקשר לצינור הנוכחי
        try {
            din = new DataInputStream(socket.getInputStream());//קבלת כניסת זרם
            dout = new ObjectOutputStream(socket.getOutputStream());//קבלת יציאת זרם 
            start();
        } catch (IOException ex) {
            Logger.getLogger(ConnectedwithClient.class.getName()).log(Level.SEVERE, null, ex);
        }
 
    }
    public void run() {
       int palce;
        
        String read = null;
        
            try 
            {
                dout.writeObject(Serverb.bar );
                //קוראת מה נכנס
                read = din.readUTF();
                System.out.println(read);
            } 
            catch (IOException ex) 
            {
                Logger.getLogger(ConnectedwithClient.class.getName()).log(Level.SEVERE, null, ex);
            }
            //בדיקה מי אתה
            if(read.equals("לקוח"))
            {
                try 
                {
                    try
                    {
                        take=din.readUTF();
                        //הפעלת הפונקציה
                        //IsInStock();
                    }
                    catch (IOException ex)
                    {
                        Logger.getLogger(ConnectedwithClient.class.getName()).log(Level.SEVERE, null, ex);
                    }
                    palce=IsInStock(); //פונקציה שבודקת אםם יש בבר את מה שהלקוח רצה
                    
                    dout.writeObject(bar);//לשלוח ללקוח את הבר שיראה אותו
                }
                catch (IOException ex) 
                {
                    Logger.getLogger(ConnectedwithClient.class.getName()).log(Level.SEVERE, null, ex);
                }
            } 
            
            else    
            {
                try 
                { 
                    put=din.readUTF();
                } 
                catch (IOException ex) 
                {
                    Logger.getLogger(ConnectedwithClient.class.getName()).log(Level.SEVERE, null, ex);
                }
                palce=  IsPlace();//פונקציה שבודקת אםם יש בבר מקום
                if(palce != -1)
                {
                    
                }
            }
    }
           public synchronized int IsInStock()//האם יש מה לקחת
           {
             for (int i = 0; i < bar.length; i++) 
             {
                 if(bar[i].equals(take))
                 {
                     return i;
                 }  
             }
               
            return -1;
               
           }
          public synchronized int IsPlace()//האם יש לאיפה להכניס
          {
            for (int i = 0; i < bar.length; i++) 
            {
                if(bar[i].equals(""))
                 {
                     System.out.println("יש מקום להכניס לבר:) ");
                     return i;
                 }  
                   
            }
            System.out.println("מצטערים אין מקום בבר :(");
           return -1;
            
          }
        
    }

   
    

