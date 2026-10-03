using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toltech.Cad.Model
{
    /// <summary>
    /// Type d'entité géométrique pouvant être sélectionnée
    /// dans un logiciel de CAO.
    /// </summary>
    public enum CadSelectionType
    {
        /// <summary>
        /// Point géométrique.
        /// </summary>
        Point,

        /// <summary>
        /// Direction géométrique.
        /// </summary>
        Direction,

        /// <summary>
        /// Sommet d'une géométrie.
        /// </summary>
        Vertex,

        /// <summary>
        /// Arête.
        /// </summary>
        Edge,

        /// <summary>
        /// Face.
        /// </summary>
        Face,

        /// <summary>
        /// Axe.
        /// </summary>
        Axis,

        /// <summary>
        /// Système de coordonnées.
        /// </summary>
        CoordinateSystem,

        /// <summary>
        /// Pièce.
        /// </summary>
        Part,

        /// <summary>
        /// Corps géométrique.
        /// </summary>
        Body
    }
}
