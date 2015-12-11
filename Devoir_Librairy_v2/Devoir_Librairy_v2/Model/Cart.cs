using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.Model
{
    public class Cart
    {

        public int NbItems { get; set; }
        public Ouvrage Ouvrage { get; set; }
        public String ClientName { get; set; }
        public List<Ouvrage> CartClient { get; set; }

        public Cart()
        {
            CartClient = new List<Ouvrage>();
            ClientName = "guest";
            NbItems = 0;
        }

        /**
         * Ajoute un item à la Cart du client
         * @param prod Le produit à ajouter
         * @param qty La quantiter commandée du produit
         */
        public void addOuvrage(Ouvrage ouvrage, int qty)
        {
            CartClient.Add(ouvrage);
            NbItems += qty;

            //if (CartClient.Contains(ouvrage))
            //{
            //    foreach (Ouvrage o in CartClient)
            //    {
            //        if (o.ISBN.Equals(ouvrage.ISBN))
            //        {
            //            o.setQty(p.getQty() + qty);
            //        }
            //    }
            //}
            //else
            //{
            //    prod.setQty(qty);
            //    getCartClient().add(prod);
            //}

        }

        /**
         * Retour le produit qui se trouve à l'index <code>index</code>
         * @param index L'index du produit recherché
         * @return 
         */
        public Ouvrage getCartProduct(int index)
        {
            return CartClient[index];
        }

        /**
         * Retire un produit de la Cart du client
         * @param code Le code du produit à retirer
         */
        public void removeProduct(String ISBN)
        {
            Console.WriteLine("in remover");
            for (int i = 0; i < CartClient.Count; i++)
            {
                if (CartClient[i].ISBN.Equals(ISBN))
                {
                    Console.WriteLine(CartClient[i] + " is going to be removed");
                    CartClient.RemoveAt(i);
                }
            }
        }

        /**
         * Vide la Cart du client complètement
         */
        public void eraseCart()
        {
            CartClient.Clear();
        }

        /**
         * Calcul le prix total des produits qui se trouve sur la Cart
         * @return Le prix total
         */
        public float getTotal()
        {
            float total = 0;
            foreach (Ouvrage o in CartClient)
            {
                total += o.Prix;
            }

            return total;
        }

    }
}