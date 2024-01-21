using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OHOG
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float normalSpeed;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            InputCheck();
        }
        private void InputCheck()
        {
            // if (Input.GetKey())
            // {
                
            // }
        }
    }
}
