using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCs_Control : MonoBehaviour
{
    public static int score = 0;
    string order = "sisig";
    public Transform sisigOrderObj;
    public Transform burgerOrderObj;
    public Transform checkObj;
    public Transform xObj;
    
    void Update()
    {
        if (order == "burger" && GameFlow.checkSign == "n" && GameFlow.xSign == "n" && GameFlow.burgerSign == "n" && GameFlow.sisigSign == "n"
        && GameFlow.atCounter == "y" && GameFlow.moveAway == "n")
        {
            GameFlow.burgerSign = "y";
            Instantiate(burgerOrderObj, new Vector3(1.91f,2.62f,-3.32f), burgerOrderObj.rotation);
        }

        if (order == "sisig" && GameFlow.checkSign == "n" && GameFlow.xSign == "n" && GameFlow.burgerSign == "n" && GameFlow.sisigSign == "n"
        && GameFlow.atCounter == "y" && GameFlow.moveAway == "n")
        {
            GameFlow.sisigSign = "y";
            Instantiate(sisigOrderObj, new Vector3(1.90f,2.63f,-3.45f), sisigOrderObj.rotation);
        }
    }
    void OnMouseDown()
    {
        if (order == "sisig")
        {
            if (GameFlow.sisigsilogOnHand == "y")
            {
                GameFlow.destroySisigSilog = "y";
                
                GameFlow.destroySisigSign = "y";

                GameFlow.moveAway = "y";
                //GameFlow.checkSign = "y";
                score++;
                order = "burger";
            } 

            else if (GameFlow.burgersilogOnHand == "y")
            {
                GameFlow.destroyBurgerSilog = "y";

                //GameFlow.xSign = "y";
                score--;
            }
        }

        if (order == "burger")
        {
            if (GameFlow.sisigsilogOnHand == "y")
            {
                GameFlow.destroySisigSilog = "y";

                //GameFlow.xSign = "y";
                score--;
            } 

            else if (GameFlow.burgersilogOnHand == "y")
            {
                GameFlow.destroyBurgerSilog = "y";

                GameFlow.destroyBurgerSign = "y";   
                GameFlow.moveAway = "y";
                //GameFlow.checkSign = "y";
                score++;
                order = "sisig";
            }
        }

        Debug.Log(order);
        Debug.Log(score);
        
    }
}
