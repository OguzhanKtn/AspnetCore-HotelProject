namespace WebUI.Dtos.RoomDto
{
    public record ResultRoomDto
    (
        string RoomNumber,
        string RoomCoverImage,
        int Price,
        string Title,
        string BedCount,
        string BathCount,
        string Wifi,
        string Description
    );
    
}
