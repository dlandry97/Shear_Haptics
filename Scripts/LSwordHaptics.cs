using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class LSwordHaptics : MonoBehaviour
{
    public double mySum;
    public SerialController serialController;

    // Initialization
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Press A or Z to execute some actions");
    }
    void Update()
    {
        //---------------------------------------------------------------------
        // Send data
        //---------------------------------------------------------------------

        // If you press one of these keys send it to the serial device. A
        // sample serial device that accepts this input is given in the README.
        // if (mySum > 0.5 && mySum < 2.0)
        // {
        //     Debug.Log("Sending A");
        //     serialController.SendSerialMessage("A");
        // }

        // if (mySum > 2.0)
        // {
        //     Debug.Log("Sending Z");
        //     serialController.SendSerialMessage("Z");
        // }
        // if (mySum < 0.5)
        // {
        //     Debug.Log("Sending 0");
        //     serialController.SendSerialMessage("B");
        // }


        //---------------------------------------------------------------------
        // Receive data
        //---------------------------------------------------------------------

        string message = serialController.ReadSerialMessage();

        if (message == null){
            return;
        }
            

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED)){
            Debug.Log("Connection established");
        }else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED)){
            Debug.Log("Connection attempt failed or disconnection detected");
        }else{
            Debug.Log("Message arrived: " + message);
        }
            
        
            
    }

    // public SteamVR_Controller.Device mDevice;
    // public Interaction mInteraction;

    // public void Setup(SteamVR_Controller.Device newDevice, Interaction newInteraction){
    //     mDevice = newDevice;
    //     mInteraction = newInteraction;
    // }
    void OnCollisionEnter (Collision collisionInfo){
        double sum;
        double x_vel = collisionInfo.relativeVelocity.x;
        double y_vel = collisionInfo.relativeVelocity.y;
        // GameObject myobj = GameObject.Find("Katana_LODB");
        // SerialController myserial = myobj.GetComponent<SerialController>();

        // sum = Math.Sqrt(collisionInfo.relativeVelocity.x*collisionInfo.relativeVelocity.x+collisionInfo.relativeVelocity.y*collisionInfo.relativeVelocity.y+collisionInfo.relativeVelocity.z*collisionInfo.relativeVelocity.z);
        if(x_vel < 0){
            x_vel = x_vel *-1.0;
        }
        if(y_vel < 0){
            y_vel = y_vel *-1.0;
        }
        sum = x_vel + y_vel;
        // Debug.Log(sum);
        mySum = sum;
        if (mySum <0){
            ;
        }else if(mySum < 1){ //light
            Debug.Log("Sending a");
            serialController.SendSerialMessage("a");
        }else if(mySum < 2){
            Debug.Log("Sending b"); //medium
            serialController.SendSerialMessage("b");
        }else if(mySum < 3){
            Debug.Log("Sending c"); // heavy
            serialController.SendSerialMessage("c");
        }
        
        

    }
    void OnCollisionExit (Collision collisionInfo){
        Debug.Log("Sending z");
        serialController.SendSerialMessage("z");
        
        mySum = 0.0;

    }



    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
