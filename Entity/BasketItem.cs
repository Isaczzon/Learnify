using System;

namespace Entity
{
    public class BasketItem
    {
        public int Id { get; set; }

        public Guid CourseId { get; set; }

        public Course Course { get; set; }

        public int BaskeId { get; set; }

        public Basket Basket { get; set; }
    }
}