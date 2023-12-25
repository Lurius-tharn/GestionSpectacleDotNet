namespace GestionSpectacle.Vue.utils;

public class CartManager
{
    private static readonly List<EventDetail> cartItems = new();

    public static void AjouterAuPanier(EventDetail item)
    {
        cartItems.Add(item);
    }

    public static List<EventDetail> GetPanierItems()
    {
        return cartItems;
    }

    public static double GetCartTotalPrice()
    {
        return cartItems.Sum(detail => detail.Prix);
    }
}