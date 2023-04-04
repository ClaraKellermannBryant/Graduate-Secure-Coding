// This is a demonstration of parameterized querying that utilizes .NET for preventing SQL injections
// The demonstration emphasizes best practices from OWASP here: https://cheatsheetseries.owasp.org/cheatsheets/Query_Parameterization_Cheat_Sheet.html
// The queries used originate from my databases project here: https://github.com/GalarianRapidash2345/Databases/blob/main/EnhancedArtifact.sql






String sqlQuery = "SELECT arkham_enemies FROM arkhamDB WHERE EnemyID = int";

try
{
    object connect = null;
    object query = null;

    int oldQuery = new newQuery(query, connect);

    object enemyName = null;
    object Name = null;

    object p = newQuery.Parameters.Add(new SqlParameter("EnemyName", enemyName Name.Text));

    object dataReader = newQuery.ExecuteReader();
    
}

catch (Exception ex)
{

}



internal class newQuery
{
    private object? query;
    private object? connect;
    private object? Parameters;

    public newQuery(object? query, object? connect)
    {
        this.query = query;
        this.connect = connect;
        this.Parameters = Parameters;
    }

    internal static object ExecuteReader()
    {
        throw new NotImplementedException();
    }

    public static implicit operator int(newQuery v)
    {
        throw new NotImplementedException();
    }
}

public class SqlParameter
{
    private string v;
    private object? enemyName;
    private object? Name;
    private object? Text;

    public SqlParameter(string v, object? enemyName, object Text)
    {
        this.v = v;
        this.enemyName = enemyName;
        this.Name = Name;
        this.Text = Text;
    }
}
