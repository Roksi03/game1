using UnityEngine;

public class walkingScript : MonoBehaviour
{
    public GameObject footsteps;

    // Start is called before the first frame update
    void Start()
    {
        footsteps.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            walking();
        }

        if (Input.GetKeyDown("a"))
        {
            walking();
        }

        if (Input.GetKeyDown("s"))
        {
            walking();
        }
        
        if(Input.GetKeyDown("d"))
            {
                walking();
            }

        if(Input.GetKeyUp("w"))
        {
            StopWalking();
        }

        if (Input.GetKeyUp("a"))
        {
            StopWalking();
        }

        if (Input.GetKeyUp("s"))
        {
            StopWalking();
        }

        if (Input.GetKeyUp("d"))
        {
            StopWalking();
        }

        void walking()
        {
            footsteps.SetActive(true);
        }

        void StopWalking()
        {
            footsteps.SetActive(false);
        }
    }
}
