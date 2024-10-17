using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void ThirtyDays()
    {
        var items = new List<Item> {
            new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
            new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
            new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 },
            new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
        };
        var app = new GildedRose(items);
        app.UpdateQuality();

        // +5 Dexterity Vest
        Assert.That(items[0].SellIn, Is.EqualTo(9));
        Assert.That(items[0].Quality, Is.EqualTo(19));

        // Aged Brie
        Assert.That(items[1].SellIn, Is.EqualTo(1));
        Assert.That(items[1].Quality, Is.EqualTo(1));

        // Elixir of the Mongoose
        Assert.That(items[2].SellIn, Is.EqualTo(4));
        Assert.That(items[2].Quality, Is.EqualTo(6));

        // Sulfuras, Hand of Ragnaros
        Assert.That(items[3].SellIn, Is.EqualTo(0));
        Assert.That(items[3].Quality, Is.EqualTo(80));

        // Sulfuras, Hand of Ragnaros
        Assert.That(items[4].SellIn, Is.EqualTo(-1));
        Assert.That(items[4].Quality, Is.EqualTo(80));

        // Backstage passes to a TAFKAL80ETC concert
        Assert.That(items[5].SellIn, Is.EqualTo(14));
        Assert.That(items[5].Quality, Is.EqualTo(21));

        // Backstage passes to a TAFKAL80ETC concert
        Assert.That(items[6].SellIn, Is.EqualTo(9));
        Assert.That(items[6].Quality, Is.EqualTo(50));

        // Backstage passes to a TAFKAL80ETC concert
        Assert.That(items[7].SellIn, Is.EqualTo(4));
        Assert.That(items[7].Quality, Is.EqualTo(50));

        // Conjured Mana Cake
        Assert.That(items[8].SellIn, Is.EqualTo(2));
        Assert.That(items[8].Quality, Is.EqualTo(4));
    }
}