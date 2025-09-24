using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;

public class HUDTests
{
    [UnityTest]
    public IEnumerator HUD_Shows_New_HP()
    {
        var hud = Object.Instantiate(Resources.Load<HUD>("HUDDemo"));
        hud.SetHP(75);
        yield return null;
        Assert.AreEqual(75, hud.CurrentHPShown);
    }
}
