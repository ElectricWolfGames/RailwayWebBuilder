namespace LocoDBSync.Models
{
    public class ModelLocoDetails
    {
        public string CatalogueId { get; set; }

        public string DCC { get; set; }

        public string Era { get; set; }

        //[BsonId]
        //[BsonIgnoreIfDefault] // required for replace documents
        //public ObjectId Id { get; set; }

        public string Manufacturers { get; set; }
        public string Name { get; set; }
        public string RunningNumber { get; set; }
        public string Year { get; set; }
    }
}