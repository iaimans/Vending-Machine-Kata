namespace Kata;

public class VendingMachine
{
    private List<Coin> _coinReturn = new List<Coin>();
    public void insert(List<Coin> coins)
    {
        coins.FindAll(coin => coin == Coin.Penny).ForEach(coin => _coinReturn.Add(coin));
    }

    public object coinReturn()
    {
        return _coinReturn;
    }
}