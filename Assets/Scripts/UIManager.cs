using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // A variable used to keep track of the score
    private int score;

    // A variable used to get the scoreOutput GameObject
    public TextMeshProUGUI scoreOutput;

    // Start is called before the first frame update
    private void Start()
    {
        // The score gets set to 0 when the game starts
        score = 0;
    }
    
    // Used by the two value increase / decrease buttons, with a parameter for how much the value gets lowered
    public void ScoreUpdate(int value)
    {
        // The value of whatever button you press gets added / subtracted onto the score
        score += value;

        // the scoreOutput gets set to whatever the score is at the time
        scoreOutput.text = score.ToString();
    }

    // Used by the reset value button to reset the score
    public void ResetScore()
    {
        // The score gets reset to 0 by the reset value button
        score = 0;

        // the scoreOutput gets set to whatever the score is at the time
        scoreOutput.text = score.ToString();
    }
}
