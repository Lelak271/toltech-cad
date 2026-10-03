using Toltech.Cad.Model;

namespace Toltech.Cad.Abstractions;

/// <summary>
/// Service générique permettant de gérer les sélections
/// dans un logiciel de CAO.
/// </summary>
public interface ICadSelectionService
{
    /// <summary>
    /// Démarre le mode de sélection pour le type
    /// d'entité demandé.
    /// </summary>
    Task StartSelectionAsync(
        CadSelectionType selectionType,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Arrête le mode de sélection actuellement actif.
    /// </summary>
    Task StopSelectionAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Reçoit une sélection provenant du logiciel CAO.
    /// </summary>
    void ReceiveSelection(CadSelection selection);

    /// <summary>
    /// Reçoit une s
    /// </summary>
    void ReceiveHint(string hint);

    /// <summary>
    /// Se déclenche lorsqu'une entité est sélectionnée
    /// dans le logiciel CAO.
    /// </summary>
    event EventHandler<CadSelection>? SelectionChanged;

    /// <summary>
    /// Se déclenche lorsque le mode de sélection
    /// est arrêté.
    /// </summary>
    event EventHandler? SelectionStopped;

    /// <summary>
    /// Type de logiciel CAO actuellement connecté à Toltech.
    /// Null si aucun logiciel n'est connecté.
    /// </summary>
    CadSoftware? ActiveSoftware { get; }

    /// <summary>
    /// Se déclenche lorsqu'un message d'information
    /// doit être affiché à l'utilisateur.
    /// </summary>

    event EventHandler<string>? HintReceived;

}

