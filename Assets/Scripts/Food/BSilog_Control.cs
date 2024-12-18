using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSilog_Control : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.destroyBurgerSilog == "y") 
        {
            GameFlow.destroyBurgerSilog = "n";
            Destroy(gameObject);
            GameFlow.burgersilogOnHand = "n";
            
            GameFlow.sisigsilogOnHand = "n";

            GameFlow.placeEggPan = "n";
            GameFlow.placeSisigPan = "n";
            GameFlow.placeBurgerPan = "n";

            GameFlow.placeEggPlate = "n";
            GameFlow.placeBurgerPlate = "n";
            GameFlow.placeSisigPlate = "n";
            GameFlow.placeRicePlate = "n";
            GameFlow.placePlate = "n";

            GameFlow.destroySteam = "n";
        }
    }
}
