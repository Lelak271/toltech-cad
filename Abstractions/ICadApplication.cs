using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toltech.Cad.Abstractions;

namespace Toltech.Cad.Abstractions
{
    /// <summary>
    /// Représente un logiciel de CAD et fournit des services pour interagir avec lui.
    /// </summary>
    public interface ICadApplication
    {
        /// <summary>
        /// Identifiant interne du logiciel CAO.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Nom affiché dans l'interface utilisateur.
        /// </summary>
        CadSoftware Software { get; }

        /// <summary>
        /// Indique si le logiciel CAO est actuellement disponible.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Service permettant d'effectuer des sélections
        /// dans le logiciel CAO.
        /// </summary>
        ICadSelectionService Selection { get; }


    }


    public enum CadSoftware
    {
        FreeCAD,
        CatiaV5,
        SolidWorks, 
        None
    }

}
