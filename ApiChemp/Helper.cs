using ApiChemp.Context;

namespace ApiChemp;

public class Helper
{
    public static readonly PostgresContext Database = new PostgresContext();
}