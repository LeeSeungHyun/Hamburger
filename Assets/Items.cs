using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public ItemBuffer itemBuffer;
    public Transform slotRoot;
    public List<Slot> slots;
    public System.Action<ItemProperty> onSlotClick;

    public System.Action<ItemProperty> onItemClick;
    // Start is called before the first frame update
    void Start()
    {
        int slotCnt = slotRoot.childCount;

        for(int i = 0; i < slotCnt; i++) {
            var slot = slotRoot.GetChild(i).GetComponent<Slot>();

            if(i < itemBuffer.items.Count) {
                slot.setItem(itemBuffer.items[i]);
            } else {
                slot.GetComponent<Button>().interactable = false;
            }

            slots.Add(slot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSlot(Slot slot) {
        // if(onSlotClick != null) {
        //     onSlotClick(slot.item);
        // }
        if(onItemClick != null) {
            onItemClick(slot.item);
        }
    }
}
