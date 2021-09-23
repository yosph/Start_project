using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneOnClick : MonoBehaviour
{
    public int numberOfClones = 10; 

    private void OnMouseDown() {
        // la mort
        // Destroy(gameObject);

        // La vie 
        //Instantiate(gameObject);
        for(int i = 0; i<numberOfClones; i++){
            GameObject toto = Instantiate (gameObject);
            Destroy(toto, 5f);
        }
    }
 }
