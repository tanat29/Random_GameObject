using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_gameobject : MonoBehaviour
{
    public GameObject gameobject1,gameobject2,gameobject3,gameobject4,gameobject5;

    public void Random1234() {
        GameObject[] gb = {gameobject1,gameobject2,gameobject3,gameobject4,gameobject5};

        for(int i=0;i<gb.Length;i++) {
            if(gb[i].activeSelf == true) {
                gb[i].SetActive(false);
            }
        }

        int newIndex = Random.RandomRange(0,gb.Length);
        gb[newIndex].SetActive(true);
    }
}