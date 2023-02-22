using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{    
    [SerializeField] private Transform counterTopPoint;

    private KitchenObect kitchenObject;

    public virtual void Interact(Player player)
    {
        Debug.LogError("Basecounter.Interact();");
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObect kitchenObect)
    {
        this.kitchenObject = kitchenObect;
    }

    public KitchenObect SetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
