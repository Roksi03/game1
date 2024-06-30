using UnityEngine;

public class webSound : MonoBehaviour
{
    public GameObject SoundWeb;

    // Start is called before the first frame update
    void Start()
    {
        SoundWeb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            web();
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopWeb();
        }

        void web()
        {
            SoundWeb.SetActive(true);
        }

        void StopWeb()
        {
            SoundWeb.SetActive(false);
        }
    }
}
