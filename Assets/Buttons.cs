using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject mouse;
    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.J))
       {
            if (mouse.GetComponent<Rigidbody>().linearVelocity.y > 0)
            {
                Debug.Log("LightButtonPressed");
            }
            
            
       }
       if (Input.GetKey(KeyCode.K))
       {
            Debug.Log("MediumButtonPressed");
       }
       if (Input.GetKey(KeyCode.L))
       {
            Debug.Log("HeavyButtonPressed");
       }
        if (Input.GetKey(KeyCode.Comma))
        {
            Debug.Log("SpecialButtonPressed");
        }
    }
}
