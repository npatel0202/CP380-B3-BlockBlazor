
using System;
using System.Threading.Tasks;

namespace CP380_B1_BlockList.Models
{
    public enum TransactionTypes
    {
        BUY, SELL, GRANT
    }

    public class Payload
    {
        // TODO

        public string User { get; set; }
        public string Item { get; set; }
        public TransactionTypes Type { get; set; }
        public int Amount { get; set; }
        public Payload(string User, TransactionTypes Type, int Amount, string Item)
        {

            this.User = User;
            this.Type = Type;
            this.Amount = Amount;
            this.Item = Item;
        }

        public static Task<string> GetStatuses()
        {
            throw new NotImplementedException();
        }
    }
}
