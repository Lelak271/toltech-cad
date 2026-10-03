using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toltech.Cad.Model
{
    /// <summary>
    /// Représente une entité sélectionnée dans un logiciel de CAO.
    /// </summary>
    public sealed class CadSelection
    {
        public CadSelectionType Type { get; }

        public CadPoint? Point { get; }

        public CadDirection? Direction { get; }

        /// <summary>
        /// Construit une sélection de type Point.
        /// </summary>
        public CadSelection(CadPoint point)
        {
            Type = CadSelectionType.Point;
            Point = point;
        }

        /// <summary>
        /// Construit une sélection de type Direction.
        /// </summary>
        public CadSelection(CadDirection direction)
        {
            Type = CadSelectionType.Direction;
            Direction = direction;
        }

        /// <summary>
        /// Message d'information transmis par un logiciel CAO
        /// vers Toltech pendant une opération de sélection.
        /// </summary>
        public sealed record CadHint
        {
            public string Message { get; init; } = string.Empty;
        }

    }
}
