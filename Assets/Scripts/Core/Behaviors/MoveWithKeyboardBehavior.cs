using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Input Keys
public enum InputKeyboard{
    arrows = 0, 
    wasd = 1
}
public class MoveWithKeyboardBehavior : AgentBehaviour
{
    public InputKeyboard inputKeyboard; 

    public override Steering GetSteering()
    {
        Steering steering = new Steering();
        //implement your code here

        float horizontal = 0;
        float vertical = 0;
        if (InputKeyboard.wasd == inputKeyboard) {
            horizontal = Input.GetAxis("Horizontal_arrows");
            vertical = Input.GetAxis("Vertical_arrows");

        } else if (inputKeyboard == InputKeyboard.arrows) {
            horizontal = Input.GetAxis("InputAD");
            vertical = Input.GetAxis("InputWS");
        }
        steering.linear = new Vector3(horizontal, 0, vertical)* agent.maxAccel;
        steering.linear = agent.transform.parent.TransformDirection(Vector3.ClampMagnitude(steering.linear , agent.maxAccel));
        return steering;
        
    }

}
