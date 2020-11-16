using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries dwf1 = new DragonbornWaffleFries();
            sides.Add(dwf1);
            DragonbornWaffleFries dwf2 = new DragonbornWaffleFries();
            dwf2.Size = Size.Medium;
            sides.Add(dwf2);
            DragonbornWaffleFries dwf3 = new DragonbornWaffleFries();
            dwf3.Size = Size.Large;
            sides.Add(dwf3);
            FriedMiraak fm1 = new FriedMiraak();
            sides.Add(fm1);
            FriedMiraak fm2 = new FriedMiraak();
            fm2.Size = Size.Medium;
            sides.Add(fm2);
            FriedMiraak fm3 = new FriedMiraak();
            fm3.Size = Size.Large;
            sides.Add(fm3);
            MadOtarGrits mog1 = new MadOtarGrits();
            sides.Add(mog1);
            MadOtarGrits mog2 = new MadOtarGrits();
            mog2.Size = Size.Medium;
            sides.Add(mog2);
            MadOtarGrits mog3 = new MadOtarGrits();
            mog3.Size = Size.Large;
            sides.Add(mog3);
            VokunSalad vs1 = new VokunSalad();
            sides.Add(vs1);
            VokunSalad vs2 = new VokunSalad();
            vs2.Size = Size.Medium;
            sides.Add(vs2);
            VokunSalad vs3 = new VokunSalad();
            vs3.Size = Size.Large;
            sides.Add(vs3);
            return sides;
        }
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice aj1 = new AretinoAppleJuice();
            drinks.Add(aj1);
            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            aj2.Size = Size.Medium;
            drinks.Add(aj2);
            AretinoAppleJuice aj3 = new AretinoAppleJuice();
            aj3.Size = Size.Large;
            drinks.Add(aj3);
            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            drinks.Add(cc1);
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            cc2.Size = Size.Medium;
            drinks.Add(cc2);
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc3.Size = Size.Large;
            drinks.Add(cc3);
            CandlehearthCoffee cc4 = new CandlehearthCoffee();
            cc4.Decaf = true;
            cc4.Size = Size.Small;
            drinks.Add(cc4);
            CandlehearthCoffee cc5 = new CandlehearthCoffee();
            cc5.Decaf = true;
            cc5.Size = Size.Medium;
            drinks.Add(cc5);
            CandlehearthCoffee cc6 = new CandlehearthCoffee();
            cc6.Decaf = true;
            cc6.Size = Size.Large;
            drinks.Add(cc6);
            MarkarthMilk mm1 = new MarkarthMilk();
            drinks.Add(mm1);
            MarkarthMilk mm2 = new MarkarthMilk();
            mm2.Size = Size.Medium;
            drinks.Add(mm2);
            MarkarthMilk mm3 = new MarkarthMilk();
            mm3.Size = Size.Large;
            drinks.Add(mm3);

            SailorSoda ss = new SailorSoda();
            drinks.Add(ss);
            SailorSoda ss2 = new SailorSoda();
            ss2.Size = Size.Medium;
            drinks.Add(ss2);
            SailorSoda ss3 = new SailorSoda();
            ss3.Size = Size.Large;
            drinks.Add(ss3);
            SailorSoda ss4 = new SailorSoda();
            ss4.Flavor = SodaFlavor.Blackberry;
            ss4.Size = Size.Small;
            drinks.Add(ss4);
            SailorSoda ss5 = new SailorSoda();
            ss5.Flavor = SodaFlavor.Blackberry;
            ss5.Size = Size.Medium;
            drinks.Add(ss5);
            SailorSoda ss6 = new SailorSoda();
            ss6.Flavor = SodaFlavor.Blackberry;
            ss6.Size = Size.Large;
            drinks.Add(ss6);
            SailorSoda ss7 = new SailorSoda();
            ss7.Flavor = SodaFlavor.Grapefruit;
            ss7.Size = Size.Small;
            drinks.Add(ss7);
            SailorSoda ss8 = new SailorSoda();
            ss8.Flavor = SodaFlavor.Grapefruit;
            ss8.Size = Size.Medium;
            drinks.Add(ss8);
            SailorSoda ss9 = new SailorSoda();
            ss9.Flavor = SodaFlavor.Grapefruit;
            ss9.Size = Size.Large;
            drinks.Add(ss9);
            SailorSoda ss10 = new SailorSoda();
            ss10.Flavor = SodaFlavor.Lemon;
            ss10.Size = Size.Small;
            drinks.Add(ss10);
            SailorSoda ss11 = new SailorSoda();
            ss11.Flavor = SodaFlavor.Lemon;
            ss11.Size = Size.Medium;
            drinks.Add(ss11);
            SailorSoda ss12 = new SailorSoda();
            ss12.Flavor = SodaFlavor.Lemon;
            ss12.Size = Size.Large;
            drinks.Add(ss12);
            SailorSoda ss13 = new SailorSoda();
            ss13.Flavor = SodaFlavor.Peach;
            ss13.Size = Size.Small;
            drinks.Add(ss13);
            SailorSoda ss14 = new SailorSoda();
            ss14.Flavor = SodaFlavor.Peach;
            ss14.Size = Size.Medium;
            drinks.Add(ss14);
            SailorSoda ss15 = new SailorSoda();
            ss15.Flavor = SodaFlavor.Peach;
            ss15.Size = Size.Large;
            drinks.Add(ss15);
            SailorSoda ss16 = new SailorSoda();
            ss16.Flavor = SodaFlavor.Watermelon;
            ss16.Size = Size.Small;
            drinks.Add(ss16);
            SailorSoda ss17 = new SailorSoda();
            ss17.Flavor = SodaFlavor.Watermelon;
            ss17.Size = Size.Medium;
            drinks.Add(ss17);
            SailorSoda ss18 = new SailorSoda();
            ss18.Flavor = SodaFlavor.Watermelon;
            ss18.Size = Size.Large;
            drinks.Add(ss18);

            WarriorWater ww1 = new WarriorWater();
            drinks.Add(ww1);
            WarriorWater ww2 = new WarriorWater();
            ww2.Size = Size.Medium;
            drinks.Add(ww2);
            WarriorWater ww3 = new WarriorWater();
            ww3.Size = Size.Large;
            drinks.Add(ww3);
            return drinks;
        }
        public static IEnumerable<IOrderItem> FullMenu()
        {
            IEnumerable<IOrderItem> e = Entrees();
            IEnumerable<IOrderItem> es = e.Concat(Sides());
            IEnumerable<IOrderItem> allItems = es.Concat(Drinks());
            return allItems;
        }

        private static IEnumerable<IOrderItem> allItems = FullMenu();
        /*public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return allItems;
            else
            {
                foreach(IOrderItem item in allItems)
                {
                    if (item.ToString().Contains(terms))
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }*/
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /*public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return items;
            // Filter the supplied collection of items
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if (categories.Contains("drinks") && Drinks().Contains(item))
                {
                    results.Add(item);
                }
                else if (categories.Contains("entrees") && Entrees().Contains(item))
                {
                    results.Add(item);
                }
                else if (categories.Contains("sides") && Sides().Contains(item))
                {
                    results.Add(item);
                }
            }
            return results;
        }*/
    }
}
