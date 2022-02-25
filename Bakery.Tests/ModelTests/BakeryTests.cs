using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateBreadObject_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AddNumberOfLoaves_NumberOfLoaves()
    {
      int numberOfLoaves = 1;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.NumberOfLoaves;
      Assert.AreEqual(numberOfLoaves, result);
    }

    [TestMethod]
    public void BreadPrice_GetPriceOfLoaves_Price()
    {
      int numberOfLoaves = 1;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.BreadPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void BreadPrice_GetPriceOfTwoLoaves_Price()
    {
      int numberOfLoaves = 2;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.BreadPrice();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void BreadPrice_GetPriceOfThreeLoaves_Price()
    {
      int numberOfLoaves = 3;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.BreadPrice();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void BreadPrice_GetPriceOfMoreThanThreeLoaves_Price()
    {
      int numberOfLoaves = 4;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.BreadPrice();
      Assert.AreEqual(15, result);
    }
  }
}