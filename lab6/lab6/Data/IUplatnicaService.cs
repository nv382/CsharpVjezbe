namespace lab6.Data
{
    public interface IUplatnicaService
    {
        List<Uplatnica> GetUplatnicas();

        Uplatnica GetUplatnica(int id);

        void UpdateUplatnica(Uplatnica uplatnica);

        void AddUplatnica(Uplatnica uplatnica);

        void DeleteUplatnica(int id);

    }
}
