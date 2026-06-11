using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MyTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void MyTestSimplePasses()
    {
        // Arrange (준비)
        int a = 10;
        int b = 20;

        // Act (실행)
        int result = a + b;

        // Assert (검증: 10 + 20은 무조건 30이어야 성공!)
        Assert.AreEqual(30, result);
    }

    // // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // // `yield return null;` to skip a frame.
    // [UnityTest]
    // public IEnumerator MyTestWithEnumeratorPasses()
    // {
    //     int initialFrame = Time.frameCount;

    //     // 1프레임 대기
    //     yield return null;

    //     // 현재 프레임이 아까보다 증가했는지 검증
    //     Assert.IsTrue(Time.frameCount > initialFrame);
    // }
}
