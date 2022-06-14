/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
 
package serverb;

import java.io.DataOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.util.List;
import java.util.LinkedList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author student
 */
public class SynchQueue<String> {
  
 

    // BlockingQueue using LinkedList structure
    // with a constraint on capacity
    private final List<String> queue = new LinkedList<String>();
 
    // limit variable to define capacity
    private int limit;
 
    // constructor of BlockingQueue
    public SynchQueue(int limit) { this.limit = limit; }
    
    // enqueue method that throws Exception
    // when you try to insert after the limit
    //מכניס  מגש
    public synchronized void put(String item,DataOutputStream out)
        throws InterruptedException
    {
        while (this.queue.size() == this.limit) {
            try {
                out.writeUTF("כרגע אין מקום להכניס לבר, אתה בהמתנה");
            } catch (IOException ex) {
                Logger.getLogger(SynchQueue.class.getName()).log(Level.SEVERE, null, ex);
            }
            wait();
        }
        if (this.queue.size() == 0) {
            notifyAll();
        }
        this.queue.add(item);
    }
 
    // dequeue methods that throws Exception
    // when you try to remove element from an
    // empty queue
    //מוציא  מגש
    public synchronized String take(DataOutputStream out)
        throws InterruptedException
    {
        while (this.queue.size() == 0) {
            try {
                out.writeUTF("כרגע אין מה לקחת , אתה בהמתנה");
            } catch (IOException ex) {
                Logger.getLogger(SynchQueue.class.getName()).log(Level.SEVERE, null, ex);
            }
            wait();
        }
        if (this.queue.size() == this.limit) {
            notifyAll();
        }
 
        return this.queue.remove(0);
    }
   
   
} 

