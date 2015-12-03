using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationVoiture.Services
{
    class ReservationsServices
    {
        // Propriétés
        public locationvoitureEntities reservationEntitie { get; private set; }

        //Constructeur
        public ReservationsServices()
        {
            reservationEntitie = new locationvoitureEntities();
        }

        /// <summary>
        /// Ajoute une réservation à la table reservation
        /// </summary>
        /// <param name="reservationToAdd">La réservation qui doit être ajoutée</param>
        /// <returns>True si la réservation a été ajouté ; False sinon</returns>
        public Boolean AddReservation(reservation reservationToAdd)
        {
            bool isAdded = false;        
            try
            {
                reservationEntitie.reservations.Add(reservationToAdd);
                Save();
                isAdded = true;
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Add reservation (Méthode AddReservation)");
            }
            return isAdded;
        }

        /// <summary>
        /// Recherche par ID d'une réservation dans la table réservation
        /// </summary>
        /// <param name="searchValue">Le ID de la réservation recherchée</param>
        /// <returns>La réservation recherchée ; Null sinon</returns>
        public reservation FindReservation(string searchValue)
        {
            reservation reservationFinder = null;
            try
            {
                int reservationID = int.Parse(searchValue);
                reservationFinder = reservationEntitie.reservations.Where(res => res.reservationID == reservationID).Single();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Find Reservation (Méthode FindReservation)");
            }
            return reservationFinder;
        }

        public List<reservation> FindBy(String searchValue, String searchBy)
        {
            List<reservation> reservationFinder = new List<reservation>();

            if (searchValue != "")
            {
                try
                {

                    int searchValueInt;                    

                    // SEARCH BY EMPLOYE ID
                    if (searchBy.Equals("reservationID"))
                    {
                        searchValueInt = int.Parse(searchValue);
                        reservationFinder = reservationEntitie.reservations.Where(res => res.reservationID == searchValueInt).ToList();
                    }

                    // SEARCH BY EMPLOYE NOM
                    else if (searchBy.Equals("clientID"))
                    {
                        searchValueInt = int.Parse(searchValue);
                        reservationFinder = reservationEntitie.reservations.Where(res => res.clientID == searchValueInt).ToList();
                    }

                    // SEARCH BY EMPLOYE USERNAME
                    else if (searchBy.Equals("employeID"))
                    {
                        searchValueInt = int.Parse(searchValue);
                        reservationFinder = reservationEntitie.reservations.Where(res => res.employeID == searchValueInt).ToList();
                    }

                    // SEARCH BY EMPLOYE succursaleID
                    else if (searchBy.Equals("succursaleID"))
                    {
                        searchValueInt = int.Parse(searchValue);
                        reservationFinder = reservationEntitie.reservations.Where(res => res.succursaleID == searchValueInt).ToList();
                    }

                    // SEARCH BY reservation dateReservation
                    else if (searchBy.Equals("dateReservation"))
                    {
                        //reservationFinder = reservationEntitie.reservations.Where(res => res.date_debut_reservation.Value.Date == dateReservation.Date).ToList();

                        DateTime dateReservation = Convert.ToDateTime(searchValue);
                        foreach (reservation res in reservationEntitie.reservations.ToList())
                        {
                            if(res.date_debut_reservation.Value.Date == dateReservation.Date)
                            {
                                reservationFinder.Add(res);
                            }
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("Erreur dans le findBy Reservation");
                }

            }

            return reservationFinder;
        }

        /// <summary>
        /// Enregistre les modification fait à la table reservation
        /// </summary>
        public Boolean Save()
        {
            try
            {
                reservationEntitie.SaveChanges();
                reservationEntitie.Dispose();
                return true;
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Add reservation (Méthode AddReservation)");
                return false;
            }
        }
    }
}
