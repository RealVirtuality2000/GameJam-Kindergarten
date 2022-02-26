using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick2 : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image img;
    [SerializeField] private Sprite speed_inc, loot, inc_range;
    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    private int skill;

    public void was_clicked()
    {
        Debug.Log(gameObject.name + " clicked!");

        switch (skill)
        {
            case 4:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_speed ();
                Debug.Log("inc speed");
                break;
            case 5:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().loot();
                Debug.Log("loot");
                break;
            case 6:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_range();
                Debug.Log("range");
                break;
        }

        gameObject.transform.parent.gameObject.SetActive(false);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }

}
