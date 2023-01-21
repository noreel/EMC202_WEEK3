using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu]
    public class EquipmentItemSO : ItemSO, IDestroyableItem, IItemAction
    {
        public string ActionName => "Drop";

        public bool PerformAction(GameObject character)
        {
            throw new NotImplementedException();
        }
    }

   
   
    
}    