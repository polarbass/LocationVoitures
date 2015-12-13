using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;

namespace Lib_LocationVoiture.Services
{
    public class ReservationsServices
    {
        // Propriétés
        private ReservationsDAO reservationsDAO{ get; set; }

        //Constructeur
        public ReservationsServices()
        {
            reservationsDAO = new ReservationsDAO();
        }

        /// <summary>
        /// Ajoute une réservation à la table reservation
        /// </summary>
        /// <param name="reservationToAdd">La réservation qui doit être ajoutée</param>
        /// <returns>True si la réservation a été ajouté ; False sinon</returns>
        public Boolean AddReservation(reservation reservationToAdd)
        {
            return reservationsDAO.AddReservation(reservationToAdd);
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
                reservationFinder = reservationsDAO.FindReservation(searchValue);
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
                    reservationFinder = reservationsDAO.FindBy(searchValue, searchBy);                   
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
            return reservationsDAO.Save();
        }
    }
}
