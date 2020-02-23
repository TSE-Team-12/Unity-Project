using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{
    public LayerMask collisionmask;
    public float Speed = 5;
    public float Damage = 25;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);   
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Time.deltaTime * Speed+0.5f, collisionmask))
        {

            if (hit.transform.tag == "Enemy")
            {
                hit.transform.GetComponent<EnemyStats>().TakeDamage(Damage);
                Destroy(gameObject);
            } else if (hit.transform.tag == "Wall")
            {
                Vector3 reflect = Vector3.Reflect(ray.direction, hit.normal);
                float rot = 90 - Mathf.Atan2(reflect.z, reflect.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, rot, 0);
            }
            else
            {
                
            }

            
        }

    }
}
