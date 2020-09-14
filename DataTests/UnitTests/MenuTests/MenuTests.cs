using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void EntreeListCorrect()
        {
            var list = Menu.Entrees();
            BriarheartBurger e1 = new BriarheartBurger();
            DoubleDraugr e2 = new DoubleDraugr();
            GardenOrcOmelette e3 = new GardenOrcOmelette();
            PhillyPoacher e4 = new PhillyPoacher();
            SmokehouseSkeleton e5 = new SmokehouseSkeleton();
            ThalmorTriple e6 = new ThalmorTriple();
            ThugsTBone e7 = new ThugsTBone();
            Assert.Collection(list,
                item => Assert.Equal(e1.ToString(), item.ToString()),
                item => Assert.Equal(e2.ToString(), item.ToString()),
                item => Assert.Equal(e3.ToString(), item.ToString()),
                item => Assert.Equal(e4.ToString(), item.ToString()),
                item => Assert.Equal(e5.ToString(), item.ToString()),
                item => Assert.Equal(e6.ToString(), item.ToString()),
                item => Assert.Equal(e7.ToString(), item.ToString())
                );
        }
        [Fact]
        public void SideListCorrect()
        {
            var list = Menu.Sides();
            DragonbornWaffleFries a1 = new DragonbornWaffleFries();
            DragonbornWaffleFries a2 = new DragonbornWaffleFries();
            a2.Size = Size.Medium;
            DragonbornWaffleFries a3 = new DragonbornWaffleFries();
            a3.Size = Size.Large;
            FriedMiraak b1 = new FriedMiraak();
            FriedMiraak b2 = new FriedMiraak();
            b2.Size = Size.Medium;
            FriedMiraak b3 = new FriedMiraak();
            b3.Size = Size.Large;
            MadOtarGrits c1 = new MadOtarGrits();
            MadOtarGrits c2 = new MadOtarGrits();
            c2.Size = Size.Medium;
            MadOtarGrits c3 = new MadOtarGrits();
            c3.Size = Size.Large;
            VokunSalad d1 = new VokunSalad();
            VokunSalad d2 = new VokunSalad();
            d2.Size = Size.Medium;
            VokunSalad d3 = new VokunSalad();
            d3.Size = Size.Large;
            Assert.Collection(list,
                item => Assert.Equal(a1.ToString(), item.ToString()),
                item => Assert.Equal(a2.ToString(), item.ToString()),
                item => Assert.Equal(a3.ToString(), item.ToString()),
                item => Assert.Equal(b1.ToString(), item.ToString()),
                item => Assert.Equal(b2.ToString(), item.ToString()),
                item => Assert.Equal(b3.ToString(), item.ToString()),
                item => Assert.Equal(c1.ToString(), item.ToString()),
                item => Assert.Equal(c2.ToString(), item.ToString()),
                item => Assert.Equal(c3.ToString(), item.ToString()),
                item => Assert.Equal(d1.ToString(), item.ToString()),
                item => Assert.Equal(d2.ToString(), item.ToString()),
                item => Assert.Equal(d3.ToString(), item.ToString())
                );
        }
        [Fact]
        public void DrinkListCorrect()
        {
            var list = Menu.Drinks();
            AretinoAppleJuice aj1 = new AretinoAppleJuice();
            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            aj2.Size = Size.Medium;
            AretinoAppleJuice aj3 = new AretinoAppleJuice();
            aj3.Size = Size.Large;
            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            cc2.Size = Size.Medium;
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc3.Size = Size.Large;
            CandlehearthCoffee cc4 = new CandlehearthCoffee();
            cc4.Decaf = true;
            CandlehearthCoffee cc5 = new CandlehearthCoffee();
            cc5.Size = Size.Medium;
            cc5.Decaf = true;
            CandlehearthCoffee cc6 = new CandlehearthCoffee();
            cc6.Size = Size.Large;
            cc6.Decaf = true;
            MarkarthMilk mm1 = new MarkarthMilk();
            MarkarthMilk mm2 = new MarkarthMilk();
            mm2.Size = Size.Medium;
            MarkarthMilk mm3 = new MarkarthMilk();
            mm3.Size = Size.Large;
            SailorSoda ss1 = new SailorSoda();
            SailorSoda ss2 = new SailorSoda();
            ss2.Size = Size.Medium;
            SailorSoda ss3 = new SailorSoda();
            ss3.Size = Size.Large;
            SailorSoda ssb1 = new SailorSoda();
            ssb1.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssb2 = new SailorSoda();
            ssb2.Size = Size.Medium;
            ssb2.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssb3 = new SailorSoda();
            ssb3.Size = Size.Large;
            ssb3.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssg1 = new SailorSoda();
            ssg1.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssg2 = new SailorSoda();
            ssg2.Size = Size.Medium;
            ssg2.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssg3 = new SailorSoda();
            ssg3.Size = Size.Large;
            ssg3.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssl1 = new SailorSoda();
            ssl1.Flavor = SodaFlavor.Lemon;
            SailorSoda ssl2 = new SailorSoda();
            ssl2.Size = Size.Medium;
            ssl2.Flavor = SodaFlavor.Lemon;
            SailorSoda ssl3 = new SailorSoda();
            ssl3.Size = Size.Large;
            ssl3.Flavor = SodaFlavor.Lemon;
            SailorSoda ssp1 = new SailorSoda();
            ssp1.Flavor = SodaFlavor.Peach;
            SailorSoda ssp2 = new SailorSoda();
            ssp2.Size = Size.Medium;
            ssp2.Flavor = SodaFlavor.Peach;
            SailorSoda ssp3 = new SailorSoda();
            ssp3.Size = Size.Large;
            ssp3.Flavor = SodaFlavor.Peach;
            SailorSoda ssw1 = new SailorSoda();
            ssw1.Flavor = SodaFlavor.Watermelon;
            SailorSoda ssw2 = new SailorSoda();
            ssw2.Size = Size.Medium;
            ssw2.Flavor = SodaFlavor.Watermelon;
            SailorSoda ssw3 = new SailorSoda();
            ssw3.Size = Size.Large;
            ssw3.Flavor = SodaFlavor.Watermelon;
            WarriorWater ww1 = new WarriorWater();
            WarriorWater ww2 = new WarriorWater();
            ww2.Size = Size.Medium;
            WarriorWater ww3 = new WarriorWater();
            ww3.Size = Size.Large;
            Assert.Collection(list,
                item => Assert.Equal(aj1.ToString(), item.ToString()),
                item => Assert.Equal(aj2.ToString(), item.ToString()),
                item => Assert.Equal(aj3.ToString(), item.ToString()),
                item => Assert.Equal(cc1.ToString(), item.ToString()),
                item => Assert.Equal(cc2.ToString(), item.ToString()),
                item => Assert.Equal(cc3.ToString(), item.ToString()),
                item => Assert.Equal(cc4.ToString(), item.ToString()),
                item => Assert.Equal(cc5.ToString(), item.ToString()),
                item => Assert.Equal(cc6.ToString(), item.ToString()),
                item => Assert.Equal(mm1.ToString(), item.ToString()),
                item => Assert.Equal(mm2.ToString(), item.ToString()),
                item => Assert.Equal(mm3.ToString(), item.ToString()),
                item => Assert.Equal(ss1.ToString(), item.ToString()),
                item => Assert.Equal(ss2.ToString(), item.ToString()),
                item => Assert.Equal(ss3.ToString(), item.ToString()),
                item => Assert.Equal(ssb1.ToString(), item.ToString()),
                item => Assert.Equal(ssb2.ToString(), item.ToString()),
                item => Assert.Equal(ssb3.ToString(), item.ToString()),
                item => Assert.Equal(ssg1.ToString(), item.ToString()),
                item => Assert.Equal(ssg2.ToString(), item.ToString()),
                item => Assert.Equal(ssg3.ToString(), item.ToString()),
                item => Assert.Equal(ssl1.ToString(), item.ToString()),
                item => Assert.Equal(ssl2.ToString(), item.ToString()),
                item => Assert.Equal(ssl3.ToString(), item.ToString()),
                item => Assert.Equal(ssp1.ToString(), item.ToString()),
                item => Assert.Equal(ssp2.ToString(), item.ToString()),
                item => Assert.Equal(ssp3.ToString(), item.ToString()),
                item => Assert.Equal(ssw1.ToString(), item.ToString()),
                item => Assert.Equal(ssw2.ToString(), item.ToString()),
                item => Assert.Equal(ssw3.ToString(), item.ToString()),
                item => Assert.Equal(ww1.ToString(), item.ToString()),
                item => Assert.Equal(ww2.ToString(), item.ToString()),
                item => Assert.Equal(ww3.ToString(), item.ToString())
                );
        }
        [Fact]
        public void FullMenuListCorrect()
        {
            var list = Menu.FullMenu();
            BriarheartBurger e1 = new BriarheartBurger();
            DoubleDraugr e2 = new DoubleDraugr();
            GardenOrcOmelette e3 = new GardenOrcOmelette();
            PhillyPoacher e4 = new PhillyPoacher();
            SmokehouseSkeleton e5 = new SmokehouseSkeleton();
            ThalmorTriple e6 = new ThalmorTriple();
            ThugsTBone e7 = new ThugsTBone();
            DragonbornWaffleFries a1 = new DragonbornWaffleFries();
            DragonbornWaffleFries a2 = new DragonbornWaffleFries();
            a2.Size = Size.Medium;
            DragonbornWaffleFries a3 = new DragonbornWaffleFries();
            a3.Size = Size.Large;
            FriedMiraak b1 = new FriedMiraak();
            FriedMiraak b2 = new FriedMiraak();
            b2.Size = Size.Medium;
            FriedMiraak b3 = new FriedMiraak();
            b3.Size = Size.Large;
            MadOtarGrits c1 = new MadOtarGrits();
            MadOtarGrits c2 = new MadOtarGrits();
            c2.Size = Size.Medium;
            MadOtarGrits c3 = new MadOtarGrits();
            c3.Size = Size.Large;
            VokunSalad d1 = new VokunSalad();
            VokunSalad d2 = new VokunSalad();
            d2.Size = Size.Medium;
            VokunSalad d3 = new VokunSalad();
            d3.Size = Size.Large;
            AretinoAppleJuice aj1 = new AretinoAppleJuice();
            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            aj2.Size = Size.Medium;
            AretinoAppleJuice aj3 = new AretinoAppleJuice();
            aj3.Size = Size.Large;
            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            cc2.Size = Size.Medium;
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc3.Size = Size.Large;
            CandlehearthCoffee cc4 = new CandlehearthCoffee();
            cc4.Decaf = true;
            CandlehearthCoffee cc5 = new CandlehearthCoffee();
            cc5.Size = Size.Medium;
            cc5.Decaf = true;
            CandlehearthCoffee cc6 = new CandlehearthCoffee();
            cc6.Size = Size.Large;
            cc6.Decaf = true;
            MarkarthMilk mm1 = new MarkarthMilk();
            MarkarthMilk mm2 = new MarkarthMilk();
            mm2.Size = Size.Medium;
            MarkarthMilk mm3 = new MarkarthMilk();
            mm3.Size = Size.Large;
            SailorSoda ss1 = new SailorSoda();
            SailorSoda ss2 = new SailorSoda();
            ss2.Size = Size.Medium;
            SailorSoda ss3 = new SailorSoda();
            ss3.Size = Size.Large;
            SailorSoda ssb1 = new SailorSoda();
            ssb1.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssb2 = new SailorSoda();
            ssb2.Size = Size.Medium;
            ssb2.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssb3 = new SailorSoda();
            ssb3.Size = Size.Large;
            ssb3.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssg1 = new SailorSoda();
            ssg1.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssg2 = new SailorSoda();
            ssg2.Size = Size.Medium;
            ssg2.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssg3 = new SailorSoda();
            ssg3.Size = Size.Large;
            ssg3.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssl1 = new SailorSoda();
            ssl1.Flavor = SodaFlavor.Lemon;
            SailorSoda ssl2 = new SailorSoda();
            ssl2.Size = Size.Medium;
            ssl2.Flavor = SodaFlavor.Lemon;
            SailorSoda ssl3 = new SailorSoda();
            ssl3.Size = Size.Large;
            ssl3.Flavor = SodaFlavor.Lemon;
            SailorSoda ssp1 = new SailorSoda();
            ssp1.Flavor = SodaFlavor.Peach;
            SailorSoda ssp2 = new SailorSoda();
            ssp2.Size = Size.Medium;
            ssp2.Flavor = SodaFlavor.Peach;
            SailorSoda ssp3 = new SailorSoda();
            ssp3.Size = Size.Large;
            ssp3.Flavor = SodaFlavor.Peach;
            SailorSoda ssw1 = new SailorSoda();
            ssw1.Flavor = SodaFlavor.Watermelon;
            SailorSoda ssw2 = new SailorSoda();
            ssw2.Size = Size.Medium;
            ssw2.Flavor = SodaFlavor.Watermelon;
            SailorSoda ssw3 = new SailorSoda();
            ssw3.Size = Size.Large;
            ssw3.Flavor = SodaFlavor.Watermelon;
            WarriorWater ww1 = new WarriorWater();
            WarriorWater ww2 = new WarriorWater();
            ww2.Size = Size.Medium;
            WarriorWater ww3 = new WarriorWater();
            ww3.Size = Size.Large;
            Assert.Collection(list,
                item => Assert.Equal(e1.ToString(), item.ToString()),
                item => Assert.Equal(e2.ToString(), item.ToString()),
                item => Assert.Equal(e3.ToString(), item.ToString()),
                item => Assert.Equal(e4.ToString(), item.ToString()),
                item => Assert.Equal(e5.ToString(), item.ToString()),
                item => Assert.Equal(e6.ToString(), item.ToString()),
                item => Assert.Equal(e7.ToString(), item.ToString()),
                item => Assert.Equal(a1.ToString(), item.ToString()),
                item => Assert.Equal(a2.ToString(), item.ToString()),
                item => Assert.Equal(a3.ToString(), item.ToString()),
                item => Assert.Equal(b1.ToString(), item.ToString()),
                item => Assert.Equal(b2.ToString(), item.ToString()),
                item => Assert.Equal(b3.ToString(), item.ToString()),
                item => Assert.Equal(c1.ToString(), item.ToString()),
                item => Assert.Equal(c2.ToString(), item.ToString()),
                item => Assert.Equal(c3.ToString(), item.ToString()),
                item => Assert.Equal(d1.ToString(), item.ToString()),
                item => Assert.Equal(d2.ToString(), item.ToString()),
                item => Assert.Equal(d3.ToString(), item.ToString()),
                item => Assert.Equal(aj1.ToString(), item.ToString()),
                item => Assert.Equal(aj2.ToString(), item.ToString()),
                item => Assert.Equal(aj3.ToString(), item.ToString()),
                item => Assert.Equal(cc1.ToString(), item.ToString()),
                item => Assert.Equal(cc2.ToString(), item.ToString()),
                item => Assert.Equal(cc3.ToString(), item.ToString()),
                item => Assert.Equal(cc4.ToString(), item.ToString()),
                item => Assert.Equal(cc5.ToString(), item.ToString()),
                item => Assert.Equal(cc6.ToString(), item.ToString()),
                item => Assert.Equal(mm1.ToString(), item.ToString()),
                item => Assert.Equal(mm2.ToString(), item.ToString()),
                item => Assert.Equal(mm3.ToString(), item.ToString()),
                item => Assert.Equal(ss1.ToString(), item.ToString()),
                item => Assert.Equal(ss2.ToString(), item.ToString()),
                item => Assert.Equal(ss3.ToString(), item.ToString()),
                item => Assert.Equal(ssb1.ToString(), item.ToString()),
                item => Assert.Equal(ssb2.ToString(), item.ToString()),
                item => Assert.Equal(ssb3.ToString(), item.ToString()),
                item => Assert.Equal(ssg1.ToString(), item.ToString()),
                item => Assert.Equal(ssg2.ToString(), item.ToString()),
                item => Assert.Equal(ssg3.ToString(), item.ToString()),
                item => Assert.Equal(ssl1.ToString(), item.ToString()),
                item => Assert.Equal(ssl2.ToString(), item.ToString()),
                item => Assert.Equal(ssl3.ToString(), item.ToString()),
                item => Assert.Equal(ssp1.ToString(), item.ToString()),
                item => Assert.Equal(ssp2.ToString(), item.ToString()),
                item => Assert.Equal(ssp3.ToString(), item.ToString()),
                item => Assert.Equal(ssw1.ToString(), item.ToString()),
                item => Assert.Equal(ssw2.ToString(), item.ToString()),
                item => Assert.Equal(ssw3.ToString(), item.ToString()),
                item => Assert.Equal(ww1.ToString(), item.ToString()),
                item => Assert.Equal(ww2.ToString(), item.ToString()),
                item => Assert.Equal(ww3.ToString(), item.ToString())
                );
        }
    }
}
