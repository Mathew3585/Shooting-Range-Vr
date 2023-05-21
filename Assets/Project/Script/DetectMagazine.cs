using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMagazine : MonoBehaviour
{
    private GunVr gun;
    public int MagazineSize;
    // Start is called before the first frame update
    void Start()
    {
        gun = GetComponentInParent<GunVr>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Magazine"))
        {
            gun.Bullet += MagazineSize;
            other.GetComponent<Rigidbody>().useGravity= false;
            other.gameObject.transform.parent = transform.parent;
            other.gameObject.transform.position = transform.position;
            other.gameObject.transform.rotation = transform.rotation;
            Debug.Log("Enter");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Magazine"))
        {
            gun.Bullet += MagazineSize;
            other.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.transform.parent = transform.parent;
            other.gameObject.transform.position = transform.position;
            other.gameObject.transform.rotation = transform.rotation;
            Debug.Log("Enter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Magazine"))
        {
            gun.Bullet = 0;
            other.GetComponent<Rigidbody>().useGravity = true;

            Debug.Log("Exit");
        }


    }
}
