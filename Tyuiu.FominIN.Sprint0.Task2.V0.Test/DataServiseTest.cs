using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.FominIN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Ваня";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод ArtEqual
            Assert.AreEqual("Привет..., Ваня", res);
        }
    }
}
