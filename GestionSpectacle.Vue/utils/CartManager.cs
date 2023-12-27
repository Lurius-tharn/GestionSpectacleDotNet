namespace GestionSpectacle.Vue.utils;

public class CartManager
{
    private static List<EventDetail> _cartItems = new();

    public static void AjouterAuPanier(EventDetail item)
    {
        if (_cartItems.Find(detail => detail.Equals(item)) is not null)
            _cartItems.Find(detail => detail.Equals(item))!.nbPlaces += item.nbPlaces;
        else
            _cartItems.Add(item);
    }

    public static List<EventDetail> GetPanierItems()
    {
        return _cartItems;
    }

    public static double GetCartTotalPrice()
    {
        return _cartItems.Sum(detail => detail.Prix);
    }

    public static void ResetCart()
    {
        _cartItems = new List<EventDetail>();
    }
}