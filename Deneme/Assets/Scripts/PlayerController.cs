using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float harizontalInput;
    public float speed=10.0f;
    public float turnSpeed;

    public GameObject projectilePrefab ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        harizontalInput=Input.GetAxis("Horizontal");
       // transform.Translate(Vector3.forward * Time.deltaTime* speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    if (Input.GetKeyDown(KeyCode.Space)) 
    {
      //oyuncu balik firlatsin
     Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
   
    }

}
