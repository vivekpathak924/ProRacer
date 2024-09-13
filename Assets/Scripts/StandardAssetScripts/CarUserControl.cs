using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        public enum ControlMode{
            Keyboard,
            Buttons
        };
        private CarController m_Car; // the car controller we want to use
        public ControlMode controlInput;

        float h,v,handbrake;
        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        public void MoveInputs(float input){
            v = input;
        }
        public void SteerInputs(float input){
            h = input;
        }
        public void StopInputs(float input){
            handbrake = input;
        }
        void GetInputs(){
            if(controlInput==ControlMode.Keyboard){
                h = CrossPlatformInputManager.GetAxis("Horizontal");
                v = CrossPlatformInputManager.GetAxis("Vertical");

                handbrake = CrossPlatformInputManager.GetAxis("Jump");
                
            }
        }
        private void FixedUpdate()
        {
            m_Car.Move(h, v, v, handbrake);

            m_Car.Move(h, v, v, 0f);
        }

        
        
    }
}
