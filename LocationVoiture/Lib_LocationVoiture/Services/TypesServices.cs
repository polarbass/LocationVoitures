﻿using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;

namespace LocationVoiture.Services
{
    public class TypesServices
    {
        private TypesDAO typesDAO { get; set; }

        public TypesServices()
        {
            typesDAO = new TypesDAO();
        }

        /// <summary>
        /// Retourne une liste de tout les types de voitures
        /// </summary>
        /// <returns>La liste de tout les types de voitures : Une liste vide sinon</returns>
        public List<type> getAll()
        {
            List<type> listeTypes = new List<type>();
            try
            {
                listeTypes = typesDAO.getAll(); 
            }
            catch
            {
                Console.WriteLine("Erreur dans le GetAll types");
            }
            return listeTypes;
        }
    }
}
