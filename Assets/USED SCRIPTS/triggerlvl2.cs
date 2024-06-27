using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerlvl2 : MonoBehaviour
{
    public List<GameObject> objectsBeforeActivation;

    // Lista obiektów widocznych po pierwszym strzale w dŸwigniê
    public List<GameObject> objectsAfterFirstActivation;

    // Lista obiektów widocznych po drugim strzale w dŸwigniê
    public List<GameObject> objectsAfterSecondActivation;

    // Licznik strza³ów
    private int shotCount = 0;

    // Start jest wywo³ywany przed pierwsz¹ klatk¹
    void Start()
    {
        // Ustaw obiekty po pierwszym strzale jako niewidoczne na pocz¹tku
        foreach (GameObject obj in objectsAfterFirstActivation)
        {
            obj.SetActive(false);
        }

        // Ustaw obiekty po drugim strzale jako niewidoczne na pocz¹tku
        foreach (GameObject obj in objectsAfterSecondActivation)
        {
            obj.SetActive(false);
        }
    }

    // Metoda wywo³ywana, gdy inny obiekt wejdzie w kolizjê z dŸwigni¹
    private void OnTriggerEnter2D(Collider2D other)
    {
        // SprawdŸ, czy obiekt, który wywo³a³ kolizjê, jest pociskiem
        if (other.CompareTag("throwWeb"))
        {
            shotCount++;

            if (shotCount == 1)
            {
                // Pierwszy strza³: ukryj obiekty przed aktywacj¹ i poka¿ obiekty po pierwszym strzale
                foreach (GameObject obj in objectsBeforeActivation)
                {
                    obj.SetActive(false);
                }

                foreach (GameObject obj in objectsAfterFirstActivation)
                {
                    obj.SetActive(true);
                }
            }
            else if (shotCount == 2)
            {
                // Drugi strza³: ukryj obiekty po pierwszym strzale i poka¿ obiekty po drugim strzale
                foreach (GameObject obj in objectsAfterFirstActivation)
                {
                    obj.SetActive(false);
                }

                foreach (GameObject obj in objectsAfterSecondActivation)
                {
                    obj.SetActive(true);
                }
            }

            // Zniszcz pocisk po kolizji, jeœli to potrzebne
            Destroy(other.gameObject);
        }
    }
}
