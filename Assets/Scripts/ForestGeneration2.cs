using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestGeneration2 : MonoBehaviour
{
    public GameObject ground1;
    public float position1 = 500;
    public int forestSize1 = 25;
    public int elementSpacing1 = 3;
    public Element[] elements1;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 500; x += elementSpacing1)
        {
            for (int z = 0; z < forestSize1; z += elementSpacing1)
            {
                for (int i = 0; i < elements1.Length; i++)
                {
                    Element element = elements1[i];

                    if (element.CanPlace())
                    {

                        Vector3 position = new Vector3(x - 501.8f , 0f, z - 2000);
                        Vector3 offset = new Vector3(Random.Range(-0.75f, 0.75f), 0f, Random.Range(-0.75f, 0.75f));
                        Vector3 rotation = new Vector3(Random.Range(0, 5f), Random.Range(0, 360f), Random.Range(0, 5f));
                        Vector3 scale = Vector3.one * Random.Range(0.75f, 1.75f);

                        GameObject newElement = Instantiate(element.GetRandom());
                        newElement.transform.SetParent(transform);
                        newElement.transform.position = position + offset;
                        newElement.transform.eulerAngles = rotation;
                        newElement.transform.localScale = scale;
                        break;
                    }
                }
            }
        }
    }
    [System.Serializable]
    public class Element
    {
        public string name1;
        [Range(1, 10)]

        public int density1;
        public GameObject[] prefabs;
        public bool CanPlace()
        {
            if (Random.Range(0, 10) < density1)
                return true;
            else
                return false;
        }
        public GameObject GetRandom()
        {
            return prefabs[Random.Range(0, prefabs.Length)];

        }
    }
}
    
