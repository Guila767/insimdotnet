namespace InSimDotNet.Packets
{
    // NOTE : SelType is zero if no object type is selected
    // in most modes it refers to an AXO_x as in ObjectInfo
    // in FV_EDIT_MARSH mode it may be one of these :
    public enum SelectedObjectType
    {
        MARSH_IS_CP = 252, // insim checkpoint
        MARSH_IS_AREA = 253, // insim circle
        MARSH_MARSHALL = 254, // restricted area
        MARSH_ROUTE = 255 // route checker
    }
}
