using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKitchenObjectParent
{
    public Transform GetKitchenObjectFollowTransform();

    public void SetKitchenObject(KitchenObect kitchenObect);

    public KitchenObect SetKitchenObject();

    public void ClearKitchenObject();

    public bool HasKitchenObject();
}
