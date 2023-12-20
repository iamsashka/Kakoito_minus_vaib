public class BudgetRecord
{
    public string Date { get; set; }
    public string TransactionType { get; set; }
    public decimal Amount { get; set; }
    public string Comment { get; set; }
}

public interface IBugalter
{
    void Read();
    void Update();
    void Delete();
    void Search();
}

public class Bugalter : IBugalter
{
    private string path;
    private List<BudgetRecord> budgetRecords;

    public Bugalter(string path)
    {
        this.path = path;
        budgetRecords = new List<BudgetRecord>();
    }

    public void Read()
    {
        // Действия по чтению
    }

    public void Update()
    {
        // Действия по обновлению
    }

    public void Delete()
    {
        // Действия по удалению
    }

    public void Search()
    {
        // Действия по поиску
    }
}

Bugalter bugalter = new Bugalter("file.json");
bugalter.Read();
