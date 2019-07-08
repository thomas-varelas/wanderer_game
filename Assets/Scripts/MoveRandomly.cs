using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandomly : MonoBehaviour
{
    public float timer;
    public int newTarget;
    public float speed;
    public NavMeshAgent nav;
    public Vector3 Target;

    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= newTarget)
        {
            newTargetFn();
            timer = 0;
        }
    }

    void newTargetFn()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos = myX + Random.Range(myX - 20, myX + 20);
        float zPos = myZ + Random.Range(myZ - 20, myZ + 20);

        Target = new Vector3(xPos, gameObject.transform.position.y, zPos);

        nav.SetDestination(Target);

    }
}
