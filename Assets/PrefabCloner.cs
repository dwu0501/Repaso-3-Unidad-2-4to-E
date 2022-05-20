using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{
    public GameObject prefab;
    public Text InputCloneAmount;
    public Text displayClonesLeft;
    public int counter;
    public InputField IField;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonePrefab()
    {
        if (InputCloneAmount.text != "")
        {
            int CloneAmount = int.Parse(InputCloneAmount.text);
            IField.readOnly = true;
            if (counter< CloneAmount)
            {
                Instantiate(prefab);
                counter++;
                displayClonesLeft.text = (CloneAmount - counter).ToString();
            }
            else
            {
                displayClonesLeft.text = ("No hay más");
            }
        }
        else
        {
            displayClonesLeft.text = ( "ERROR, Ingrese un valor" );
        }
    }
}
