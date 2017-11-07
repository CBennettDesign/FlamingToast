using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCanisterSnapper : MonoBehaviour {


    public FluxType[] compatibleTypes;

    public virtual bool IsCompatibleCanister(Canister a_canister )
    { 
        foreach(FluxType t in compatibleTypes)
        {
            if (a_canister.Type == t)
                return true;
        }

        return false;
    }

    public virtual bool giveCanister(GameObject a_canister)
    {
        return false;
    }
}
