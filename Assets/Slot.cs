﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [HideInInspector]
    public ItemProperty item;
    public Image image;
    public Button sellBtn;
    // Start is called before the first frame update

    private void Awake() {
        SetSellBtnInteractable(false);
    }

    void SetSellBtnInteractable(bool b) {
        if(sellBtn != null) {
            sellBtn.interactable = b;
        }
    }
    public void setItem(ItemProperty item)
    {
        this.item = item;
        if(item == null) {
            image.enabled = false;
            gameObject.name = "Empty";
        } else {
            // image.enabled = true;
            image.enabled = true;
            gameObject.name = item.name;
            image.sprite = item.sprite;
            SetSellBtnInteractable(true);
        }
    }

    public void onClickSellBtn() {
        setItem(null);
    }
}
