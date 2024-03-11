namespace DbASP_NET_11_03_2024.DB
{
    public class Transistors
    {
        // MusicInstrument - сущность, описывающая объект "Музыкальный инструмент", который соответствует
        // таблице в БД

            // поля - реализованы через автосвойства
            public int Id { get; set; }
            public string types {  get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public Transistors()
            {
                Description = "";
            }

            public override string ToString()
            {
                return $"{Id} - {Description} - {Price} - {Quantity}";
            }
        }
    }

