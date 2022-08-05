namespace HalkbankList.MyEnumarable
{
    public interface IMyEnumerator
    {
        object? Current { get; }
        bool MoveNext();
        void Reset();
    }
}