namespace CodeFirst.Models.Entities{

    public class Department{

        public long Id { get; set; }

        /* Rename the `Title` property of the `Department` entity to `Name` */

        // public string Title { get; set; } 
        public string Name { get; set; }

        /* Delete the `HOD` property of the `Department` entity */

        //public string HOD { get; set; }
    }
}