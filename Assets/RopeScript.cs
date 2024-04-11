using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RopeScript : MonoBehaviour
{
    public Vector2 destiny;
    public float speed = 1;
    public float distance = 2;
    public GameObject NodePrefab;
    public GameObject player;
    public GameObject lastNode;
    public LineRenderer lr;
    int vertexCount = 2;
    public List<GameObject> Nodes = new List<GameObject>();
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        lastNode = transform.gameObject;

        Nodes.Add(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destiny, speed);

        if ((Vector2)transform.position != destiny)
        {
            if (Vector2.Distance(player.transform.position, lastNode.transform.position) > distance)
            {
                CreateNode();
            }
        }

        else if (done == false)
        {

            if(Vector2.Distance(player.transform.position, lastNode.transform.position) > distance)
            {
                CreateNode();
            }

            done = true;
            lastNode.GetComponent<HingeJoint2D>().connectedBody = player.GetComponent<Rigidbody2D>();
        }
        RenderLine();
    }
    
    

    void RenderLine()
    {
        lr.positionCount = vertexCount;
        int i;
        for ( i = 0; i < Nodes.Count; i++)
        {
            lr.SetPosition(i, Nodes[i].transform.position);
        }
        lr.SetPosition(Nodes.Count - 1,player.transform.position);
    }

    void CreateNode()
    {
        Vector2 pos2Create = player.transform.position-lastNode.transform.position;
        pos2Create.Normalize();
        pos2Create *= distance;
        pos2Create += (Vector2)lastNode.transform.position;

        GameObject go = (GameObject) Instantiate (NodePrefab, pos2Create, Quaternion.identity);

        go.transform.SetParent(transform);

        lastNode.GetComponent<HingeJoint2D>().connectedBody = go.GetComponent<Rigidbody2D>();
        lastNode = go;

        Nodes.Add(lastNode);

        vertexCount++;
    }
}
