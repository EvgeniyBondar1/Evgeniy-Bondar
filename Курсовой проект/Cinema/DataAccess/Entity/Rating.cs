namespace Cinema.DataAccess.Entity
{
    public class Rating
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
        public Film Film { get; set; }
        public Guid FilmId { get; set; }//Установка внешнего ключа
        public Account Account { get; set; } 
        public Guid AccountId { get; set; }//Установка внешнего ключа
    }
}
