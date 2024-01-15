using NUnit.Framework;

namespace Kata.Unit.Tests;

public class VendingMachineShould
{

    public static IEnumerable<object[]> insertedAndRejectedCoins()
    {
        yield return new object[] { new List<Coin> { Coin.Nickel, Coin.Dime }, new List<Coin> { } };
        yield return new object[] { new List<Coin> { Coin.Penny }, new List<Coin> { Coin.Penny } };
        yield return new object[] { new List<Coin> { Coin.Penny, Coin.Nickel, Coin.Dime, Coin.Penny }, new List<Coin> { Coin.Penny, Coin.Penny } };

    }
    
    [TestCaseSource(nameof(insertedAndRejectedCoins))]
    public void rejected_coins_are_placed_into_coin_return(List<Coin> insertedCoins, List<Coin> rejectedCoins)
    {
        var vendingMachine = new VendingMachine();
        
        vendingMachine.insert(insertedCoins);

        Assert.That(vendingMachine.coinReturn(), Is.EqualTo(rejectedCoins));
    }
    
}