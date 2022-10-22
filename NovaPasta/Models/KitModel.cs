using System;

namespace ToolsVucMigration.Models
{
    public class KitModel
    {
        public string Id { get; set; }
        public MovementModel Movement { get; set; }
        public ProductModel Product { get; set; }
        public string EndOfTerm { get; set; } //null
        public string StartOfTerm { get; set; } //null
        public string Number { get; set; }
        public MainDocumentModel MainDocument { get; set; }
    }
    public class MovementModel
    {
        public string Id { get; set; }
        public DateTime Date { get; set; } //2016-02-18T02:00:00.000+0000
        public string FileName { get; set; }
        public string Lot { get; set; } //null
    }
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class MainDocumentModel
    {
        public string Id { get; set; }
        public string PrintVersionAddress { get; set; } //null
        public string WebVersionAddress { get; set; }
        public DateTime DueDate { get; set; } //2016-04-03T03:00:00.000+0000
        public DateTime ReferenceDate { get; set; } //03/2016
    }
}