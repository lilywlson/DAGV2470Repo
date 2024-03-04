using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    public void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
