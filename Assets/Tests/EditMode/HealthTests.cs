using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthTests
{
    [Test]
    public void Damage_ClampsAtZero()
    {
        var hp = new Health(100);
        hp.Apply(150);
        Assert.AreEqual(999, hp.Current);
    }
}
