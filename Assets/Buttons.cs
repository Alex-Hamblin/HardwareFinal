using System.Collections;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject mouse;
    [SerializeField] GameObject center;

    [SerializeField] GameObject Light;
    [SerializeField] GameObject med;
    [SerializeField] GameObject heavy;
    [SerializeField] GameObject special;
    [SerializeField] AudioSource Audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.J))
       {
            if (Vector3.Distance(mouse.transform.position, center.transform.position) > 3)
            {
                Debug.Log("LightButtonPressed");
                StartCoroutine(LightAttack());
                Audio.Play();
            }
            
            
       }
       if (Input.GetKey(KeyCode.K))
       {
            if (Vector3.Distance(mouse.transform.position, center.transform.position) > 3)
            {
                Debug.Log("MediumButtonPressed");
                StartCoroutine(MedAttack());
                Audio.Play();
            }
        }
       if (Input.GetKey(KeyCode.L))
       {
            if (Vector3.Distance(mouse.transform.position, center.transform.position) > 3)
            {
                Debug.Log("HeavyButtonPressed");
                StartCoroutine(HeavyAttack());
                Audio.Play();
            }
        }
        if (Input.GetKey(KeyCode.Comma))
        {
            if (Vector3.Distance(mouse.transform.position, center.transform.position) > 3)
            {
                Debug.Log("SpecialButtonPressed");
                StartCoroutine(specialAttack());
                Audio.Play();
            }
        }
    }
    IEnumerator LightAttack()
    {
        Light.GetComponent<MeshRenderer>().materials[0].color = Color.red;
        yield return new WaitForSeconds(1);
        Light.GetComponent<MeshRenderer>().materials[0].color = Color.gray;
    }
    IEnumerator MedAttack()
    {
        med.GetComponent<MeshRenderer>().materials[0].color = Color.green;
        yield return new WaitForSeconds(1);
        med.GetComponent<MeshRenderer>().materials[0].color = Color.gray;
    }
    IEnumerator HeavyAttack()
    {
        heavy.GetComponent<MeshRenderer>().materials[0].color = Color.blue;
        yield return new WaitForSeconds(1);
        heavy.GetComponent<MeshRenderer>().materials[0].color = Color.gray;
    }
    IEnumerator specialAttack()
    {
        special.GetComponent<MeshRenderer>().materials[0].color = Color.yellow;
        yield return new WaitForSeconds(1);
        special.GetComponent<MeshRenderer>().materials[0].color = Color.gray;
    }
}

