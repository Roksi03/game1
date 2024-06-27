using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerlvl2 : MonoBehaviour
{
    public List<GameObject> objectsBeforeActivation;

    // Lista obiekt�w widocznych po pierwszym strzale w d�wigni�
    public List<GameObject> objectsAfterFirstActivation;

    // Lista obiekt�w widocznych po drugim strzale w d�wigni�
    public List<GameObject> objectsAfterSecondActivation;

    // Licznik strza��w
    private int shotCount = 0;

    // Start jest wywo�ywany przed pierwsz� klatk�
    void Start()
    {
        // Ustaw obiekty po pierwszym strzale jako niewidoczne na pocz�tku
        foreach (GameObject obj in objectsAfterFirstActivation)
        {
            obj.SetActive(false);
        }

        // Ustaw obiekty po drugim strzale jako niewidoczne na pocz�tku
        foreach (GameObject obj in objectsAfterSecondActivation)
        {
            obj.SetActive(false);
        }
    }

    // Metoda wywo�ywana, gdy inny obiekt wejdzie w kolizj� z d�wigni�
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Sprawd�, czy obiekt, kt�ry wywo�a� kolizj�, jest pociskiem
        if (other.CompareTag("throwWeb"))
        {
            shotCount++;

            if (shotCount == 1)
            {
                // Pierwszy strza�: ukryj obiekty przed aktywacj� i poka� obiekty po pierwszym strzale
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
                // Drugi strza�: ukryj obiekty po pierwszym strzale i poka� obiekty po drugim strzale
                foreach (GameObject obj in objectsAfterFirstActivation)
                {
                    obj.SetActive(false);
                }

                foreach (GameObject obj in objectsAfterSecondActivation)
                {
                    obj.SetActive(true);
                }
            }

            // Zniszcz pocisk po kolizji, je�li to potrzebne
            Destroy(other.gameObject);
        }
    }
}
