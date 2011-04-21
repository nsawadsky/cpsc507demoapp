// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using CPSC507DemoAppTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace CPSC507DemoApp
{
    public partial class OrderTest
    {
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost734()
{
    Order order;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    Promotion[] promotions = new Promotion[0];
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void testCalculateCostThrowsArgumentOutOfRangeException809()
{
    Order order;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    Promotion[] promotions = new Promotion[0];
    this.testCalculateCost(order, promotions, int.MinValue);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void testCalculateCostThrowsArgumentNullException27()
{
    Order order;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    Promotion[] promotions = new Promotion[1];
    this.testCalculateCost(order, promotions, 0);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost264()
{
    Order order;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    Promotion[] promotions = new Promotion[0];
    this.testCalculateCost(order, promotions, 1);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost73401()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder(default(DateTime), orderItemAndQuantitys);
    Promotion[] promotions = new Promotion[0];
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void testCalculateCostThrowsArgumentNullException705()
{
    Order order;
    Promotion promotion;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 0);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost164()
{
    Order order;
    Promotion promotion;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void testCalculateCostThrowsArgumentOutOfRangeException393()
{
    Order order;
    Promotion promotion;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, int.MinValue);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost498()
{
    Order order;
    Promotion promotion;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
                 (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 2305843009213693952L, 
                                                               (DateTimeKind)(2305843009213693952uL >> 62)), default(DateTime), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 1);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost73402()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[2];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    orderItemAndQuantitys[1] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder(default(DateTime), orderItemAndQuantitys);
    Promotion[] promotions = new Promotion[0];
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost379()
{
    Order order;
    Promotion promotion;
    order =
      PexFactoryMethods.createOrder(default(DateTime), (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost49801()
{
    Order order;
    Promotion promotion;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
                 (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 1);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost49802()
{
    Order order;
    Promotion promotion;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
                 (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), 
                                                new DateTime(4611686018427387903L & 2305843009213693952L, 
                                                             (DateTimeKind)(2305843009213693952uL >> 62)), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 1);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost16401()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem =
      PexFactoryMethods.createOrderItem("", ItemCategory.Electronics, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder(default(DateTime), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost787()
{
    Order order;
    Promotion promotion;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)), 
                 (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 1);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost78701()
{
    Order order;
    Promotion promotion;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
                 (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 2305843009213693952L, 
                                                               (DateTimeKind)(2305843009213693952uL >> 62)), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 1);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost78702()
{
    Order order;
    Promotion promotion;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 3079102049506410804L, 
                              (DateTimeKind)(3079102049506410804uL >> 62)), 
                 (OrderItemAndQuantity[])null);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 3079102049506410804L, 
                                                               (DateTimeKind)(3079102049506410804uL >> 62)), 
                                                  new DateTime(4611686018427387903L & 7690788067933798708L, 
                                                               (DateTimeKind)(7690788067933798708uL >> 62)), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 1);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost16402()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 3155378975999983624L, 
                              (DateTimeKind)(3155378975999983624uL >> 62)), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 3155378975999983624L, 
                                                               (DateTimeKind)(3155378975999983624uL >> 62)), 
                                                  new DateTime(4611686018427387903L & 256L, (DateTimeKind)(256uL >> 62)), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost16403()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 3155378975999983616L, 
                              (DateTimeKind)(3155378975999983616uL >> 62)), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 3155378975999983616L, 
                                                               (DateTimeKind)(3155378975999983616uL >> 62)), 
                                                  new DateTime(4611686018427387903L & 3155378975999983616L, 
                                                               (DateTimeKind)(3155378975999983616uL >> 62)), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost16404()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 36117053228206725L, 
                              (DateTimeKind)(36117053228206725uL >> 62)), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 146411054255311628L, 
                                                               (DateTimeKind)(146411054255311628uL >> 62)), default(DateTime), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost255()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 3155378975463112736L, 
                              (DateTimeKind)(3155378975463112736uL >> 62)), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 3155378975463112736L, 
                                                               (DateTimeKind)(3155378975463112736uL >> 62)), 
                                                  new DateTime(4611686018427387903L & 3155378975463112736L, 
                                                               (DateTimeKind)(3155378975463112736uL >> 62)), 0);
    Promotion[] promotions = new Promotion[1];
    promotions[0] = promotion;
    this.testCalculateCost(order, promotions, 2);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost37901()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
                 orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost37902()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 36117053228206725L, 
                              (DateTimeKind)(36117053228206725uL >> 62)), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 146411054255311628L, 
                                                               (DateTimeKind)(146411054255311628uL >> 62)), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost37903()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", ItemCategory.Book, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 256);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder
                (new DateTime(4611686018427387903L & 1876942095834512036L, 
                              (DateTimeKind)(1876942095834512036uL >> 62)), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion("", ItemCategory.Book, ss, 
                                                  new DateTime(4611686018427387903L & 1876942095834512036L, 
                                                               (DateTimeKind)(1876942095834512036uL >> 62)), 
                                                  new DateTime(4611686018427387903L & 1876942095834512036L, 
                                                               (DateTimeKind)(1876942095834512036uL >> 62)), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
[TestMethod]
[PexGeneratedBy(typeof(OrderTest))]
public void testCalculateCost37904()
{
    OrderItem orderItem;
    OrderItemAndQuantity orderItemAndQuantity;
    Order order;
    Promotion promotion;
    orderItem = PexFactoryMethods.createOrderItem("", (ItemCategory)16, "", 0);
    orderItemAndQuantity =
      PexFactoryMethods.createOrderItemAndQuantity(orderItem, 0);
    OrderItemAndQuantity[] orderItemAndQuantitys = new OrderItemAndQuantity[1];
    orderItemAndQuantitys[0] = orderItemAndQuantity;
    order = PexFactoryMethods.createOrder(default(DateTime), orderItemAndQuantitys);
    string[] ss = new string[0];
    promotion = PexFactoryMethods.createPromotion
                    ("", ItemCategory.Book, ss, default(DateTime), default(DateTime), 0);
    Promotion[] promotions = new Promotion[2];
    promotions[0] = promotion;
    promotions[1] = promotion;
    this.testCalculateCost(order, promotions, 0);
    Assert.IsNotNull((object)order);
}
    }
}
