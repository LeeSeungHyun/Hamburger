using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburger : MonoBehaviour
{
    // public Transform rootSlot;
    public Items store;
    private int i = 0;

    public GameObject Apple;
    public GameObject Bacon;
    public GameObject Chicken;
    public GameObject Fish;
    public GameObject Egg;

    // private List<Slot> slots;
    // Start is called before the first frame update
    void Start()
    {
        // slots = new List<Slot>();
        // int slotCnt = rootSlot.childCount;

        // for(int i = 0; i < slotCnt; i++) {
        //     var slot = rootSlot.GetChild(i).GetComponent<Slot>();

        //     slots.Add(slot);
        // }
        if(store != null) {
            store.onItemClick += GetItem;
        }
    }

    void GetItem (ItemProperty item) 
    {
        // var emptySlot = slots.Find(t=>
        // {   
        //     return t.item == null || t.item.name == string.Empty;
        // });

        // if(emptySlot != null) {
        //     emptySlot.setItem(item);
        // }
        GameObject temp = null;

        i++;
        switch(item.name) {
            case "item1":
                temp = Apple;
                break;
            case "item2":
                temp = Bacon;
                break;
            case "item3":
                temp = Chicken;
                break;
            case "item4":
                temp = Fish;
                break;
            case "item5":
                temp = Egg;
                break;
            default:
              break;
        }

        Instantiate(temp, new Vector3(transform.position.x , (transform.position.y - 120) + 2f * i * 20, 0), transform.rotation, transform);
        
        Debug.Log(item.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
