using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ZipLineInteractable : XRBaseInteractable
{
    protected override void OnSelectEntering(XRBaseInteractor interactor)
    {
        base.OnSelectEntering(interactor);

        if (interactor is XRDirectInteractor)
            ZipLiner.hand = interactor.GetComponent<XRController>();
    }

    protected override void OnSelectExiting(XRBaseInteractor interactor)
    {
        base.OnSelectExiting(interactor);

        if (interactor is XRDirectInteractor)
        {
            if (ZipLiner.hand && ZipLiner.hand.name == interactor.name)
            {
                ZipLiner.hand = null;
            }
        }
    }
}
