using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2_zbiór : MonoBehaviour
{


    public List<GameObject> zbior = new List<GameObject>();
    public Gradient gr;
    public List<SpriteRenderer> lista_spritów = new List<SpriteRenderer>();
    public List<GameObject> lista_spin = new List<GameObject>();

    public void Debug3d(Transform obiekt3d)
    {
        Debug.Log("Obiekt " + obiekt3d.name + " jest 3D");
    }

    //Funkcja Debug2d która printuje, ¿e obiekt jest 2d
    public void Debug2d(SpriteRenderer obiekt2d)
    {
        Debug.Log("Obiekt " + obiekt2d.name + " jest 2D");
    }

    public void Cube(Transform transformCube)
    {
        transformCube.rotation = Quaternion.Euler(transformCube.position.x * 36, 0, 0);
    }

    void SpriteColorChange(SpriteRenderer sprite)
    {
        sprite.color = gr.Evaluate(sprite.gameObject.transform.position.y / 100);
    }


    void SortObj()
    {
        foreach (GameObject go in zbior)

        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                Debug2d(go.GetComponent<SpriteRenderer>());
            }
            else if (go.GetComponent<MeshRenderer>() != null)
            {
                Debug3d(go.GetComponent<Transform>());
            }
        }

    }





    // Start is called before the first frame update
    void Start()
    {

        SortObj();



    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject GO in lista_spin)
        {
            Cube(GO.transform);
        }


    }






}
