namespace InSimDotNet.Packets
{
    /// <summary>
    /// // Conn Interface Mode
    /// </summary>
    public class IS_CIM : IPacket
    {
        /// <summary>
        /// 8
        /// </summary>
        public byte Size { get; private set; }

        /// <summary>
        /// ISP_CIM
        /// </summary>
        public PacketType Type { get; private set; }

        /// <summary>
        /// 0
        /// </summary>
        public byte ReqI { get; private set; }

        /// <summary>
        /// connection's unique id (0 = host)
        /// </summary>
        public byte UCID { get; set; }

        /// <summary>
        /// mode identifier
        /// </summary>
        public ModeIdentifier Mode { get; set; }

        /// <summary>
        /// submode identifier
        /// </summary>
        public SubmodeIdentifier SubMode { get; set; }

        /// <summary>
        /// selected object type
        /// </summary>
        public SelectedObjectType SelType { get; set; }

        /// <summary>
        /// Spare
        /// </summary>
        public byte Sp3 { get; set; }

        /// <summary>
        /// Conn Interface Mode
        /// </summary>
        public IS_CIM()
        {
            Size = 8;
            Type = PacketType.ISP_CIM;
        }

        /// <summary>
        /// Conn Interface Mode
        /// </summary>
        /// <param name="buffer">Packet data</param>
        public IS_CIM(byte[] buffer)
        {
            var reader = new PacketReader(buffer);
            Size = reader.ReadByte();
            Type = (PacketType)reader.ReadByte();
            ReqI = reader.ReadByte();
            UCID = reader.ReadByte();
            Mode = (ModeIdentifier)reader.ReadByte();
            SubMode = (SubmodeIdentifier)reader.ReadByte();
            SelType = (SelectedObjectType)reader.ReadByte();
            Sp3 = reader.ReadByte();
        }
    };
}
