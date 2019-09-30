using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text score;
    public Text round;
    int total = 0;
    int mouseCounter = 0;
    int roundnum = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mouseCounter++;

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if(hit.collider != null)
            {
                roundnum++;
                if(hit.collider.gameObject.tag == "ball")
                {
                    total += 2;
                }
                else if(hit.collider.gameObject.tag == "dice")
                {
                    total++;
                }
                score.text = total.ToString();
                finalTotalController.totalScore = total;
                //Destroy(hit.collider.gameObject);

            }
            else if ( mouseCounter% 5 == 0)
            {
                roundnum++;
                round.text = roundnum.ToString();
            }
            if (roundnum == 4)
            {
                SceneManager.LoadScene("FinalScene");
            }

        }
        

    }
}
