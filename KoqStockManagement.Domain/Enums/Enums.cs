namespace KoqStockManagement.Domain.Enums;

public enum UserRole
{
    Admin,
    StoreManager,
    WorkshopStaff
}

public enum LocationType
{
    Store,
    Workshop,
    Warehouse
}

public enum TransferStatus
{
    Pending,
    InTransit,
    Completed,
    Cancelled
}

public enum ReceptionStatus
{
    Pending,
    Completed
}
