namespace PierreBakery.Models;

public class UIBakery 
{
    public Bread BreadOrder { get; set; }
    public Pastry PastryOrder { get; set; }

    public UIBakery(int breadQuantity, int pastryQuantity)
    {
        BreadOrder = new Bread(breadQuantity);
        PastryOrder = new Pastry(pastryQuantity);
    }
    public int TotalCost()
    {
        return BreadOrder.BreadTotal() + PastryOrder.PastryTotal();
    }
}