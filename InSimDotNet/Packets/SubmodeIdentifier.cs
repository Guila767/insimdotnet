namespace InSimDotNet.Packets
{
    // Submode identifiers for free view mode

    public enum SubmodeIdentifier
    {
        FVM_PLAIN,          // no buttons displayed
        FVM_BUTTONS,        // buttons displayed (not editing)
        FVM_SP2,            // reserved
        FVM_SP3,            // reserved
        FVM_EDIT_CHALK,
        FVM_EDIT_CONES,
        FVM_EDIT_TYRES,
        FVM_EDIT_MARKERS,
        FVM_EDIT_OTHER,
        FVM_EDIT_CONCRETE,
        FVM_EDIT_CONTROL,
        FVM_EDIT_MARSH,
        FVM_NUM
    };
}
